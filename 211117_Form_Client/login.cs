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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kullanici.Text.Trim() == "" && txt_sifre.Text.Trim()== "")
                MessageBox.Show("Kullanici adi veya sifre alani boş");
            else
            {
                baseForm form2 = new baseForm(txt_kullanici.Text);
                form2.Show();
                this.Hide();
            }
        }
    }
}
