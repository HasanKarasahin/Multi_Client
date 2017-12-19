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
        public Sol()
        {
            InitializeComponent();
        }
        new int Width = 1900;
        new int Height = 1080;
        private void Sol_Load(object sender, EventArgs e)
        {
            Rectangle ClientCoz = new Rectangle();
            ClientCoz = Screen.GetBounds(ClientCoz);
            float WidthOran = ((float)ClientCoz.Width / (float)Width);
            float HeightOran = ((float)ClientCoz.Height / (float)Height);
            this.Scale(WidthOran, HeightOran);
        }
    }
}
