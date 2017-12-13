using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211117_Form_Client
{
    public class DosyaIslemleri
    {
        baseForm frm;
        string kullaniciadi;

        public DosyaIslemleri(baseForm frm,string kullaniciadi)
        {
            this.frm = frm;
            this.kullaniciadi = kullaniciadi;
        }
        public DosyaIslemleri() { }
        public void dosyaOlustur()
        {
            String klasorAdres = @"C:\Users\" + Environment.UserName + @"\NaberChat\"+kullaniciadi;
            Directory.CreateDirectory(klasorAdres);
        }
         
        public void sohbettxt(string kisi)
        {
          
            String sohbetadresi = @"C:\Users\" + Environment.UserName + @"\NaberChat\" + kullaniciadi + @"\" + kisi + ".txt";
            string deger=" ";
            Console.WriteLine(sohbetadresi);
            if (File.Exists(sohbetadresi))//dosya var mı yok mu
            {
                StreamReader oku = new StreamReader(sohbetadresi);
                deger = oku.ReadLine();
                frm.rtx_msjlar.Text = "";
                while (deger != null)
                {
                    frm.rtx_msjlar.Text += deger+"\n";
                    deger = oku.ReadLine();
                }
                oku.Close();
            }
            else
            {
                FileStream fs = File.Create(sohbetadresi);//NabarChat klasörüne metinbelgesi oluşturma
                fs.Close();
            }
        }
        public void sohbettxtYaz(string kisi,string msj)
        {
            String sohbetadresi = @"C:\Users\" + Environment.UserName + @"\NaberChat\" + kullaniciadi + @"\" + kisi.Trim() + ".txt";
            StreamWriter sw = File.AppendText(sohbetadresi);
            sw.WriteLine(msj);
            sw.Flush();
            sw.Close();
        }
    }
}
