using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devis.Model
{
    public class EnteteDevis
    {
        public EnteteDevis(List<Noeud> noeuds)
        {
            this.Noeuds = noeuds;
        }
        public int ID { get; set; }
        public string Description { get; set; }

        public decimal DefaultPRUH1 { get; set; }
        public decimal DefaultPRUH2 { get; set; }
        public decimal DefaultPRUH3 { get; set; }
        public decimal DefaultPVUH1 { get; set; }
        public decimal DefaultPVUH2 { get; set; }
        public decimal DefaultPVUH3 { get; set; }

        public decimal DefaultCoefAchat { get; set; }
        public decimal DefaultCoefMontant { get; set; }

        public decimal VAO{ get; set; }
        public bool UtiliseVAO { get; set; }

        public virtual List<Noeud> Noeuds { get; set; }
        public void AddNoeud(List<IPoste> postes)
        {
            Noeuds.Add(new Noeud(this, postes));
        }

        public decimal GetPRUH1()
        {
            return UtiliseVAO ? VAO : DefaultPRUH1;
        }
        public decimal GetPRUH2()
        {
            return UtiliseVAO ? VAO : DefaultPRUH2;
        }
        public decimal GetPRUH3()
        {
            return UtiliseVAO ? VAO : DefaultPRUH3;
        }
        public decimal GetPVUH1()
        {
            return UtiliseVAO ? VAO : DefaultPVUH1;
        }                                     
        public decimal GetPVUH2()             
        {                                     
            return UtiliseVAO ? VAO : DefaultPVUH2;
        }                                     
        public decimal GetPVUH3()             
        {                                     
            return UtiliseVAO ? VAO : DefaultPVUH3;
        }
        public decimal GetCoefMontant()
        {
            return UtiliseVAO ? VAO : DefaultCoefMontant;
        }
        public decimal GetCoefAchat()
        {
            return UtiliseVAO ? VAO : DefaultCoefAchat;
        }
    }
}
