using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pierwszyprogram
{
    class Program
    {
        static void  aain()
        {

            string[,] multiarray = { { "jan", "rodo"},
                { "krzysztof", "kononowicz"}, {"Major", "Suchodolski" } }; 
            for (int i = 0; i < multiarray.GetLength(0); i++)
            {
                for (int j = 0; j < multiarray.GetLength(1); j++)
                {
                    Console.Write(" {0}", multiarray[i, j].ToUpper());
                }
                Console.WriteLine();
            }

            // drugi blok tk
            
            int[] tablica = {20, 40, 60, 100};
            int[] tablica1 = new int[10];
            Array tablica2 = Array.CreateInstance(typeof(int), 10);

            StringBuilder sb = new StringBuilder("RANDOM TEXT");
            
            


            Console.ReadKey();
        }


        static void PrintArray(Array intArray, string mess)
        {
            foreach (int i in intArray)
            {
               
                    Console.WriteLine("{0} : {1} ", i, mess);
                
            }
        }


        private static void SayHello()
        {
            
            Console.Write("What is your name  ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);

            Console.ReadKey();
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


