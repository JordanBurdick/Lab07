using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07JordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1 loop
            Console.WriteLine("");
            Console.WriteLine("Part 1");
            Console.WriteLine("");

            //loop control variable
            int LoopVar = 0;
            //loop terminating condition
            while (LoopVar < 9)
            {
                //loop
                LoopVar++;
                //loop counter
                Console.WriteLine(LoopVar);
            }

            //part 2 loop
            Console.WriteLine("");
            Console.WriteLine("Part 2");
            Console.WriteLine("");
            int i = 30;
            String EvenStatement;
            while (i < 45)
            {
                i += 1;
                if ((i%2) ==0)
                {
                    EvenStatement = "This number is even";
                }
                else
                {
                    EvenStatement = "This number is odd";
                }
                Console.WriteLine("{0} {1}",i,EvenStatement);
            }

            //part 3 if time
            Console.WriteLine("");
            Console.WriteLine("Part 3");
            Console.WriteLine("");

            
            int UserTimeInput;
            Console.WriteLine("Please enter the current time in 24 hour format");
            UserTimeInput = int.Parse(Console.ReadLine());
            if (UserTimeInput < 12 && UserTimeInput > 0)
            {
                Console.WriteLine("Good morning");
            }
            else if (UserTimeInput > 11 && UserTimeInput < 17)
            {
                Console.WriteLine("Good afternoon");
            }
            else if (UserTimeInput > 16 && UserTimeInput < 25)
            {
                Console.WriteLine("Good evening");
            }
            else
            {
                Console.WriteLine("Please enter a valid time");
            }


            //part 4 fix the bug
            Console.WriteLine("");
            Console.WriteLine("Part 4");
            Console.WriteLine("Search and destroy");
            Console.WriteLine("");

            //old code
            /*
             
            int i2 = 10;
            while (i2 < 21)
            {
                Console.WriteLine(i2);
            }

            */


            //change this to 9 from 10
            int i2 = 9;
            //and change the limit from 21 to 20
            while (i2 < 20)
            {      
                //just add i2++ like i did below so it counts, otherwise its an infinite loop as i2 will never get above 21
                i2++;
                Console.WriteLine(i2);
            }


            Console.WriteLine("");
            Console.WriteLine("Part 5");
            Console.WriteLine("");

            for (int j = 0; j < 101; j++)
                // all i did was add brackets, not sure if thats what you wanted
            {
                Console.WriteLine(j);
                Console.WriteLine("********");
            }

            Console.WriteLine("");
            Console.WriteLine("Part 6");
            Console.WriteLine("");

            int i3;
            for (i3 = 0; i3 <= 10; i3++)
            {
                Console.WriteLine("**********".Substring(0, i3));
            }

            //pls
        }
    }
}
