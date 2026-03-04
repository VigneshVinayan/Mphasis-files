using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class Advance_ado
    {
        //======Topics covered=======
        //adding rows and columns manually to database
        // assigning primary key
        //finding the row state
        //relationship
        //how add records through dataview
        //app.congiguration
        //concurrency in ado.net

        public void demo1()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Movineid", typeof(int));//without specifyinh datatypes the column become object
            dt.Columns.Add("Movinename", typeof(string));
            dt.Columns.Add("actor", typeof(string));
            dt.Columns.Add("actress", typeof(string));

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };//Adds primary key
            //Mehtod1
            //dt.Rows.Add(100, "abcd", "aaa", "bbb");
            //dt.Rows.Add(200, "xyz", "aaa", "bbb");

            //Method2
            DataRow dr = dt.NewRow();
            dr[0] = 100;
            dr[1] = "abcd";
            dr[2] = "xyz";
            dr[3] = "a1";

            Console.WriteLine(dr.RowState);

            dt.Rows.Add(dr);

            Console.WriteLine(dr.RowState);

            dt.AcceptChanges();
            dr[0] = 20;

            Console.WriteLine(dr.RowState);

            //dt.AcceptChanges();
            //dr.Delete();
            //Console.WriteLine(dr.RowState);


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
            }
        }
        public void demo2()
        {


            
            DataTable dtc = new DataTable();
            dtc.Columns.Add("Custid", typeof(int));
            dtc.Columns.Add("Custname", typeof(string));
            dtc.Columns.Add("age", typeof(int));
            dtc.Columns.Add("address", typeof(string));
            dtc.PrimaryKey = new DataColumn[] { dtc.Columns[0] };

            DataTable dto = new DataTable();
            dto.Columns.Add("Orderid", typeof(int));
            dto.Columns.Add("Custid", typeof(int));
            dto.Columns.Add("product", typeof(string));
            dto.Columns.Add("price", typeof(int));
            dto.PrimaryKey = new DataColumn[] { dto.Columns[0] };

            ForeignKeyConstraint fc = new ForeignKeyConstraint("fc1", dtc.Columns[0], dto.Columns[1]);
            fc.DeleteRule = Rule.SetNull;//default is cascade
            dto.Constraints.Add(fc);//now foreign key accepts null values 

            DataSet ds = new DataSet();
            ds.Tables.Add(dtc);
            ds.Tables.Add(dto);
            DataRelation drr = new DataRelation("hi", dtc.Columns[0], dto.Columns[1]);
            ds.Relations.Add(drr);

            dtc.Rows.Add(100, "raj",21, "bangalore");
            dtc.Rows.Add(200, "jay",20, "chennai");
            dtc.Rows.Add(300, "vijay",22, "delhi");



            dto.Rows.Add(1, 100, "books", 300);
            dto.Rows.Add(2, 200, "cd", 100);
            dto.Rows.Add(3, 300, "pen", 200);
            //dto.Rows.Add(4, 400, "marker", 50);


            //DataRow[] dr = dtc.Select("Custid = 100");

            dtc.Rows[0].Delete();
            

            

            foreach (DataRow item in dtc.Rows)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
            }
            Console.WriteLine("==================");
            foreach (DataRow item in dto.Rows)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
            }
        }
    }
}
