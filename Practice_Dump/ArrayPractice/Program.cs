using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Program:ICloneable
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            string[] names = new string[3] { "Pravin", "Chirag", "Nikhil" };
            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
            System.Array.Sort(names);
            foreach (string s in names)
            {
                Console.Write(s + " ");
            }

            //2d array
            int[,] matrix = new int[3, 3]
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            //Jagged arrays
            int[][] jaggedArray = new int[3][];
            Array.Reverse(arr);
            Console.WriteLine("***********");

            //Console.WriteLine(arr.Average());
            //Console.WriteLine(matrix.Rank);
            Console.WriteLine(Array.BinarySearch(arr, 3));
            Console.WriteLine(Array.IndexOf(arr, 100));
            Array.Resize(ref arr, 10);
            Console.WriteLine(string.Join(", ", arr));
            //Array.Clear(arr,0,2);
            Console.WriteLine(string.Join(", ", arr));
            int[] copiedArray = new int[10];
            //Array.Copy(arr,copiedArray,10);
            //Console.WriteLine(string.Join(", ", arr));
            //Console.WriteLine(string.Join(", ", copiedArray));
            object v = arr.Clone();
            Console.WriteLine("************************************************");
            foreach(int item in (int[])v)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine("\n************************************************");

            //Jagged array
            int[][] jg = new int[4][];
            jg[0] = new int[4]{ 1,2,3,4};
            jg[1] = new int[3] { 5, 6, 7 };
            jg[2] = new int[5] { 8, 9, 10, 11, 12 };
            jg[3] = new int[1] { 13 };
            for (int i = 0; i < jg.Length; i++)
            {
                for (int j = 0; j < jg[i].Length; j++)
                {
                    Console.Write(jg[i][j] + ", ");
                }
                Console.WriteLine();
            }


            


        }
    }
}
