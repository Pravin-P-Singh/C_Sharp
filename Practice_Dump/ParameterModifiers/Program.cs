using System;

namespace ParameterModifiers
{
    internal class Program
    {
        private double marks=100;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Ref parameter modifier example the Resize method of Array class.
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"Num1 : {num1}  & Num2 :  {num2}");
            Change(ref num1, ref num2);
            Console.WriteLine($"Num1 : {num1}  & Num2 :  {num2}");

            //Out parameter modifier
            float numerator = 10.0f;
            float denominator = 0.0f;
            double result; //Old way of using out parameter modifier

            try
            {
                if (Divide(numerator, denominator, out result)) //out double result -> result could have been used only inside this if block then. It is called out declaration.
                {
                    Console.WriteLine($"Result is :{result}");
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }

            //in parameter modifier
            //var obj = new Object();
            //ParameterModifierIn(in obj); //We can just pass the reference and not actually change it inside the method.

            //ref returns
            Console.WriteLine("Ref return ::");
            Program p = new Program();
            ref double m = ref p.GetMarks();
            m = 45;
            Console.WriteLine(p.GetMarks());


            //params modifier
            String[] sports = { "Cricket", "Kabaddi", "Khokho" };
            printNames("Pravin");
            printNames("A1", "A2", "A3");
            printNames(sports);


            //local functions
            Console.WriteLine(CalculateDiscountPrice(10000, "SAVE10"));
            Console.WriteLine(CalculateDiscountPrice(10000, "SAVE20"));

        }
        public static void Change(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a + " " + b);
        }

        public static bool Divide(float numerator, float denominator, out double result)
        {
            if (denominator == 0)
            {
                result = 0;
                return false;
            }
            else
            {
                result = numerator / denominator;
                return true;
            }
        }

        public static void ParameterModifierIn(in Object obj)
        {
            Console.WriteLine($"{obj.GetType()}");
            try
            {
                //obj = new Object();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        public ref double GetMarks()
        {
            return ref marks;
        }

        public static void printNames(params String[] names)
        {
            foreach(string name in names)
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();
        }

        public static decimal CalculateDiscountPrice(decimal initialPrice, string userDiscountCode)
        {
            decimal discountedPrice;

            decimal GetDiscountPercentage(decimal Price, string discountCode)
            {
                if(Price > 500 && discountCode == "SAVE10")
                {
                    return 0.1M;
                }
                if(Price > 1000 && discountCode=="SAVE20")
                {
                    return 0.2M;
                }
                return 0;
            }
            discountedPrice = initialPrice - (initialPrice * GetDiscountPercentage(initialPrice, userDiscountCode));
            return discountedPrice;
        }

    }
}
