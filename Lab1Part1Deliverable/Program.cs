using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        const int maxLength = 3;
        private static void Main(string[] args)

        { //instructs user to enter a 3 digit number
            Console.WriteLine("We will compare two, 3-digit numbers to see if their corresponding place in the two numbers sums to the same total.");
            Console.Write("Enter a 3 digit number. ");

            int userValue1;
            userValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another 3 digit number. ");
            int userValue2;
            userValue2 = Convert.ToInt32(Console.ReadLine());

            // ensure user inputs only 3 digits.  Converting arguments to string so that I could use the Count() function
            if ((userValue1.ToString().Count() != 3) || (userValue2.ToString().Count() != 3))
            {
                Console.WriteLine("Error: Either 1 or both of the arguments you entered isn't 3 digits long");
                Console.Read();
            }

            int a = userValue1;
            int b = userValue2;
            int c = a + b;

            // Access each character separately, convert to integer, and add to the 2nd argument at same location
            int sumPlace1 = Convert.ToInt32(userValue1.ToString()[0] - '0') + Convert.ToInt32(userValue2.ToString()[0]) - '0';
            int sumPlace2 = Convert.ToInt32(userValue1.ToString()[1] - '0') + Convert.ToInt32(userValue2.ToString()[1]) - '0';
            int sumPlace3 = Convert.ToInt32(userValue1.ToString()[2] - '0') + Convert.ToInt32(userValue2.ToString()[2]) - '0';

            // return true if all 3 sums from above are equal
            if ((sumPlace1 == sumPlace2) && (sumPlace1 == sumPlace3))
            {
                Console.WriteLine("True");
            }

            else if ((sumPlace1 != sumPlace2))
            {
             
                 
            Console.WriteLine("False");
            }


            Console.WriteLine("{0} + {1} = ", userValue1, userValue2);
            Console.WriteLine(c);
            Console.Read();
        }
    }
}
