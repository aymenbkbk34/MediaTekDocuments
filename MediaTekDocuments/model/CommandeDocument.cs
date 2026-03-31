using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe qui modélise une commande de document (livre ou DVD)
    /// </summary>
    public class CommandeDocument
    {
        private readonly string id;
        private readonly DateTime dateCommande;
        private readonly double montant;
        private readonly int nbExemplaire;
        private readonly string idLivreDvd;
        private string idSuivi;
        private string libelleSuivi;

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        public CommandeDocument(string id, DateTime dateCommande, double montant,
            int nbExemplaire, string idLivreDvd, string idSuivi, string libelleSuivi)
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.montant = montant;
            this.nbExemplaire = nbExemplaire;
            this.idLivreDvd = idLivreDvd;
            this.idSuivi = idSuivi;
            this.libelleSuivi = libelleSuivi;
        }

        /// <summary>Getter id</summary>
        public string Id { get => id; }

        /// <summary>Getter dateCommande</summary>
        public DateTime DateCommande { get => dateCommande; }

        /// <summary>Getter montant</summary>
        public double Montant { get => montant; }

        /// <summary>Getter nbExemplaire</summary>
        public int NbExemplaire { get => nbExemplaire; }

        /// <summary>Getter idLivreDvd</summary>
        public string IdLivreDvd { get => idLivreDvd; }

        /// <summary>Getter/Setter idSuivi</summary>
        public string IdSuivi { get => idSuivi; set => idSuivi = value; }

        /// <summary>Getter/Setter libelleSuivi</summary>
        public string LibelleSuivi { get => libelleSuivi; set => libelleSuivi = value; }
    }
}