using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace formsApp
{
    public partial class FormMainpage : Form
    {
        public FormMainpage()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VLV4GS76\\SQLKODLAB;Initial Catalog=applicationDatabase;Integrated Security=True");
        flashCardClass flashCard = new flashCardClass();
        public int i = 0;
        public int j = 0;
        private void veriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdd addform = new formAdd();
            addform.ShowDialog();
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
        private void listeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDeleteList listdeleteform = new formDeleteList();
            listdeleteform.ShowDialog();
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
        private void isChooseList()
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
            //datagridMain.DataSource = null;
            //SqlDataAdapter da = new SqlDataAdapter("select quesiton,answer,listName,puan,soruNo from data_table where answer IS NOT NULL and quesiton IS NOT  NULL", flashCard.baglanti());
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //datagridMain.DataSource = ds.Tables[0];
            //flashCard.datagridCreate(datagridMain);
            flashCard.baglanti().Close();
            flashCard.comboboxCreate(comboboxlisteMain);
        }
        private void comboboxlisteMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelsoru.Visible = true;
            i = 0;
            j = 0;
            SqlCommand komut = new SqlCommand("select quesiton,answer,listName,puan,soruNo from data_table where listName=@list and answer is not null order by puan asc", flashCard.baglanti());
            komut.Parameters.AddWithValue("@list", comboboxlisteMain.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridMain.DataSource = ds.Tables[0];
            flashCard.baglanti().Close();
            isChooseList();
            if (i < datagridMain.Rows.Count - 1)
            {
                labelsoru.Text = datagridMain.Rows[i].Cells[0].Value.ToString();
                labelSoruNo.Text = datagridMain.Rows[i].Cells[4].Value.ToString();
                i++;
            }
            datagridMain.Columns[0].HeaderText = "Soru";
            datagridMain.Columns[1].HeaderText = "Cevap";
            datagridMain.Columns[2].HeaderText = "private number";
            datagridMain.Columns[3].HeaderText = "Liste";
            datagridMain.Columns[4].HeaderText = "Puan";
        }
        private void btnShowDialoganswerMain_Click(object sender, EventArgs e)
        {
            labelcevap.Visible = true;
            labelcevap.Text = datagridMain.Rows[j].Cells[1].Value.ToString();
        }
        private void showCard()
        {
            labelcevap.Visible = false;
            ///soruyu ekrana yazdırma
            if (i < datagridMain.Rows.Count - 1)//datagridin son satırına kadar git ve hücreyi labela aktar
            {
                labelsoru.Text = datagridMain.Rows[i].Cells[0].Value.ToString();
                labelSoruNo.Text= datagridMain.Rows[i].Cells[4].Value.ToString();
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
            flashCard.comboboxRefresh(comboboxlisteMain);
        }

        private void bilgiAlmakİçinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkımda hakkimda=new hakkımda();
            hakkimda.ShowDialog();
        }
        private void projeÖzetiVeÇıkarılanDerslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok Yakında...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void pDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(datagridMain.ColumnCount);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                                                        // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.

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
    }    
}
