namespace StegoProjekt
{
    partial class UpisTeksta
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
            this.uiActionSpremiSliku = new System.Windows.Forms.Button();
            this.uiActionUgradiTekst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputTekstZaUgradnju = new System.Windows.Forms.TextBox();
            this.uiActionUcitajSliku = new System.Windows.Forms.Button();
            this.uiOutputSlikaZaUcitavanje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaUcitavanje)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionSpremiSliku
            // 
            this.uiActionSpremiSliku.Location = new System.Drawing.Point(12, 357);
            this.uiActionSpremiSliku.Name = "uiActionSpremiSliku";
            this.uiActionSpremiSliku.Size = new System.Drawing.Size(165, 23);
            this.uiActionSpremiSliku.TabIndex = 15;
            this.uiActionSpremiSliku.Text = "Spremi sliku";
            this.uiActionSpremiSliku.UseVisualStyleBackColor = true;
            this.uiActionSpremiSliku.Click += new System.EventHandler(this.uiActionSpremiSliku_Click);
            // 
            // uiActionUgradiTekst
            // 
            this.uiActionUgradiTekst.Enabled = false;
            this.uiActionUgradiTekst.Location = new System.Drawing.Point(12, 331);
            this.uiActionUgradiTekst.Name = "uiActionUgradiTekst";
            this.uiActionUgradiTekst.Size = new System.Drawing.Size(165, 23);
            this.uiActionUgradiTekst.TabIndex = 14;
            this.uiActionUgradiTekst.Text = "Ugradi tekst";
            this.uiActionUgradiTekst.UseVisualStyleBackColor = true;
            this.uiActionUgradiTekst.Click += new System.EventHandler(this.uiActionUgradiTekst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tekst za ugradnju:";
            // 
            // uiInputTekstZaUgradnju
            // 
            this.uiInputTekstZaUgradnju.Enabled = false;
            this.uiInputTekstZaUgradnju.Location = new System.Drawing.Point(12, 195);
            this.uiInputTekstZaUgradnju.Multiline = true;
            this.uiInputTekstZaUgradnju.Name = "uiInputTekstZaUgradnju";
            this.uiInputTekstZaUgradnju.Size = new System.Drawing.Size(165, 130);
            this.uiInputTekstZaUgradnju.TabIndex = 12;
            // 
            // uiActionUcitajSliku
            // 
            this.uiActionUcitajSliku.Location = new System.Drawing.Point(12, 152);
            this.uiActionUcitajSliku.Name = "uiActionUcitajSliku";
            this.uiActionUcitajSliku.Size = new System.Drawing.Size(165, 23);
            this.uiActionUcitajSliku.TabIndex = 11;
            this.uiActionUcitajSliku.Text = "Učitaj sliku";
            this.uiActionUcitajSliku.UseVisualStyleBackColor = true;
            this.uiActionUcitajSliku.Click += new System.EventHandler(this.uiActionUcitajSliku_Click);
            // 
            // uiOutputSlikaZaUcitavanje
            // 
            this.uiOutputSlikaZaUcitavanje.Location = new System.Drawing.Point(12, 12);
            this.uiOutputSlikaZaUcitavanje.Name = "uiOutputSlikaZaUcitavanje";
            this.uiOutputSlikaZaUcitavanje.Size = new System.Drawing.Size(165, 133);
            this.uiOutputSlikaZaUcitavanje.TabIndex = 10;
            this.uiOutputSlikaZaUcitavanje.TabStop = false;
            // 
            // UpisTeksta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 388);
            this.Controls.Add(this.uiActionSpremiSliku);
            this.Controls.Add(this.uiActionUgradiTekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputTekstZaUgradnju);
            this.Controls.Add(this.uiActionUcitajSliku);
            this.Controls.Add(this.uiOutputSlikaZaUcitavanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpisTeksta";
            this.Text = "UpisTeksta";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaUcitavanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionSpremiSliku;
        private System.Windows.Forms.Button uiActionUgradiTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiInputTekstZaUgradnju;
        private System.Windows.Forms.Button uiActionUcitajSliku;
        private System.Windows.Forms.PictureBox uiOutputSlikaZaUcitavanje;
    }
}