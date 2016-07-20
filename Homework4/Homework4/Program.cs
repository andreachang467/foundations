using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            string strName;  // strName is the variable inputed by the user
            Console.WriteLine("Input a number that you want the factorial of");
            strName = Console.ReadLine(); //store the input
            int x = int.Parse(strName); // converting the string into an integer named x

            int y; // the amount you are multiplying X by
            int z; // the product of x and y
            y = 1;
            z = 1;

            for (y = 1; y <= x; y++) // 
            {
                z = z * y;
                Console.WriteLine("{0}! = {1}", y,z);

            }

            
            Console.ReadLine();

        }
    }
}