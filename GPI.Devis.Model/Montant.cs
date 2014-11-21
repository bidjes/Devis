using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public class Montant : PosteNom
    {
        protected internal Montant(string soustype)
            : base()
        {
            this.SousTypePoste = soustype;
        }
        protected internal override void InitPoste()
        {
            this.EstSai = true;
            this.CoefCalc = Noeud.GetCoefMontant();
            this.CoefSai = Noeud.GetCoefMontant();
        }
        public override bool EstSai
        {
            get
            {
                return true;
            }
        }
        public override string Code
        {
            get
            {
                return "";
            }
        }
        public override decimal CACalc
        {
            get
            {
                return CASai;
            }
        }
        public override decimal CARet
        {
            get
            {
                return CASai;
            }
        }
        public override decimal CoefRet
        {
            get
            {
                return CoefSai;
            }
        }
        public override decimal PRUCalc
        {
            get
            {
                return PRUSai;
            }
        }
        public override decimal PRURet
        {
            get
            {
                return PRUSai;
            }
        }
        public override decimal PVUCalc
        {
            get
            {
                return PRUSai * CoefCalc;
            }
        }
        public override decimal PVURet
        {
            get
            {
                return PVUSai;
            }
        }
    }
}
