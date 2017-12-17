using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace _211117_Form_Client
{
    public partial class baseForm : Form
    {
        string kullanici_adi,verioku;
        Thread ctThread;
        labels labeller;
        DosyaIslemleri io;
        Sol sl;
        ServeraYolla SV;
        Baglanti baglanti;
        TcpClient istemci;
        public baseForm(string kullanici_adi)
        {
            InitializeComponent();
            this.kullanici_adi = kullanici_adi;
        }
        public baseForm() { }
        private void baseForm_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti = new Baglanti("127.0.0.1",8888);
                istemci=baglanti.getIstemci();
                 baglanti.getserverAkim();              
                SV = new ServeraYolla(baglanti.getserverAkim());
                SV.servera_yolla(kullanici_adi); //servara ben geldim diyoruz.
                ctThread = new Thread(gelenmesaj);
                ctThread.Start();
                io = new DosyaIslemleri(this, kullanici_adi);
                io.dosyaOlustur();
            }
            catch (Exception)
            {
                MessageBox.Show("Servera Baglanirken Hata OLustu. ");
                this.Close();
            }
            sl = new Sol();
            sl.Visible = true;
            labeller = new labels(sl,io,this);
            labeller.labelleri_olustur();
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }
        private void mesaj()
        {
            if (this.InvokeRequired) // Therad safe olmadıgı için bu kontrol ile karmaşıklık önleniyor.
                this.Invoke(new MethodInvoker(mesaj));
            else
            {
                if (!verioku.Contains("3$*$*3"))
                {
                    string[] parcalar = verioku.Split(':');
                    if (grb_kisi.Text==parcalar[0].Trim())
                    {
                        rtx_msjlar.Text += verioku+"\n";
                        io.sohbettxtYaz(parcalar[0].Trim(), rtx_msjlar.Lines[rtx_msjlar.Lines.Length - 2]);
                    }
                    else io.sohbettxtYaz(parcalar[0].Trim(), verioku);
                }
                else
                { // Serverdan gelen mesajın içerisinde bu kod var ise online kisi listesi gelmistir.Bunu işlememiz lazim.Buraya gelen liste 3$*$*3 sifresi ile gelmişti.Bu sifreden arındırdık. Arindirdigimiz listenin her bir istemcisi arasinda $ isareti var bunlarida kendı aralarında arındıracagız.
                    String[] parcalar = verioku.Substring(6, verioku.Length - 6).Split('$');
                    if (parcalar != null) labeller.labelleri_yenile(parcalar);
                }
            }
        }
        private void gelenmesaj()
        {
            try
            {
                while (true) // Sonsuz dongu.
                {
                    byte[] readByte = new byte[istemci.ReceiveBufferSize];
                    baglanti.getserverAkim().Read(readByte, 0, readByte.Length);
                    verioku = Encoding.ASCII.GetString(readByte).Replace("\0",null);
                    mesaj();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server Kapatti");
                istemci.Close();
                baglanti.getserverAkim().Close();
                ctThread.Abort();
            }
        }
        private void btn_msj_gndr_Click(object sender, EventArgs e)
        {
            rtx_msjlar.Text += kullanici_adi+" : "+txt_msj.Text+"\n";
            SV.servera_yolla(grb_kisi.Text + "..444.." +kullanici_adi+" : "+txt_msj.Text); //servara mesajı yollarken yollanan kisiyide ekleyip yolluyoruz ki servar kime gonderıldıgını bilsin.
            //MessageBox.Show(grb_kisi.Text + "..444.." + kullanici_adi + " : " + txt_msj.Text);
            txt_msj.Clear();
            txt_msj.Focus();
            io.sohbettxtYaz(grb_kisi.Text, rtx_msjlar.Lines[rtx_msjlar.Lines.Length - 2]);
        }
        private void rtx_msjlar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rtx_msjlar.SelectionStart = rtx_msjlar.Text.Length;
                rtx_msjlar.ScrollToCaret();
            }
            catch (Exception)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

 

        private void baseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SV.servera_yolla("3*3"); // servara ben ccikiyorum diyoruz.
            istemci.Close();
            baglanti.getserverAkim().Close();
            ctThread.Abort();
            Application.Exit();
        }}}
