using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devis.Model
{
    public interface INoeud
    {
        List<IPoste> Postes { get; set; }

        decimal GetPRUH1();
        decimal GetPRUH2();
        decimal GetPRUH3();
        decimal GetPVUH1();
        decimal GetPVUH2();
        decimal GetPVUH3();
        decimal GetCoefAchat();
        decimal GetCoefMontant();
    }
}