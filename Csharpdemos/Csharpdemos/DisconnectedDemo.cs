using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Csharpdemos
{
    internal class DisconnectedDemo
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public DisconnectedDemo()
        {
            string str = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            SqlConnection con = new SqlConnection(str);


            da = new SqlDataAdapter("select * from employee", con);

            SqlCommandBuilder s = new SqlCommandBuilder(da);//Builds query
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "e");//now we are filling ds with employee records

            dt = ds.Tables["e"];
        }
        public void ShowEmployee()
        {


            for(int i = 0; i < ds.Tables["e"].Rows.Count; i++)
            {
                for(int j = 0;j <  ds.Tables["e"].Columns.Count;j++)
                {
                    Console.Write(ds.Tables["e"].Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void ShowEmployeeById()
        {
            //SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            
            Console.WriteLine("Enter employee id");
            int id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(id);

            if (dr != null)
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine(dr[4]);
            }
            else
            {
                Console.WriteLine("Id does not exist");
            }
        }
        public void AddEmployee()
        {

            //adding records to datatable happens offline
            dt.Rows.Add(500, "Raj", "1-1-2019", 20000, 10);
            dt.Rows.Add(600, "Ravi", "1-1-2015", 20000, 20);
            dt.Rows.Add(700, "Rahul", "1-1-2010", 20000, 30);
            //now datatable having 3 rows

            int i = da.Update(dt);//updates changes to database
            Console.WriteLine("Rows inserted " + i);
        }
        public void DeleteEmployee()
        {
            int id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(id);
            dr.Delete();//delete row from datatable
            //dt.Rows.Remove(dr);
            int i = da.Update(dt);//updates changes to database
            Console.WriteLine("Rows inserted " + i);
        }
        public void UpdateEmployee()
        {
            int id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(id);
            dr[3] = 40000;
            //dt.Rows.Remove(dr);
            int i = da.Update(dt);//updates changes to database
            Console.WriteLine("Rows inserted " + i);
        }
        public void DataViewdemo()
        {
            DataView dv = new DataView(dt);

            dv.RowFilter = "salary >= 20000 and salary <= 50000 and empname like 'M%'";
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }
        }
        public void read_writeXml()
        {
            //storing data in XML, if database is not there
            //dt.Rows.Add(800, "Raju", "1-1-2014", 25000, 10);
            if (ds.HasChanges())
            {
                ds.GetChanges().WriteXml("c:\\emp.xml");
            }
            else
            {
                Console.WriteLine("no changes made");
            }
        }
        public void read_xml()
        {
            ds.ReadXml("c:\\emp.xml");
            
            da.Update(dt);
        }
    }
}
