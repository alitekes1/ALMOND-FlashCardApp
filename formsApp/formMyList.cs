using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace formsApp
{
    public partial class formMyList : Form
    {
        public formMyList()
        {
            InitializeComponent();
        }
        flashCardClass flashCard = new flashCardClass();
        private void formGroup_Load(object sender, EventArgs e)
        {
            flashCardClass flashCard = new flashCardClass();
            SqlDataAdapter da = new SqlDataAdapter("select distinct listName from data_table where listName is NOT NULL", flashCard.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridMyList.DataSource = ds.Tables[0];
            flashCard.baglanti().Close();
            datagridMyList.Columns[0].HeaderText = "Liste";
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.ShowDialog();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdate updateform = new formUpdate();
            updateform.ShowDialog();
        }
        private void oluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCreateList formCreateList1 = new formCreateList();
            formCreateList1.ShowDialog();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDeleteList deletelist = new formDeleteList();
            deletelist.ShowDialog();
        }
    }
}
