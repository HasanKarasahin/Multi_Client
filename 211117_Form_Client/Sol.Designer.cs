namespace _211117_Form_Client
{
    partial class Sol
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
            this.grb_kisiler = new System.Windows.Forms.GroupBox();
            this.lbl_kimseyok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grb_kisiler
            // 
            this.grb_kisiler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grb_kisiler.BackColor = System.Drawing.SystemColors.Control;
            this.grb_kisiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_kisiler.Location = new System.Drawing.Point(35, 32);
            this.grb_kisiler.Name = "grb_kisiler";
            this.grb_kisiler.Size = new System.Drawing.Size(196, 347);
            this.grb_kisiler.TabIndex = 7;
            this.grb_kisiler.TabStop = false;
            this.grb_kisiler.Text = "Kişiler";
            // 
            // lbl_kimseyok
            // 
            this.lbl_kimseyok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kimseyok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kimseyok.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_kimseyok.Location = new System.Drawing.Point(-2, -1);
            this.lbl_kimseyok.Name = "lbl_kimseyok";
            this.lbl_kimseyok.Size = new System.Drawing.Size(194, 54);
            this.lbl_kimseyok.TabIndex = 6;
            this.lbl_kimseyok.Text = "Mesajlasacak Kimse Yok!";
            this.lbl_kimseyok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_kimseyok.Visible = false;
            // 
            // Sol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(250, 399);
            this.Controls.Add(this.grb_kisiler);
            this.Controls.Add(this.lbl_kimseyok);
            this.Name = "Sol";
            this.Text = "Sol";
            this.Load += new System.EventHandler(this.Sol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grb_kisiler;
        public System.Windows.Forms.Label lbl_kimseyok;
    }
}