using Devis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public class Nomenclature:Poste,INoeud
    {

        protected internal Nomenclature(List<IPoste> postes)
            : base()
        {
            this.Postes = postes;
        }

        protected internal override void InitPoste()
        {
            
        }


        public virtual List<IPoste> Postes { get; set; }

        public decimal GetPRUH1()
        {
            return Noeud.GetPRUH1();
        }

        public decimal GetPRUH2()
        {
            return Noeud.GetPRUH2();
        }

        public decimal GetPRUH3()
        {
            return Noeud.GetPRUH3();
        }

        public decimal GetPVUH1()
        {
            return Noeud.GetPVUH1();
        }

        public decimal GetPVUH2()
        {
            return Noeud.GetPVUH2();
        }

        public decimal GetPVUH3()
        {
            return Noeud.GetPVUH3();
        }

        public decimal GetCoefAchat()
        {
            return Noeud.GetCoefAchat();
        }

        public decimal GetCoefMontant()
        {
            return Noeud.GetCoefMontant();
        }
    }
}
