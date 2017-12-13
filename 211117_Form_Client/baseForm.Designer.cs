namespace _211117_Form_Client
{
    partial class baseForm
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
            this.rtx_msjlar = new System.Windows.Forms.RichTextBox();
            this.txt_msj = new System.Windows.Forms.TextBox();
            this.btn_msj_gndr = new System.Windows.Forms.Button();
            this.grb_kisiler = new System.Windows.Forms.GroupBox();
            this.lbl_kimseyok = new System.Windows.Forms.Label();
            this.grb_kisi = new System.Windows.Forms.GroupBox();
            this.grb_kisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtx_msjlar
            // 
            this.rtx_msjlar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtx_msjlar.Location = new System.Drawing.Point(22, 34);
            this.rtx_msjlar.Name = "rtx_msjlar";
            this.rtx_msjlar.ReadOnly = true;
            this.rtx_msjlar.Size = new System.Drawing.Size(396, 216);
            this.rtx_msjlar.TabIndex = 0;
            this.rtx_msjlar.Text = "";
            this.rtx_msjlar.TextChanged += new System.EventHandler(this.rtx_msjlar_TextChanged);
            // 
            // txt_msj
            // 
            this.txt_msj.Location = new System.Drawing.Point(23, 257);
            this.txt_msj.Name = "txt_msj";
            this.txt_msj.Size = new System.Drawing.Size(395, 20);
            this.txt_msj.TabIndex = 1;
            // 
            // btn_msj_gndr
            // 
            this.btn_msj_gndr.Location = new System.Drawing.Point(23, 284);
            this.btn_msj_gndr.Name = "btn_msj_gndr";
            this.btn_msj_gndr.Size = new System.Drawing.Size(394, 66);
            this.btn_msj_gndr.TabIndex = 2;
            this.btn_msj_gndr.Text = "Gönder";
            this.btn_msj_gndr.UseVisualStyleBackColor = true;
            this.btn_msj_gndr.Click += new System.EventHandler(this.btn_msj_gndr_Click);
            // 
            // grb_kisiler
            // 
            this.grb_kisiler.BackColor = System.Drawing.SystemColors.Control;
            this.grb_kisiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_kisiler.Location = new System.Drawing.Point(16, 12);
            this.grb_kisiler.Name = "grb_kisiler";
            this.grb_kisiler.Size = new System.Drawing.Size(196, 347);
            this.grb_kisiler.TabIndex = 3;
            this.grb_kisiler.TabStop = false;
            this.grb_kisiler.Text = "Kişiler";
            // 
            // lbl_kimseyok
            // 
            this.lbl_kimseyok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kimseyok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kimseyok.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_kimseyok.Location = new System.Drawing.Point(-6, -3);
            this.lbl_kimseyok.Name = "lbl_kimseyok";
            this.lbl_kimseyok.Size = new System.Drawing.Size(194, 54);
            this.lbl_kimseyok.TabIndex = 0;
            this.lbl_kimseyok.Text = "Mesajlasacak Kimse Yok!";
            this.lbl_kimseyok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_kimseyok.Visible = false;
            // 
            // grb_kisi
            // 
            this.grb_kisi.Controls.Add(this.rtx_msjlar);
            this.grb_kisi.Controls.Add(this.txt_msj);
            this.grb_kisi.Controls.Add(this.btn_msj_gndr);
            this.grb_kisi.Location = new System.Drawing.Point(218, 12);
            this.grb_kisi.Name = "grb_kisi";
            this.grb_kisi.Size = new System.Drawing.Size(431, 356);
            this.grb_kisi.TabIndex = 4;
            this.grb_kisi.TabStop = false;
            // 
            // baseForm
            // 
            this.AcceptButton = this.btn_msj_gndr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 371);
            this.Controls.Add(this.grb_kisi);
            this.Controls.Add(this.grb_kisiler);
            this.Controls.Add(this.lbl_kimseyok);
            this.MaximizeBox = false;
            this.Name = "baseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "baseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.baseForm_FormClosed);
            this.Load += new System.EventHandler(this.baseForm_Load);
            this.grb_kisi.ResumeLayout(false);
            this.grb_kisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_msj;
        private System.Windows.Forms.Button btn_msj_gndr;
        public System.Windows.Forms.GroupBox grb_kisiler;
        public System.Windows.Forms.GroupBox grb_kisi;
        public System.Windows.Forms.Label lbl_kimseyok;
        public System.Windows.Forms.RichTextBox rtx_msjlar;
    }
}