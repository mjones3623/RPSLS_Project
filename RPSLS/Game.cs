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

        Player Player1;
        Player Player2;
        //string numberofPlayers;
        
        int playerOneScore;
        int playerTwoScore;
        

        //Constructor

        public Game()
        {
        //numberofPlayers = "";
        
        

        }
        


        //Methods

        public void runGame()
        {
            string players = GetNumberofPlayers();
            setPlayers(players);

            do
            {
                Player1.chooseGesture();
                Player2.chooseGesture();
                roundWinner();
            } while (Player1.Score < 3 && Player2.Score < 3);            
            

        }
               
        public string GetNumberofPlayers()
        {
            string numberofPlayers;
            do
            {
                Console.WriteLine("Enter 1 or 2 players: ");
                numberofPlayers = Console.ReadLine();

            } while (numberofPlayers != "1" && numberofPlayers != "2");

            return numberofPlayers;                    
        }


        public void setPlayers(string numberofPlayers)
        {
            if(numberofPlayers == "1")
            {
                Player1 = new Human();
                Player2 = new AI();
            }
            else if(numberofPlayers == "2")
            {
                Player1 = new Human();
                Player2 = new Human();

            }
        }


        public void roundWinner()
        {
            if (Player1.gesture == Player2.gesture)
            {
                Console.WriteLine("Tie, no change in score.");
            }
            else if (Player1.gesture == Player1.gestures[1] && Player2.gesture == Player2.gestures[0])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[1] && Player2.gesture == Player2.gestures[4])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[0] && Player2.gesture == Player2.gestures[2])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[0] && Player2.gesture == Player2.gestures[2])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[2] && Player2.gesture == Player2.gestures[1])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[2] && Player2.gesture == Player2.gestures[2])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[3] && Player2.gesture == Player2.gestures[4])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[2] && Player2.gesture == Player2.gestures[1])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[4] && Player2.gesture == Player2.gestures[2])
            {
                Player1.Score++;
            }
            else if (Player1.gesture == Player1.gestures[4] && Player2.gesture == Player2.gestures[0])
            {
                Player1.Score++;
            }
            else
            {
                Player2.Score++;
            }

            Console.WriteLine("Player 1 score:  " + Player1.Score);
            Console.WriteLine("Player 2 score:  " + Player2.Score);

            if (Player1.Score == 3)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (Player2.Score == 3)
            {
                Console.WriteLine("Player 2 wins!");
            }
            Console.ReadLine();

            
            
        }


    }
}
