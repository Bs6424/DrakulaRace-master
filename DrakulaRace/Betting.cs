using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakulaRace
{
    class Betting : Vampire
    {
        public int BetAmount { get; set; }
        public BetPlacer gambler { get; set; }
        public int vampire { get; set; }
        public int rewardMultiplier = 4;

        public int CashOut(int winningChevilry)
        {
            if (winningChevilry == vampire)
                return BetAmount * rewardMultiplier;
            else
                return (0 - BetAmount);
        }
    }
}
