using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using mylib;
using mymathlib;
namespace Csharpdemos
{
    public class Program
    {
        //public delegate string Greet(string name);
        
        //public static string Hello(string name)
        //{
        //    return $"Hello: {name}";
        //}
        public static void Main(string[] args)
        {


            //DelRealtime ob = new DelRealtime();
            //int[] x = { 10, 20, 30, 40, 50, 60, 70, 80 };
            //ob.StoreInFile(k => k < 50,x);
            //ob.StoreInFile(k => k > 20 && k < 60, x);
            //ob.StoreInFile(k => k > 20 && k < 60 || k >50 , x);

            Features f = new Features();
            f.demo();

























            //Greet del = Hello;

            //string res = del("Ebin");

            //Console.WriteLine(res);

            //deleg del = new deleg();
            //del.show(6);


            //Console.WriteLine("The sum of "+a+" and "+b+" is " + c);
            //Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);



            //MyClass obj = new MyClass();
            ////obj.DictionaryDemo();
            //obj.stackDemo();

            //obj.queuedemo();
            //Task1 t = new Task1();
            //t.compute();

            EmpClass emp1 = new EmpClass();
            emp1.Empid = 1;
            emp1.firstName = "Vignesh ";
            emp1.lastName = "K V";
            emp1.sal = 40000;
            emp1.dept = "CSE";

            //emp1.displayFullName();
            //emp1.calculateAnnualSalary();
            //t.calledExeption();
            //MovieDetails mov = new MovieDetails();
            //mov.viewMovies();
            //mov.viewByName();

            //HelloClass obj = new HelloClass();
            //obj.hello();
            //    myMathClass obj = new myMathClass();
            //    obj.add(1, 2);
            //    obj.multiply(3, 3);


            //string firstName = Console.ReadLine();
            //string lastName = Console.ReadLine();
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //Personcls p = new Personcls(firstName, lastName, date);

            //p.checkBirthday();

            //MusicPlayer p = new MusicPlayer();
            //p.play();

            //DerivedClass dc = new DerivedClass(20);

            //Student[] details = new Student[5];
            //for (int i = 0; i < 5; i++)
            //{

            //    int id = int.Parse(Console.ReadLine());
            //    string name = Console.ReadLine();
            //    int[] mark = new int[4];
            //    for (int j = 0; j < 4; j++)
            //    {
            //        mark[j] = int.Parse(Console.ReadLine());
            //    }
            //    details[i] = new Student(id, name, mark);
            //}
            //Student s = new Student();
            //s.getDetails(details
            //

            //ConnectedDemo obj = new ConnectedDemo();
            //obj.Showcustomers();
            //obj.Addcustomer();
            //obj.Updatecustomer();
            //obj.ShowempByName();
            //obj.Transdemo();

            //DisconnectedDemo dm = new DisconnectedDemo();
            //dm.ShowEmployee();
            //dm.ShowEmployeeById();
            //dm.AddEmployee();
            //dm.read_xml();


            //Dayfour df = new Dayfour();
            //df.showEmpandDept();
            //df.DataViewSorting();
            //df.counttables();
            //df.addstudents();

            //Advance_ado ob = new Advance_ado();
            //ob.demo2
            //LinqDemo d = new LinqDemo();
            //d.Demo1();
            //d.Demo5();
            //Task5 obj = new Task5();
            //obj.Demo();
            //obj.ProdDemo();

            //EFDemo ob = new EFDemo();
            //ob.getproc();
        }
    }
}
//Parse can only be using to convert string values to the desired type or else use convert
