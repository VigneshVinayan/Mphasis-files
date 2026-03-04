using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Csharpdemos
{
    internal class ConnectedDemo
    {
        public void Showcustomers()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from employee", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} ");
            }
            con.Close();
        }
        public void ShowcustomerById()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            con.Open();

            int id = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("select * from employee where empid = " + id, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                    Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} ");
            }
            con.Close();
        }
        public void Addcustomer()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            con.Open();

            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            DateTime date = DateTime.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"insert into employee values ( {id}, '{name}', '{date}', {salary} )", con);

            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Total rows are " + i);
        }
        public void Updatecustomer()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            con.Open();

            int id = int.Parse(Console.ReadLine());
            int sal = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"update employee set salary = {sal} where empid = {id}",con);

            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Total rows are " + i);

            con.Close();
        }
        public void Deletecustomer()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            con.Open();

            
            int id = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("delete from employee where empid = " + id, con);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Total rows deleted " + i);
        }
        public void ShowempByName()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
            con.Open();

            string name = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("showempbyname 'a'",con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}");
            }
            con.Close();
        }
        public void Transdemo()
        {
            SqlTransaction tr = null;
            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true;server=WIN2019;database=db0902");
                con.Open();

                tr = con.BeginTransaction();
                SqlCommand cmd1 = new SqlCommand("insert into TableA values(2,'bb')", con);
                cmd1.Transaction = tr;
                SqlCommand cmd2 = new SqlCommand("insert into TableB values(1,'bb')", con);
                cmd2.Transaction = tr;
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                tr.Commit();
                Console.WriteLine("Query executed");
            }
            catch (Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("Transaction Rollbacked");
            }
        }
    }
}
