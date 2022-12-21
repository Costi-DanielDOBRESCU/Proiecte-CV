using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Produse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string categorie = (string)cmbCategorie.SelectedItem;
            string denumire = txtDenumire.Text;
            int pret = int.Parse(txtPret.Text);
            string moneda  = null;

            if (rbRON.Checked)
            {
                moneda = rbRON.Text;
            }else if (rbEUR.Checked)
            {
                moneda = rbEUR.Text;
            }else if (rbUSD.Checked)
            {
                moneda = rbUSD.Text;
            }

            bool p_nou;
            if (cbxProdusNou.Checked)
                p_nou = true;
            else
                p_nou = false;

            ProdusIT p = new ProdusIT(categorie, denumire, pret, moneda, p_nou);

            ListViewItem item = new ListViewItem();
            item.Text = p.ToString();
            item.Tag = p;

            if (p_nou == true)
                lvNou.Items.Add(item);
            else
                lvSH.Items.Add(item);

            //Console.WriteLine(denumire);
        }
    }
}
