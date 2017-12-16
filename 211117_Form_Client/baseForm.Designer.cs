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
            this.grb_kisi = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // grb_kisi
            // 
            this.grb_kisi.Controls.Add(this.rtx_msjlar);
            this.grb_kisi.Controls.Add(this.txt_msj);
            this.grb_kisi.Controls.Add(this.btn_msj_gndr);
            this.grb_kisi.Location = new System.Drawing.Point(12, 28);
            this.grb_kisi.Name = "grb_kisi";
            this.grb_kisi.Size = new System.Drawing.Size(431, 356);
            this.grb_kisi.TabIndex = 4;
            this.grb_kisi.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAPA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseForm
            // 
            this.AcceptButton = this.btn_msj_gndr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 386);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grb_kisi);
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
        public System.Windows.Forms.GroupBox grb_kisi;
        public System.Windows.Forms.RichTextBox rtx_msjlar;
        private System.Windows.Forms.Button button1;
    }
}