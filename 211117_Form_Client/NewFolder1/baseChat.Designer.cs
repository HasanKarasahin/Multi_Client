namespace Client
{
    partial class baseChat
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
            this.grb_kisi = new System.Windows.Forms.GroupBox();
            this.btn_msj_gndr = new System.Windows.Forms.Button();
            this.txt_msj = new System.Windows.Forms.TextBox();
            this.rtx_msjlar = new System.Windows.Forms.RichTextBox();
            this.grb_kisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_kisi
            // 
            this.grb_kisi.Controls.Add(this.btn_msj_gndr);
            this.grb_kisi.Controls.Add(this.txt_msj);
            this.grb_kisi.Controls.Add(this.rtx_msjlar);
            this.grb_kisi.Location = new System.Drawing.Point(12, 12);
            this.grb_kisi.Name = "grb_kisi";
            this.grb_kisi.Size = new System.Drawing.Size(260, 237);
            this.grb_kisi.TabIndex = 0;
            this.grb_kisi.TabStop = false;
            this.grb_kisi.Text = "groupBox1";
            // 
            // btn_msj_gndr
            // 
            this.btn_msj_gndr.Location = new System.Drawing.Point(85, 163);
            this.btn_msj_gndr.Name = "btn_msj_gndr";
            this.btn_msj_gndr.Size = new System.Drawing.Size(75, 23);
            this.btn_msj_gndr.TabIndex = 2;
            this.btn_msj_gndr.Text = "button1";
            this.btn_msj_gndr.UseVisualStyleBackColor = true;
            // 
            // txt_msj
            // 
            this.txt_msj.Location = new System.Drawing.Point(20, 137);
            this.txt_msj.Name = "txt_msj";
            this.txt_msj.Size = new System.Drawing.Size(207, 20);
            this.txt_msj.TabIndex = 1;
            // 
            // rtx_msjlar
            // 
            this.rtx_msjlar.Location = new System.Drawing.Point(20, 19);
            this.rtx_msjlar.Name = "rtx_msjlar";
            this.rtx_msjlar.Size = new System.Drawing.Size(207, 112);
            this.rtx_msjlar.TabIndex = 0;
            this.rtx_msjlar.Text = "";
            // 
            // baseChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grb_kisi);
            this.Name = "baseChat";
            this.Text = "baseChat";
            this.Load += new System.EventHandler(this.baseChat_Load);
            this.grb_kisi.ResumeLayout(false);
            this.grb_kisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grb_kisi;
        public System.Windows.Forms.TextBox txt_msj;
        public System.Windows.Forms.RichTextBox rtx_msjlar;
        public System.Windows.Forms.Button btn_msj_gndr;
    }
}