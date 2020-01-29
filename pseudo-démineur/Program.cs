using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pseudo_démineur
{
    class Program
    {
        //Partie 1
        static void CreerDemineur1(int[,] demineur) 
        {
            int x = 0, y = 0;
            for (int i = 0; i < demineur.Length; i++)
            {
                if (demineur[y, x] < 0)
                    Console.Write("| M ");
                else
                    Console.Write("| " + demineur[y, x] + " ");
                x++;
                if (x > 4)
                {
                    x = 0;
                    y++;
                    Console.Write("|\n");
                }
            }
        }
        //Partie 2 & 3
        static void CreerDemineur2(int[,] demineur)
        {
            while (1 == 1)
            {
                bool checkProximity = true;
                int x = 0, y = 0;
                Console.Write("_________________________________________\n");
                for (int i = 0; i < demineur.Length; i++)
                {
                    if (demineur[y, x] < 10)
                        Console.Write("|_*_");
                    else
                        Console.Write("|_" + (demineur[y, x] - 10) + "_");
                    x++;
                    if (x >= demineur.GetLength(0))
                    {
                        x = 0;
                        y++;
                        Console.Write("|\n");
                    }
                }
                Console.Write("\nQuelle case voulez-vous sélectionner?\nX - ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y - "); y = Convert.ToInt32(Console.ReadLine());
                //Si l'utilisateur frappe une mine
                if (demineur[y, x] == -1)
                {
                    Console.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.Write("" +
    "     _.-^^---....,,--       \n" +
    " _--                  --_   \n" +
    "<                        >) \n" +
    "|                         | \n" +
    " \\._                   _./  \n" +
    "    ```--. . , ; .--'''     \n" +
    "          | |   |           \n" +
    "       .-=||  | |=-.        \n" +
    "       `-=#$%&%$#=-'        \n" +
    "          | ;  :|           \n" +
    " _____.,-#%&$@%#&#~,._____  ");
                        System.Threading.Thread.Sleep(250);
                        Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(0, 0);
                        Console.Write("" +
    "     _.-^^---....,,--       \n" +
    " _--                  --_   \n" +
    "<                        >) \n" +
    "|                         | \n" +
    " \\._                   _./  \n" +
    "    ```--. . , ; .--'''     \n" +
    "          | |   |           \n" +
    "       .-=||  | |=-.        \n" +
    "       `-=#$%&%$#=-'        \n" +
    "          | ;  :|           \n" +
    " _____.,-#%&$@%#&#~,._____  ");
                        System.Threading.Thread.Sleep(250);
                    }
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nVOUS AVEZ FRAPPER UNE MINE. GAME OVER!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                //Si l'utilisateur frappe une case qu'il n'as pas toucher.
                if (demineur[y, x] < 10)
                    demineur[y, x] += 10;
                int x2 = 0, y2 = 0;
                while (checkProximity)
                {
                    checkProximity = false; x2 = 0; y2 = 0;
                    //Si la case était de 0(donc 10 après le clic)
                    if (demineur[y + y2, x + x2] == 10)
                    {
                        for (x2 = -1; x2 < 2; x2++)
                        {
                            for (y2 = -1; y2 < 2; y2++)
                            {
                                try
                                {
                                    if (demineur[y + y2, x + x2] == 0)
                                    {
                                        demineur[y + y2, x + x2] += 10;
                                        checkProximity = true;
                                        CheckProximityRecursive(ref demineur, x, y, x2, y2);
                                    }
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                }
                Console.Clear();
            }
        }
        static void CheckProximityRecursive(ref int[,] demineur, int x, int y, int x2, int y2)
        {
            y += y2; x += x2;
            for (x2 = -1; x2 < 2; x2++)
            {
                for (y2 = -1; y2 < 2; y2++)
                {
                    try
                    {
                        if (demineur[y + y2, x + x2] == 0)
                        {
                            demineur[y + y2, x + x2] += 10;
                            CheckProximityRecursive(ref demineur, x, y, x2, y2);
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
        static void Main(string[] args)
        {
            /* Partie 1
            int[,] demineur = {
                { 1, 2, 1, 1 , 0 },
                { -1, 2, -1, 1, 0 },
                { 1, 2, 1, 1, 0 },
                { 1, 1, 1, 0, 0 },
                { 1, -1, 1, 0, 0 }
                };*/
            /* Partie 2(modifiée pour partie 3
            int[,] demineur = {
                { 1, 2, 1, 1 , 0 },
                { -1, 2, -1, 1, 0 },
                { 1, 2, 1, 1, 0 },
                { 1, 1, 1, 0, 0 },
                { 1, -1, 1, 0, 0 }
                }; */
            //Partie 3, test MEGA
            int[,] demineur =
            {
                { 0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
                { 0, 0, 1, 1, 1, 0, 1, -1, 1, 0},
                { 0, 1, 2, -1, 2, 1, 1, 1, 1, 0},
                { 0, 1, -1, 2, 3,-1, 1, 1, 1, 1},
                { 0, 1, 1, 1, 1, 1, 1, 1,-1, 1},
                { 0, 1, -1, 1, 0, 0, 0, 1, 1, 1},
                { 0, 1, 1, 1, 0, 1, 1, 1, 0, 0},
                { 0, 1, 1, 1, 1, 1, 2, -1, 1, 0},
                { 1, 2, -1, 1, 1,-1, 2, 1, 1, 0},
                { 1, -1, 2, 1, 1, 1, 1, 0, 0, 0}
            };
            CreerDemineur2(demineur);
            Console.ReadKey();

        }
    }
}
