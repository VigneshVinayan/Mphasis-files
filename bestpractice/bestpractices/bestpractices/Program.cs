using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestpractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //practice p = new practice();
            ////p.Demo1();
            //p.printdata("10","20","30","40");
            ////Console.WriteLine("Hello world");
            //var res = p.printdata();
            //res.Append("Russia");
            //foreach(var r in res)
            //{
            //    Console.WriteLine(r);
            //}
            //using (Class1 ob = new Class1())
            //{
            //    ob.displaydata();
            //    ob.deletedata();
            //} ;
            Thdemo t = new Thdemo();
            Task.Run(() => { t.demo1(); });
            Task.Run(() => { t.demo2(); });
            Console.Read();
        }
    }
}
