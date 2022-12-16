using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter index of item to be searched : ");
            string input = Console.ReadLine();

            findItemFromArray(Convert.ToInt32(input));

            //Console.WriteLine(Convert.ToInt32(input));

            Console.ReadKey();
        }

        public static void findItemFromArray(int index)
        {
            int[] array = new int[] { 10, 20, 30, 40, 50, 60 };

            try
            {
                Console.WriteLine("Execution Started!");
                Console.WriteLine("Item at index " + index + " is : " + array[index]);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally 
            { 
                Console.WriteLine("Execution Finished!"); 
            }
            
        }
    }
}
