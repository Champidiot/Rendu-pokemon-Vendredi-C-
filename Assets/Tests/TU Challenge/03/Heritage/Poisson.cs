using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEditor.VersionControl.Asset;

namespace TU_Challenge.Heritage
{
    public class Poisson : Animal
    {
        public Poisson(string name) : base(name)
        {
            if(name == "Nemo")
            {
                this.Name = "Nemo le poisson";
            }
            Pattes = 0;
        }

        public override String Crier()
        {
            return "";

        }
    }
}
