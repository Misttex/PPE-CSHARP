using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using ppe3;

namespace WindowsFormsApp1
{
    public partial class FVisiteur : Form
    {
        public FVisiteur()
        {
            InitializeComponent();
        }

        private void FVisiteur_Load(object sender, EventArgs e)
        {
            //On récupère tous les clients
            List<Visiteur> visiteurs = DAOVisiteur.GetVisiteur();
            //On vérifique la liste des visiteurs n'est pas vide
            if (visiteurs != null)
            {
                //On insère dans un tableau tous les clients
                foreach (Visiteur visiteur in visiteurs)
                {
                    string[] row = { visiteur.Matricule, visiteur.Nom, visiteur.Prenom, visiteur.Adresse, visiteur.Cp, visiteur.Ville, visiteur.Dateembauche.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    lVVisiteur.Items.Add(listViewItem);
                }
            }
        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMenu Fmenu = new FMenu();
            Fmenu.Closed += (s, args) => this.Close();
            Fmenu.Show();
        }
    }
}
