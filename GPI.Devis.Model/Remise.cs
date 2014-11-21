using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public class Remise:Poste
    {
        protected internal Remise()
            : base()
        {
            this.EstSai = true;
            this.CoefSai = 0;
            this.CoefCalc = 0;
            this.PRUCalc = 0;
            this.PRUSai = 0;
            this.CACalc = 0;
            this.CASai = 0;
            this.PVUCalc = 0;
            this.PVUSai = -100000;
        }

        protected internal override void InitPoste()
        {
            
        }
        public override bool EstSai
        {
            get
            {
                return true;
            }
        }
        public override decimal CACalc
        {
            get
            {
                return PVUSai;
            }
        }
        public override decimal CARet
        {
            get
            {
                return PVUSai;
            }
        }
        public override decimal CASai
        {
            get
            {
                return PVUSai;
            }
        }
        public override decimal PRUCalc
        {
            get
            {
                return 0;
            }
        }
        public override decimal PRURet
        {
            get
            {
                return 0;
            }
        }
        public override decimal PRUSai
        {
            get
            {
                return 0;
            }
        }
        public override decimal PVUCalc
        {
            get
            {
                return PVUSai;
            }
        }
        public override decimal PVURet
        {
            get
            {
                return PVUSai;
            }
        }
        public override decimal PVUSai
        {
            get
            {
                return base.PVUSai;
            }
            set
            {
                PVUSai = value;
            }
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
        public override int Qte
        {
            get
            {
                return 1;
            }
        }
        public override string Code
        {
            get
            {
                return "";
            }
        }
    }
}
