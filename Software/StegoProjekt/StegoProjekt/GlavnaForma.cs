using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StegoProjekt
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void uiActionUpis_Click(object sender, EventArgs e)
        {
            UpisTeksta ut = new UpisTeksta();
            ut.ShowDialog();
        }

        private void uiActionIspis_Click(object sender, EventArgs e)
        {
            IspisTeksta it = new IspisTeksta();
            it.ShowDialog();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            uiActionUpis.Focus();
        }
    }
}
