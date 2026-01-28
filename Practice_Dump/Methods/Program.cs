using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        string name;
        int id;
        public Program()
        {
            Console.WriteLine("No argument constructor called.");
        }
        //public Program():base()  --> BY default this base call is always there which calls constructor of the topmost parent class i.e. the System.object class.
        //{
        //    Console.WriteLine("No argument constructor called.");
        //}
        public Program(int id):this()
        {
            Console.WriteLine("1 Parameter Constructor Called.");
            this.id = id;
        }

        public Program(String name, int id):this(id)
        {
            this.name = name;
            Console.WriteLine("2 Parameter Constructor called");
            Console.WriteLine(this.GetType());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method called.");
            Program program = new Program("Pravin",12);
            Console.WriteLine($"The value for id:{program.id} name:{program.name}");

            //We can also use this keyword inorder to pass the current object to the next method
        }
    }
}
