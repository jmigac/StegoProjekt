using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StegoProjekt
{
    class StegoExporter
    {
        public Bitmap Slika { get; set; }
        public String Tekst { get; set; }
        public Bitmap SlikaZaIzvoz{
            get=>Export();
            set { }
        }
        public StegoExporter(Bitmap slikaUgradnje)
        {
            this.Slika = slikaUgradnje;
        }
        private int ProvjeraPrijeExporta()
        {
            try
            {
                return ExportDuzinuTeksta();
            }
            catch
            {
                return 0;
            }
        }
        private int ExportDuzinuTeksta()
        {
            var bitmap = new Bitmap(Slika);
            string tridesetBajtova = string.Empty, duzinaTeksta = string.Empty;

            for (int i = 0; i < 10; i++)  // gettint last 30 bytes of the image 
            {
                tridesetBajtova += Convert.ToString(bitmap.GetPixel(i, Slika.Height - 1).ToArgb(), 2).Substring(8);
            }

            int pokazivac = 7;
            for (int i = 0; i < 30; i++)   // getting the last bit of the each bytes 
            {
                duzinaTeksta += tridesetBajtova.Substring(pokazivac, 1);
                pokazivac += 8;
            }

            var duzinaTekstaDecimalno = new char[5];
            int m, tmp = 0, smanjenje = 0, k = 0;

            for (m = 0; m < duzinaTeksta.Length / 6; m++)
            {
                for (int n = k; n < k + 6; n++)
                {
                    tmp += Convert.ToInt32(duzinaTeksta.Substring(n, 1)) * (int)Math.Pow(2, (5 - smanjenje));
                    smanjenje++;
                }

                duzinaTekstaDecimalno[m] = Convert.ToChar(tmp);
                k += 6;
                tmp = 0;
                smanjenje = 0;
            }
            return Convert.ToInt32(new string(duzinaTekstaDecimalno).TrimStart('0'));
        }
        public char NumberToTurkishChar(int number)
        {
            if (number == 0)
                return 'ş';
            if (number == 1)
                return 'Ş';
            if (number == 2)
                return 'ç';
            if (number == 3)
                return 'Ç';
            if (number == 4)
                return 'ğ';
            if (number == 5)
                return 'Ğ';
            if (number == 6)
                return 'ü';
            if (number == 7)
                return 'Ü';
            if (number == 8)
                return 'ö';
            if (number == 9)
                return 'Ö';
            if (number == 10)
                return '\n';
            if (number == 11)
                return 'İ';
            if (number == 12)
                return 'ı';
            return '?';
        }
        public string DohvatiNuzneBitove(int totalPixel, int totalBytesMod3)
        {
            var bitovi = string.Empty;
            var brojac = 0;
            for (var y = 0; y < Slika.Height; y++)
            {
                for (var x = 0; x < Slika.Width; x++)
                {
                    if (brojac == totalPixel)
                    {
                        y = Slika.Height;
                        break;
                    }
                    brojac++;
                    bitovi += Convert.ToString(Slika.GetPixel(x, y).ToArgb(), 2).Substring(8);
                }
            }
            if (totalBytesMod3 == 0)
                return bitovi;

            var nekoristeniBajtoviZadnjegPiksela = (3 - (totalBytesMod3)); // the number of unused bytes of last pixel
            bitovi = bitovi.Remove(8 * totalPixel * 3 - nekoristeniBajtoviZadnjegPiksela * 8); // trimming unused bytes of the last pixel 
            return bitovi;
        }
        public Bitmap Export()
        {
            int ugradenaDuzinaTeksta = ProvjeraPrijeExporta();
            if (ugradenaDuzinaTeksta != 0)
            {
                Bitmap bmp = new Bitmap(Slika);
                int totalBytes = ugradenaDuzinaTeksta * 7;
                int totalPixels = totalBytes / 3;
                int totalBytesMod3 = totalBytes % 3;
                if (totalBytesMod3 != 0)
                    totalPixels++;

                var bytesToExport = DohvatiNuzneBitove(totalPixels, totalBytesMod3);
                int pointer = 6;//++++
                string bytesToExportLast = string.Empty;
                string importedText = null;

                for (int l = 0; l < totalBytes; l++) // Getting the last bit of each bytes and stores to 'bytesToExportast'  
                {
                    bytesToExportLast += bytesToExport.Substring(pointer, 2);
                    pointer += 8;
                }
                int decrease = 0, k = 0, temp = 0;
                importedText = string.Empty;

                for (int j = 0; j < bytesToExportLast.Length / 14; j++)
                {
                    for (int i = k; i < k + 14; i++)
                    {
                        temp += Convert.ToInt32(bytesToExportLast.Substring(i, 1)) * (int)Math.Pow(2, (13 - decrease));
                        decrease++;
                    }

                    if (temp >= 1000)
                    {
                        importedText += Encoding.Unicode.GetString(BitConverter.GetBytes(temp + 43032)).TrimEnd((Char)0);
                    }
                    else if (temp < 13)
                    {
                        importedText += NumberToTurkishChar(temp);
                    }
                    else
                    {
                        importedText += Encoding.Unicode.GetString(BitConverter.GetBytes(temp)).TrimEnd((Char)0);
                    }

                    k += 14; temp = decrease = 0;
                }

                Tekst = importedText;
                return bmp;
            }
            else
            {
                throw new Exception("This is not a stego file!");
            }
        }
    }
}
