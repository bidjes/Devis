using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devis.Model
{
    public static class FactoryPoste
    {
        public static Poste MakePoste(INoeud noeud, string type,string sousType)
        {
            Poste poste;
            switch (type)
            {
                case "A": 
                    switch(sousType)
                    {
                        case "": 
                            poste = new Article();
                            break;
                        default: throw new ArgumentOutOfRangeException("Ce sous-type de poste est inconnu, impossible de le créer.");
                    }
                    break;
                case "H":
                    switch(sousType)
                    {
                        case "1":
                        case "2":
                        case "3":
                            poste = new Heure();
                            break;
                        default: throw new ArgumentOutOfRangeException("Ce sous-type de poste est inconnu, impossible de le créer.");
                    }
                    break;
                case "N":
                    switch(sousType)
                    {
                        case "":
                            poste = new Nomenclature(new List<IPoste>());
                            break;
                        default: throw new ArgumentOutOfRangeException("Ce sous-type de poste est inconnu, impossible de le créer.");
                    }
                    break;
                case "M": 
                    switch (sousType)
                    {
                        case "A":
                        case "D":
                            poste = new Montant(sousType);
                            break;
                        case "R": 
                            poste = new Remise();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Ce type de poste est inconnu, impossible de le créer.");
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Ce type de poste est inconnu, impossible de le créer.");
            }
            poste.Noeud = noeud;
            poste.TypePoste = type;
            poste.SousTypePoste = sousType;
            poste.InitPoste();
            return poste;
        }
    }
}