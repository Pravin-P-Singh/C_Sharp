using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //using is similar to import in java; you import the classes by writing it so that you can be able to create the objects in the main method.

namespace ConsoleApp1 //Namespace is similar to packages in java. It is used to organize the code into logical sections as per the requirement and helps prevent naming conflicts. With proper use of namespaces you will make sure that a class's full name is always unique.
{
    internal class Program //This is the name of the class i.e. Program; the 'internal' access modifier means that the class will be accessible inside the current project only; if you don't specify internal keyword then it is going to be by default internal.

    //Private access modifier is not allowed for top level classes. Private modifier is only allowed for class members like methods, variables and other nested classes.
    {
        //A class cannot have multiple main methods.
        /*  Valid method signatures.
         *  static void Main()
            static void Main(string[] args)
            static int Main()
            static int Main(string[] args)

         */
        /*static void Main(string[] args) //static - Can be only called with the class name; void - the method doesn't returns anything; Main - name of the method; string [] args - Accepts an argument of string array.
        {
            Console.WriteLine("Hello World"); //Console is a class; WriteLine is a method.
            //Note that every method in c sharp follows pascal case naming convention example: 'W'rite'L'ine 
        }*/
    }
}
