using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class Task1
    {
        public void compute()
        {
            string empname = Console.ReadLine();
            int sal = int.Parse(Console.ReadLine());

            double hra = sal * 0.15;
            double da = sal * 0.10;
            double gross = hra + da + sal;
            double tax = gross*0.08;
            Console.WriteLine(hra);
            Console.WriteLine(da);
            Console.WriteLine($"{tax} {gross} {empname} {sal}");
            
        }
        public void printNames()
        {
            int count = int.Parse(Console.ReadLine());
            string name= Console.ReadLine();

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(name);
            }
        }
        public void findCommon()
        {
            int[] arr1 = { 45, 78, 45, 34, 65, 89 };
            int[] arr2 = { 78, 4, 8, 9, 65, 3, 7, 34};
            for(int i=0;i<arr1.Length;i++)
            {
                for(int j=0;j<arr2.Length;j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr2[i]);
                    }
                }
            }
        }

        public void findStrings()
        {
            Object[] myObjects = new object[5];
            myObjects[0] = "hello";
            myObjects[1] = 123;
            myObjects[2] = 123.4;
            myObjects[3] = null;
            myObjects[4] ="Mphasis";
            for(int i = 0; i < myObjects.Length; i++)
            {
                if (myObjects[i] is String)
                {
                    Console.WriteLine(myObjects[i]);
                }
            }

        }
        public void countries()
        {
            String[] st = {"Srilanka","Singapore","India","Swedan","Canada"};
            for(int i = 0; i < st.Length; i++)
            {
                if (st[i].StartsWith("S") && st[i].Length >= 7)
                {
                    Console.WriteLine(st[i].ToUpper());
                }
            }
        }
        public void countryNameCheck()
        {
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(1, "India");
            di.Add(2, "Srilanka");
            di.Add(3, "Canada");
            int key = int.Parse(Console.ReadLine());
            if (di.ContainsKey(key))
            {
                Console.WriteLine(di[key]);
            }
            else
            {
                Console.WriteLine("Inappropriate key");
            }
        }
        public void calledExeption()
        {
            int[] arr = new int[5];
            Console.WriteLine(arr[5]);
        }
    }
}
