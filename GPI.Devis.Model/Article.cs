using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devis.Model
{
    public class Article : PosteNom
    {
        protected internal Article()
            : base() 
        {
            EstSai = false;
        }

        protected internal override void InitPoste()
        {
            this.PRUCalc = Noeud.GetCoefAchat();
            this.EstSai = false;
        }
    }
}