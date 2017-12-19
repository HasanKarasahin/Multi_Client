using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _211117_Form_Client
{
    class ServeraYolla
    {
        public static NetworkStream serverAkim;
        public ServeraYolla(NetworkStream serverAkima)
        {
            if(serverAkim==null)
            serverAkim = serverAkima;
        }
        public ServeraYolla()
        {

        }
        public void servera_yolla(string mesaj)
        {
            Console.Write("Mesaj Geldi  :  "+mesaj);
            byte[] readByte = Encoding.ASCII.GetBytes(mesaj); // Kullanici adimizi/mesajımızı byte[] ceviriyoruz.
            serverAkim.Write(readByte, 0, readByte.Length); // Servera byte[] yolluyoruz.
            serverAkim.Flush();  // Akimi temizliyoruz.
        }
    }
}
