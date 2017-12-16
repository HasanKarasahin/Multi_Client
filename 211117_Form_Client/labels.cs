using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211117_Form_Client
{
    public class labels
    {
        Sol sl;
        DosyaIslemleri io;
        baseForm frm;
        public labels(Sol sl,DosyaIslemleri io,baseForm frm)
        {
            this.sl = sl;
            this.io = io;
            this.frm = frm;
        }

        public Label[] lbl_kisiler = new Label[10];
        public void labelleri_olustur()
        {
            for (int i = 0; i < lbl_kisiler.Length; i++)
            {
                lbl_kisiler[i] = new Label();
                lbl_kisiler[i].Name = "lbl_kisi" + i;
                lbl_kisiler[i].Visible = true;
                lbl_kisiler[i].Left = 10;
                lbl_kisiler[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lbl_kisiler[i].Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl_kisiler[i].Location = new System.Drawing.Point(10, 40 + i * 50);
                lbl_kisiler[i].Size = new System.Drawing.Size(82, 27);
                lbl_kisiler[i].Text = "";
                lbl_kisiler[i].Click += Labels_Click;// label'imize clilck eventi ekledik.
                sl.grb_kisiler.Controls.Add(lbl_kisiler[i]);
            }
        }
        private void Labels_Click(object sender, EventArgs e)
        {
            frm.rtx_msjlar.Clear();
            Label ogren = sender as Label;//bu eventin bir labele ait olduğunu programa bildiriyoruz ve ogren kod adı altında bu label'e ait tüm özellikleri öğrenebiliriz.
            frm.grb_kisi.Text = ogren.Text;//işte bunun gibi tıklanan label'in name değerini text değerini ve karakter uzunluğunu yazdırdım.
            io.sohbettxt(ogren.Text);
            frm.Opacity = 100;
        }
        //olustur.
        public void labelleri_yenile(String[] kisiler)
        {
            if (kisiler.Length > 1)
            {
                sl.grb_kisiler.Visible = true;
                sl.lbl_kimseyok.Visible = false;
                for (int i = 0; i < lbl_kisiler.Length; i++)
                {
                    lbl_kisiler[i].Visible = false;
                    lbl_kisiler[i].Text = null;
                } 
                   
                for (int i = 0; i < kisiler.Length - 1; i++)
                {
                    lbl_kisiler[i].Visible = true;
                    lbl_kisiler[i].Text = kisiler[i].ToString();
                }
                
            }
            else
            {
                sl.lbl_kimseyok.Visible = true;
                sl.grb_kisiler.Visible = false;
                //frm.grb_kisi.Text = "";
                //frm.rtx_msjlar.Clear();
            }
        }
    }
}
