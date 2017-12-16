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
            textBox3.Select();
        }

          
        private void textBox1_Click(object sender, EventArgs e)
        {
            txt_kullanici.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txt_sifre.Clear();
            txt_sifre.PasswordChar = '*';
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kullanici.Text.Trim() == "" && txt_sifre.Text.Trim() == "")
                MessageBox.Show("Kullanici adi veya sifre alani boş");
            else
            {
                try
                {
                    baseForm form2 = new baseForm(txt_kullanici.Text);
                    form2.Visible = true;
                    this.Hide();
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.ToString());
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
