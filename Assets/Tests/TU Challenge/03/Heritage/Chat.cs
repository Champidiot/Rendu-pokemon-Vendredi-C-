using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {

        public bool hasEatFish = false;
        public Chat(string name) : base(name)
        {
            Pattes = 4;
        }

        public override String Crier()
        {
            if (hasEatFish)
            {
                return "Miaou (Le poisson etait bon)";
            }
            else if (feedTime == 0)
            {
                return "Miaou (j'ai faim)";
            }

            else
            {
                return "Miaou (c'est bon laisse moi tranquille humain)";
            }

        }
    }
}
