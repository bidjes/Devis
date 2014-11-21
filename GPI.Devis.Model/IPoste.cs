using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public interface IPoste
    {
        int ID { get; set; }
        string Description { get; set; }
        string TypePoste { get; set; }
        string SousTypePoste { get; set; }
        string TypeCodePoste { get; }
        string Code { get; set; }

        decimal PRUCalc { get; set; }
        decimal PRUSai { get; set; }
        decimal PRURet { get;}
        decimal PVUCalc { get; set; }
        decimal PVUSai { get; set; }
        decimal PVURet { get; }
        decimal CoefCalc { get; set; }
        decimal CoefSai { get; set; }
        decimal CoefRet { get; }
        decimal CACalc { get; set; }
        decimal CASai { get; set; }
        decimal CARet { get; }
        int Qte { get; set; }

        bool EstSai { get; set; }

        INoeud Noeud { get; set; }
    }
}
