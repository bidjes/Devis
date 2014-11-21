using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Devis.Model;

namespace Devis.Model.Test
{
    [TestClass]
    public class FactoryPosteTest
    {
        [TestMethod]
        public void MakePosteTest_ArticleOk()
        {
            EnteteDevis entete = new EnteteDevis(new List<Noeud>());
            entete.AddNoeud(new List<IPoste>());
            entete.Noeuds.First().AddPoste("A", "");
            Assert.IsInstanceOfType(entete.Noeuds.First().Postes.First(), typeof(Article));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MakePosteTest_ArticleNotOk()
        {
            EnteteDevis entete = new EnteteDevis(new List<Noeud>());
            entete.AddNoeud(new List<IPoste>());
            entete.Noeuds.First().AddPoste("A", "M");
            Assert.Fail();
        }
    }
}