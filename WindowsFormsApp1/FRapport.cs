using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ppe3;
using DAO;

namespace WindowsFormsApp1
{
    public partial class FRapport : Form
    {
        List<RapportVisite> RapportsListe = new List<RapportVisite>();
        List<Praticien> praticiens = DAOPraticien.GetPraticien();
        int index = 0;
        Boolean nouveau = false;
        public FRapport()
        {
            
            InitializeComponent();

        }

        private void FRapport_Load(object sender, EventArgs e)
        {
            List<RapportVisite> Rapport = DAORapportVisite.GetRapportVisite();

            foreach (RapportVisite Rapports in Rapport)
            {
                //On crée un tableau de chaine de caractères : chaque cellule contient un attribut chaine de caractères du client
                RapportVisite unRapport = new RapportVisite(Rapports.Numero, Rapports.Date, Rapports.Bilan, Rapports.Motif, Rapports.Pra_num, Rapports.Vis_matricule);
                RapportsListe.Add(unRapport);

            }
            RapportVisite Rapportaffiche = RapportsListe[0];
            TBXNumRapport.Text = Rapportaffiche.Numero;
            TBXMotif.Text = Rapportaffiche.Motif;
            TBXBilan.Text = Rapportaffiche.Bilan;
            BTNPrecedent.Enabled = false;

            foreach (Praticien praticien in praticiens)
            {

                string nomPrenom = praticien.Nom + " " + praticien.Prenom;

                CBXPraticien.Items.Add(nomPrenom);
            }
            CBXPraticien.SelectedIndex = Rapportaffiche.Pra_num - 1;

        }

        private void BTNSuivant_Click(object sender, EventArgs e)
        {
            if (index < RapportsListe.Count - 1)
            {
                index += 1;
                if (index == RapportsListe.Count - 1)
                {
                    BTNSuivant.Enabled = false;
                }
                RapportVisite Rapportaffiche = RapportsListe[index];
                TBXNumRapport.Text = Rapportaffiche.Numero;
                TBXDateRapport.Text = Rapportaffiche.Date;
                TBXMotif.Text = Rapportaffiche.Motif;
                TBXBilan.Text = Rapportaffiche.Bilan;
                CBXPraticien.SelectedIndex = Rapportaffiche.Pra_num - 1;
                BTNPrecedent.Enabled = true;
            }
        }

        private void BTNPrecedent_Click(object sender, EventArgs e)
        {
            BTNSuivant.Enabled = true;
            if (index > 0)
            {
                index -= 1;
                if (index == 0)
                {
                    BTNPrecedent.Enabled = false;
                }
                RapportVisite Rapportaffiche = RapportsListe[index];
                TBXNumRapport.Text = Rapportaffiche.Numero;
                TBXDateRapport.Text = Rapportaffiche.Date;
                TBXMotif.Text = Rapportaffiche.Motif;
                TBXBilan.Text = Rapportaffiche.Bilan;
                CBXPraticien.SelectedIndex = Rapportaffiche.Pra_num - 1;
            }
            if (nouveau)
            {
                index = RapportsListe.Count - 1;
                TBXNumRapport.Enabled = false;
                this.nouveau = false;
            }
        }

        private void CBXPraticien_TextChanged(object sender, EventArgs e)
        {

            string[] NomPrenom = CBXPraticien.Text.Split(' ');

            Praticien praticien;

            try
            {
                praticien = DAOPraticien.GetPraticienNomPrenom(NomPrenom[0], NomPrenom[1]);
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Format Incorrect");
                praticien = null;
            }
        }


        private void BTNNouveau_Click(object sender, EventArgs e)
        {

            index = RapportsListe.Count;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            TBXDateRapport.Text = sqlFormattedDate;
            TBXNumRapport.Text = "";
            TBXNumRapport.Enabled = true;
            TBXMotif.Text = "";
            TBXBilan.Text = "";
            CBXPraticien.SelectedIndex = 0;
            this.nouveau = true;
            BTNEnregistrer.Enabled = true;
            BTNEnregistrer.Visible = true;
            BTNSuivant.Enabled = false;
            BTNPrecedent.Enabled = false;

        }

        private void BTNDetails_Click(object sender, EventArgs e)
        {

            Praticien PraticienSelectionne;

            int indiceSelectionne = CBXPraticien.SelectedIndex;

            Praticien praticienSelectionne = praticiens[indiceSelectionne];

            FPraticien praticienSelect = new FPraticien(praticienSelectionne);
            praticienSelect.ShowDialog();

        }

        private void BTNEnregistrer_Click(object sender, EventArgs e)
        {
            if (nouveau)
            {
                RapportVisite nouveauRapport = new RapportVisite();
                nouveauRapport.Numero = TBXNumRapport.Text;
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                string sqlFormattedDate = "1970-01-01";
                List<string> eltDate = new List<string>(TBXDateRapport.Text.Split(separateurs));
                if (eltDate.Count == 3)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (eltDate.Count == 6)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                nouveauRapport.Date = sqlFormattedDate;
                nouveauRapport.Bilan = TBXBilan.Text;
                nouveauRapport.Motif = TBXMotif.Text;
                nouveauRapport.Pra_num = CBXPraticien.SelectedIndex + 1;
                if (DAORapportVisite.CreateRapport(nouveauRapport))
                {
                    RapportsListe.Add(nouveauRapport);
                };

            }
            else
            {
                RapportVisite rapportModifie = new RapportVisite();
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                string sqlFormattedDate = "1970-01-01";
                List<string> eltDate = new List<string>(TBXDateRapport.Text.Split(separateurs));
                if (eltDate.Count == 3)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (eltDate.Count == 6)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                rapportModifie.Numero = TBXNumRapport.Text;
                rapportModifie.Date = sqlFormattedDate;
                rapportModifie.Bilan = TBXBilan.Text;
                rapportModifie.Motif = TBXMotif.Text;
                rapportModifie.Pra_num = CBXPraticien.SelectedIndex + 1;
                DAORapportVisite.UpdateRapport(rapportModifie);
                this.RapportsListe[index] = rapportModifie;
            }

            this.refresh();
            

        }

        private void BTNFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMenu Fmenu = new FMenu();
            Fmenu.Closed += (s, args) => this.Close();
            Fmenu.Show();
        }

        private void refresh()
        {
            this.Hide();
            FMenu Fmenu = new FMenu();
            Fmenu.Closed += (s, args) => this.Close();
            Fmenu.Show();
        }
    }
}
