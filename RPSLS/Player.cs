using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Variables
        public string Name;
        public int Score;
        public string gesture;

        public List<string> gestures;


        //Constructor

        public Player()
        {
            gestures = new List<string> { "rock", "paper", "scisors", "lizared", "spock" };
        }


        //Method
        public abstract string chooseGesture();

    }
    
    

}
