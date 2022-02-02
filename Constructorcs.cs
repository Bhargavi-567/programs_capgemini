using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgemini_programs
{
    internal class Constructorcs
    {

        // Default constructor
        public Constructorcs()
        {
            Console.WriteLine("Welcome message from Default Constructor...");
        }

        // Parametarized constructor
        public Constructorcs(string name)
        {
            Console.WriteLine("\n\nThis message from parametarized constructor");
            Console.WriteLine("Welcome to Constructor sample, by {0}", name);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            // Creating object for Welcome class
            // This will called default constructor
            Constructorcs obj = new Constructorcs();

            // Creating object for welcome class by passing parameter
            // This will called parametarized constructor which matches
            Constructorcs pObj = new Constructorcs("Ramakrishna Basgalla");

            Console.Read();
        }
    }
}
