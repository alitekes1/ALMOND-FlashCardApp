using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace formsApp
{
    internal class flashCardClass
    {
        public SqlConnection baglanti()
        {//sql için gerekli olan baglanti adresi
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VLV4GS76\\SQLKODLAB;Initial Catalog=applicationDatabase;Integrated Security=True");
            connection.Open();
            return connection;
        }
        public void datagridCreate(DataGridView dtgrd)
        {//datagride verileri oluşturur.
            flashCardClass flashCard = new flashCardClass();
            SqlDataAdapter da = new SqlDataAdapter("select idNumber,quesiton,answer,listName from data_table where answer IS NOT NULL order by puan desc", flashCard.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgrd.DataSource = ds.Tables[0];
            flashCard.baglanti().Close();
            dtgrd.Columns[0].HeaderText = "ID Number";
            dtgrd.Columns[0].Visible = false;
            dtgrd.Columns[1].HeaderText = "Soru";
            dtgrd.Columns[2].HeaderText = "Cevap";
            dtgrd.Columns[3].HeaderText = "Liste";
            dtgrd.RowHeadersVisible = false; // data griddeki en sağda bulunan boş sutunun gizlenmesini sağlar 

        }
        public void comboboxCreate(ComboBox combobox)
        {//sql den combobaxa verileri çeker.
            flashCardClass flashCard = new flashCardClass();
            SqlCommand komut1 = new SqlCommand("select distinct listName from data_table", flashCard.baglanti());
            combobox.DataSource = null;
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                combobox.Items.Add(dr["listName"]);
            }
            flashCard.baglanti().Close();
        }
        public void comboboxRefresh(ComboBox combobox)
        {
            combobox.Items.Clear();
            comboboxCreate(combobox);
        }
        public void datagridCellClick(MaskedTextBox maskedId, MaskedTextBox maskedque, MaskedTextBox maskedanswer, DataGridView dataGridView)
        {
            //hücreye tıklanınca veriyi ilgili yer aktarır.
            int secilenDeger = dataGridView.SelectedCells[0].RowIndex;
            maskedId.Text = dataGridView.Rows[secilenDeger].Cells[0].Value.ToString();
            maskedque.Text = dataGridView.Rows[secilenDeger].Cells[1].Value.ToString();
            maskedanswer.Text = dataGridView.Rows[secilenDeger].Cells[2].Value.ToString();
        }
    }
}
