namespace StegoProjekt
{
    partial class GlavnaForma
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
            this.uiActionUpis = new System.Windows.Forms.Button();
            this.uiActionIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiActionUpis
            // 
            this.uiActionUpis.Location = new System.Drawing.Point(24, 24);
            this.uiActionUpis.Name = "uiActionUpis";
            this.uiActionUpis.Size = new System.Drawing.Size(108, 68);
            this.uiActionUpis.TabIndex = 0;
            this.uiActionUpis.Text = "Upis u sliku";
            this.uiActionUpis.UseVisualStyleBackColor = true;
            this.uiActionUpis.Click += new System.EventHandler(this.uiActionUpis_Click);
            // 
            // uiActionIspis
            // 
            this.uiActionIspis.Location = new System.Drawing.Point(138, 24);
            this.uiActionIspis.Name = "uiActionIspis";
            this.uiActionIspis.Size = new System.Drawing.Size(108, 68);
            this.uiActionIspis.TabIndex = 0;
            this.uiActionIspis.Text = "Ispis iz slike";
            this.uiActionIspis.UseVisualStyleBackColor = true;
            this.uiActionIspis.Click += new System.EventHandler(this.uiActionIspis_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 110);
            this.Controls.Add(this.uiActionIspis);
            this.Controls.Add(this.uiActionUpis);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionUpis;
        private System.Windows.Forms.Button uiActionIspis;
    }
}