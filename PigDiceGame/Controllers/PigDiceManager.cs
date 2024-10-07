using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame.Controllers
{
    internal class PigDiceManager
    {
        Random random = new Random();
        public int DiceRoll()
        {
            return random.Next(1, 7);//Use random function to get the number between 1 to 6 randomly 
        }

        
    }
}
