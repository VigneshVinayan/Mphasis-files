using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class Dayfour
    {
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds = new DataSet();
        DataTable emp = new DataTable();
        DataTable dept = new DataTable();

        public Dayfour()
        {

            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");

            da = new SqlDataAdapter("select * from employee", con);
            da1 = new SqlDataAdapter("Select * from Dept", con);

            SqlCommandBuilder s = new SqlCommandBuilder(da);//Builds query
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "e");//now we are filling ds with employee records
            da1.Fill(ds, "d");
            emp = ds.Tables["e"];
            dept = ds.Tables["d"];
        }
        public void showEmpandDept()
        {
            Console.WriteLine("Employee Table");
            for (int i = 0; i < ds.Tables["e"].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables["e"].Columns.Count; j++)
                {
                    Console.Write(ds.Tables["e"].Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Department Table");
            for (int i = 0; i < ds.Tables["d"].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables["d"].Columns.Count; j++)
                {
                    Console.Write(ds.Tables["d"].Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void DataViewSorting()
        {
            DataView dv = new DataView(emp);

            dv.RowFilter = "salary >= 47000 and dept=10 and empname like 'M%'";
            dv.Sort = "empid desc";
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
                Console.WriteLine("=========================");
            }
        }
        public void counttables()
        {
            Console.WriteLine(ds.Tables.Count);
        }
        public void addstudents()
        {
            DataTable stud = new DataTable("Student");

            stud.Columns.Add("Studentid",typeof (int));
            stud.Columns.Add("Name", typeof(string));
            stud.Columns.Add("Age", typeof(int));

            stud.Rows.Add(4001, "Raj",21);
            stud.Rows.Add(4002, "Ravi",21);
            stud.Rows.Add(4003, "Rahul",21);
            for(int i = 0; i <  stud.Rows.Count; i++)
            {
                for(int j = 0; j < stud.Columns.Count; j++)
                {
                    Console.WriteLine(stud.Rows[i][j] + " ");
                }
            }
        }
        //public void copyData()
        //{
        //    DataTable copy = new DataTable();
        //    copy.Load(ds.Tables["d"]);
        //}
    }
}
