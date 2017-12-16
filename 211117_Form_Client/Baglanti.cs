using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _211117_Form_Client
{
    class Baglanti
    {
        private TcpClient istemci = new TcpClient(); // TcpClient nesnesi olusturuluyor.
        private NetworkStream serverAkim;
        public Baglanti(string ip,int port)
        {
            istemci.Connect(ip, port);
            serverAkim = getIstemci().GetStream();
        }
        public TcpClient getIstemci()
        {
            return istemci;
        }
        public NetworkStream getserverAkim()
        {
            return serverAkim;
        }
    }
}
