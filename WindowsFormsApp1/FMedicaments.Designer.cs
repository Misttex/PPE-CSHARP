namespace WindowsFormsApp1
{
    partial class FMedicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMedicaments));
            this.lVMedicament = new System.Windows.Forms.ListView();
            this.columnDepotLegal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNomCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEffets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContreIndic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixEchantillon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNRetour = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVMedicament
            // 
            this.lVMedicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDepotLegal,
            this.columnNomCommercial,
            this.columnComposition,
            this.columnEffets,
            this.columnContreIndic,
            this.columnPrixEchantillon});
            this.lVMedicament.HideSelection = false;
            this.lVMedicament.Location = new System.Drawing.Point(7, 36);
            this.lVMedicament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lVMedicament.Name = "lVMedicament";
            this.lVMedicament.Size = new System.Drawing.Size(1051, 510);
            this.lVMedicament.TabIndex = 0;
            this.lVMedicament.UseCompatibleStateImageBehavior = false;
            this.lVMedicament.View = System.Windows.Forms.View.Details;
            // 
            // columnDepotLegal
            // 
            this.columnDepotLegal.Text = "Dépôt légal";
            this.columnDepotLegal.Width = 101;
            // 
            // columnNomCommercial
            // 
            this.columnNomCommercial.Text = "Nom Commercial";
            this.columnNomCommercial.Width = 120;
            // 
            // columnComposition
            // 
            this.columnComposition.Text = "Composition";
            this.columnComposition.Width = 261;
            // 
            // columnEffets
            // 
            this.columnEffets.Text = "Effets";
            this.columnEffets.Width = 213;
            // 
            // columnContreIndic
            // 
            this.columnContreIndic.Text = "Contre indication";
            this.columnContreIndic.Width = 213;
            // 
            // columnPrixEchantillon
            // 
            this.columnPrixEchantillon.Text = "Prix par échantillon";
            this.columnPrixEchantillon.Width = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des médicaments :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lVMedicament);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 564);
            this.panel1.TabIndex = 2;
            // 
            // BTNRetour
            // 
            this.BTNRetour.Location = new System.Drawing.Point(986, 587);
            this.BTNRetour.Name = "BTNRetour";
            this.BTNRetour.Size = new System.Drawing.Size(108, 23);
            this.BTNRetour.TabIndex = 3;
            this.BTNRetour.Text = "Retour";
            this.BTNRetour.UseVisualStyleBackColor = true;
            this.BTNRetour.Click += new System.EventHandler(this.BTNRetour_Click);
            // 
            // FMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1112, 618);
            this.Controls.Add(this.BTNRetour);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMedicaments";
            this.Text = "MEDICAMENTS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMedicaments_FormClosed);
            this.Load += new System.EventHandler(this.FMedicaments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnDepotLegal;
        private System.Windows.Forms.ColumnHeader columnNomCommercial;
        private System.Windows.Forms.ColumnHeader columnComposition;
        private System.Windows.Forms.ColumnHeader columnEffets;
        private System.Windows.Forms.ColumnHeader columnContreIndic;
        private System.Windows.Forms.ColumnHeader columnPrixEchantillon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNRetour;
    }
}