using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgemini_programs
{
     class Inheritance
    {
       

            public string name;

            public void display()
            {
                Console.WriteLine("I am an animal");
            }

        }

         
        class Dog : Inheritance
        {

            public void getName()
            {
                Console.WriteLine("My name is " + name);
            }
        }

        class Program_1
        {

            static void Main(string[] args)
            {

                
                Dog labrador = new Dog();

                
                labrador.name = "Rohu";
                labrador.display();

                
                labrador.getName();

                Console.ReadLine();
            }

        }
}
