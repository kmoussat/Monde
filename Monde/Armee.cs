using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monde
{
    class Armee
    {
        private string blason;
        private string transport;
        private List<Soldat> listesoldat;
        private List<Gobelin> listegobelin;
        private List<Troll> listetroll;




        //constructeur
        public Armee(string blason, string transport)
            {
            this.blason = blason;
            this.transport = transport;
            this.listesoldat = new List<Soldat>();
            this.listegobelin = new List<Gobelin>();
            this.listetroll = new List<Troll>();
            }

        public void CompteSoldat()
        {
            listesoldat.Count();
        }

        //mais c'st quoi la partie de ton code qui trie? Sort();
        //Ok et le code qu'il y a en dessous c'est quoi alors? C'est le listage des soldats, la méthode demandée
        //mais alors pk dans le texte il est dit " afficher les carac de chacun
        //Ok et ca affiche pas encore les caractèristiques si? si, mais c'est à définir dans le main, mais on s'en fout du main
        public void ListeSoldat()
        {
            listesoldat.Sort(); //j'ai rajouté le triage comme ça on va du plus vieux au plus récent pas obligatoire ceci-dit
            for (int i = 0; i < listesoldat.Count(); ++i )
            {
                Console.WriteLine(listesoldat[i]);
                //Mdr tkt pas grave déjà ce que tu fais c'est bcp donc tkt
                //je dois t'avouer que là, tu me poses une colle, j'ai oublié là
            }
            Console.ReadLine();
        }


    public string Blason
        {
            get { return blason;  }
        }

    public string Transport
        {
            get { return transport;  }
        }

        //je sélectionne puis Ctrl+E suivit de Ctrl+R 


        //je reviendrai plus tard pour faire le compte et le listage
    }//2secok je reviens repidement tkt
    // okay beauté :-*
    
}
