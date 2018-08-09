using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        
        public bool Playing { get; set; }
        public Cricket()
        {
            PlayerScore = 0;
            Playing = true;
        }

        public void Score(int runs)
        {
            if (Playing)
            {
                if ((runs <= 6) && runs >= 0)
                {
                    this.PlayerScore += runs;
                    
                }
            }
        }
    }
}
