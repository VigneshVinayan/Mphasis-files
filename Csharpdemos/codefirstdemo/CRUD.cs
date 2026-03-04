using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstdemo
{
    internal class CRUD
    {
        Model1 dc = new Model1();
        public void Add()
        {
            try
            {


                Customer c = new Customer()
                {
                    id = 20,
                    name = "raj",
                    caddress = "bangalore",
                    age = 30,
                    Email = "raj@gmail.com",
                    Nationality = "india",
                    phone = "8585858585"
                };
                dc.Customers.Add(c);
                int i = dc.SaveChanges();
                Console.WriteLine("Total rows inserted are " + i);
            }
            catch(Exception e)
            {
                var res = dc.GetValidationErrors();
                foreach(var item in res)
                {
                    foreach(var i in item.ValidationErrors)
                    {
                        Console.WriteLine(i.PropertyName + " " + i.ErrorMessage);
                    }
                }
            }

        }
        public void display()
        {

        }
    }
}
