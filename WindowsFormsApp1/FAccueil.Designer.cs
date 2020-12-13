namespace WindowsFormsApp1
{
    partial class FAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccueil));
            this.TBXId = new System.Windows.Forms.TextBox();
            this.TBXMdp = new System.Windows.Forms.TextBox();
            this.BTNValider = new System.Windows.Forms.Button();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Identifiant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxGSBlogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGSBlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TBXId
            // 
            this.TBXId.Location = new System.Drawing.Point(121, 90);
            this.TBXId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXId.Name = "TBXId";
            this.TBXId.Size = new System.Drawing.Size(100, 22);
            this.TBXId.TabIndex = 1;
            // 
            // TBXMdp
            // 
            this.TBXMdp.Location = new System.Drawing.Point(121, 188);
            this.TBXMdp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXMdp.Name = "TBXMdp";
            this.TBXMdp.PasswordChar = '*';
            this.TBXMdp.Size = new System.Drawing.Size(100, 22);
            this.TBXMdp.TabIndex = 2;
            this.TBXMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBXMdp_KeyPress);
            // 
            // BTNValider
            // 
            this.BTNValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTNValider.ForeColor = System.Drawing.Color.Black;
            this.BTNValider.Location = new System.Drawing.Point(59, 240);
            this.BTNValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNValider.Name = "BTNValider";
            this.BTNValider.Size = new System.Drawing.Size(228, 70);
            this.BTNValider.TabIndex = 3;
            this.BTNValider.Text = "Valider";
            this.BTNValider.UseVisualStyleBackColor = true;
            this.BTNValider.Click += new System.EventHandler(this.BTNValider_Click);
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNQuitter.ForeColor = System.Drawing.Color.Black;
            this.BTNQuitter.Location = new System.Drawing.Point(3, 2);
            this.BTNQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(176, 41);
            this.BTNQuitter.TabIndex = 3;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = false;
            this.BTNQuitter.Click += new System.EventHandler(this.BTNQuitter_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.BTNQuitter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 43);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(419, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 407);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Identifiant);
            this.panel3.Controls.Add(this.BTNValider);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TBXMdp);
            this.panel3.Controls.Add(this.TBXId);
            this.panel3.Location = new System.Drawing.Point(23, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 374);
            this.panel3.TabIndex = 6;
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identifiant.ForeColor = System.Drawing.Color.Black;
            this.Identifiant.Location = new System.Drawing.Point(97, 54);
            this.Identifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(141, 29);
            this.Identifiant.TabIndex = 4;
            this.Identifiant.Text = "Identifiant :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mot de passe :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxGSBlogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 407);
            this.panel2.TabIndex = 8;
            // 
            // pictureBoxGSBlogo
            // 
            this.pictureBoxGSBlogo.Image = global::WindowsFormsApp1.Properties.Resources.gsb_background;
            this.pictureBoxGSBlogo.Location = new System.Drawing.Point(12, 73);
            this.pictureBoxGSBlogo.Name = "pictureBoxGSBlogo";
            this.pictureBoxGSBlogo.Size = new System.Drawing.Size(394, 244);
            this.pictureBoxGSBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGSBlogo.TabIndex = 0;
            this.pictureBoxGSBlogo.TabStop = false;
            // 
            // FAccueil
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FAccueil";
            this.Text = "ACCEUIL";
            this.Load += new System.EventHandler(this.FAccueil_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGSBlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TBXId;
        private System.Windows.Forms.TextBox TBXMdp;
        private System.Windows.Forms.Button BTNValider;
        private System.Windows.Forms.Button BTNQuitter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxGSBlogo;
    }
}

