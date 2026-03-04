using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class deleg
    {
        public delegate void mydel(int x);

        public void Odd(int x)
        {
            Console.WriteLine("Odd numbers");
        }
        public void Even(int x)
        {
            Console.WriteLine("Even numbers");
        }
        public void show(int x)
        {
            mydel ob = null;
            if (x % 2 == 0)
            {
                //ob = new mydel(Even);//1. way
                //ob = Even;//2.way
                ob = delegate (int y)//3.way -> anonymous methods
                {
                    Console.WriteLine("Even number" + y);
                };
            }
            else
            {
                ob = new mydel(Odd);
            }
            ob.Invoke(x);
                
        }


    }
}
