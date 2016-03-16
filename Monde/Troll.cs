using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monde
{
    class Troll : Soldat
    {
        private int mouche;
        private string pouvoir;

        //constructeur : même chose que pour gobelin
        public Troll(int pays, string arme, int mouche, string pouvoir) : base (pays, arme)
        {
            this.mouche = mouche;
            this.pouvoir = pouvoir;
        }
        //Et le éventuellement c'je'sta lllaà?Is y venir

        public Troll(int pays, string arme, int mouche) 
            : this (pays, arme, mouche, "") //on met une valeur par défaut pour faire le éventuellement, dans ce cas 
                      
        {
            
        }

        public int Mouche
        {
            get
            {
                return mouche;
            }

            set
            {
                mouche = value;
            }
        }

        public string Pouvoir
        {
            get
            {
                return pouvoir;
            }        
        }

        void Nettoyage(int Mouche) //ici
        {
            Mouche = 0;
        }
    }
}
