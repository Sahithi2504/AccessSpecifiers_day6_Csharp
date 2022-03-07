using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_specifiers
{
    internal class Program
    {
        class access
        {

            public string name;
            public void print()
            {
                Console.WriteLine("\nMy name is " + name);
            }
        }


        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:");
            ac.name = Console.ReadLine();
            ac.print();

            Console.ReadLine();
        }





        //-------------protected------

        class ProtectedTest
        {
            protected string name = "Sahithi";
            protected void Msg(string msg)
            {
                Console.WriteLine("Hello " + msg);
            }
        }
        class Program1 : ProtectedTest
        {
            static void Main(string[] args)
            {
                Program1 program = new Program1();
                // Accessing protected variable  
                Console.WriteLine("Hello " + program.name);
                // Accessing protected function  
                program.Msg("Sravya");
                Console.ReadLine();
            }
        }




        //-----internal access specifier------


        class access
        {

            internal string name;
            public void print()
            {
                Console.WriteLine("My name is " + name);
            }
        }


        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:");
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }


        //---------protected internal---------
        class access
        {

            protected internal string name;
            public void print()
            {
                Console.WriteLine("My name is " + name);
            }
        }



        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:");
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}
