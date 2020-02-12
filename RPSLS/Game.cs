using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Variables

        public int playerOneScore;
        public int playerTwoScore;
        public int computerScore;
        public string playerOneEntry;
        public string playerTwoEntry;
        public string computerEntry;
        public string whichGame;

        
        List<string> gestures = new List<string> { "rock", "paper", "scisor", "lizared", "spock" };

        //Constructor
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            computerScore = 0;
            playerOneEntry = null;
            playerTwoEntry = null;
            computerEntry = null;
            whichGame = null;




        }
        
        //Methods


        public void singleOrDoubleGame()
        {
            Console.WriteLine("If you would like to play by yourself type 'one'.  Otherwise type 'two' to play agianst the computer: ");
            whichGame = Console.ReadLine();
            
            
            //need to enter commands here for one or two players
        }

        public void printStartingScore()
        {
            Console.WriteLine("Starting score is: ");
            Console.WriteLine("Player 1: ",playerOneScore);
            Console.WriteLine("Player 1: ", playerTwoScore);
        }

        public void getPlayerOneEntry()
        {
            do
            {
                Console.WriteLine("Player one, enter gestrure rock, paper, scisors, lizard, or spock");

                playerOneEntry = Console.ReadLine();
            }
            while (playerOneEntry != gestures[0] || playerOneEntry != gestures[1] || playerOneEntry != gestures[2] || playerOneEntry != gestures[3] || playerOneEntry != gestures[4]);
        }
        public void getPlayerTwoEntry()
        {
            Console.WriteLine("Player two, enter gestrure: ");
            playerTwoEntry = Console.ReadLine();
        }

        public void checkForWinner()
        {
            if(playerOneScore == 3)
            {
                Console.WriteLine("Player 1 is the winner!");
            }
            else if(playerTwoScore == 3)
            {
                Console.WriteLine("Player 2 is the winner!");
            }
        }

        
        
        public void roundWinner()
        {
           
            while(playerOneScore < 3 && playerTwoScore < 3)
            {
                if (playerOneEntry == playerTwoEntry)
                {
                    Console.WriteLine("Tie, no change in score.");
                }
                else if (playerOneEntry == gestures[1] && playerTwoEntry == gestures[0])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[1] && playerTwoEntry == gestures[4])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[0] && playerTwoEntry == gestures[2])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[0] && playerTwoEntry == gestures[2])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[2] && playerTwoEntry == gestures[1])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[2] && playerTwoEntry == gestures[2])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[3] && playerTwoEntry == gestures[4])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[2] && playerTwoEntry == gestures[1])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[4] && playerTwoEntry == gestures[2])
                {
                    playerOneScore++;
                }
                else if (playerOneEntry == gestures[4] && playerTwoEntry == gestures[0])
                {
                    playerOneScore++;
                }
                else
                {
                    playerTwoScore++;
                }
            }
            
        }


    }
}
