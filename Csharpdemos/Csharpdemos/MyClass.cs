using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class MyClass
    {
        //access specifiers in csharp are private, protected, internal, protected internal
        public void add()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;

            //--String interpolation--
            Console.WriteLine($"The sum of {a} and {b} is {c}");
        }
        public void findGreatest()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine($"{a} is greater");
            //}
            //else
            //{
            //    Console.WriteLine($"{b} is greater");
            //}
            Console.WriteLine(((a > b)? a : b ) + " is greater");
        }
        public void ListDemo()
        {
            // in list items are accessed using index
            //suitable for small records
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);
            
            foreach(var item in li)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(li[0]);
        }
        public void DictionaryDemo()
        {   // in dictionary we access the data using keys
            //suitable for huge records as they use keys to accessing which is quicker
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(100, "India");
            dict.Add(200, "Canada");
            dict.Add(300, "UK");
            dict.Add(400, "Germany");

            foreach(var item in dict)
            {
                Console.WriteLine(item.Value + " ");
            }
        }
        public void stackDemo()
        {
            Stack<int> st = new Stack<int>();
            st.Push(100);
            st.Push(200);
            st.Push(300);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }
        public void queuedemo()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            Console.WriteLine(q.Dequeue());
        }
    }
}