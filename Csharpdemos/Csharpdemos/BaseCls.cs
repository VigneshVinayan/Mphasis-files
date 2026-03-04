using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    public class BaseCls
    {
        public BaseCls(int num) 
        {
            Console.WriteLine(num);
        }
    }
    public class DerivedClass : BaseCls
    {
        public DerivedClass(int num) : base(num)
        {
            Console.WriteLine(num);
        }
    }
}
