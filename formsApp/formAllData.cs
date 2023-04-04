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

namespace formsApp
{
    public partial class formAllData : Form
    {
        public formAllData()
        {
            InitializeComponent();
        }
        flashCardClass flashCard = new flashCardClass();
        private void formAllData_Load(object sender, EventArgs e)
        {
            flashCard.datagridCreate(datagridAllData);
        }
        private void tümVerileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.ShowDialog();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDelete deleteform = new formDelete();
            deleteform.ShowDialog();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdate updateform = new formUpdate();   
            updateform.ShowDialog();
        }
        private void listelerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMyList myListform=new formMyList();
            myListform.ShowDialog();
        }
    }
}
