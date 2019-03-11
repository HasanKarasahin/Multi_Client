using System;
using System.Collections;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _231117_Form_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public Hashtable istemciListesi = new Hashtable();
        TcpListener serverSocket;
        TcpClient gelenistemci;
        NetworkStream akim;
        byte[] readByte; // byte array oluşturuyoruz.
        string kullanici_adi = null;
        private void btn_baslat_Click(object sender, EventArgs e)
        {
            try
            {//System.Net.IPAddress.Parse("192.168.1.185")192.168.43.92 //System.Net.IPAddress.Loopback
                serverSocket = new TcpListener(System.Net.IPAddress.Parse("127.0.0.1"), 8888);//Hangi ipyi ve portu dinleyecegimizi buraya yaziyoruz.
                serverSocket.Start();
                rtb_log.Text = "Server Baslatıldı.";
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception){MessageBox.Show("Baglanirken Hata Olustu");}
        }
        public void gelen_istemciler()
        {
            while (true)
            {
                try
                {
                    gelenistemci = serverSocket.AcceptTcpClient(); // Gelen istemciyi kabul ediyoruz.
                    akim = gelenistemci.GetStream(); // Clientlardan gelen kullaniciadi bilgisi bu fonksiyonda.Gelen kullanicini adini NetworkStream a aktariyoruz.
                    readByte = new byte[gelenistemci.ReceiveBufferSize]; // byte[] a gelen kullaniciadinin boyutunu atıyoruz.
                    akim.Read(readByte, 0, readByte.Length); // NetworkStream'de olan kullaniciadini byte[] 'a yaziyoruz.
                    kullanici_adi = Encoding.ASCII.GetString(readByte).Replace("\0", null); // byte[] da olan kullaniciadini string e ceviriyoruz.
                    istemciListesi.Add(kullanici_adi, gelenistemci); // istemcilistesine yeni gelen istemciyi ekliyoruz.
                    listeleriGuncelle();//yeni gelen istemciyle birlikte diger istemcilerinde listelerini guncelliyorum.
                    rtb_log.Text += "\n" + kullanici_adi + " Chat odasına katıldı. \n";
                    handleClinet istemci = new handleClinet();
                    istemci.startClient(gelenistemci, kullanici_adi, istemciListesi, this);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void listeleriGuncelle()
        {
            foreach (DictionaryEntry client in istemciListesi)
                istemciye_guncel_liste(client.Key.ToString(), (TcpClient)client.Value);
        }
        public void istemciye_guncel_liste(string kullanici_adi, TcpClient gelenistemci)
        {
            try
            {
                byte[] ReadByte;
                TcpClient gonderilecek_istemci = gelenistemci;
                NetworkStream gelen_akim = gelenistemci.GetStream();
                string gonderilen_liste = onlinekisilerlistesi(kullanici_adi);
                rtb_log.Text += "\n"+kullanici_adi + " kisisine liste yollandi : " + gonderilen_liste;
                ReadByte = Encoding.ASCII.GetBytes(gonderilen_liste);
                gelen_akim.Write(ReadByte, 0, ReadByte.Length);
                gelen_akim.Flush();
            }
            catch (Exception)
            {
                rtb_log.Text += "\n Hata";
            }
        }

        public string onlinekisilerlistesi(string kullanici_adi)
        {
            string online_kisiler = "3$*$*3";
            foreach (DictionaryEntry istemci in istemciListesi)
                if (istemci.Key.ToString() != kullanici_adi)
                    online_kisiler += istemci.Key.ToString() + "$";
            return online_kisiler;
        }

        public void kisiye_mesaj(string mesaj, string gonderen)
        {
            String[] parcalar = mesaj.Split(new[] { "..444.." }, StringSplitOptions.None);
            foreach (DictionaryEntry client in istemciListesi)
            {
                if ((string)client.Key == parcalar[0])
                {
                    byte[] ReadByte;
                    TcpClient gonderilecek_istemci = (TcpClient)client.Value;
                    NetworkStream gelen_akim = gonderilecek_istemci.GetStream();
                    ReadByte = Encoding.ASCII.GetBytes(parcalar[1]);
                    gelen_akim.Write(ReadByte, 0, ReadByte.Length);
                    gelen_akim.Flush();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            gelen_istemciler();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            rtb_log.Clear();
        }
    }
}
