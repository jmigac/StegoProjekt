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
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaUcitavanje)).BeginInit();
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 358);
            this.Controls.Add(this.uiActionUgradiTekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputTekstZaUgradnju);
            this.Controls.Add(this.uiActionUcitajSliku);
            this.Controls.Add(this.uiOutputSlikaZaUcitavanje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlikaZaUcitavanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uiOutputSlikaZaUcitavanje;
        private System.Windows.Forms.Button uiActionUcitajSliku;
        private System.Windows.Forms.TextBox uiInputTekstZaUgradnju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionUgradiTekst;
    }
}

