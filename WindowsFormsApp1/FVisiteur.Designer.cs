namespace WindowsFormsApp1
{
    partial class FVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVisiteur));
            this.lVVisiteur = new System.Windows.Forms.ListView();
            this.columnMatricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateembauche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVVisiteur
            // 
            this.lVVisiteur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMatricule,
            this.columnNom,
            this.columnPrenom,
            this.columnAdresse,
            this.columnCp,
            this.columnVille,
            this.columnDateembauche});
            this.lVVisiteur.HideSelection = false;
            this.lVVisiteur.Location = new System.Drawing.Point(3, 48);
            this.lVVisiteur.Name = "lVVisiteur";
            this.lVVisiteur.Size = new System.Drawing.Size(770, 364);
            this.lVVisiteur.TabIndex = 0;
            this.lVVisiteur.UseCompatibleStateImageBehavior = false;
            this.lVVisiteur.View = System.Windows.Forms.View.Details;
            // 
            // columnMatricule
            // 
            this.columnMatricule.Text = "Matricule";
            this.columnMatricule.Width = 82;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            this.columnNom.Width = 58;
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prenom";
            this.columnPrenom.Width = 92;
            // 
            // columnAdresse
            // 
            this.columnAdresse.Text = "Adresse";
            this.columnAdresse.Width = 180;
            // 
            // columnCp
            // 
            this.columnCp.Text = "Code postal";
            this.columnCp.Width = 99;
            // 
            // columnVille
            // 
            this.columnVille.Text = "Ville";
            this.columnVille.Width = 102;
            // 
            // columnDateembauche
            // 
            this.columnDateembauche.Text = "Date d\'embauche";
            this.columnDateembauche.Width = 159;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lVVisiteur);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 432);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des Visiteurs";
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Location = new System.Drawing.Point(658, 453);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(126, 23);
            this.BTNQuitter.TabIndex = 2;
            this.BTNQuitter.Text = "Retour";
            this.BTNQuitter.UseVisualStyleBackColor = true;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            // 
            // FVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(798, 488);
            this.Controls.Add(this.BTNQuitter);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FVisiteur";
            this.Text = "VISITEURS";
            this.Load += new System.EventHandler(this.FVisiteur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVVisiteur;
        private System.Windows.Forms.ColumnHeader columnMatricule;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader columnAdresse;
        private System.Windows.Forms.ColumnHeader columnCp;
        private System.Windows.Forms.ColumnHeader columnVille;
        private System.Windows.Forms.ColumnHeader columnDateembauche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNQuitter;
    }
}