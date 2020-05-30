using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace pierwszyprogram
{
    class Program
    {
        static void  sain()
        {

            Console.WriteLine("welcome to quest random number");
            
            Random r = new Random();
            int RandomNumber = r.Next(1, 11);
            bool win;
            int trycount = 1;
            int userNumber = -1;

            do
            {
                

                Console.WriteLine("choose number betwen 1 - 10");

                
                bool isENumber = int.TryParse(Console.ReadLine(), out userNumber);

                while (!BetweenRanges(1,10, userNumber) || !isENumber)
                {

                    Console.WriteLine("u must type number between 1 and 10, and string is invalid");
                    isENumber = int.TryParse(Console.ReadLine(), out userNumber);
                    
                }



            if (userNumber == RandomNumber)
            {
                Console.WriteLine("gratz you guess correct number");
                    win = true;
            }
            else
            {
                    
                    win = false;
                    trycount += 1;

                    if (userNumber > RandomNumber)
                    {
                        Console.WriteLine(" your number is too high, try again");
                    }
                    else {
                        Console.WriteLine(" ur number is too low, try again");
                         }
                    
            }
            } while (!win);

            Console.WriteLine($"u win after {trycount} tries");

            Console.ReadKey();
        }


        


        static bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }
    }
}
/*
namespace Drugiprogram
{
    class Program2
    {


        static void UMBO(string[] args)
        {


        }
    }
}
*/


