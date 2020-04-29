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
    public partial class Form1 : Form
    {
        private Bitmap slikaZaUvozSteganografije = null;
        private Bitmap slikaZaSkrivenimTekstom = null;
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
                slikaZaUvozSteganografije = PostaviElementSlike(ofd);
            }

        }
        private Bitmap PostaviElementSlike(OpenFileDialog ofd)
        {
            Bitmap slika = new Bitmap(ofd.FileName);
            uiOutputSlikaZaUcitavanje.Image = Image.FromFile(ofd.FileName);
            uiInputTekstZaUgradnju.Enabled = true;
            uiActionUgradiTekst.Enabled = true;
            uiActionUcitajSliku.Enabled = false;
            return slika;
        }

        private void uiActionUgradiTekst_Click(object sender, EventArgs e)
        {
            StegoImporter importer = new StegoImporter(slikaZaUvozSteganografije, uiInputTekstZaUgradnju.Text);
            try
            {
                slikaZaSkrivenimTekstom = importer.StegoSlika;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            uiActionUgradiTekst.Enabled = false;
            uiActionSpremiSliku.Focus();
        }

        private void SpremiSliku(Bitmap slikaZaSpremanje)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = OgranicenjaDialoga.SaveDialogFilter;
            sfd.Title = OgranicenjaDialoga.SaveDialogTitle;
            sfd.DefaultExt = "jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (ProvjeriNazivSpremljeneDatoteke(sfd.FileName))
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1:
                            slikaZaSpremanje.Save(sfd.FileName);
                            break;
                        case 2:
                            slikaZaSpremanje.Save(sfd.FileName);
                            break;
                        case 3:
                            System.IO.FileStream fs = sfd.OpenFile() as System.IO.FileStream;
                            slikaZaSpremanje.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            fs.Close();
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

        private void uiActionSpremiSliku_Click(object sender, EventArgs e)
        {
            SpremiSliku(slikaZaSkrivenimTekstom);
            uiActionSpremiSliku.Enabled = false;
            uiActionUcitajSliku.Enabled = true;
            uiOutputSlikaZaUcitavanje.Image = null;
            uiInputTekstZaUgradnju.Clear();
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
    }
}
