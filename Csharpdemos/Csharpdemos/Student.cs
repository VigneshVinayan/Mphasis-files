using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdemos
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int []mark { get; set; }

        public Student() { }
        public Student(int id, string name, int[] mark) 
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }

        public void getDetails(Student[] details)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.Write(details[i].id + " ");
                Console.Write(details[i].name + " ");
                int m = 0;
                for (int j = 0; j < 4; j++)
                {
                    m += details[i].mark[j];
                }
                int a = m / 4;

                if (a > 60)
                {
                    Console.Write("FirstClass ");
                }
                else if (a < 60 && a > 50)
                {
                    Console.Write("Second Class ");
                }
                else
                {
                    Console.Write("Fail ");
                }
            }
        }
        public void getById(int Id, Student[]details)
        {
            for (int i = 0; i < 5; i++)
            {
                if(Id == details[i].id)
                {
                    Console.WriteLine(details[i].id);
                    Console.WriteLine(details[i].name);
                    for(int j = 0; j < 4; j++)
                    {
                        Console.WriteLine(mark[j]);
                    }
                }
            }
        }
        public void getFirstClassStudents(Student[] details)
        {
            for (int i = 0; i < 5; i++)
            {
                int m = 0;

                for (int j = 0; j < 4; j++)
                {
                    m += details[i].mark[j];
                }
                int a = m / 4;
                if (a > 60)
                {
                    Console.WriteLine(details[i].id);
                    Console.WriteLine(details[i].name);
                } 
            }
        }
        public void getStdNametStartsS(Student[] details)
        {
            for (int i = 0; i < 5; i++)
            {
                if (details[i].name.StartsWith("S")|| details[i].name.StartsWith("s"))
                {
                    
                    Console.WriteLine(details[i].name);
                    
                }
            }
        }
    }
}
