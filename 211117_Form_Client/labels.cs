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
        baseForm frm;
        DosyaIslemleri io;
        public labels(baseForm frm,DosyaIslemleri io)
        {
            this.frm = frm;
            this.io = io;
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
                lbl_kisiler[i].MouseDown += Labels_MouseDown;
                frm.grb_kisiler.Controls.Add(lbl_kisiler[i]);
            }
        }

        private void Labels_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(frm.rtx_msjlar.Lines.Length);
            //if (frm.rtx_msjlar.Lines.Length>io.eskiMetinBelgesi(frm.grb_kisi.Text) || frm.rtx_msjlar.Lines.Length==0)
            //{
            //    Console.WriteLine("Metin belgesine yeni degerler gonderildi");
            //    foreach (string satir in frm.rtx_msjlar.Lines)
            //        io.sohbettxtYaz(frm.grb_kisi.Text, satir);
            //}
            //else
            //{
            //   Console.WriteLine("Metin belgesinde degisiklik yok");
            //}
            //frm.rtx_msjlar.Text = "";
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            frm.rtx_msjlar.Clear();
            Label ogren = sender as Label;//bu eventin bir labele ait olduğunu programa bildiriyoruz ve ogren kod adı altında bu label'e ait tüm özellikleri öğrenebiliriz.
            frm.grb_kisi.Text = ogren.Text;//işte bunun gibi tıklanan label'in name değerini text değerini ve karakter uzunluğunu yazdırdım.
            io.sohbettxt(ogren.Text);
        }
        //olustur.
        public void labelleri_yenile(String[] kisiler)
        {
            if (kisiler.Length > 1)
            {
                frm.grb_kisiler.Visible = true;
                frm.lbl_kimseyok.Visible = false;
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
                frm.lbl_kimseyok.Visible = true;
                frm.grb_kisiler.Visible = false;
                frm.grb_kisi.Text = "";
                frm.rtx_msjlar.Clear();
            }
        }
    }
}
