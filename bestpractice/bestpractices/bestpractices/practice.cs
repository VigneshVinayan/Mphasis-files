using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestpractices
{
    internal class practice
    {
        /// <summary>
        /// 
        /// </summary>
        public void Demo1() => Console.WriteLine("Inside Demo1 Method");

        public void printdata(params string[] arr)
        {
            foreach (var s in arr) Console.WriteLine(s);
        }
        public List<string> printdata()
        {
            List<string> li = new List<string>() { "india", "canada" };
            return li;
        }
    }
}
