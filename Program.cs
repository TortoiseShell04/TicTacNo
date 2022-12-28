using System;
namespace App
{
    class Program
    {
        // Array for the playing feild
        static string[,] gameZone = {{"□","□","□"},
                                     {"□","□","□"},
                                     {"□","□","□"}};

        // Array for available spaces on the board
        static int[,] avaibableMove = {{0,0,0}
                                      ,{0,0,0}
                                      ,{0,0,0}};

        static bool gameIsOn = true;

        // Main method
        public static void Main(string[] args)
        {
           // Game loop
           while(gameIsOn)
           {
             Console.Clear();
             Display();
             PlayerMove();
             GameMove();
             Check();
             CheckForDraw();
           }
            
        } 


        // Method responsible for displaying the game board
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

        // Checks if the game ended and who won
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
  
        // Method for user input
        public static void PlayerMove()
        {
            Console.WriteLine($"Select column: ");
            Console.WriteLine($"1,2,3?");
            int col = Convert.ToInt32(Console.ReadLine());
            col--;

            Console.WriteLine("Select row: ");
            Console.WriteLine($"1 \n2 \n3 ");
            int row = Convert.ToInt32(Console.ReadLine());
            row--;
            
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
    
        // Genenrating random game move
        public static void GameMove()
        {
            bool MoveHasBeenMade = false;
            while (!MoveHasBeenMade)
            {
                Random move = new();

                int row = move.Next(0,3);
                int col = move.Next(0,3);

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

        // Checks if a draw occured
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