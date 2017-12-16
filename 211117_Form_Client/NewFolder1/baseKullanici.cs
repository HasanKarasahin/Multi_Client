using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class baseKullanici : Form
    {
        labels labeller;
        DosyaIslemleri io;
        baseChat bsChat;
        string kullaniciadi;
        public baseKullanici(string kullaniciadi,baseChat bsChat)
        {
            InitializeComponent();
            this.bsChat = bsChat;
            this.kullaniciadi = kullaniciadi;
        }

        private void baseKullanici_Load(object sender, EventArgs e)
        {
            labeller = new labels(this, bsChat,io);
            labeller.labelleri_olustur();
        }
    }
}
