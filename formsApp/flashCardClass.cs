using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace formsApp
{
    internal class flashCardClass
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VLV4GS76\\SQLKODLAB;Initial Catalog=applicationDatabase;Integrated Security=True");
            connection.Open();
            return connection;
        }
        public void datagridCreate(DataGridView dtgrd)
        {
            flashCardClass flashCard=new flashCardClass();
            SqlDataAdapter da = new SqlDataAdapter("select idNumber,quesiton,answer,listName from data_table where answer IS NOT NULL and quesiton IS NOT  NULL ", flashCard.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgrd.DataSource = ds.Tables[0];
            flashCard.baglanti().Close();
            dtgrd.Columns[0].HeaderText = "ID Number";
            dtgrd.Columns[1].HeaderText = "Soru";
            dtgrd.Columns[2].HeaderText = "Cevap";
            dtgrd.Columns[3].HeaderText = "Liste";
            dtgrd.RowHeadersVisible = false; //Gizlenmesini sağlar 

        }
        public void comboboxCreate(ComboBox combobox)
        {
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
        public void datagridCellClick(MaskedTextBox maskedId,MaskedTextBox maskedque,MaskedTextBox maskedanswer, DataGridView dataGridView)
        {
            //hücreye tıklanınca veriyi ilgili yer aktarır.
            int secilenDeger = dataGridView.SelectedCells[0].RowIndex;
            maskedId.Text = dataGridView.Rows[secilenDeger].Cells[0].Value.ToString();
            maskedque.Text = dataGridView.Rows[secilenDeger].Cells[1].Value.ToString();
            maskedanswer.Text = dataGridView.Rows[secilenDeger].Cells[2].Value.ToString();
        }
    }
}
