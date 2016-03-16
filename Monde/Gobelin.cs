using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monde
{
    class Gobelin : Soldat
    {
        private string nom;
        private string ceinture; //on peut faire avec un booléen aussi
       
        //constructeur
        public Gobelin(int pays, string arme, string nom, string ceinture) : base (pays, arme)
        {
            this.nom = nom;
            this.ceinture = ceinture;
        }

        public string Nom
        {
            get
            {
                return nom;
            }

        }

        public string Ceinture
        {
            get
            {
                return ceinture;
            }

        }
        
    }
}
