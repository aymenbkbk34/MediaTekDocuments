namespace MediaTekDocuments.view
{
    partial class FrmAuthentification
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.label1.Text = "Login :";
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.AutoSize = true;
            this.label2.Text = "Mot de passe :";
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.AutoSize = true;
            this.txbLogin.Location = new System.Drawing.Point(130, 27);
            this.txbLogin.Size = new System.Drawing.Size(200, 20);
            this.txbLogin.Name = "txbLogin";
            this.txbMdp.Location = new System.Drawing.Point(130, 67);
            this.txbMdp.Size = new System.Drawing.Size(200, 20);
            this.txbMdp.Name = "txbMdp";
            this.txbMdp.PasswordChar = '*';
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.Location = new System.Drawing.Point(130, 110);
            this.btnConnexion.Size = new System.Drawing.Size(120, 30);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            this.ClientSize = new System.Drawing.Size(380, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbMdp);
            this.Controls.Add(this.btnConnexion);
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}