using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class Winner
    {
        public Cricket DeclareWinner(Cricket PlayerOne,Cricket PlayerTwo)
        {
            if (PlayerOne.PlayerScore > PlayerTwo.PlayerScore)
            {
                return PlayerOne;
            }
            else
            {
                return PlayerTwo;
            }
        }

        public bool GetOut()
        {
            return false;

        }
    }
}
