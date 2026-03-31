namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe qui modélise un utilisateur
    /// </summary>
    public class Utilisateur
    {
        private readonly string id;
        private readonly string nom;
        private readonly string prenom;
        private readonly string login;
        private readonly string mdp;
        private readonly string idService;
        private readonly string libelleService;

        public Utilisateur(string id, string nom, string prenom, string login, string mdp, string idService, string libelleService)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.mdp = mdp;
            this.idService = idService;
            this.libelleService = libelleService;
        }

        public string Id { get => id; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Login { get => login; }
        public string Mdp { get => mdp; }
        public string IdService { get => idService; }
        public string LibelleService { get => libelleService; }
    }
}