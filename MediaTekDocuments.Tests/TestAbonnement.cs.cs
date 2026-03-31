using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MediaTekDocuments.model;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class TestAbonnement
    {
        /// <summary>
        /// Teste si une date de parution est dans un abonnement
        /// </summary>
        private bool ParutionDansAbonnement(DateTime dateCommande, DateTime dateFinAbonnement, DateTime dateParution)
        {
            return dateParution >= dateCommande && dateParution <= dateFinAbonnement;
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateDedans_RetourneVrai()
        {
            DateTime dateCommande = new DateTime(2026, 1, 1);
            DateTime dateFin = new DateTime(2026, 12, 31);
            DateTime dateParution = new DateTime(2026, 6, 15);
            Assert.IsTrue(ParutionDansAbonnement(dateCommande, dateFin, dateParution));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateAvant_RetourneFaux()
        {
            DateTime dateCommande = new DateTime(2026, 1, 1);
            DateTime dateFin = new DateTime(2026, 12, 31);
            DateTime dateParution = new DateTime(2025, 12, 31);
            Assert.IsFalse(ParutionDansAbonnement(dateCommande, dateFin, dateParution));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateApres_RetourneFaux()
        {
            DateTime dateCommande = new DateTime(2026, 1, 1);
            DateTime dateFin = new DateTime(2026, 12, 31);
            DateTime dateParution = new DateTime(2027, 1, 1);
            Assert.IsFalse(ParutionDansAbonnement(dateCommande, dateFin, dateParution));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateEgaleDebut_RetourneVrai()
        {
            DateTime dateCommande = new DateTime(2026, 1, 1);
            DateTime dateFin = new DateTime(2026, 12, 31);
            DateTime dateParution = new DateTime(2026, 1, 1);
            Assert.IsTrue(ParutionDansAbonnement(dateCommande, dateFin, dateParution));
        }
    }
}