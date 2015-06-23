using Magic_The_Base.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_The_Base
{
    public partial class MagicTheBase : Form
    {
        private List<String> Collection;
        CardController cards;
        public MagicTheBase()
        {
            InitializeComponent();
            cards = new CardController();
        }

        private void MagicTheBase_Load(object sender, EventArgs e)
        {
            txtStatus.Text = "Preenchendo combobox com Cards Collections...";
            Collection = cards.recoverCollections();
            if (Collection.Count > 0)
            {
                cmbColection.DataSource = Collection;
                txtStatus.Text = "Combobox de coleções preenchido...";
            }
            else
            {
                MessageBox.Show("Problemas com sua conexão de internet, tente novamente mais tarde.", "Error");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Pesquisando links de cartas...";
            List<String> cartas = cards.RecoverCardsLinks(cmbColection.Text);
            txtStatus.Text = "Iniciando extração de dados das cartas...";
            cards.ExtrairCards(cartas);
        }
    }
}
