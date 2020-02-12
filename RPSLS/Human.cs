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
                
                return gesture;
            }
            while (gesture != gestures[0] || gesture != gestures[1] || gesture != gestures[2] || gesture != gestures[3] || gesture != gestures[4]);
            


            
        }
    }
}
