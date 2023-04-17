using System;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace formsApp
{
    public partial class formDelete : Form
    {
        public formDelete()
        {
            InitializeComponent();
        }
        flashCardClass flashCard = new flashCardClass();
        private void formDelete_Load(object sender, EventArgs e)
        {
            flashCard.datagridCreate(datagridDelete);
        }
        private void veriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.ShowDialog();
        }
        private void veriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdate updateform = new formUpdate();
            updateform.ShowDialog();
        }
        private void tümVerileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAllData allDataform = new formAllData();
            allDataform.ShowDialog();
        }
        private void listelerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMyList myListform = new formMyList();
            myListform.ShowDialog();
        }
        public int veriVarmi(string maskedTextBox, string column)//kullanıcının girdiği verinın varlığını sorgular.
        {
            SqlCommand komut1 = new SqlCommand("select count(" + column + ") from data_table where " + column + "=@maskedTextBoxValue", flashCard.baglanti());
            komut1.Parameters.AddWithValue("@maskedTextBoxValue", maskedTextBox);
            int result2 = Convert.ToInt32(komut1.ExecuteScalar());
            flashCard.baglanti().Close();
            return result2;
        }
        public void deleteData(string column, MaskedTextBox msktxtbox)//veri silme işlemi
        {
            SqlCommand komut = new SqlCommand("DELETE FROM data_table WHERE " + column + " = @deger", flashCard.baglanti());
            komut.Parameters.AddWithValue("@deger", msktxtbox.Text);
            komut.ExecuteNonQuery();
            flashCard.baglanti().Close();
            msktextquesitonindelete.Clear();
            maskedtextanswerindelete.Clear();
            maskedtextIdindelete.Clear(); MessageBox.Show("Veri Silinmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            flashCard.datagridCreate(datagridDelete);
        }
        private void btnquestionsearchDelete_Click(object sender, EventArgs e)
        {
            string column = "quesiton";
            int result = veriVarmi(msktextquesitonindelete.Text, column);//veritabanında verinin varlığını kontrol eder
            if (msktextquesitonindelete.Text.Length != 0)//kutucukta verinin varlığını kontrol eder.
            {
                if (result > 0)//>0 olmasının sebebi bir veriden birden fazla olabilir.
                {
                    deleteData(column, msktextquesitonindelete);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz soruya uygun veri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Soru Kutucuğu boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnanswersearchDelete_Click(object sender, EventArgs e)
        {
            string column = "answer";
            int result = veriVarmi(maskedtextanswerindelete.Text, column);//veritabanında verinin varlığını kontrol eder
            if (maskedtextanswerindelete.Text.Length != 0)//kutucukta verinin varlığını kontrol eder.
            {
                if (result != 0)
                {
                    deleteData(column, maskedtextanswerindelete);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz cevaba uygun veri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cevap Kutucuğu boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsearchidDelete_Click(object sender, EventArgs e)
        {
            string column = "idNumber";
            int result = veriVarmi(maskedtextIdindelete.Text, column);//veritabanında verinin varlığını kontrol eder
            if (maskedtextIdindelete.Text.Length != 0)//kutucukta verinin varlığını kontrol eder.
            {
                if (result != 0)
                {
                    deleteData(column, maskedtextIdindelete);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz ID numarasına uygun veri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Kutucuğu boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kullanıcı id,soru,cevap kutucuklarından hangisine göre silme işlemi yapacaksa accept buton o olacaktır.
        private void msktextquesitonindelete_MouseClick(object sender, MouseEventArgs e)
        {
            formDelete.ActiveForm.AcceptButton = btnquesitonDelete;
        }
        private void maskedtextanswerindelete_MouseClick(object sender, MouseEventArgs e)
        {
            formDelete.ActiveForm.AcceptButton = btnanswerDelete;
        }
        private void maskedtextIdindelete_MouseClick(object sender, MouseEventArgs e)
        {
            formDelete.ActiveForm.AcceptButton = btnidDelete;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //kullanıcının datagriddeki hücreye çift tıklayınca verilerin textbox lara aktarılmasını sağlar.
            flashCard.datagridCellClick(maskedtextIdindelete, msktextquesitonindelete, maskedtextanswerindelete, datagridDelete);
        }
    }
}

