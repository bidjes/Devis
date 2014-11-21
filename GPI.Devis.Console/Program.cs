using Devis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devis.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.ReadLine();
                EnteteDevis entete = new EnteteDevis(new List<Noeud>());
                entete.AddNoeud(new List<IPoste>());
                entete.Noeuds.First().AddPoste("A", "");
                entete.Noeuds.First().AddPoste("H", "1");
                System.Console.ReadLine();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.ReadLine();
            }
        }
    }
}
