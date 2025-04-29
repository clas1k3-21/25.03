using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Alice");
            //p.Age = -5;   
            //p.Age = 15;
            p.Age = 18;
            Console.WriteLine(p.Age); 


        }


    }

    class Person 
    {
    private int age;    
    public string Name { get; set; }    
    public int Age
        {
            get { return age; }

            set
            {

                if (value < 0)
                {
                    Console.WriteLine("Возраст не может быть отрицательным");
                    return;
                }

                if (value < 18)
                {
                    Console.WriteLine("Несовершеннолетний пользователь");
                }
                age = value;                  
            }
        }
        public Person(string Name)
        {
            this.Name = Name;
            
        }

    }
}
