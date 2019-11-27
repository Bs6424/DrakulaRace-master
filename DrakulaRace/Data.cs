using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakulaRace
{
    abstract class Data
    {
        public static Vampire[] vampire = new Vampire[4];
        public static BetPlacer[] bettor = new BetPlacer[3];
        public static Random rand = new Random();
        public static int currentGambler { get; set; }
    }
}
