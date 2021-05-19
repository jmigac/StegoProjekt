namespace StegoProjekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiOutputSlikaZaUcitavanje = new System.Windows.Forms.PictureBox();
            this.uiActionUcitajSliku = new System.Windows.Forms.Button();
            this.uiInputTekstZaUgradnju = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionUgradiTekst = new System.Windows.Forms.Button();
            this.uiOutputSlikaZaIzvoz = new System.Windows.Forms.PictureBox();
            this.uiActionUcitajSlikuZaIzvoz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiOutputTekstZaIzvoz = new System.Windows.Forms.TextBox();
            this.uiActionSpremiSliku = new System.Windows.Forms.Button();
            this.uiActionSpremiSadrzajSteganografije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaUcitavanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaIzvoz)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputSlikaZaUcitavanje
            // 
            this.uiOutputSlikaZaUcitavanje.Location = new System.Drawing.Point(13, 13);
            this.uiOutputSlikaZaUcitavanje.Name = "uiOutputSlikaZaUcitavanje";
            this.uiOutputSlikaZaUcitavanje.Size = new System.Drawing.Size(165, 133);
            this.uiOutputSlikaZaUcitavanje.TabIndex = 0;
            this.uiOutputSlikaZaUcitavanje.TabStop = false;
            // 
            // uiActionUcitajSliku
            // 
            this.uiActionUcitajSliku.Location = new System.Drawing.Point(13, 153);
            this.uiActionUcitajSliku.Name = "uiActionUcitajSliku";
            this.uiActionUcitajSliku.Size = new System.Drawing.Size(165, 23);
            this.uiActionUcitajSliku.TabIndex = 1;
            this.uiActionUcitajSliku.Text = "Učitaj sliku";
            this.uiActionUcitajSliku.UseVisualStyleBackColor = true;
            this.uiActionUcitajSliku.Click += new System.EventHandler(this.uiActionUcitajSliku_Click);
            // 
            // uiInputTekstZaUgradnju
            // 
            this.uiInputTekstZaUgradnju.Enabled = false;
            this.uiInputTekstZaUgradnju.Location = new System.Drawing.Point(13, 196);
            this.uiInputTekstZaUgradnju.Multiline = true;
            this.uiInputTekstZaUgradnju.Name = "uiInputTekstZaUgradnju";
            this.uiInputTekstZaUgradnju.Size = new System.Drawing.Size(165, 130);
            this.uiInputTekstZaUgradnju.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tekst za ugradnju:";
            // 
            // uiActionUgradiTekst
            // 
            this.uiActionUgradiTekst.Enabled = false;
            this.uiActionUgradiTekst.Location = new System.Drawing.Point(13, 332);
            this.uiActionUgradiTekst.Name = "uiActionUgradiTekst";
            this.uiActionUgradiTekst.Size = new System.Drawing.Size(165, 23);
            this.uiActionUgradiTekst.TabIndex = 4;
            this.uiActionUgradiTekst.Text = "Ugradi tekst";
            this.uiActionUgradiTekst.UseVisualStyleBackColor = true;
            this.uiActionUgradiTekst.Click += new System.EventHandler(this.uiActionUgradiTekst_Click);
            // 
            // uiOutputSlikaZaIzvoz
            // 
            this.uiOutputSlikaZaIzvoz.Location = new System.Drawing.Point(184, 13);
            this.uiOutputSlikaZaIzvoz.Name = "uiOutputSlikaZaIzvoz";
            this.uiOutputSlikaZaIzvoz.Size = new System.Drawing.Size(165, 133);
            this.uiOutputSlikaZaIzvoz.TabIndex = 5;
            this.uiOutputSlikaZaIzvoz.TabStop = false;
            // 
            // uiActionUcitajSlikuZaIzvoz
            // 
            this.uiActionUcitajSlikuZaIzvoz.Location = new System.Drawing.Point(184, 153);
            this.uiActionUcitajSlikuZaIzvoz.Name = "uiActionUcitajSlikuZaIzvoz";
            this.uiActionUcitajSlikuZaIzvoz.Size = new System.Drawing.Size(165, 23);
            this.uiActionUcitajSlikuZaIzvoz.TabIndex = 6;
            this.uiActionUcitajSlikuZaIzvoz.Text = "Učitaj sliku";
            this.uiActionUcitajSlikuZaIzvoz.UseVisualStyleBackColor = true;
            this.uiActionUcitajSlikuZaIzvoz.Click += new System.EventHandler(this.uiActionUcitajSlikuZaIzvoz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tekst iz steganografske slike:";
            // 
            // uiOutputTekstZaIzvoz
            // 
            this.uiOutputTekstZaIzvoz.Enabled = false;
            this.uiOutputTekstZaIzvoz.Location = new System.Drawing.Point(184, 197);
            this.uiOutputTekstZaIzvoz.Multiline = true;
            this.uiOutputTekstZaIzvoz.Name = "uiOutputTekstZaIzvoz";
            this.uiOutputTekstZaIzvoz.Size = new System.Drawing.Size(165, 129);
            this.uiOutputTekstZaIzvoz.TabIndex = 8;
            // 
            // uiActionSpremiSliku
            // 
            this.uiActionSpremiSliku.Location = new System.Drawing.Point(13, 358);
            this.uiActionSpremiSliku.Name = "uiActionSpremiSliku";
            this.uiActionSpremiSliku.Size = new System.Drawing.Size(165, 23);
            this.uiActionSpremiSliku.TabIndex = 9;
            this.uiActionSpremiSliku.Text = "Spremi sliku";
            this.uiActionSpremiSliku.UseVisualStyleBackColor = true;
            this.uiActionSpremiSliku.Click += new System.EventHandler(this.uiActionSpremiSliku_Click);
            // 
            // uiActionSpremiSadrzajSteganografije
            // 
            this.uiActionSpremiSadrzajSteganografije.Location = new System.Drawing.Point(185, 332);
            this.uiActionSpremiSadrzajSteganografije.Name = "uiActionSpremiSadrzajSteganografije";
            this.uiActionSpremiSadrzajSteganografije.Size = new System.Drawing.Size(164, 23);
            this.uiActionSpremiSadrzajSteganografije.TabIndex = 10;
            this.uiActionSpremiSadrzajSteganografije.Text = "Spremi u .txt";
            this.uiActionSpremiSadrzajSteganografije.UseVisualStyleBackColor = true;
            this.uiActionSpremiSadrzajSteganografije.Click += new System.EventHandler(this.uiActionSpremiSadrzajSteganografije_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 388);
            this.Controls.Add(this.uiActionSpremiSadrzajSteganografije);
            this.Controls.Add(this.uiActionSpremiSliku);
            this.Controls.Add(this.uiOutputTekstZaIzvoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiActionUcitajSlikuZaIzvoz);
            this.Controls.Add(this.uiOutputSlikaZaIzvoz);
            this.Controls.Add(this.uiActionUgradiTekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputTekstZaUgradnju);
            this.Controls.Add(this.uiActionUcitajSliku);
            this.Controls.Add(this.uiOutputSlikaZaUcitavanje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaUcitavanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaIzvoz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uiOutputSlikaZaUcitavanje;
        private System.Windows.Forms.Button uiActionUcitajSliku;
        private System.Windows.Forms.TextBox uiInputTekstZaUgradnju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionUgradiTekst;
        private System.Windows.Forms.PictureBox uiOutputSlikaZaIzvoz;
        private System.Windows.Forms.Button uiActionUcitajSlikuZaIzvoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiOutputTekstZaIzvoz;
        private System.Windows.Forms.Button uiActionSpremiSliku;
        private System.Windows.Forms.Button uiActionSpremiSadrzajSteganografije;
    }
}

