using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26a_ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] firstarray = new int[3] { 1, 2, 3 };
            ArrayHelper newarray = new ArrayHelper();
            Console.WriteLine("Enter an integer.");
            bool exit = false;
            while (!exit)
            {
                string response = Console.ReadLine();
                if (response == "x")
                {
                    exit = true;
                }
                else
                {
                    newarray.Add((Convert.ToInt16(response)));
                    Console.WriteLine("\nHere's your new array of integers:");                    for (int i = 0; i < newarray.Length(); i++)
                    {
                        Console.Write(newarray.IntegerArray[i] + " ");
                    }
                    Console.Write("\n ");
                }
                Console.WriteLine("\nEnter 'x' to quit. Or enter a new integer.");
            }
        }
    }
    class ArrayHelper
    {
        public int[] IntegerArray = new int[0];
        public void Add(int number)
        {
            int[] temparray = new int[IntegerArray.Length + 1];
            for (int i = 0; i < IntegerArray.Length; i++)
            {
                temparray[i] = IntegerArray[i];

            }
            int nextnumber = number;
            temparray[temparray.Length - 1] = nextnumber;
            IntegerArray = temparray;


        }
        public int Length()
        {
            return IntegerArray.Length;
        }

    }
}
