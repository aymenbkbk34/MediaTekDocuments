using System;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;

namespace MediaTekDocuments.view
{
    public partial class FrmAuthentification : Form
    {
        private readonly FrmMediatekController controller;

        public FrmAuthentification()
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text.Trim();
            string mdp = txbMdp.Text.Trim();
            if (login.Equals("") || mdp.Equals(""))
            {
                MessageBox.Show("Veuillez saisir un login et un mot de passe.");
                return;
            }
            Utilisateur utilisateur = controller.GetUtilisateur(login, mdp);
            if (utilisateur == null)
            {
                MessageBox.Show("Login ou mot de passe incorrect.");
                return;
            }
            if (utilisateur.LibelleService.Equals("Culture"))
            {
                MessageBox.Show("Vos droits ne sont pas suffisants pour accéder à cette application.");
                Environment.Exit(0);
                return;
            }
            FrmMediatek frmMediatek = new FrmMediatek(utilisateur);
            this.Hide();
            frmMediatek.ShowDialog();
            this.Close();
        }
    }
}