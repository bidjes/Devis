using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devis.Model
{
    public interface ILignePoste
    {
        public Poste Poste{ get; set; }
        public Heure Heure{ get; set; }
    }
}
