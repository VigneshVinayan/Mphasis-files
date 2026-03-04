using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class EmpClass
    {
        public int Empid;
        public string firstName;
        public string lastName;
        public int sal;
        public string dept;
        public void displayFullName()
        {
            Console.WriteLine(firstName + lastName);
        }
        public void calculateAnnualSalary()
        {
            Console.WriteLine(sal * 12);
        }
    }
}
