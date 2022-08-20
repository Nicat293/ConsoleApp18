using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{

    public class MyClass
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int num1 = array[0];
            int num2 = array[1];
            int count = 0;

            int num11 = num1;
            int num22 = num2;

            int num111 = num1;
            int num222 = num2;


            for (int i = num1; i < num2+1; i++)
            {
                
                   if (num11 / 2 == 0 & num11!=1)
                   {
                          num11 = num11 / 2;
                          count++;
                   }
                   else if (num11 / 2 == 1 & num11!=1)
                   {
                          num11 = 3 * num11 + 1;
                          count++;
                   }
                
            }


            Console.WriteLine(num111 + " " + num222 + " " + count);
            Console.ReadLine();

        }
    }
}
