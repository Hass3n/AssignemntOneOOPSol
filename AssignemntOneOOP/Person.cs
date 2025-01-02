using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignemntOneOOP
{
    public struct Person
    {

        public String Name;
        public int age;

        public Person(String _name, int _age)
        {
            this.Name = _name;
            this.age = _age;
        }


        public void DisplayOldest(Person[] p )
        {
            int oldestAge = int.MinValue;
            String oldestName = "";
            for (int i = 0; i < p.Length; i++)
            {

                if (p[i].age > oldestAge)
                {
                    oldestAge = p[i].age;
                    oldestName = p[i].Name;

                }
               
            }

            Console.WriteLine("the oldest person is :");
            Console.WriteLine(oldestName);
            Console.WriteLine(oldestAge);
        }
 


    }
}
