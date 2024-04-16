using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Core.Model
{

    public class ObjetDePret
    {
        public string TitreDeLObjet { get; set; }
        public string Emprunteur { get; set; }
                
        public ObjetDePret(string titreDeLObjet)
        {
            this.TitreDeLObjet = titreDeLObjet;
        }

        public bool Emprunte(string emprunteur)
        {
            throw new NotImplementedException();
        }

    }
}
