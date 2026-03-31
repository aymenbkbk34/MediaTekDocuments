namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe qui modélise une étape de suivi d'une commande
    /// </summary>
    public class Suivi
    {
        private readonly string id;
        private readonly string libelle;

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="id">identifiant du suivi</param>
        /// <param name="libelle">libellé du suivi</param>
        public Suivi(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        /// <summary>
        /// Getter id
        /// </summary>
        public string Id { get => id; }

        /// <summary>
        /// Getter libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Retourne le libellé pour affichage dans les listes
        /// </summary>
        public override string ToString()
        {
            return libelle;
        }
    }
}