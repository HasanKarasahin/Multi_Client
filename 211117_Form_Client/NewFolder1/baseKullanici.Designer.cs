namespace Client
{
    partial class baseKullanici
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
            this.lbl_kimseyok = new System.Windows.Forms.Label();
            this.grb_kisiler = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbl_kimseyok
            // 
            this.lbl_kimseyok.AutoSize = true;
            this.lbl_kimseyok.Location = new System.Drawing.Point(72, 23);
            this.lbl_kimseyok.Name = "lbl_kimseyok";
            this.lbl_kimseyok.Size = new System.Drawing.Size(54, 13);
            this.lbl_kimseyok.TabIndex = 0;
            this.lbl_kimseyok.Text = "kimse yok";
            // 
            // grb_kisiler
            // 
            this.grb_kisiler.Location = new System.Drawing.Point(46, 61);
            this.grb_kisiler.Name = "grb_kisiler";
            this.grb_kisiler.Size = new System.Drawing.Size(180, 142);
            this.grb_kisiler.TabIndex = 1;
            this.grb_kisiler.TabStop = false;
            this.grb_kisiler.Text = "groupBox1";
            // 
            // baseKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grb_kisiler);
            this.Controls.Add(this.lbl_kimseyok);
            this.Name = "baseKullanici";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.baseKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_kimseyok;
        public System.Windows.Forms.GroupBox grb_kisiler;
    }
}

