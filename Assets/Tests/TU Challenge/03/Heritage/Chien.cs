using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEditor.VersionControl.Asset;

namespace TU_Challenge.Heritage
{
    public class Chien : Animal
    {
        public Chien(string name) : base(name)
        {
            Pattes = 4;
        }

        public override String Crier()
        {
            if(feedTime == 0)
            {
            return "Ouaf (j'ai faim)";
            }
            else
            {
                return "Ouaf (viens on joue ?)";
            }

        }
    }
}
