using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StegoProjekt
{
    public partial class IspisTeksta : Form
    {
        public IspisTeksta()
        {
            InitializeComponent();
        }

        private void uiActionUcitajSlikuZaIzvoz_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Bitmap slikaZaSteganografiju = null;
            ofd.Filter = "All picture files| *.bmp; *.dib; *.jpg; *.jpeg; *.jpe; *.jfif; *.tif; *.tiff; *.gif; *.png | Bitmap files(*.bmp, *.dib) | *.bmp; *.dib | JPEG(*.jpg, *.jpeg, *.jpe, *.jfif) | *.jpg; *.jpeg; *.jpe; *.jfif | TIFF(*.tif, *.tiff) | *.tif; *.tiff | GIF(*.gif) | *.gif | PNG(*.png) | *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                slikaZaSteganografiju = PostaviElementSlikeZaIzvoz(ofd);
            }
            StegoExporter exporter = new StegoExporter(slikaZaSteganografiju);
            try
            {
                exporter.Export();
                uiOutputTekstZaIzvoz.Text = exporter.Tekst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Bitmap PostaviElementSlikeZaIzvoz(OpenFileDialog ofd)
        {
            Bitmap slika = new Bitmap(ofd.FileName);
            uiOutputSlikaZaIzvoz.Image = Image.FromFile(ofd.FileName);
            return slika;
        }
        private void uiActionSpremiSadrzajSteganografije_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = OgranicenjaDialoga.SaveDialogTxt;
            sfd.Title = OgranicenjaDialoga.SaveDialogTitle;
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (ProvjeriNazivSpremljeneDatoteke(sfd.FileName))
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1:
                        case 2:
                        case 3:
                            FileStream fParameter = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                            m_WriterParameter.Write(uiOutputTekstZaIzvoz.Text);
                            m_WriterParameter.Flush();
                            m_WriterParameter.Close();
                            fParameter.Close();
                            break;
                    }
                }
            }
        }
        private bool ProvjeriNazivSpremljeneDatoteke(string nazivDatoteke)
        {
            if (nazivDatoteke != string.Empty)
                return true;
            else return false;
        }
    }
}
