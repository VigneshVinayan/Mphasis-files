using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class Task5
    {
        List<Movies> li = new List<Movies>()
        {
            new Movies(){ MovieId=100, MovieName="Bahubali", Actor="Prabhas",
            Actress="Tamanna", YOR=2015 },
            new Movies(){ MovieId=200, MovieName="Bahubali2", Actor="Prabhas",
            Actress="Anushka", YOR=2017 },
            new Movies(){ MovieId=300, MovieName="Robot", Actor="Rajini",
            Actress="Aish", YOR=2010 },
            new Movies(){ MovieId=400, MovieName="3 idiots", Actor="Amir",
            Actress="kareena", YOR=2009 },
            new Movies(){ MovieId=500, MovieName="Saaho", Actor="Prabhas",
            Actress="shraddha", YOR=2019 },
           };
        List<Products> p = new List<Products>()
          {
            new Products() { pid = 100, pname = "book", price = 1000, qty = 5 },
            new Products() { pid = 200, pname = "cd", price = 2000, qty = 6 },
            new Products() { pid = 300, pname = "toys", price = 3000, qty = 5 },
            new Products() { pid = 400, pname = "mobile", price = 8000, qty = 6 },
            new Products() { pid = 600, pname = "pen", price = 200, qty = 7 },
            new Products() { pid = 700, pname = "tv", price = 30000, qty = 7 },
            };
        public void Demo()
        {
            var probhasmovies = from t in li where t.Actor == "Prabhas" select t;
            foreach(var i in probhasmovies)
            {
                Console.WriteLine(i.MovieName);
            }
            Console.WriteLine("==========================");
            var release = from t in li where t.YOR == 2019 select t;
            foreach(var i in release)
            {
                Console.WriteLine(i.MovieName);
            }
            Console.WriteLine("==========================");
            var together = from t in li where t.Actor == "Prabhas" && t.Actress == "Anushka" select t;
            foreach(var i in together)
            {
                Console.WriteLine(i.MovieName);
            }
            Console.WriteLine("==========================");
            var actedwith = from t in li where t.Actor == "Prabhas" select t;
            foreach(var i in actedwith)
            {
                Console.WriteLine(i.Actress);
            }
            Console.WriteLine("==========================");
            var desc = from t in li orderby t.YOR descending select t;
            foreach(var i in desc)
            {
                Console.WriteLine($" {i.MovieId} {i.MovieName} {i.Actor} {i.Actress} {i.YOR}");
            }
            Console.WriteLine("==========================");
            var maximum = from t in li group t by t.Actor into g orderby g.Count() descending select new {Actor = g.Key, Count = g.Count()}; 
            foreach(var i in maximum)
            {
                Console.WriteLine($"{i.Actor} {i.Count}");
            }
            Console.WriteLine("==========================");
            var charactercount = from t in li where t.MovieName.Length == 5 select t;
            foreach(var i in charactercount)
            {
                Console.WriteLine(i.MovieName);
            }
            Console.WriteLine("==========================");
            int[] y = { 2017, 2009, 2019 };
            var moviereleased = from t in li where y.Contains(t.YOR) select t;
            //var moviereleased = from t in li where t.YOR == 2017 || t.YOR == 2009 || t.YOR == 2019 select t;
            foreach(var i in moviereleased)
            {
                Console.WriteLine($"{i.Actor} {i.Actress}");
            }
            Console.WriteLine("==========================");
            var startend = from t in li where t.MovieName.StartsWith("B") && t.MovieName.EndsWith("i") select t;
            foreach(var i in startend)
            {
                Console.WriteLine(i.MovieName);
            }
            Console.WriteLine("==========================");
            var notrajini = from t in li where t.Actor != "Rajini" orderby t.Actress descending select t ;
            foreach(var i in notrajini)
            {
                Console.WriteLine(i.Actress);
            }
            Console.WriteLine("==========================");
            var format = from t in li select new { movie_name = t.MovieName, cast = $"{t.Actor}-{t.Actress}" };
            foreach(var i in format)
            {
                Console.WriteLine($"{i.movie_name} {i.cast}");
            }
            Console.WriteLine("==========================");

        }
        public void ProdDemo()
        {
            var sechigh = p.OrderByDescending(t => t.price).Take(2).Skip(1);
            foreach (var i in sechigh)
            {
                Console.WriteLine($"{i.pid} {i.pname}");
            }
            Console.WriteLine("==========================");
            var topthree = p.OrderByDescending(t => t.price).Take(3);
            foreach(var i in topthree)
            {
                Console.WriteLine($"{i.pid} {i.pname} {i.price} {i.qty}");
            }
            Console.WriteLine("==========================");
            var sumpriceo = p.Where(t => t.pname.Contains("o")).Sum(p => p.price);
            Console.WriteLine(sumpriceo);
            Console.WriteLine("==========================");
            var ende = p.Where(t => t.pname.EndsWith("e"));
            foreach(var i in ende)
            {
                Console.WriteLine($"{ i.pid} {i.pname}");
            }
            Console.WriteLine("==========================");
            var qty = p.GroupBy(t => t.qty).Select(g => new { Qty = g.Key, MaxPrice = g.Max(t => t.price) });
            foreach(var i in qty)
            {
                Console.WriteLine($"{i.Qty} {i.MaxPrice}");
            }
            Console.WriteLine("==========================");
        }
    }
    class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public int YOR { get; set; }
    }
    class Products
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
    }
}
