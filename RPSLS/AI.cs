using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        //Variables
       


       
        public override string chooseGesture()
        {

            int randomGestureNumber = new Random().Next(0, 6);
            gesture = gestures[randomGestureNumber];

            return gesture;
        }


    }



}
