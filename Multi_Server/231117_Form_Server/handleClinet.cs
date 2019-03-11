using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace _231117_Form_Server
{
    public class handleClinet
    {
        TcpClient gelenistemci;
        Hashtable istemciListesi;
        string kullanici_adi;
        Thread ctThread;
        Form1 frm;
        public void startClient(TcpClient gelenistemci, string kullanici_adi, Hashtable istemciListesi, Form1 frm)
        {
            this.gelenistemci = gelenistemci;
            this.kullanici_adi = kullanici_adi;
            this.istemciListesi = istemciListesi;
            this.frm = frm;
            ctThread = new Thread(sohbetEt);
            ctThread.Start();
        }
        private void sohbetEt()
        {
            while (true) // Sonsuz dongü. // istemciden gelen mesajları dınlıyor.
            {
                NetworkStream gelen_akim;
                try
                {
                    gelen_akim = gelenistemci.GetStream();
                    byte[] readByte = new byte[gelenistemci.ReceiveBufferSize];
                    gelen_akim.Read(readByte, 0, readByte.Length);
                    string dataFromClient = Encoding.ASCII.GetString(readByte).Replace("\0", null); ;

                    if (dataFromClient != "3*3")
                    {
                        frm.rtb_log.Text += "\n" + "İstemciden Gelen : - " + kullanici_adi + " : " + dataFromClient;
                        frm.kisiye_mesaj(dataFromClient, kullanici_adi);
                    }
                    else
                    {
                        frm.istemciListesi.Remove(kullanici_adi);
                        frm.listeleriGuncelle();
                        break;
                    }
                }
                catch (Exception)
                {
                    frm.rtb_log.Text += "\n" + "Hata Oluştu";
                    break;
                }
            }
        }
    }
}
