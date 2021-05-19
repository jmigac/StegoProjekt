using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StegoProjekt
{
    class StegoImporter
    {
        public Bitmap Slika { get; set; }
        public String TekstZaUgradnju { get; set; }
        public Bitmap StegoSlika
        {
            get => Ugradi();
        }
        private int korea_First_Index = 44032;
        public StegoImporter(Bitmap slika, String tekst)
        {
            this.Slika = slika;
            this.TekstZaUgradnju = tekst;
        }
        public byte[] StringToBajtNiz(string binary)
        {
            var list = new List<byte>();
            for (int i = 0; i < binary.Length; i += 8)
            {
                list.Add(Convert.ToByte(binary.Substring(i, 8), 2));
            }
            return list.ToArray();
        }
        private string TurkishCharTo7Bit(char turkishChar)
        {
            if (turkishChar == 'ş')
                return "00000000000000";
            if (turkishChar == 'Ş')
                return "00000000000001";
            if (turkishChar == 'ç')
                return "00000000000010";
            if (turkishChar == 'Ç')
                return "00000000000011";
            if (turkishChar == 'ğ')
                return "00000000000100";
            if (turkishChar == 'Ğ')
                return "00000000000101";
            if (turkishChar == 'ü')
                return "00000000000110";
            if (turkishChar == 'Ü')
                return "00000000000111";
            if (turkishChar == 'ö')
                return "00000000001000";
            if (turkishChar == 'Ö')
                return "00000000001001";
            if (turkishChar == '\n')
                return "00000000001010";
            if (turkishChar == 'İ')
                return "00000000001011";
            if (turkishChar == 'ı')
                return "00000000001100";
            return "?";
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

            var nekoristeniBajtoviZadnjegPiksela= (3 - (totalBytesMod3)); // the number of unused bytes of last pixel
            bitovi = bitovi.Remove(8 * totalPixel * 3 - nekoristeniBajtoviZadnjegPiksela * 8); // trimming unused bytes of the last pixel 
            return bitovi;
        }
        public Bitmap ByteNizToBitmap(byte[] data)
        {
            int index = 0;
            var bitmap = new Bitmap(Slika);
            var colorsArray = new Color[data.Length / 3];

            for (int i = 0; i < data.Length - 2; i += 3)
            {
                colorsArray[index] = Color.FromArgb(data[i], data[i + 1], data[i + 2]);
                index++;
            }

            int counter = 0, x = 0, keep = 0, y;
            index = 0;

            for (y = 0; y < Slika.Height; y++)
            {
                for (x = 0; x < Slika.Width; x++)
                {
                    if (counter == colorsArray.Length)
                    {
                        keep = y;
                        y = Slika.Height;
                        break;
                    }
                    counter++;
                    bitmap.SetPixel(x, y, colorsArray[index]);
                    index++;
                }
            }

            if (data.Length % 3 == 1) // Fixing, if all bytes of the latest pixel were not used.
            {
                bitmap.SetPixel(x, keep, Color.FromArgb(data[3 * counter], bitmap.GetPixel(x, keep).R, bitmap.GetPixel(x, keep).B));
            }
            else if (data.Length % 3 == 2)
            {
                bitmap.SetPixel(x, keep, Color.FromArgb(data[3 * counter], data[(3 * counter) + 1], bitmap.GetPixel(x, keep).B));
            }
            return bitmap;
        }
        private void UgradiDuzinuTeksta()
        {
            var maksimumBajtova = string.Empty;
            int brojac = 0, y = 0;
            var newBottom = string.Empty;
            var duzinaTeksta = TekstZaUgradnju.Length.ToString().PadLeft(5, '0');
            var duzinaTekstaDecimalniNiz = duzinaTeksta.ToCharArray(); // 0 -> 0
            var duzinaTekstaBinarno = duzinaTekstaDecimalniNiz.Aggregate(string.Empty, (tekuci, t) => tekuci + Convert.ToString(t, 2)); // 0 -> 110000

            for (var i = 0; i < 10; i++)
                maksimumBajtova += Convert.ToString(Slika.GetPixel(i, Slika.Height - 1).ToArgb(), 2).Substring(8);

            while (30 > brojac) // (max. 99999 chars means max 30 bytes
            {
                newBottom = newBottom + maksimumBajtova.Substring(y, 7) + int.Parse(duzinaTekstaBinarno.Substring(brojac, 1));
                brojac++;
                y += 8;
            }

            y = 0;
            var nizZaUgradnju = StringToBajtNiz(newBottom);
            for (var i = 0; i < 10; i++)
            {
                Slika.SetPixel(i, Slika.Height - 1, Color.FromArgb(nizZaUgradnju[y], nizZaUgradnju[y + 1], nizZaUgradnju[y + 2]));
                y += 3;
            }
        }
        private bool ProvjeriPrijeUgradnje()
        {
            if (Slika.Height == 0 || TekstZaUgradnju.Length==0)
                return false;
            if (((Slika.Width*(Slika.Height-1) * 3) / 7) < TekstZaUgradnju.Length)
                return false;
            return true;
        }
        private Bitmap Ugradi()
        {
            if (ProvjeriPrijeUgradnje())
            {
                string bitoviZaUgradnju = string.Empty;
                var znakoviZaUgradnju = TekstZaUgradnju.ToCharArray();
                var ukupnoBajtova = znakoviZaUgradnju.Length * 7;
                var ukupnoPiksela = ukupnoBajtova / 3; // Total number of pixels to be used..
                var ukupnoBajtovaMod3 = ukupnoBajtova % 3;
                if (ukupnoBajtovaMod3 != 0)
                    ukupnoPiksela++;

                var znakoviToBitove = string.Empty;
                foreach (char znak in znakoviZaUgradnju)// bitsToImport holds the bit form of the character that will be imported.
                {
                    if (znak >= korea_First_Index)
                    {
                        znakoviToBitove = Convert.ToString(znak - korea_First_Index + 1000, 2);
                        //(Chr - Korean_First_Index is to reduce 16 bits to 14 bits) (The reason that add 1000 to text is to protect overlapping with turkish).
                    }
                    else
                    {
                        znakoviToBitove = Convert.ToString(znak, 2); //if chr is not Korean, change to binary
                    }

                    if (znakoviToBitove.Length > 7 && znakoviToBitove.Length < 9) // if it's binary is between 7 and 9
                    {
                        bitoviZaUgradnju += TurkishCharTo7Bit(znak); // set to 14 bits in Turkish letter
                    }
                    else
                    {
                        bitoviZaUgradnju += znakoviToBitove.PadLeft(14, '0'); // If less than 14 bits, padding the leading 0

                    }
                }
                var bitoviSlike = DohvatiNuzneBitove(ukupnoPiksela, ukupnoBajtovaMod3);
                int pokazivacSedmogBita = 0, pokazivacJednogBita = 0;
                var zadnjiBitoviSlike = string.Empty;

                while (bitoviZaUgradnju.Length > pokazivacJednogBita) //bitsToImport is importing into imagebits. the result is stored in imageBitLast.
                {
                    zadnjiBitoviSlike += bitoviSlike.Substring(pokazivacSedmogBita, 6) + (bitoviZaUgradnju.Substring(pokazivacJednogBita, 2));
                    pokazivacJednogBita = pokazivacJednogBita + 2;
                    pokazivacSedmogBita += 8;
                }

                UgradiDuzinuTeksta();
                zadnjiBitoviSlike += bitoviSlike.Substring(pokazivacSedmogBita);
                return ByteNizToBitmap(StringToBajtNiz(zadnjiBitoviSlike));
            }
            else
            {
                throw new Exception("Sliku je nemoguće importati!");
            }
        }



    }
}
