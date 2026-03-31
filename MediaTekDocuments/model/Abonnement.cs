using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe qui modélise un abonnement à une revue
    /// </summary>
    public class Abonnement
    {
        private readonly string id;
        private readonly DateTime dateCommande;
        private readonly double montant;
        private readonly DateTime dateFinAbonnement;
        private readonly string idRevue;

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        public Abonnement(string id, DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue)
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.montant = montant;
            this.dateFinAbonnement = dateFinAbonnement;
            this.idRevue = idRevue;
        }

        /// <summary>Getter id</summary>
        public string Id { get => id; }

        /// <summary>Getter dateCommande</summary>
        public DateTime DateCommande { get => dateCommande; }

        /// <summary>Getter montant</summary>
        public double Montant { get => montant; }

        /// <summary>Getter dateFinAbonnement</summary>
        public DateTime DateFinAbonnement { get => dateFinAbonnement; }

        /// <summary>Getter idRevue</summary>
        public string IdRevue { get => idRevue; }
    }
}