using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psuedocode_testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this problem i need to solve a Fizz buzz algorithm 
            //Make a code that generates numbers from 1-20 ON A NEW LINE
            //Each time the code reaches multple of 3 it must display (FIZZ)
            //Each time the code reaches multple of 5 it must display (BUZZ)
            //Each time the code reaches multple of both 3 and 5  it must display(FIZZ BUZZ)

            //---------------------------------------------------------------------------------------

            for (int i = 1; i <= 20; i++)  //A for loop that starts from 1-20
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                //If number is a multple of 3 the code will display fizz
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                //If number is a multple of 5 the code will display buzz
               else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
               
                else Console.WriteLine(i);
            
                    
              
            }  

            Console.ReadLine();
        }
    }
}
