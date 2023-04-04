using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace formsApp
{
    public partial class formPuanTable : Form
    {
        public formPuanTable()
        {
            InitializeComponent();
        }
        flashCardClass flashCard = new flashCardClass();    
        private void formMyMistakes_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select quesiton,answer,puan from data_table where puan>=0 order by puan asc", flashCard.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "data_table");
            datagridPuanTable.DataSource = ds.Tables[0];
            datagridPuanTable.Columns[0].HeaderText = "Soru";
            datagridPuanTable.Columns[1].HeaderText = "Cevap";
            datagridPuanTable.Columns[2].HeaderText = "Puan";
            flashCard.baglanti().Close();
        }
    }
}
