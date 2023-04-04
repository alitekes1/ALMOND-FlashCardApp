using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsApp
{
    public partial class formCreateList : Form
    {
        flashCardClass flashCard = new flashCardClass();
        public formCreateList()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textboxCREATEList.Text.Length > 0 )
            {
                Random rnd = new Random();
                int sayi=rnd.Next(0,1500);
                SqlCommand komut = new SqlCommand("insert into data_table (listName,idNumber) values (@namelist,@idNo)", flashCard.baglanti());
                komut.Parameters.AddWithValue("@namelist",textboxCREATEList.Text);
                komut.Parameters.AddWithValue("@idNo", sayi);
                komut.ExecuteNonQuery();
                flashCard.baglanti().Close();
                MessageBox.Show(textboxCREATEList.Text + " adlı liste oluşturuldu.", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxCREATEList.Clear();
            }
            else
            {
                MessageBox.Show("Liste ismi boş bırakılamaz!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void formCreateList_Load(object sender, EventArgs e)
        {

        }
    }
}
