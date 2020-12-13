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
    public partial class FMedicaments : Form
    {
        public FMedicaments()
        {
            InitializeComponent();
        }

        private void FMedicaments_Load(object sender, EventArgs e)
        {
            //On récupère la liste des clients
            List<Medicament> medicaments = DAOMedicament.GetMedicament();

            //Il faut vérifier que cette liste n'est pas vide
            if (medicaments != null)
            {
                //On met chaque medicament dans un tableau
                foreach (Medicament medicament in medicaments)
                {
                    string[] row = { medicament.Depotlegal, medicament.Nomcommercial, medicament.Composition, medicament.Effets, medicament.Contreindic, medicament.Prixechantillon.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    lVMedicament.Items.Add(listViewItem);
                }
            }
        }

        private void FMedicaments_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FMenu Fmenu = new FMenu();
            Fmenu.Closed += (s, args) => this.Close();
            Fmenu.Show();
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
