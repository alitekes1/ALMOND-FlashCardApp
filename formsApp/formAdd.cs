using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formsApp
{
    public partial class formAdd : Form
    {
        public formAdd()
        {
            InitializeComponent();
        }
        formUpdate updateform = new formUpdate();
        flashCardClass flashCard = new flashCardClass();
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
        formDelete deleteform = new formDelete();
            deleteform.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateform.ShowDialog();
        }

        private void tümVerileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAllData alldataform = new formAllData();
            alldataform.ShowDialog();
        }
        private void formAdd_Load(object sender, EventArgs e)
        {
            flashCard.datagridCreate(datagridADD);
            flashCard.comboboxCreate(combochooselistAdd);
            textboxquestionAdd.Clear();
            textboxanwserAdd.Clear();
            textboxquestionAdd.Focus();
        }
        private void linklabelnewlistAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCreateList listcreateform = new formCreateList();   
            listcreateform.ShowDialog();
            combochooselistAdd.DataSource = null;
        }
        int i = 0;
        private void btnkaydetinadd_Click(object sender, EventArgs e)
        {
            if (textboxanwserAdd.Text.Length != 0 && textboxquestionAdd.Text.Length != 0)
            {
            Random rnd = new Random();
            int sayi=rnd.Next(0,5000);
            SqlCommand komut1 = new SqlCommand("insert into data_table (quesiton,answer,idNumber,listName,puan) values (@soru,@cevap,@idno,@liste,@puAn)", flashCard.baglanti());
            komut1.Parameters.AddWithValue("@soru", textboxquestionAdd.Text);
            komut1.Parameters.AddWithValue("@cevap", textboxanwserAdd.Text);
            komut1.Parameters.AddWithValue("@idno", sayi);
            komut1.Parameters.AddWithValue("@liste", combochooselistAdd.Text);
            komut1.Parameters.AddWithValue("@puAn", 0);
            komut1.ExecuteNonQuery();
            flashCard.datagridCreate(datagridADD);
            DialogResult mesaj = MessageBox.Show("Veri Kaydedilmiştir.","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            flashCard.baglanti().Close();
                if (mesaj == DialogResult.OK)
                {
                    textboxquestionAdd.Clear();
                    textboxanwserAdd.Clear();
                    textboxquestionAdd.Focus();
                }
            }
            else
            {
                MessageBox.Show("Soru ve Cevap kısımları boş bırakılamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnvazgecinadd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listelerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMyList formMylist = new formMyList();
            formMylist.ShowDialog();
        }
        private void combochooselistAdd_MouseClick(object sender, MouseEventArgs e)
        {
            flashCard.comboboxRefresh(combochooselistAdd);
        }
    }
}
