﻿namespace _211117_Form_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_kisi = new System.Windows.Forms.Label();
            this.rtx_msjlar = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_msj_gndr = new System.Windows.Forms.Button();
            this.txt_msj = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 186);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.grb_kisi);
            this.panel3.Location = new System.Drawing.Point(6, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 74);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grb_kisi
            // 
            this.grb_kisi.AutoSize = true;
            this.grb_kisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grb_kisi.Location = new System.Drawing.Point(81, 14);
            this.grb_kisi.Name = "grb_kisi";
            this.grb_kisi.Size = new System.Drawing.Size(92, 31);
            this.grb_kisi.TabIndex = 0;
            this.grb_kisi.Text = "Necati";
            // 
            // rtx_msjlar
            // 
            this.rtx_msjlar.BackColor = System.Drawing.Color.Ivory;
            this.rtx_msjlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtx_msjlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtx_msjlar.Location = new System.Drawing.Point(6, 120);
            this.rtx_msjlar.Name = "rtx_msjlar";
            this.rtx_msjlar.Size = new System.Drawing.Size(326, 270);
            this.rtx_msjlar.TabIndex = 1;
            this.rtx_msjlar.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_msj_gndr);
            this.panel2.Controls.Add(this.txt_msj);
            this.panel2.Location = new System.Drawing.Point(6, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 63);
            this.panel2.TabIndex = 2;
            // 
            // btn_msj_gndr
            // 
            this.btn_msj_gndr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_msj_gndr.Location = new System.Drawing.Point(236, 19);
            this.btn_msj_gndr.Name = "btn_msj_gndr";
            this.btn_msj_gndr.Size = new System.Drawing.Size(90, 36);
            this.btn_msj_gndr.TabIndex = 2;
            this.btn_msj_gndr.Text = "GÖNDER";
            this.btn_msj_gndr.UseVisualStyleBackColor = true;
            this.btn_msj_gndr.Click += new System.EventHandler(this.btn_msj_gndr_Click);
            // 
            // txt_msj
            // 
            this.txt_msj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_msj.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_msj.Location = new System.Drawing.Point(7, 19);
            this.txt_msj.Name = "txt_msj";
            this.txt_msj.Size = new System.Drawing.Size(203, 33);
            this.txt_msj.TabIndex = 1;
            // 
            // baseForm
            // 
            this.AcceptButton = this.btn_msj_gndr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(342, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtx_msjlar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "baseForm";
            this.Text = "N\'aberÇet";
            this.Load += new System.EventHandler(this.baseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox rtx_msjlar;
        public System.Windows.Forms.TextBox txt_msj;
        public System.Windows.Forms.Button btn_msj_gndr;
        public System.Windows.Forms.Label grb_kisi;
    }
}