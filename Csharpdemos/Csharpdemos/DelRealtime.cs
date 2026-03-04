using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    public delegate bool mydelegate(int x);
    internal class DelRealtime
    {
        public void StoreInFile(mydelegate a,int[] data)
        {
            foreach(int item in data)
            {
                if (a.Invoke(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        
    }
}
