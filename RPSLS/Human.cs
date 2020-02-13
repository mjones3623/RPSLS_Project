using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {


        public override string chooseGesture()
        {
                       
            do
            {
                Console.WriteLine("Choose, and type, either rock, paper, scisors, lizard, or spock");

                gesture = Console.ReadLine();

                if (gesture == "rock")
                {

                    Console.WriteLine("You entered rock");
                }
                else if (gesture == "paper")
                {

                    Console.WriteLine("You entered paper");
                }
                else if (gesture == "scisors")
                {

                    Console.WriteLine("You entered scisors");
                }
                else if (gesture == "lizard")
                {

                    Console.WriteLine("You entered lizard");
                }
                else if (gesture == "spock")
                {

                    Console.WriteLine("You entered spock");
                }
                else
                {
                    Console.WriteLine("Please enter a valid option:");

                }

                
                return gesture;
            }
            while (gesture != gestures[0] || gesture != gestures[1] || gesture != gestures[2] || gesture != gestures[3] || gesture != gestures[4]);
            


            
        }
    }
}
