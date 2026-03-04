using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bestpractices
{
    internal class Thdemo
    {
        public void demo1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 1 called : "+i);
                Thread.Sleep(1000);
            }
        }
        public void demo2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2 called : " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
