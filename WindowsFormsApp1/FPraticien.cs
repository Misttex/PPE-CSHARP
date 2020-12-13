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
    public partial class FPraticien : Form
    {

        public FPraticien(Praticien praticienSelectionne)
        {
            InitializeComponent();
        }

        public FPraticien()
        {
            InitializeComponent();
        }

        private void lVPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FPraticien_Load(object sender, EventArgs e)
        {

            //On récupère tous les clients
            List<Praticien> praticiens = DAOPraticien.GetPraticien();
            //On vérifique la liste des visiteurs n'est pas vide
            if (praticiens != null)
            {
                //On insère dans un tableau tous les clients
                foreach (Praticien praticien in praticiens)
                {
                    string[] row = { praticien.Num, praticien.Nom, praticien.Prenom, praticien.Adresse, praticien.Cp, praticien.Ville, praticien.Coefnotoriete};
                    ListViewItem listViewItem = new ListViewItem(row);
                    lVPraticien.Items.Add(listViewItem);
                }
            }

        }

        private void BTNRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMenu Fmenu = new FMenu();
            Fmenu.Closed += (s, args) => this.Close();
            Fmenu.Show();
        }
    }
}
