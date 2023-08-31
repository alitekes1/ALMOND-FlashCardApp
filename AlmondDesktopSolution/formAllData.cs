using System;
using System.Windows.Forms;

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
            flashCard.datagridCreatewithID(datagridAllData);
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
            formMyList myListform = new formMyList();
            myListform.ShowDialog();
        }
    }
}
