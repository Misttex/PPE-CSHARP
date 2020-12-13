namespace WindowsFormsApp1
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.grBoxMenu = new System.Windows.Forms.GroupBox();
            this.BTNCompteRendus = new System.Windows.Forms.Button();
            this.BTNMedicaments = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.BTNPraticiens = new System.Windows.Forms.Button();
            this.BTNVisiteurs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageGSB = new System.Windows.Forms.PictureBox();
            this.grBoxMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGSB)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxMenu
            // 
            this.grBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.grBoxMenu.Controls.Add(this.BTNCompteRendus);
            this.grBoxMenu.Controls.Add(this.BTNMedicaments);
            this.grBoxMenu.Cursor = System.Windows.Forms.Cursors.No;
            this.grBoxMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBoxMenu.Location = new System.Drawing.Point(0, 58);
            this.grBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBoxMenu.Name = "grBoxMenu";
            this.grBoxMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBoxMenu.Size = new System.Drawing.Size(392, 392);
            this.grBoxMenu.TabIndex = 6;
            this.grBoxMenu.TabStop = false;
            // 
            // BTNCompteRendus
            // 
            this.BTNCompteRendus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNCompteRendus.BackColor = System.Drawing.Color.LightGray;
            this.BTNCompteRendus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNCompteRendus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNCompteRendus.Location = new System.Drawing.Point(101, 188);
            this.BTNCompteRendus.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCompteRendus.Name = "BTNCompteRendus";
            this.BTNCompteRendus.Size = new System.Drawing.Size(164, 44);
            this.BTNCompteRendus.TabIndex = 4;
            this.BTNCompteRendus.Text = "Comptes-Rendus";
            this.BTNCompteRendus.UseVisualStyleBackColor = false;
            this.BTNCompteRendus.Click += new System.EventHandler(this.BTNCompteRendus_Click);
            this.BTNCompteRendus.MouseEnter += new System.EventHandler(this.BTNCompteRendus_MouseEnter);
            this.BTNCompteRendus.MouseLeave += new System.EventHandler(this.BTNCompteRendus_MouseLeave);
            // 
            // BTNMedicaments
            // 
            this.BTNMedicaments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNMedicaments.BackColor = System.Drawing.Color.LightGray;
            this.BTNMedicaments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNMedicaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMedicaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNMedicaments.Location = new System.Drawing.Point(115, 108);
            this.BTNMedicaments.Margin = new System.Windows.Forms.Padding(4);
            this.BTNMedicaments.Name = "BTNMedicaments";
            this.BTNMedicaments.Size = new System.Drawing.Size(132, 44);
            this.BTNMedicaments.TabIndex = 1;
            this.BTNMedicaments.Text = "Médicaments";
            this.BTNMedicaments.UseVisualStyleBackColor = false;
            this.BTNMedicaments.Click += new System.EventHandler(this.BTNMedicaments_Click);
            this.BTNMedicaments.MouseEnter += new System.EventHandler(this.BTNMedicaments_MouseEnter);
            this.BTNMedicaments.MouseLeave += new System.EventHandler(this.BTNMedicaments_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 58);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 55);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNQuitter.BackColor = System.Drawing.Color.LightGray;
            this.BTNQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNQuitter.Location = new System.Drawing.Point(309, 344);
            this.BTNQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(100, 44);
            this.BTNQuitter.TabIndex = 5;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = false;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            this.BTNQuitter.MouseEnter += new System.EventHandler(this.BTNQuitter_MouseEnter);
            this.BTNQuitter.MouseLeave += new System.EventHandler(this.BTNQuitter_MouseLeave);
            // 
            // BTNPraticiens
            // 
            this.BTNPraticiens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNPraticiens.BackColor = System.Drawing.Color.LightGray;
            this.BTNPraticiens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNPraticiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNPraticiens.Location = new System.Drawing.Point(148, 108);
            this.BTNPraticiens.Margin = new System.Windows.Forms.Padding(4);
            this.BTNPraticiens.Name = "BTNPraticiens";
            this.BTNPraticiens.Size = new System.Drawing.Size(113, 44);
            this.BTNPraticiens.TabIndex = 2;
            this.BTNPraticiens.Text = "Praticiens";
            this.BTNPraticiens.UseVisualStyleBackColor = false;
            this.BTNPraticiens.Click += new System.EventHandler(this.BTNPraticiens_Click);
            this.BTNPraticiens.MouseEnter += new System.EventHandler(this.BTNPraticiens_MouseEnter);
            this.BTNPraticiens.MouseLeave += new System.EventHandler(this.BTNPraticiens_MouseLeave);
            // 
            // BTNVisiteurs
            // 
            this.BTNVisiteurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNVisiteurs.BackColor = System.Drawing.Color.LightGray;
            this.BTNVisiteurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNVisiteurs.Location = new System.Drawing.Point(144, 188);
            this.BTNVisiteurs.Margin = new System.Windows.Forms.Padding(4);
            this.BTNVisiteurs.Name = "BTNVisiteurs";
            this.BTNVisiteurs.Size = new System.Drawing.Size(121, 44);
            this.BTNVisiteurs.TabIndex = 3;
            this.BTNVisiteurs.Text = "Visiteurs";
            this.BTNVisiteurs.UseVisualStyleBackColor = false;
            this.BTNVisiteurs.Click += new System.EventHandler(this.BTNVisiteurs_Click);
            this.BTNVisiteurs.MouseEnter += new System.EventHandler(this.BTNVisiteurs_MouseEnter);
            this.BTNVisiteurs.MouseLeave += new System.EventHandler(this.BTNVisiteurs_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImageGSB);
            this.panel1.Controls.Add(this.BTNQuitter);
            this.panel1.Controls.Add(this.BTNPraticiens);
            this.panel1.Controls.Add(this.BTNVisiteurs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(387, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 392);
            this.panel1.TabIndex = 8;
            // 
            // ImageGSB
            // 
            this.ImageGSB.Image = global::WindowsFormsApp1.Properties.Resources.gsb_background;
            this.ImageGSB.Location = new System.Drawing.Point(316, 7);
            this.ImageGSB.Name = "ImageGSB";
            this.ImageGSB.Size = new System.Drawing.Size(93, 49);
            this.ImageGSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageGSB.TabIndex = 5;
            this.ImageGSB.TabStop = false;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grBoxMenu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMenu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.grBoxMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageGSB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTNQuitter;
        private System.Windows.Forms.Button BTNCompteRendus;
        private System.Windows.Forms.Button BTNVisiteurs;
        private System.Windows.Forms.Button BTNPraticiens;
        private System.Windows.Forms.Button BTNMedicaments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImageGSB;
    }
}