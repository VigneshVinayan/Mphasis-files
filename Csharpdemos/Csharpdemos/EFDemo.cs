using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class EFDemo
    {
        db0902Entities dc = new db0902Entities();
        public void DisplayEmployee()
        {
            var res = from t in dc.employees select t;
            foreach(var i in res)
            {
                Console.WriteLine($"{i.empid} {i.empname} {i.doj} {i.salary} {i.dept}");
            }
        }

        public void DisplayById()
        {
            int id = int.Parse(Console.ReadLine());
            var res = (from t in dc.employees where id == t.empid select t).First();//First()  reads only the first record, doint this way foreach is not required
            
                Console.WriteLine($"{res.empid} {res.empname} {res.doj} {res.salary} {res.dept}");
            
        }
        public void AddNewRecord()
        {
            employee e = new employee()
            {
                empid = 700,
                empname = "Ravi",
                doj = DateTime.Parse("2009-05-05"),
                salary = 45000,
                dept = 20
            };
            dc.employees.Add(e);
            int i = dc.SaveChanges();
            Console.WriteLine("Total rows inserted are " + i);
        }
        public void DeleteRecord()
        {
            employee e = new employee();
            int id = 800;
            e = dc.employees.Find(id);
            dc.employees.Remove(e);
            int i = dc.SaveChanges();
            Console.WriteLine("Total rows deleted are " + i);
        }
        public void UpdateRecord()
        {
            int id = int.Parse(Console.ReadLine());
            var res = dc.employees.Find(id);
            res.salary = 55000;
            //dc.employees.AddOrUpdate(res);
            int i = dc.SaveChanges();
            Console.WriteLine("Total rows deleted are " + i);
        }
        public void showDepartment()
        {
            //var res = from d in dc.depts
            //          join e in dc.employees
            //          on d.deptid equals e.dept
            //          select new {e, d};

            var res = from d in dc.depts
                      from e in dc.employees
                      where d.deptid == e.dept
                      select new { d, e };
            foreach(var i in res)
            {
                Console.WriteLine($"{i.e.empid} {i.e.empname} {i.d.deptname} {i.e.salary}  {i.e.doj} ");
            }

        }
        public void procedureCall()
        {
            int id = int.Parse(Console.ReadLine());
            var res = dc.getempbyid(id).First();

            Console.WriteLine($"{res.empid} {res.empname} {res.doj} {res.salary} {res.dept}");
        }
        public void displayrecords()
        {
            var res = dc.Database.SqlQuery<dept>("select * from dept");
            foreach(var i in res)
            {
                Console.WriteLine($"{i.deptid} {i.deptname} {i.deptid}");
            }
        }
        public void Addrecords()// use this method for insert, update and delete
        {
            int i = dc.Database.ExecuteSqlCommand("insert into dept values(900,50,'admin')");
             
            Console.WriteLine("Total rows inserted are " + i);
        }
        public void getproc()
        {
            //int id = int.Parse(Console.ReadLine());

            var res = dc.Database.SqlQuery<employee>($"getempbyid 100");
            foreach (var i in res)
            {
                Console.WriteLine($"{i.empid} {i.empname} {i.salary}");
            }
        }
    }
}
