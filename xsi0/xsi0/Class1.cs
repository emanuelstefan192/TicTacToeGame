using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xsi0
{
    internal class actiuni
    {
        public const char playerMove = 'X';
        public static void resetboard(char[,] t)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t[i, j] = ' ';
                }
            }
        }
        public static void PlayerXMove(char[,] t)
        {
            Console.WriteLine("Enter a line (1-3) and a row (1-3):");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            while (x < 1 || x > 3 || y < 1 || y > 3 || t[x - 1, y - 1] != ' ')
            {
                Console.WriteLine("Incorect value. Enter other line and other row");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            x = x - 1; y = y - 1;
            t[x, y] = playerMove;
        }
        public static void showboard(char[,] t)
        {
            Console.WriteLine("-------------");
            Console.WriteLine($"| {t[0, 0]} | {t[0, 1]} | {t[0, 2]} | ");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {t[1, 0]} | {t[1, 1]} | {t[1, 2]} | ");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {t[2, 0]} | {t[2, 1]} | {t[2, 2]} | ");
            Console.WriteLine("-------------");
        }
        public static int freespaces(char[,] t)
        {
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (t[i, j] == ' ')
                    {
                        k++;
                    }
                }
            }
            return k;
        }
        public static char checkwinner(char[,] t)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((t[i, 0] == t[i, 1]) && (t[i, 0] == t[i, 2]))
                {
                    return t[i, 0];
                }
                else
                {
                    if ((t[0, i] == t[1, i]) && (t[1, i] == t[2, i]))
                    {
                        return t[0, i];
                    }
                    else
                    {
                        if ((t[0, 0] == t[1, 1]) && (t[0, 0] == t[2, 2]))
                        {
                            return t[0, 0];
                        }
                        else
                        {
                            if ((t[2, 0] == t[1, 1]) && (t[1, 1] == t[0, 2]))
                            {
                                return t[2, 0];
                            }
                        }
                    }
                }
            }
            return ' ';
        }
        public static void PlayerOMove(char[,] t)
        {
            Random rnd = new Random();
            int x;
            x = rnd.Next(0, 2);
            int y;
            y= rnd.Next(0, 2);
            while (t[x, y] == 'X' || t[x,y] == 'O')
            {
                x = rnd.Next(0, 2);
                y = rnd.Next(0, 2);
            }
            t[x, y] = 'O';
        }
    }
}