using System;
namespace App
{
    class Program
    {
        static string[,] gameZone = {{"□","□","□"},
                                     {"□","□","□"},
                                     {"□","□","□"}};

        static int[,] avaibableMove = {{0,0,0}
                                      ,{0,0,0}
                                      ,{0,0,0}};

        static bool gameIsOn = true;
        public static void Main(string[] args)
        {
           while(gameIsOn)
           {
             Console.Clear();
             Display();
             Check();
             PlayerMove();
             GameMove();
             CheckForDraw();
           }
            
        } 
        public static void Display()
        {
            int count = 0;

            foreach (string n in gameZone)
            {
                if(count == 2 )
                {
                    Console.WriteLine(n);
                    count=0;
                }
                else
                {
                    Console.Write(n);
                    count++;
                }
            }
        }   

        public static void Check()
        {
            // Horrizontal checks
            if (gameZone[0,0] == gameZone[0,1] && gameZone[0,1] == gameZone[0,2])
            {
                if (gameZone[0,0] == "x" && gameZone[0,1] == "x" && gameZone[0,2] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[0,0] == "o" && gameZone[0,1] == "o" && gameZone[0,2] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }
            if (gameZone[1,0] == gameZone[1,1] && gameZone[1,1] == gameZone[1,2])
            {
                 if (gameZone[1,0] == "x" && gameZone[1,1] == "x" && gameZone[1,2] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[1,0] == "o" && gameZone[1,1] == "o" && gameZone[1,2] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }
            if (gameZone[2,0] == gameZone[2,1] && gameZone[2,1] == gameZone[2,2])
            {
                 if (gameZone[2,0] == "x" && gameZone[2,1] == "x" && gameZone[2,2] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[2,0] == "o" && gameZone[2,1] == "o" && gameZone[2,2] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }

            // Vertical checks
            if (gameZone[0,0] == gameZone[1,0] && gameZone[1,0] == gameZone[2,0])
            {
                 if (gameZone[0,0] == "x" && gameZone[1,0] == "x" && gameZone[2,0] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[0,0] == "o" && gameZone[1,0] == "o" && gameZone[2,0] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }
            if (gameZone[0,1] == gameZone[1,1] && gameZone[1,1] == gameZone[2,1])
            {
                 if (gameZone[0,1] == "x" && gameZone[1,1] == "x" && gameZone[2,1] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[0,1] == "o" && gameZone[1,1] == "o" && gameZone[2,1] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }
            if (gameZone[0,2] == gameZone[1,2] && gameZone[1,2] == gameZone[2,2])
            {
                 if (gameZone[0,2] == "x" && gameZone[1,2] == "x" && gameZone[2,2] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[0,2] == "o" && gameZone[1,2] == "o" && gameZone[2,2] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }

            // Diagonal checks
            if(gameZone[0,0] == gameZone[1,1] && gameZone[1,1] == gameZone[2,2])
            {
                 if (gameZone[0,0] == "x" && gameZone[1,1] == "x" && gameZone[2,2] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[0,0] == "o" && gameZone[1,1] == "o" && gameZone[2,2] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }
            if(gameZone[0,2] == gameZone[1,1] && gameZone[1,1] == gameZone[2,0])
            {
                 if (gameZone[0,2] == "x" && gameZone[1,1] == "x" && gameZone[2,0] == "x")
                {
                    Console.WriteLine($"You won");
                    gameIsOn = false;
                }
                if (gameZone[0,2] == "o" && gameZone[1,1] == "o" && gameZone[2,0] == "o")
                {
                    Console.WriteLine($"You lost");
                    gameIsOn = false;
                }
            }

        }
  
        public static void PlayerMove()
        {
            Console.WriteLine($"Select column: ");
            Console.WriteLine($"1,2,3?");
            int col = Convert.ToInt32(Console.ReadLine()) - 1;


            Console.WriteLine("Select row: ");
            Console.WriteLine($"1 \n2 \n3 ");
            int row = Convert.ToInt32(Console.ReadLine()) - 1;
            
            if (avaibableMove[row,col] == 0)
            {
                gameZone[row,col] = "x";
                avaibableMove[row,col] = 1;
            }
            else
            {
                Console.WriteLine($"Invalid Move");
            }
        }
    
        public static void GameMove()
        {
            bool MoveHasBeenMade = false;
            while (!MoveHasBeenMade)
            {
                Random move = new();

                int row = move.Next(0,2);
                int col = move.Next(0,2);

                if (avaibableMove[row,col] == 0)
                {
                    gameZone[row,col] = "o";
                    avaibableMove[row,col] = 1;
                    MoveHasBeenMade = true;
                }
                else
                {
                    continue;
                }
            }
        }
    
        public static void CheckForDraw()
        {
            int count = 0;

            foreach (int n in avaibableMove)
            {
                if (n == 1)
                {
                    count++;
                }
            }

            if (count == 9)
            {
                Console.WriteLine($"Draw");
                gameIsOn = false;
            }
        }
    }
}