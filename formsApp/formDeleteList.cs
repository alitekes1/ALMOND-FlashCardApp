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
    public partial class formDeleteList : Form
    {
        public formDeleteList()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti=new SqlConnection("Data Source=LAPTOP-VLV4GS76\\SQLKODLAB;Initial Catalog=applicationDatabase;Integrated Security=True");
        flashCardClass flashCard = new flashCardClass();
        private void formDeleteList_Load(object sender, EventArgs e)
        {
            flashCard.comboboxCreate(comboBoxdeleteList);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxdeleteList.Text.Length != 0)
            {
            SqlCommand komut = new SqlCommand("delete from data_table where listName=@p1", flashCard.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxdeleteList.Text);
            komut.ExecuteNonQuery();
            flashCard.baglanti().Close();
            MessageBox.Show(comboBoxdeleteList.Text+ " listesi silinmiştir.","İşlem başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            comboBoxdeleteList.Text = null;
            }
            else
            {
                MessageBox.Show("Lutfen silinecek liste seçiniz!");
            }
        }
        private void comboBoxdeleteList_MouseClick(object sender, MouseEventArgs e)
        {
            flashCard.comboboxRefresh(comboBoxdeleteList);
        }
    }
}
