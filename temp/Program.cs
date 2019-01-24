using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {

            //conversion from Fahrenheit to Celsius or vise versa
            Console.WriteLine("Press 1 to convert Fahrenheit to Celsius or press 2 to convet Celsius to Fahrenheit.");
            //it will read 1 or 2 and direct to the proper if statement
            //a is the answer    t is the temp
            string a = Console.ReadLine();
            double t = Convert.ToDouble(a);

            //conversion formula from F to C
            if (t == 1)
            {
                Console.WriteLine("Enter the temperature for Fahrenheit:");
                double x = Convert.ToDouble(Console.ReadLine());
                //takes the double and solves the equation
                double FtoC = (x - 32) * 5 / 9;
                Console.WriteLine("The Celsius temperature is {0}: ", FtoC);
                Console.ReadLine();
            }


            //conversion formula from C to F
            else if (t == 2)
            {
                Console.WriteLine("Enter the temperature for Celsius:");
                double x = Convert.ToDouble(Console.ReadLine());
                //takes double and solves the equation
                double CtoF = (x * 9 / 5) + 32;
                Console.WriteLine("The Fanrenheit temperature is {0}: ", CtoF);
                Console.ReadLine();
            }
            }
        }
    }

