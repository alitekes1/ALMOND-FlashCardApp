using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace formsApp
{
    public partial class formDelete : Form
    {
        public formDelete()
        {
            InitializeComponent();
        }
        flashCardClass flashCard = new flashCardClass();
        formUpdate updateform =new formUpdate();
        private void formDelete_Load(object sender, EventArgs e)
        {
            flashCard.datagridCreate(dataGridDELETE);
        }
        private void veriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.ShowDialog();
        }
        private void veriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        #region kutucuklara girlien değerlerin varlığını kontrol eden fonksiyon
        public int veriVarmi(string maskedTextBox, string column)
        {
            SqlCommand komut1 = new SqlCommand("select count(" + column + ") from data_table where " + column + "=@maskedTextBoxValue", flashCard.baglanti());
            komut1.Parameters.AddWithValue("@maskedTextBoxValue", maskedTextBox);
            int result2 = Convert.ToInt32(komut1.ExecuteScalar());
            flashCard.baglanti().Close();
            return result2;
        }
        #endregion
        private void btnquestionsearchDelete_Click(object sender, EventArgs e)
        {
            string column = "quesiton";
            int result = veriVarmi(msktextquesitonindelete.Text, column);
            if (msktextquesitonindelete.Text.Length != 0)
            {
                if (result != 0)
                {
                    SqlCommand komut2 = new SqlCommand("delete from data_table where quesiton=@sil", flashCard.baglanti());
                    komut2.Parameters.AddWithValue("@sil", msktextquesitonindelete.Text);
                    komut2.ExecuteNonQuery();
                    this.data_tableTableAdapter.Fill(this.enGuncelapplicationDatabaseDataSet.data_table);
                    msktextquesitonindelete.Clear();
                    maskedtextanswerindelete.Clear();
                    maskedtextIdindelete.Clear();
                    flashCard.baglanti().Close();
                    flashCard.datagridCreate(dataGridDELETE);
                    MessageBox.Show("Veri Silinmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string answer = "answer";
            int result = veriVarmi(maskedtextanswerindelete.Text, answer);
            if (maskedtextanswerindelete.Text.Length != 0)
            { 
                if (result != 0)
                {
                    SqlCommand komut2 = new SqlCommand("delete from data_table where answer=@sil", flashCard.baglanti());
                    komut2.Parameters.AddWithValue("@sil", maskedtextanswerindelete.Text);
                    komut2.ExecuteNonQuery();
                    msktextquesitonindelete.Clear();
                    maskedtextanswerindelete.Clear();
                    maskedtextIdindelete.Clear();
                    flashCard.baglanti().Close();
                    MessageBox.Show("Veri Silinmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flashCard.datagridCreate(dataGridDELETE);
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
            int result=veriVarmi(maskedtextIdindelete.Text, column);
            if (maskedtextIdindelete.Text.Length != 0)
            {
                if (result != 0)
                {
                    SqlCommand komut2 = new SqlCommand("delete from data_table where idnumber=@sil", flashCard.baglanti());
                    komut2.Parameters.AddWithValue("@sil", maskedtextIdindelete.Text);
                    komut2.ExecuteNonQuery();
                    this.data_tableTableAdapter.Fill(this.enGuncelapplicationDatabaseDataSet.data_table);
                    msktextquesitonindelete.Clear();
                    maskedtextanswerindelete.Clear();
                    flashCard.baglanti().Close();
                    maskedtextIdindelete.Clear(); MessageBox.Show("Veri Silinmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flashCard.datagridCreate(dataGridDELETE);
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
        private void msktextquesitonindelete_MouseClick(object sender, MouseEventArgs e)
        {
            formDelete.ActiveForm.AcceptButton = btnquestionsearchDelete;
        }
        private void maskedtextanswerindelete_MouseClick(object sender, MouseEventArgs e)
        {
            formDelete.ActiveForm.AcceptButton = btnanswersearchDelete;
        }
        private void maskedtextIdindelete_MouseClick(object sender, MouseEventArgs e)
        {
            formDelete.ActiveForm.AcceptButton = btnsearchidDelete ;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            msktextquesitonindelete.Clear();
            maskedtextanswerindelete.Clear();
            maskedtextIdindelete.Clear();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flashCard.datagridCellClick(maskedtextIdindelete, msktextquesitonindelete, maskedtextanswerindelete,dataGridDELETE);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
} 

