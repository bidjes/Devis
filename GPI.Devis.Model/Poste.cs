using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public abstract class Poste : IPoste
    {
        protected internal Poste()
        {
            this.Qte = 1;
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public string TypePoste { get; set; }
        public string SousTypePoste { get; set; }
        public string TypeCodePoste
        {
            get
            {
                return TypePoste + SousTypePoste;
            }
        }
        public virtual string Code { get; set; }
        public virtual decimal PRUCalc { get; set; }
        public virtual decimal PRUSai { get; set; }
        public virtual decimal PRURet 
        { 
            get 
            { 
                return EstSai ? PRUSai : PRUCalc; 
            }
        }
        public virtual decimal PVUCalc { get; set; }
        public virtual decimal PVUSai { get; set; }
        public virtual decimal PVURet { 
            get 
            { 
                return EstSai ? PVUSai : PVUCalc; 
            } 
        }
        public virtual decimal CoefCalc { get; set; }
        public virtual decimal CoefSai { get; set; }
        public virtual decimal CoefRet { 
            get 
            { 
                return EstSai ? CoefSai : CoefCalc; 
            } 
        }
        public virtual decimal CACalc { get; set; }
        public virtual decimal CASai { get; set; }
        public virtual decimal CARet 
        { 
            get 
            { 
                return EstSai ? CASai : CACalc; 
            } 
        }
        public virtual int Qte { get; set; }

        public virtual bool EstSai { get; set; }

        protected internal abstract void InitPoste();

        public virtual string VerifPoste()
        {
            if (this.ID > 0)
            {
                return "Ok";
            }
            else
            {
                return "L'identifiant est invalide";
            }
        }

        public virtual INoeud Noeud { get; set; }
    }
}