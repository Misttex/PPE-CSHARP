namespace WindowsFormsApp1
{
    partial class FRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRapport));
            this.LABRapport = new System.Windows.Forms.Label();
            this.LABNumRapport = new System.Windows.Forms.Label();
            this.LABPrati = new System.Windows.Forms.Label();
            this.LABDate = new System.Windows.Forms.Label();
            this.LABMotif = new System.Windows.Forms.Label();
            this.LABBilan = new System.Windows.Forms.Label();
            this.TBXNumRapport = new System.Windows.Forms.TextBox();
            this.CBXPraticien = new System.Windows.Forms.ComboBox();
            this.BTNDetails = new System.Windows.Forms.Button();
            this.TBXDateRapport = new System.Windows.Forms.TextBox();
            this.TBXMotif = new System.Windows.Forms.TextBox();
            this.TBXBilan = new System.Windows.Forms.TextBox();
            this.BTNPrecedent = new System.Windows.Forms.Button();
            this.BTNSuivant = new System.Windows.Forms.Button();
            this.BTNNouveau = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMedciament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColonneNbEchant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABOffres = new System.Windows.Forms.Label();
            this.BTNFermer = new System.Windows.Forms.Button();
            this.BTNEnregistrer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LABRapport
            // 
            this.LABRapport.AutoSize = true;
            this.LABRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABRapport.Location = new System.Drawing.Point(302, 5);
            this.LABRapport.Name = "LABRapport";
            this.LABRapport.Size = new System.Drawing.Size(225, 25);
            this.LABRapport.TabIndex = 0;
            this.LABRapport.Text = "RAPPORT DE VISITE";
            this.LABRapport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABNumRapport
            // 
            this.LABNumRapport.AutoSize = true;
            this.LABNumRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABNumRapport.Location = new System.Drawing.Point(5, 13);
            this.LABNumRapport.Name = "LABNumRapport";
            this.LABNumRapport.Size = new System.Drawing.Size(133, 18);
            this.LABNumRapport.TabIndex = 1;
            this.LABNumRapport.Text = "Numéro Rapport";
            // 
            // LABPrati
            // 
            this.LABPrati.AutoSize = true;
            this.LABPrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LABPrati.Location = new System.Drawing.Point(12, 52);
            this.LABPrati.Name = "LABPrati";
            this.LABPrati.Size = new System.Drawing.Size(74, 18);
            this.LABPrati.TabIndex = 1;
            this.LABPrati.Text = "Praticien";
            // 
            // LABDate
            // 
            this.LABDate.AutoSize = true;
            this.LABDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LABDate.Location = new System.Drawing.Point(12, 103);
            this.LABDate.Name = "LABDate";
            this.LABDate.Size = new System.Drawing.Size(108, 18);
            this.LABDate.TabIndex = 1;
            this.LABDate.Text = "Date Rapport";
            // 
            // LABMotif
            // 
            this.LABMotif.AutoSize = true;
            this.LABMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LABMotif.Location = new System.Drawing.Point(12, 155);
            this.LABMotif.Name = "LABMotif";
            this.LABMotif.Size = new System.Drawing.Size(92, 18);
            this.LABMotif.TabIndex = 1;
            this.LABMotif.Text = "Motif Visite";
            // 
            // LABBilan
            // 
            this.LABBilan.AutoSize = true;
            this.LABBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LABBilan.Location = new System.Drawing.Point(13, 187);
            this.LABBilan.Name = "LABBilan";
            this.LABBilan.Size = new System.Drawing.Size(54, 18);
            this.LABBilan.TabIndex = 1;
            this.LABBilan.Text = "BILAN";
            // 
            // TBXNumRapport
            // 
            this.TBXNumRapport.Enabled = false;
            this.TBXNumRapport.Location = new System.Drawing.Point(157, 13);
            this.TBXNumRapport.Name = "TBXNumRapport";
            this.TBXNumRapport.Size = new System.Drawing.Size(94, 22);
            this.TBXNumRapport.TabIndex = 2;
            // 
            // CBXPraticien
            // 
            this.CBXPraticien.FormattingEnabled = true;
            this.CBXPraticien.Location = new System.Drawing.Point(157, 51);
            this.CBXPraticien.Name = "CBXPraticien";
            this.CBXPraticien.Size = new System.Drawing.Size(241, 24);
            this.CBXPraticien.TabIndex = 3;
            this.CBXPraticien.TextChanged += new System.EventHandler(this.CBXPraticien_TextChanged);
            // 
            // BTNDetails
            // 
            this.BTNDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNDetails.Location = new System.Drawing.Point(404, 43);
            this.BTNDetails.Name = "BTNDetails";
            this.BTNDetails.Size = new System.Drawing.Size(84, 37);
            this.BTNDetails.TabIndex = 4;
            this.BTNDetails.Text = "Détails";
            this.BTNDetails.UseVisualStyleBackColor = true;
            this.BTNDetails.Click += new System.EventHandler(this.BTNDetails_Click);
            // 
            // TBXDateRapport
            // 
            this.TBXDateRapport.Location = new System.Drawing.Point(157, 99);
            this.TBXDateRapport.Name = "TBXDateRapport";
            this.TBXDateRapport.Size = new System.Drawing.Size(165, 22);
            this.TBXDateRapport.TabIndex = 5;
            // 
            // TBXMotif
            // 
            this.TBXMotif.Location = new System.Drawing.Point(157, 151);
            this.TBXMotif.Name = "TBXMotif";
            this.TBXMotif.Size = new System.Drawing.Size(165, 22);
            this.TBXMotif.TabIndex = 6;
            // 
            // TBXBilan
            // 
            this.TBXBilan.Location = new System.Drawing.Point(157, 186);
            this.TBXBilan.Multiline = true;
            this.TBXBilan.Name = "TBXBilan";
            this.TBXBilan.Size = new System.Drawing.Size(179, 118);
            this.TBXBilan.TabIndex = 7;
            // 
            // BTNPrecedent
            // 
            this.BTNPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNPrecedent.Location = new System.Drawing.Point(16, 329);
            this.BTNPrecedent.Name = "BTNPrecedent";
            this.BTNPrecedent.Size = new System.Drawing.Size(135, 27);
            this.BTNPrecedent.TabIndex = 8;
            this.BTNPrecedent.Text = "Précédent";
            this.BTNPrecedent.UseVisualStyleBackColor = true;
            this.BTNPrecedent.Click += new System.EventHandler(this.BTNPrecedent_Click);
            // 
            // BTNSuivant
            // 
            this.BTNSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNSuivant.Location = new System.Drawing.Point(170, 327);
            this.BTNSuivant.Name = "BTNSuivant";
            this.BTNSuivant.Size = new System.Drawing.Size(135, 27);
            this.BTNSuivant.TabIndex = 8;
            this.BTNSuivant.Text = "Suivant";
            this.BTNSuivant.UseVisualStyleBackColor = true;
            this.BTNSuivant.Click += new System.EventHandler(this.BTNSuivant_Click);
            // 
            // BTNNouveau
            // 
            this.BTNNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNNouveau.Location = new System.Drawing.Point(323, 328);
            this.BTNNouveau.Name = "BTNNouveau";
            this.BTNNouveau.Size = new System.Drawing.Size(149, 26);
            this.BTNNouveau.TabIndex = 8;
            this.BTNNouveau.Text = "Nouveau";
            this.BTNNouveau.UseVisualStyleBackColor = true;
            this.BTNNouveau.Click += new System.EventHandler(this.BTNNouveau_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMedciament,
            this.ColonneNbEchant});
            this.dataGridView1.Location = new System.Drawing.Point(13, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 134);
            this.dataGridView1.TabIndex = 9;
            // 
            // ColMedciament
            // 
            this.ColMedciament.HeaderText = "Médicament";
            this.ColMedciament.MinimumWidth = 6;
            this.ColMedciament.Name = "ColMedciament";
            this.ColMedciament.Width = 125;
            // 
            // ColonneNbEchant
            // 
            this.ColonneNbEchant.HeaderText = "Nb. Échantillon";
            this.ColonneNbEchant.MinimumWidth = 6;
            this.ColonneNbEchant.Name = "ColonneNbEchant";
            this.ColonneNbEchant.Width = 125;
            // 
            // LABOffres
            // 
            this.LABOffres.AutoSize = true;
            this.LABOffres.Location = new System.Drawing.Point(-51, -57);
            this.LABOffres.Name = "LABOffres";
            this.LABOffres.Size = new System.Drawing.Size(137, 17);
            this.LABOffres.TabIndex = 12;
            this.LABOffres.Text = "Offres d\'échantillons";
            // 
            // BTNFermer
            // 
            this.BTNFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNFermer.Location = new System.Drawing.Point(132, 228);
            this.BTNFermer.Name = "BTNFermer";
            this.BTNFermer.Size = new System.Drawing.Size(97, 31);
            this.BTNFermer.TabIndex = 13;
            this.BTNFermer.Text = "Retour";
            this.BTNFermer.UseVisualStyleBackColor = true;
            this.BTNFermer.Click += new System.EventHandler(this.BTNFermer_Click);
            // 
            // BTNEnregistrer
            // 
            this.BTNEnregistrer.Enabled = false;
            this.BTNEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNEnregistrer.Location = new System.Drawing.Point(142, 361);
            this.BTNEnregistrer.Name = "BTNEnregistrer";
            this.BTNEnregistrer.Size = new System.Drawing.Size(180, 40);
            this.BTNEnregistrer.TabIndex = 14;
            this.BTNEnregistrer.Text = "Enregistrer";
            this.BTNEnregistrer.UseVisualStyleBackColor = true;
            this.BTNEnregistrer.Visible = false;
            this.BTNEnregistrer.Click += new System.EventHandler(this.BTNEnregistrer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LABNumRapport);
            this.panel1.Controls.Add(this.BTNEnregistrer);
            this.panel1.Controls.Add(this.LABPrati);
            this.panel1.Controls.Add(this.LABDate);
            this.panel1.Controls.Add(this.LABMotif);
            this.panel1.Controls.Add(this.LABBilan);
            this.panel1.Controls.Add(this.BTNNouveau);
            this.panel1.Controls.Add(this.TBXNumRapport);
            this.panel1.Controls.Add(this.BTNSuivant);
            this.panel1.Controls.Add(this.CBXPraticien);
            this.panel1.Controls.Add(this.BTNPrecedent);
            this.panel1.Controls.Add(this.BTNDetails);
            this.panel1.Controls.Add(this.TBXBilan);
            this.panel1.Controls.Add(this.TBXDateRapport);
            this.panel1.Controls.Add(this.TBXMotif);
            this.panel1.Location = new System.Drawing.Point(17, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 406);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.LABOffres);
            this.panel2.Controls.Add(this.BTNFermer);
            this.panel2.Location = new System.Drawing.Point(524, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 303);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.LABRapport);
            this.panel3.Location = new System.Drawing.Point(3, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 447);
            this.panel3.TabIndex = 17;
            // 
            // FRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(866, 463);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRapport";
            this.Text = "RAPPORT";
            this.Load += new System.EventHandler(this.FRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LABRapport;
        private System.Windows.Forms.Label LABNumRapport;
        private System.Windows.Forms.Label LABPrati;
        private System.Windows.Forms.Label LABDate;
        private System.Windows.Forms.Label LABMotif;
        private System.Windows.Forms.Label LABBilan;
        private System.Windows.Forms.TextBox TBXNumRapport;
        private System.Windows.Forms.ComboBox CBXPraticien;
        private System.Windows.Forms.Button BTNDetails;
        private System.Windows.Forms.TextBox TBXDateRapport;
        private System.Windows.Forms.TextBox TBXMotif;
        private System.Windows.Forms.TextBox TBXBilan;
        private System.Windows.Forms.Button BTNPrecedent;
        private System.Windows.Forms.Button BTNSuivant;
        private System.Windows.Forms.Button BTNNouveau;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedciament;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColonneNbEchant;
        private System.Windows.Forms.Label LABOffres;
        private System.Windows.Forms.Button BTNFermer;
        private System.Windows.Forms.Button BTNEnregistrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}