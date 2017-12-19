using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211117_Form_Client
{
    public partial class Sol : Form
    {
        ServeraYolla SV;
        public Sol()
        {
            InitializeComponent();
            SV = new ServeraYolla();
        }
        private void Sol_Load(object sender, EventArgs e)
        {
           
        }
        private void Sol_FormClosing(object sender, FormClosingEventArgs e)
        {
            SV.servera_yolla("3*3"); // servara ben ccikiyorum diyoruz.
            //istemci.Close();
            //baglanti.getserverAkim().Close();
            //ctThread.Abort();
            Application.Exit();
        }
    }
}
