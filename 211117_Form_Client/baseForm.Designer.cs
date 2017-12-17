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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 186);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 3);
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
            this.panel3.Location = new System.Drawing.Point(30, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 74);
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
            this.grb_kisi.Size = new System.Drawing.Size(0, 31);
            this.grb_kisi.TabIndex = 0;
            // 
            // rtx_msjlar
            // 
            this.rtx_msjlar.BackColor = System.Drawing.Color.Ivory;
            this.rtx_msjlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtx_msjlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtx_msjlar.Location = new System.Drawing.Point(30, 128);
            this.rtx_msjlar.Name = "rtx_msjlar";
            this.rtx_msjlar.Size = new System.Drawing.Size(735, 516);
            this.rtx_msjlar.TabIndex = 1;
            this.rtx_msjlar.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_msj_gndr);
            this.panel2.Controls.Add(this.txt_msj);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(30, 643);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 74);
            this.panel2.TabIndex = 2;
            // 
            // btn_msj_gndr
            // 
            this.btn_msj_gndr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_msj_gndr.Location = new System.Drawing.Point(642, 11);
            this.btn_msj_gndr.Name = "btn_msj_gndr";
            this.btn_msj_gndr.Size = new System.Drawing.Size(90, 49);
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
            this.txt_msj.Size = new System.Drawing.Size(629, 33);
            this.txt_msj.TabIndex = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(735, 74);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.CornerRadius = 4;
            this.rectangleShape1.Location = new System.Drawing.Point(7, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(630, 48);
            // 
            // baseForm
            // 
            this.AcceptButton = this.btn_msj_gndr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(798, 717);
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox rtx_msjlar;
        public System.Windows.Forms.TextBox txt_msj;
        public System.Windows.Forms.Button btn_msj_gndr;
        public System.Windows.Forms.Label grb_kisi;
    }
}