using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace pierwszyprogram
{
    class Program123
    {
        static void Main()
        {

            do
            {
                Console.ResetColor();
                welcomemessage();
                int player1 = input1();
                int player2 = input2();

                string winner = whowin2(player1, player2);
                winMessage(winner);
            } while (playagain());
            

            Console.ReadLine();
        }

        static void welcomemessage()
        {
            Console.WriteLine("Welcome in rock, paper, scissors game");
            Console.WriteLine("There is three types to choose : \n" +
                "1. rock \n" +
                "2. paper \n " +
                "3. scissors \n" +
                    "please choose NUMBER 1-3 ");


        }

        static int input1()
        {
            Console.WriteLine("Player 1 please input your number");
            return Convert.ToInt32(Console.ReadLine());

        }
        static int input2()
        {
            Console.WriteLine("Player 2 please input your number");
            return Convert.ToInt32(Console.ReadLine());
        }

        

        static void winMessage(string winner)
        {
            if (winner == "player1")
            {
                colorchange(ConsoleColor.Yellow);
                Console.WriteLine("Player 1 WIN");
            }
            else if (winner == "player2")
            {
                colorchange(ConsoleColor.Green);
                Console.WriteLine("Player 2 WIN");
            }
            else
            {
                colorchange(ConsoleColor.Red);
                Console.WriteLine("its a draw");
            }


        }

        static string whowin2(int x, int y)
        {
            // x- player 1 input, y- player 2 input
            // 1 - rock, 2- paper, 3 = scissors
            Dictionary<int, int> player1win = new Dictionary<int, int>() {
                { 1, 3 },
                { 2, 1 },
                { 3, 2 }
                };
             Dictionary<int, int> player2win = new Dictionary<int, int>() {
                { 1, 2 },
                { 2, 3 },
                { 3, 1 }
                   };

            string win1 = "";

            if (player1win.ContainsKey(x) && player1win[x].Equals(y))
            {
                win1 = "player1";
            }
            else if (player2win.ContainsKey(x) && player2win[x].Equals(y))
            {
                win1 = "player2";
            }
            else if (x == y)
            {
                win1 = "draw";
            }
            else
            {
                Console.WriteLine("something wrong");
            }
            return win1;


        }
        static void colorchange(ConsoleColor x)
        {
            Console.ForegroundColor = x;
            Console.Clear();
        }


        static bool playagain()
        {
            Console.WriteLine("czy chcesz grac dalej Y/N ");
            char answer = Convert.ToChar(Console.ReadLine().ToUpper());
            if (answer == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }

        }
	
    }
}
