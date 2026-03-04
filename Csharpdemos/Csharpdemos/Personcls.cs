using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    public class Personcls
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public Personcls() { }
        public Personcls(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;

            LastName = lastName;

            DOB = dob;
        }

        public void checkBirthday()
        {
            DateTime today = DateTime.Today;
            if (DOB.Month == today.Month && DOB.Day == today.Day)
            {
                Console.WriteLine("Happy Birthday :) ");
            }
            else
            {
                Console.WriteLine("No wishes for you!!");
            }
            int age = today.Year - DOB.Year;
            if(age > 18)
            {
                Console.WriteLine("Over 18!!!");
            }
            else
            {
                Console.WriteLine("Under-age!!!");
            }
        }



    }
}
