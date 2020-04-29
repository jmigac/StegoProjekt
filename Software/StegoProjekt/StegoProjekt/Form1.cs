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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uiActionUcitajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All picture files| *.bmp; *.dib; *.jpg; *.jpeg; *.jpe; *.jfif; *.tif; *.tiff; *.gif; *.png | Bitmap files(*.bmp, *.dib) | *.bmp; *.dib | JPEG(*.jpg, *.jpeg, *.jpe, *.jfif) | *.jpg; *.jpeg; *.jpe; *.jfif | TIFF(*.tif, *.tiff) | *.tif; *.tiff | GIF(*.gif) | *.gif | PNG(*.png) | *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //uiOutputSlikaZaUcitavanje.ImageLocation = ofd.FileName;
                Bitmap slika = new Bitmap(ofd.FileName);
                uiOutputSlikaZaUcitavanje.Image = Image.FromFile(ofd.FileName);
                uiInputTekstZaUgradnju.Enabled = true;
                uiActionUgradiTekst.Enabled = true;
                uiActionUcitajSliku.Enabled = false;
            }
        }
    }
}
