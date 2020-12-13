namespace WindowsFormsApp1
{
    partial class FPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPraticien));
            this.lVPraticien = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoefnotoriete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNRetour = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVPraticien
            // 
            this.lVPraticien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnNom,
            this.columnPrenom,
            this.columnAdresse,
            this.columnCp,
            this.columnVille,
            this.columnCoefnotoriete});
            this.lVPraticien.HideSelection = false;
            this.lVPraticien.Location = new System.Drawing.Point(3, 48);
            this.lVPraticien.Name = "lVPraticien";
            this.lVPraticien.Size = new System.Drawing.Size(770, 375);
            this.lVPraticien.TabIndex = 0;
            this.lVPraticien.UseCompatibleStateImageBehavior = false;
            this.lVPraticien.View = System.Windows.Forms.View.Details;
            // 
            // columnNum
            // 
            this.columnNum.Text = "Numéro";
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            this.columnNom.Width = 89;
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prénom";
            this.columnPrenom.Width = 98;
            // 
            // columnAdresse
            // 
            this.columnAdresse.Text = "Adresse";
            this.columnAdresse.Width = 125;
            // 
            // columnCp
            // 
            this.columnCp.Text = "Code postal";
            this.columnCp.Width = 113;
            // 
            // columnVille
            // 
            this.columnVille.Text = "Ville";
            this.columnVille.Width = 94;
            // 
            // columnCoefnotoriete
            // 
            this.columnCoefnotoriete.Text = "Coeff. notoriété";
            this.columnCoefnotoriete.Width = 123;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lVPraticien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des praticiens :";
            // 
            // BTNRetour
            // 
            this.BTNRetour.Location = new System.Drawing.Point(651, 443);
            this.BTNRetour.Name = "BTNRetour";
            this.BTNRetour.Size = new System.Drawing.Size(133, 23);
            this.BTNRetour.TabIndex = 2;
            this.BTNRetour.Text = "Retour";
            this.BTNRetour.UseVisualStyleBackColor = true;
            this.BTNRetour.Click += new System.EventHandler(this.BTNRetour_Click);
            // 
            // FPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.BTNRetour);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPraticien";
            this.Text = "PRATICIENS";
            this.Load += new System.EventHandler(this.FPraticien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVPraticien;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader columnAdresse;
        private System.Windows.Forms.ColumnHeader columnCp;
        private System.Windows.Forms.ColumnHeader columnVille;
        private System.Windows.Forms.ColumnHeader columnCoefnotoriete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNRetour;
    }
}