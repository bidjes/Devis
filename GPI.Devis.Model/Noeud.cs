using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public class Noeud:INoeud
    {
        public Noeud(EnteteDevis entete,List<IPoste> postes)
        {
            this.EnteteDevis = entete;
            this.Postes = postes;
        }
        public int ID { get; set; }
        public string Description { get; set; }

        public virtual EnteteDevis EnteteDevis { get; set; }


        public void AddPoste(string typePoste,string sousTypePoste)
        {
            this.Postes.Add(FactoryPoste.MakePoste(this, typePoste, sousTypePoste));
        }

        public virtual List<IPoste> Postes { get; set; }

        public decimal GetPRUH1()
        {
            return EnteteDevis.DefaultPRUH1;
        }
        public decimal GetPRUH2()
        {
            return EnteteDevis.DefaultPRUH2;
        }
        public decimal GetPRUH3()
        {
            return EnteteDevis.DefaultPRUH3;
        }
        public decimal GetPVUH1()
        {
            return EnteteDevis.DefaultPVUH1;
        }
        public decimal GetPVUH2()
        {
            return EnteteDevis.DefaultPVUH2;
        }
        public decimal GetPVUH3()
        {
            return EnteteDevis.DefaultPVUH3;
        }
        public decimal GetCoefAchat()
        {
            return EnteteDevis.DefaultCoefAchat;
        }
        public decimal GetCoefMontant()
        {
            return EnteteDevis.DefaultCoefMontant;
        }
    }
}
