using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT323_PECK_Unit6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 6 - Asserts and Try / Catch");

            string value = string.Empty;
            Debug.Assert((string.IsNullOrEmpty(value) == false), "Parameter must not be empty or null");
            int number = 0;
            Debug.Assert((number > 0), "Parameter must be greater than zero");

            try
            {
                string[] names = { "Ed", "Fred", "Ted", "Mel", "Stan" };
                string someName;
                for (int i = 0; i <= names.Length; i++)
                {
                    someName = names[i];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ArrayOutOfBounds error occured");
                Console.WriteLine(ex.Message.ToString());
            }
            try
            {
                int lineCounter = 0;
                string line;
                using (System.IO.StreamReader file = new System.IO.StreamReader("NoFileNamedThis.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        lineCounter++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FileDoesNotExist error occured"); 
                Console.WriteLine(ex.Message.ToString());
            }
            try
            {
                DivideByZero(42, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("DivideByZero error occured");
                Console.WriteLine(ex.Message.ToString());
            }
            Console.Read();
        }
        public static int DivideByZero(int num1, int num2)
        {
            if (num2 == 0)
                throw (new Exception("Divide By Zero"));
            return (num1 / num2);
        }
    }
}
