using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class Features
    {

        public void demo()
        {
            int? age = null;
            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine("Age is null");
            }
        }

        
    }
}
