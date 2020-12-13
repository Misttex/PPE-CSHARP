using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }



        private void FMenu_Load(object sender, EventArgs e)
        {
            
        }


        private void BTNMedicaments_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMedicaments Fmedicaments = new FMedicaments();
            Fmedicaments.Closed += (s, args) => this.Close();
            Fmedicaments.Show();
        }

        private void BTNPraticiens_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPraticien Fpraticien = new FPraticien();
            Fpraticien.Closed += (s, args) => this.Close();
            Fpraticien.Show();
        }

        private void BTNVisiteurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVisiteur Fvisiteur = new FVisiteur();
            Fvisiteur.Closed += (s, args) => this.Close();
            Fvisiteur.Show();
        }

        private void BTNCompteRendus_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRapport Frapport = new FRapport();
            Frapport.Closed += (s, args) => this.Close();
            Frapport.Show();
        }


        private void BTNVisiteurs_MouseEnter(object sender, EventArgs e)
        {
            BTNVisiteurs.BackColor = Color.LightBlue;
        }

        private void BTNVisiteurs_MouseLeave(object sender, EventArgs e)
        {
            BTNVisiteurs.BackColor = Color.LightGray;
        }

        private void BTNPraticiens_MouseEnter(object sender, EventArgs e)
        {
            BTNPraticiens.BackColor = Color.LightBlue;
        }

        private void BTNPraticiens_MouseLeave(object sender, EventArgs e)
        {
            BTNPraticiens.BackColor = Color.LightGray;
        }

        private void BTNCompteRendus_MouseEnter(object sender, EventArgs e)
        {
            BTNCompteRendus.BackColor = Color.LightBlue;
        }

        private void BTNCompteRendus_MouseLeave(object sender, EventArgs e)
        {
            BTNCompteRendus.BackColor = Color.LightGray;
        }

        private void BTNMedicaments_MouseEnter(object sender, EventArgs e)
        {
            BTNMedicaments.BackColor = Color.LightBlue;
        }

        private void BTNMedicaments_MouseLeave(object sender, EventArgs e)
        {
            BTNMedicaments.BackColor = Color.LightGray;
        }

        private void BTNQuitter_MouseEnter(object sender, EventArgs e)
        {
            BTNQuitter.BackColor = Color.DarkRed;
        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAccueil Faccueil = new FAccueil();
            Faccueil.Closed += (s, args) => this.Close();
            Faccueil.Show();
        }

        private void BTNQuitter_MouseLeave(object sender, EventArgs e)
        {
            BTNQuitter.BackColor = Color.LightGray;
        }
    }
}
