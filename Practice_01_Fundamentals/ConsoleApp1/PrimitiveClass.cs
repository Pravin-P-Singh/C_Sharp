using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrimitiveClass
    {
        static void Main(string[] args)
        {
             
            sbyte s_byte = 127; //sbyte.MaxValue sbyte.MinValue
            byte byte_var = 255; //byte.MaxValue byte.MinValue

            short short_var = 32767; //short.MaxValue short.MinValue

            ushort ushort_var = ushort.MaxValue;

            int int_var = int.MaxValue;

            uint uint_var = uint.MaxValue;

            long long_var = long.MinValue;

            ulong ulong_var = ulong.MaxValue;

            float float_var = float.MinValue;

            double double_var = 7.89390d;

            decimal decimal_var = decimal.MaxValue;

            Console.WriteLine(typeof(decimal));
            Console.WriteLine(decimal_var.GetType());

            //Operators ->
            //Arithmetic : + , - , * , / , %
            //Assignment :  += , -= , *= , /= , %=
            //Comparison : == , != , >= ,  <=
            //Logical : && , || , !
            //Ternary : <condition>?<if_true>:<if_false>

            //Casting:
            //Implicit casting : Happens automatically : Smaller data type value assignment to larger data type variable.
            //Explicit casting : Have to do it manually : Using <source_type> = (type) <destination_type>

            //int num = 1;
            //if (num == 1)
            //{
            //    Console.WriteLine("Num==1");
            //}
            //else if (num==2)
            //{
            //    Console.WriteLine("Num==2");
            //}
            //else
            //{
            //    Console.WriteLine("Developerrrrrrrr");
            //}

            //Switch case
            //Console.WriteLine("Enter a valid month number");
            //int month_number = int.Parse(Console.ReadLine());
            //switch(month_number)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Enter valid number"); break;
            //}


            //while loop
            int i = 1;
            while(i <= 10)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }
                else if (i == 7)
                { 
                    break; 
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            //For loop
            int tableOf = 2;
            for(int count = 1; count<=10; count++)
            {
                Console.WriteLine($"{tableOf} * {count} = {tableOf*count}");
            }

            //do while loop
            do
            {
                System.Console.WriteLine("This do while loop will execute atleast once.");
            } while (1 > 2);


            //Incrementing from 0 to n-1 
            string[] fruits = { "Apple", "Banana", "Mango", "Grapes", "Pineapple" };
            for(int count = 0; count< fruits.Length; count++)
            {
                Console.WriteLine($"Item at {count + 1} is {fruits[count]}");
            }
            
            goto printlabel;
            Console.WriteLine("Some statement - 1");
            Console.WriteLine("Some statement - 2");
            Console.WriteLine("Some statement - 3");
            Console.WriteLine("Some statement - 4");
            Console.WriteLine("Some statement - 5");

        printlabel:
            Console.WriteLine("Label demo");

            //Right Angle Star pattern
            int limit = 5;
            for(int j = 0; j < limit; j++)
            {
                for(int k = 0; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Inverted Right Angle star pattern
            for (int j = 0; j < limit; j++)
            {
                for(int k = limit-1; k >=j; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Pyramid
            for(int j = 0; j < limit; j++)
            {
                for(int space = limit-1; space > j; space--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k <= 2 * j ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Ternary Operator
            //Call stack and method stack.
        }
    }
}
