using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monde
{
    class Soldat
    {
        private int pays;
        private string arme;
       
        //ok juste 3 seconde je vais cerhche un truc sur le feu --' c'est sur cuit la =Pok
        //ah non c'est bon dsl

            //constructeur
            public Soldat(int pays, string arme)
        {
            this.pays = pays;
            this.arme = arme; //pointeurs
        }

     
        public int Pays
        {
            get
            {
                return pays;
            }

            set
            {
                pays = value;
            }
        }

        public string Arme
        {
            get
            {
                return arme;
            }

        }
    }
}
