using Almond;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace formsApp
{
    public partial class FormMainpage : Form
    {
        public FormMainpage()
        {
            InitializeComponent();
        }
        flashCardClass flashCard = new flashCardClass();
        public int i = 0;
        public int j = 0;
        private void veriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.Show();
        }

        private void veriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDelete deleteform = new formDelete();
            deleteform.ShowDialog();
        }
        private void verileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdate updateform = new formUpdate();
            updateform.ShowDialog();
        }
        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAllData alldataShowDialog = new formAllData();
            alldataShowDialog.Show();
            MessageBox.Show("Bu sayfayı verileri daha iyi görebilmek için TAM EKRAN yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void listeSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formDeleteList listdeleteform = new formDeleteList();
            listdeleteform.ShowDialog();
        }
        private void listeOluşturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCreateList formCreateList2 = new formCreateList();
            formCreateList2.ShowDialog();
        }
        private void tümListelerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMyList formMylistt = new formMyList();
            formMylistt.Show();
            MessageBox.Show("Bu sayfayı verileri daha iyi görebilmek için TAM EKRAN yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void isChooseList()//listenin seçilip seçilmediğini kontrol eder.
        {
            if (comboboxlisteMain.Text.Length == 0)
            {

                btnpuan1.Enabled = false;
                btnpuan2.Enabled = false;
                btnpuan3.Enabled = false;
                btnpuan4.Enabled = false;
                btnpuan5.Enabled = false;
                btnshowanswerMain.Enabled = false;
                btnshowanswerMain.Text = "Liste Seçiniz!";
            }
            else
            {
                btnshowanswerMain.Text = "Cevabı Göster";
                btnpuan1.Enabled = true;
                btnpuan2.Enabled = true;
                btnpuan3.Enabled = true;
                btnpuan4.Enabled = true;
                btnpuan5.Enabled = true;
                btnshowanswerMain.Enabled = true;
            }
        }
        private void FormMainpage_Load(object sender, EventArgs e)
        {
            isChooseList();
            flashCard.comboboxCreate(comboboxlisteMain);
        }
        private void comboboxlisteMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelsoru.Visible = true;
            i = 0;
            j = 0;
            SqlCommand komut = new SqlCommand("select quesiton,answer,listName,puan,soruNo from data_table where listName=@list and answer is not null order by puan asc", flashCard.baglanti());//seçilen listeye göre data gride verileri aktarır ve puan artan şekilde sıralar
            komut.Parameters.AddWithValue("@list", comboboxlisteMain.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridMain.DataSource = ds.Tables[0];
            flashCard.baglanti().Close();
            isChooseList();
            if (i < datagridMain.Rows.Count - 1)
            {//ilgili hücredeki veriyi label a aktarır.
                labelsoru.Text = datagridMain.Rows[i].Cells[0].Value.ToString();
                labelSoruNo.Text = datagridMain.Rows[i].Cells[4].Value.ToString();
                i++;
            }
        }
        private void btnShowDialoganswerMain_Click(object sender, EventArgs e)
        {
            labelcevap.Visible = true;
            labelcevap.Text = datagridMain.Rows[j].Cells[1].Value.ToString();//cevabı göster butonuna basıldığında
        }
        private void showCard()
        {
            
            labelcevap.Visible = false;
            ///soruyu ekrana yazdırma
            if (i < datagridMain.Rows.Count - 1)//datagridin son satırına gelene kadar git ve hücreyi labela aktar
            {
                labelsoru.Text = datagridMain.Rows[i].Cells[0].Value.ToString();
                labelSoruNo.Text = datagridMain.Rows[i].Cells[4].Value.ToString();
                i++;
            }
            /// cevabı ekrana yazırma 
            if (j < datagridMain.Rows.Count - 1)//datagridin son satırına kadar git ve hücreyi labela aktar
            {
                labelcevap.Text = datagridMain.Rows[j].Cells[1].Value.ToString();
                j++;
            }

            if (j == datagridMain.Rows.Count - 1)//listedeki tüm kartlar gözüktüyse
            {
                btnpuan1.Enabled = false;
                btnpuan2.Enabled = false;
                btnpuan3.Enabled = false;
                btnpuan4.Enabled = false;
                btnpuan5.Enabled = false;
                labelsoru.Visible = false;
                btnshowanswerMain.Enabled = false;
                MessageBox.Show("Seçili listeye ait tüm kartları gözden geçirdiniz.Başka listelerle devam etmek istiyorsanız tekrar liste seçiniz.", "Liste Sonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxlisteMain.Text = "";
            }
        }
        private void puanUpdate(Label label, int artis)//puan artırma fonksiyonu
        {
            SqlCommand komut = new SqlCommand("update data_table set puan+=@p2 where soruNo=@p1", flashCard.baglanti());
            komut.Parameters.AddWithValue("@p2", artis);
            komut.Parameters.AddWithValue("@p1", label.Text.ToString());
            komut.ExecuteNonQuery();
            flashCard.baglanti().Close();
        }
        private void btnpuan1_Click(object sender, EventArgs e)
        {
            int artis = 1;
            puanUpdate(labelSoruNo, artis);
            showCard();
        }
        private void btnpuan2_Click(object sender, EventArgs e)
        {
            int artis = 2;
            puanUpdate(labelSoruNo, artis);
            showCard();
        }
        private void butonpuan3_Click(object sender, EventArgs e)
        {
            int artis = 3;
            puanUpdate(labelSoruNo, artis);
            showCard();
        }
        private void btnpuan4_Click(object sender, EventArgs e)
        {
            int artis = 4;
            puanUpdate(labelSoruNo, artis);
            showCard();

        }
        private void btnpuan5_Click(object sender, EventArgs e)
        {
            int artis = 5;
            puanUpdate(labelSoruNo, artis);
            showCard();
        }
        private void enÇokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPuanTable formMyMistakes1 = new formPuanTable();
            formMyMistakes1.Show();
        }
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void comboboxlisteMain_MouseClick(object sender, MouseEventArgs e)
        {
            flashCard.comboboxRefresh(comboboxlisteMain);//comboboxa tıkalayınca refresh eder
        }

        private void bilgiAlmakİçinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımda hakkimda = new hakkımda();
            hakkimda.ShowDialog();
        }
        private void projeÖzetiVeÇıkarılanDerslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok Yakında...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pDFToolStripMenuItem1_Click(object sender, EventArgs e)//PDF İŞLEMLERİ 
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(datagridMain.ColumnCount);

                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı

                foreach (DataGridViewColumn column in datagridMain.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in datagridMain.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
        //kısayol işlemleri
        private void FormMainpage_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                btnpuan1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                btnpuan2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                butonpuan3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                btnpuan4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                btnpuan5.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnshowanswerMain.PerformClick();
            }
            // form kısayolları
            if (e.Control && e.KeyCode == Keys.A)
            {
                formAdd form = new formAdd();
                form.Show();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                formAllData form = new formAllData();
                form.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                formDelete form = new formDelete();
                form.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                formUpdate form = new formUpdate();
                form.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                formPuanTable form = new formPuanTable();
                form.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                Application.Exit();
            }

        }
        private void kısayollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formShortCuts formShortCuts = new formShortCuts();
            formShortCuts.ShowDialog();
        }
    }
}
