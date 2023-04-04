using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formsApp
{
    public partial class formUpdate : Form
    {
        public formUpdate()
        {
            InitializeComponent();
        }
        flashCardClass flashCard =new flashCardClass();
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.ShowDialog();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDelete deleteform = new formDelete();
            deleteform.ShowDialog();
        }
        private void tümVerileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAllData alldataShowDialog = new formAllData();
            alldataShowDialog.ShowDialog();
        }
        private void listelerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMyList mylistform = new formMyList();
            mylistform.ShowDialog();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedtextIdUpdate.Clear();
        }
        private void formUpdate_Load(object sender, EventArgs e)
        {
            flashCard.datagridCreate(dataGridUPDATE);
            flashCard.comboboxCreate(combochooselistUpdate);
            textboxanswerUpdate.Clear();
            textboxquestionUpdate.Clear();
            maskedtextIdUpdate.Clear();
        }
        private void btnvazgecinUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #region kutucuklara girlien değerlerin veritabanındaki varlığını kontrol eden fonksiyon
        public int veriVarmi(string maskedTextBox, string column)
        {
            SqlCommand komut1 = new SqlCommand("select count(" + column + ") from data_table where " + column + "=@maskedTextBoxValue", flashCard.baglanti());
            komut1.Parameters.AddWithValue("@maskedTextBoxValue", maskedTextBox);
            int result2 = Convert.ToInt32(komut1.ExecuteScalar());
            flashCard.baglanti().Close();
            return result2;
        }
        #endregion
        private void btnsearchidUpdate_Click(object sender, EventArgs e)
        {
            #region veritabanından alınan veriyi ilgili yere bastırmak

            if (btnsearchidUpdate.Text.Length > 0)
            {
                string column = "idNumber";
                int result = veriVarmi(maskedtextIdUpdate.Text, column);//girilen id ye uygun verinin olup olmadığını sorgulayan fonksiyon
                if (result != 0)
                {// veritabanından ilgili id numaraına göre verileri bulacak ve soru cevap ksımına bastırılacak.
                    SqlCommand komut1 = new SqlCommand("select quesiton,answer,soruno,listName from data_table where idNumber=@idno",flashCard.baglanti());
                    komut1.Parameters.AddWithValue("@idno", maskedtextIdUpdate.Text);
                    komut1.Parameters.AddWithValue("@soru", maskedtextIdUpdate.Text);
                    SqlDataReader dr = komut1.ExecuteReader();
                    while(dr.Read())
                    {
                        textboxquestionUpdate.Text = dr[0].ToString();
                        textboxanswerUpdate.Text = dr[1].ToString();
                        combochooselistUpdate.SelectedItem= dr[3].ToString();
                    }
                    flashCard.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz ID numarasına uygun veri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID numarası kutucuğu boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        //kullanıcı verisini arayacak sonra eğer girdiği veri varsa kutucuklara aktarılacak sonra kullanıcı kaydet tuşuna bastığında 
        //en son kutuucklarda olana göre güncellenecek.
        private void linknewlistUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCreateList formCreate=new formCreateList();
            formCreate.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            maskedtextIdUpdate.Clear();
            textboxanswerUpdate.Clear();
            textboxquestionUpdate.Clear();
            combochooselistUpdate.Items.Clear();
        }
        private void btngüncelleupdate_Click(object sender, EventArgs e)
        {
            if (combochooselistUpdate.Text.Length != 0)
            {
                string column = "idNumber";
                int result = veriVarmi(maskedtextIdUpdate.Text, column);
                if (result!=0)
                {
                    SqlCommand komut1 = new SqlCommand("update data_table set quesiton=@yenisoru,answer=@yenicevap,listName=@liste where idNumber=@idNo", flashCard.baglanti());
                    komut1.Parameters.AddWithValue("@idNo", maskedtextIdUpdate.Text);
                    komut1.Parameters.AddWithValue("@yenisoru", textboxquestionUpdate.Text);
                    komut1.Parameters.AddWithValue("@yenicevap", textboxanswerUpdate.Text);
                    komut1.Parameters.AddWithValue("@liste", combochooselistUpdate.Text);
                    komut1.ExecuteNonQuery();
                    flashCard.baglanti().Close();
                    flashCard.datagridCreate(dataGridUPDATE);
                    MessageBox.Show("Veri Güncellenmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz ID numarasına uygun veri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Liste boş bırakılamaz!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void maskedtextIdUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            this.AcceptButton = btnsearchidUpdate;
        }
        private void textboxquestionUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            this.AcceptButton = btngüncelleupdate;
        }
        private void textboxanswerUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            this.AcceptButton = btngüncelleupdate;
        }
        private void dataGridUPDATE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenDeger =dataGridUPDATE.SelectedCells[0].RowIndex;
            maskedtextIdUpdate.Text = dataGridUPDATE.Rows[secilenDeger].Cells[0].Value.ToString();
            textboxquestionUpdate.Text = dataGridUPDATE.Rows[secilenDeger].Cells[1].Value.ToString();
            textboxanswerUpdate.Text = dataGridUPDATE.Rows[secilenDeger].Cells[2].Value.ToString();
            combochooselistUpdate.Text = dataGridUPDATE.Rows[secilenDeger].Cells[3].Value.ToString();
        }

        private void combochooselistUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridUPDATE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
