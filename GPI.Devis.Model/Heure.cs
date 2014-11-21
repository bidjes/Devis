using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public class Heure : PosteNom
    {
        protected internal Heure()
            : base()
        {
            EstSai = false;
        }
        protected internal override void InitPoste()
        {
            switch (this.SousTypePoste)
            {
                case"1":
                    this.PRUCalc = this.Noeud.GetPRUH1();
                    this.PVUCalc = this.Noeud.GetPVUH1();
                    break;
                case "2":
                    this.PRUCalc = this.Noeud.GetPRUH2();
                    this.PVUCalc = this.Noeud.GetPVUH2();
                    break;
                case "3":
                    this.PRUCalc = this.Noeud.GetPRUH3();
                    this.PVUCalc = this.Noeud.GetPVUH3();
                    break;
                default:
                    throw new IndexOutOfRangeException("Ce type d'heure n'existe pas.");
            }
            this.EstSai = false;
        }
        public override decimal CoefCalc
        {
            get
            {
                return 0;
            }
        }
        public override decimal CoefRet
        {
            get
            {
                return 0;
            }
        }
        public override decimal CoefSai
        {
            get
            {
                return 0;
            }
        }
    }
}