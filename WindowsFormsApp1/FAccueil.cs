using Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FAccueil : Form
    {

        public FAccueil()
        {
            InitializeComponent();

        }

        private void BTNValider_Click(object sender, EventArgs e)
        {

            if (TBXId.Text == "swiss" && TBXMdp.Text == "18-jun-2003")
            {
                this.Hide();
                FMenu Fmenu = new FMenu();
                Fmenu.Closed += (s, args) => this.Close();
                Fmenu.Show();
            }
            else
            {
                if (TBXId.Text == "Villechalane" && TBXMdp.Text == "11-dec-1992")
                {
                    this.Hide();
                    FMenu Fmenu = new FMenu();
                    Fmenu.Closed += (s, args) => this.Close();
                    Fmenu.Show();
                }
                else
                {
                    if (TBXId.Text == "Andre" && TBXMdp.Text == "26-aug-1991")
                    {
                        this.Hide();
                        FMenu Fmenu = new FMenu();
                        Fmenu.Closed += (s, args) => this.Close();
                        Fmenu.Show();
                    }
                    else
                    {
                        if (TBXId.Text == "Bentot" && TBXMdp.Text == "11-mar-1996")
                        {
                            this.Hide();
                            FMenu Fmenu = new FMenu();
                            Fmenu.Closed += (s, args) => this.Close();
                            Fmenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("L'identifiant ou le mot de passe est incorrect.");
                        }
                    }
                }
            }
        }

        private void FAccueil_Load(object sender, EventArgs e)
        {

        }

        private void TBXMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (TBXId.Text == "swiss" && TBXMdp.Text == "18-jun-2003")
                {
                    this.Hide();
                    FMenu Fmenu = new FMenu();
                    Fmenu.Closed += (s, args) => this.Close();
                    Fmenu.Show();
                }
                else
                {
                    if (TBXId.Text == "Villechalane" && TBXMdp.Text == "11-dec-1992")
                    {
                        this.Hide();
                        FMenu Fmenu = new FMenu();
                        Fmenu.Closed += (s, args) => this.Close();
                        Fmenu.Show();
                    }
                    else
                    {
                        if (TBXId.Text == "Andre" && TBXMdp.Text == "26-aug-1991")
                        {
                            this.Hide();
                            FMenu Fmenu = new FMenu();
                            Fmenu.Closed += (s, args) => this.Close();
                            Fmenu.Show();
                        }
                        else
                        {
                            if (TBXId.Text == "Bentot" && TBXMdp.Text == "11-mar-1996")
                            {
                                this.Hide();
                                FMenu Fmenu = new FMenu();
                                Fmenu.Closed += (s, args) => this.Close();
                                Fmenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("L'identifiant ou le mot de passe est incorrect.");
                            }
                        }
                    }

                }
            }
        }

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}