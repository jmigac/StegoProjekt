namespace StegoProjekt
{
    partial class IspisTeksta
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
            this.uiActionSpremiSadrzajSteganografije = new System.Windows.Forms.Button();
            this.uiOutputTekstZaIzvoz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionUcitajSlikuZaIzvoz = new System.Windows.Forms.Button();
            this.uiOutputSlikaZaIzvoz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaIzvoz)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionSpremiSadrzajSteganografije
            // 
            this.uiActionSpremiSadrzajSteganografije.Location = new System.Drawing.Point(13, 331);
            this.uiActionSpremiSadrzajSteganografije.Name = "uiActionSpremiSadrzajSteganografije";
            this.uiActionSpremiSadrzajSteganografije.Size = new System.Drawing.Size(164, 23);
            this.uiActionSpremiSadrzajSteganografije.TabIndex = 15;
            this.uiActionSpremiSadrzajSteganografije.Text = "Spremi u .txt";
            this.uiActionSpremiSadrzajSteganografije.UseVisualStyleBackColor = true;
            this.uiActionSpremiSadrzajSteganografije.Click += new System.EventHandler(this.uiActionSpremiSadrzajSteganografije_Click);
            // 
            // uiOutputTekstZaIzvoz
            // 
            this.uiOutputTekstZaIzvoz.Enabled = false;
            this.uiOutputTekstZaIzvoz.Location = new System.Drawing.Point(12, 196);
            this.uiOutputTekstZaIzvoz.Multiline = true;
            this.uiOutputTekstZaIzvoz.Name = "uiOutputTekstZaIzvoz";
            this.uiOutputTekstZaIzvoz.Size = new System.Drawing.Size(165, 129);
            this.uiOutputTekstZaIzvoz.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tekst iz steganografske slike:";
            // 
            // uiActionUcitajSlikuZaIzvoz
            // 
            this.uiActionUcitajSlikuZaIzvoz.Location = new System.Drawing.Point(12, 152);
            this.uiActionUcitajSlikuZaIzvoz.Name = "uiActionUcitajSlikuZaIzvoz";
            this.uiActionUcitajSlikuZaIzvoz.Size = new System.Drawing.Size(165, 23);
            this.uiActionUcitajSlikuZaIzvoz.TabIndex = 12;
            this.uiActionUcitajSlikuZaIzvoz.Text = "Učitaj sliku";
            this.uiActionUcitajSlikuZaIzvoz.UseVisualStyleBackColor = true;
            this.uiActionUcitajSlikuZaIzvoz.Click += new System.EventHandler(this.uiActionUcitajSlikuZaIzvoz_Click);
            // 
            // uiOutputSlikaZaIzvoz
            // 
            this.uiOutputSlikaZaIzvoz.Location = new System.Drawing.Point(12, 12);
            this.uiOutputSlikaZaIzvoz.Name = "uiOutputSlikaZaIzvoz";
            this.uiOutputSlikaZaIzvoz.Size = new System.Drawing.Size(165, 133);
            this.uiOutputSlikaZaIzvoz.TabIndex = 11;
            this.uiOutputSlikaZaIzvoz.TabStop = false;
            // 
            // IspisTeksta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 368);
            this.Controls.Add(this.uiActionSpremiSadrzajSteganografije);
            this.Controls.Add(this.uiOutputTekstZaIzvoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiActionUcitajSlikuZaIzvoz);
            this.Controls.Add(this.uiOutputSlikaZaIzvoz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IspisTeksta";
            this.Text = "IspisTeksta";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaIzvoz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionSpremiSadrzajSteganografije;
        private System.Windows.Forms.TextBox uiOutputTekstZaIzvoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionUcitajSlikuZaIzvoz;
        private System.Windows.Forms.PictureBox uiOutputSlikaZaIzvoz;
    }
}