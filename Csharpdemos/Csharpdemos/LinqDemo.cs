using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class LinqDemo
    {
        List<Food> li = new List<Food>()
            {
                new Food(){Name = "Idly", Description="Indian breakfast", Price=120},
                new Food(){Name = "Poori", Description="Indian breakfast", Price=150},
                new Food(){Name = "Burger", Description="Italian breakfast", Price=220},
                new Food(){Name = "Gobi manchurian", Description="Chinese breakfast", Price=200},
                new Food(){Name = "Pizza", Description="American breakfast", Price=320}
            };
        public void Demo1()
        {
            string[] str = { "Idli", "Dosa", "Curdrice", "Pizza", "Poori" ,"Deserts", "Donut"};
            //var res = from t in str where t.Length == 5 select t;
            //var res = from t in str where (t[0] == 'D' && t[t.Length - 1] == 's' && t.Length >= 4) select t;
            var res = from t in str where t.StartsWith("D") && t.EndsWith("s") && t.Length >= 4 select t;
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
        }
        public void Demo2()
        {
            int[] nums = { 10, 11, 12, 13, 14, 15 };
            var res = from t in nums where t%2 == 0 select t;
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
        }
        public void Demo3()
        {
            int[] nums = { 10, 11, 12, 13, 14, 15 };
            var res = from t in nums where t.IsEven() select t;
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }
        //Query expression method
        public void Demo4()
        {
            
            //var res = from t in li select t;
            //foreach(var i in res)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("==========================");
            //var indian = from t in li where t.Description == "Indian breakfast" select t;
            //foreach(var i in indian)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("==========================");
            //var containsO = from t in li where t.Name.Contains("o") && t.Price >= 150 select t;
            //foreach(var i in containsO)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("==========================");
            //var sorting = from t in li orderby t.Price descending select t;
            //foreach(var i in sorting)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("==========================");
            //var sortandselecting = from t in li where t.Price > 100 && t.Price < 300 orderby t.Price ascending select t;
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("==========================");
            //var s = from t in li where t.Description != "Indian breakfast" && t.Price < 300 select t;
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("==========================");
            ////displaying specific columns
            //var r = from t in li select new { foodName = t.Name, foodprice = t.Price };
            //foreach(var i in r)
            //{
            //    Console.WriteLine($"{i.foodName} {i.foodprice}");
            //}

            var dis = from t in li select new { foodname = t.Name, foodprice = t.Price, discount = (t.Price - (t.Price*0.10))};
            foreach(var i in dis)
            {
                Console.WriteLine($"{i.foodname} {i.foodprice} {i.discount}");
            }
        }
        public  void Demo5()
        {

            //var res = li.Where(t => t.Price < 300);
            //var res = li.Take(3);
            //var res = li.Skip(3);
            //var res = li.TakeWhile(t => t.Price != 220);
            //var res = li.SkipWhile(t => t.Price != 220);
            //var res = li.Skip(3).Take(2).Skip(1);
            var res = li.OrderByDescending(t => t.Price).Take(2).Skip(1);//second largest
            //var res = 
            foreach(var i in res)
            {
                Console.WriteLine($"{i.Name} {i.Price}");
            }
        }
        

    }
    //Lambda expression method




    //Extension method
    static class mycls
    {
        public static bool IsEven(this int i)//attach iseven to int datatype(only available to the specfied datatype inside the parameter)
        {
            return i%2 == 0;
        }
    }
}
