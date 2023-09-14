using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeOOP

{
    public class Project
    {
        static void Main(string[] args)
        {
            // ----------------------- Declare the initial player -----------------------
            int player = 1;
            int choice;

            // ----------------------- Create a new object of the Game() class -----------------------
            Game myGame = new Game();
            
            while (true)
            {
                // ----------------------- Display the field -----------------------
                myGame.ShowField();
                Console.WriteLine("\nPlayer 1 = X          Player 2 = O");

                while (true)
                {
                    // ----------------------- Tell player to make a choice -----------------------
                    Console.WriteLine("Player {0}, please type your choice:", player);

                    // ----------------------- Handle cases where player makes a choice on the board -----------------------
                    try
                    {
                        choice = int.Parse(Console.ReadLine());

                        if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 || choice == 7 || choice == 8 || choice == 9)
                        {
                            // ----------------------- Handle cases where player chooses a spot already taken -----------------------
                            if (choice == 1 && myGame.GetSquare(choice - 1) != '1')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 2 && myGame.GetSquare(choice - 1) != '2')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 3 && myGame.GetSquare(choice - 1) != '3')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 4 && myGame.GetSquare(choice - 1) != '4')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 5 && myGame.GetSquare(choice - 1) != '5')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 6 && myGame.GetSquare(choice - 1) != '6')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 7 && myGame.GetSquare(choice - 1) != '7')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 8 && myGame.GetSquare(choice - 1) != '8')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            else if (choice == 9 && myGame.GetSquare(choice -1 ) != '9')
                            {
                                Console.WriteLine("Please make a valid selection that is not already marked");
                            }
                            // ----------------------- Handle cases where player chooses a valid spot -----------------------
                            else
                            {
                                break;  // Break out of the loop and start marking the board
                            }
                        }
                    }

                    // ----------------------- Handle cases where player did not make a valid choice -----------------------
                    catch
                    {
                        Console.WriteLine("\nPlease make a valid selection");   // Stay in the while loop until a valid choice is made
                    }
                }

                // ----------------------- Mark the board -----------------------
                myGame.UpdateSquare(choice, player);

                // ----------------------- Check for a winner -----------------------
                if (myGame.CheckForWinner())
                {
                    myGame.ShowField();
                    Console.WriteLine("\nLet's play again?");
                    myGame.ResetField();
                }    

                // ----------------------- Switch Players -----------------------
                if (player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
                }
            }
        }
    }
}
