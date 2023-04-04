using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsApp
{
    public partial class hakkımda : Form
    {
        public hakkımda()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/ali-teke%C5%9F-b23aba247/";
            System.Diagnostics.Process.Start(url);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/alitekes1";
            System.Diagnostics.Process.Start(url);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string recipient = "alitekes123@gmail.com";
            string subject = "Almond hakkında";
            string body = "Merhaba Ali, ";

            string mailtoUrl = string.Format("mailto:{0}?subject={1}&body={2}", recipient, subject, body);
            System.Diagnostics.Process.Start(mailtoUrl);
        }
        private void hakkımda_Load(object sender, EventArgs e)
        {
        }
    }
}
