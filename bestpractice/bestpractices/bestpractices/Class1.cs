using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestpractices
{
    internal class Class1 : IDisposable
    {
        public Class1()
        {
            Console.WriteLine("Constructor Called");
        }
        public void displaydata()
        {
            Console.WriteLine("Display data");
        }
        public void deletedata()
        {
            Console.WriteLine("Delete Data");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose Called");
            //GC.SuppressFinalize(this);
        }
        ~Class1()
        {
            Console.WriteLine("Destructor called");
        }
    }
}
