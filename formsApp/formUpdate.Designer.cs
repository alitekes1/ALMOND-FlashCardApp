namespace formsApp
{
    partial class formUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpdate));
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümVerileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearchidUpdate = new System.Windows.Forms.Button();
            this.maskedtextIdUpdate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linknewlistUpdate = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.combochooselistUpdate = new System.Windows.Forms.ComboBox();
            this.btnvazgecinUpdate = new System.Windows.Forms.Button();
            this.btngüncelleupdate = new System.Windows.Forms.Button();
            this.textboxanswerUpdate = new System.Windows.Forms.RichTextBox();
            this.textboxquestionUpdate = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelsoruupdate = new System.Windows.Forms.Label();
            this.dataGridUPDATE = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUPDATE)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 84);
            this.label7.TabIndex = 55;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 35);
            this.label3.TabIndex = 89;
            this.label3.Text = "Veri Güncelle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.addToolStripMenuItem,
            this.tümVerileriGösterToolStripMenuItem,
            this.listelerimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.updateToolStripMenuItem.Text = "Veri Ekle";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.addToolStripMenuItem.Text = "Veri Sil";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // tümVerileriGösterToolStripMenuItem
            // 
            this.tümVerileriGösterToolStripMenuItem.Name = "tümVerileriGösterToolStripMenuItem";
            this.tümVerileriGösterToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.tümVerileriGösterToolStripMenuItem.Text = "Tüm Verileri Göster";
            this.tümVerileriGösterToolStripMenuItem.Click += new System.EventHandler(this.tümVerileriGösterToolStripMenuItem_Click);
            // 
            // listelerimToolStripMenuItem
            // 
            this.listelerimToolStripMenuItem.Name = "listelerimToolStripMenuItem";
            this.listelerimToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.listelerimToolStripMenuItem.Text = "Listelerim";
            this.listelerimToolStripMenuItem.Click += new System.EventHandler(this.listelerimToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearchidUpdate);
            this.groupBox1.Controls.Add(this.maskedtextIdUpdate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnsearchidUpdate
            // 
            this.btnsearchidUpdate.Location = new System.Drawing.Point(352, 25);
            this.btnsearchidUpdate.Name = "btnsearchidUpdate";
            this.btnsearchidUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnsearchidUpdate.TabIndex = 6;
            this.btnsearchidUpdate.Text = "Ara";
            this.btnsearchidUpdate.UseVisualStyleBackColor = true;
            this.btnsearchidUpdate.Click += new System.EventHandler(this.btnsearchidUpdate_Click);
            // 
            // maskedtextIdUpdate
            // 
            this.maskedtextIdUpdate.Location = new System.Drawing.Point(160, 25);
            this.maskedtextIdUpdate.Mask = "0000";
            this.maskedtextIdUpdate.Name = "maskedtextIdUpdate";
            this.maskedtextIdUpdate.Size = new System.Drawing.Size(189, 22);
            this.maskedtextIdUpdate.TabIndex = 5;
            this.maskedtextIdUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedtextIdUpdate_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "ID numarasına göre:";
            // 
            // linknewlistUpdate
            // 
            this.linknewlistUpdate.AutoSize = true;
            this.linknewlistUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.linknewlistUpdate.Location = new System.Drawing.Point(329, 301);
            this.linknewlistUpdate.Name = "linknewlistUpdate";
            this.linknewlistUpdate.Size = new System.Drawing.Size(120, 17);
            this.linknewlistUpdate.TabIndex = 10;
            this.linknewlistUpdate.TabStop = true;
            this.linknewlistUpdate.Text = "Yeni Liste Oluştur";
            this.linknewlistUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linknewlistUpdate_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Listeyi Güncelle:";
            // 
            // combochooselistUpdate
            // 
            this.combochooselistUpdate.DisplayMember = "listName";
            this.combochooselistUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combochooselistUpdate.FormattingEnabled = true;
            this.combochooselistUpdate.Location = new System.Drawing.Point(142, 274);
            this.combochooselistUpdate.MaxDropDownItems = 4;
            this.combochooselistUpdate.Name = "combochooselistUpdate";
            this.combochooselistUpdate.Size = new System.Drawing.Size(303, 24);
            this.combochooselistUpdate.TabIndex = 9;
            this.combochooselistUpdate.ValueMember = "listName";
            this.combochooselistUpdate.SelectedIndexChanged += new System.EventHandler(this.combochooselistUpdate_SelectedIndexChanged);
            // 
            // btnvazgecinUpdate
            // 
            this.btnvazgecinUpdate.Location = new System.Drawing.Point(12, 532);
            this.btnvazgecinUpdate.Name = "btnvazgecinUpdate";
            this.btnvazgecinUpdate.Size = new System.Drawing.Size(89, 47);
            this.btnvazgecinUpdate.TabIndex = 12;
            this.btnvazgecinUpdate.Text = "Vazgeç";
            this.btnvazgecinUpdate.UseVisualStyleBackColor = true;
            this.btnvazgecinUpdate.Click += new System.EventHandler(this.btnvazgecinUpdate_Click);
            // 
            // btngüncelleupdate
            // 
            this.btngüncelleupdate.Location = new System.Drawing.Point(102, 532);
            this.btngüncelleupdate.Name = "btngüncelleupdate";
            this.btngüncelleupdate.Size = new System.Drawing.Size(343, 47);
            this.btngüncelleupdate.TabIndex = 11;
            this.btngüncelleupdate.Text = "Güncelle";
            this.btngüncelleupdate.UseVisualStyleBackColor = true;
            this.btngüncelleupdate.Click += new System.EventHandler(this.btngüncelleupdate_Click);
            // 
            // textboxanswerUpdate
            // 
            this.textboxanswerUpdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxanswerUpdate.Location = new System.Drawing.Point(230, 183);
            this.textboxanswerUpdate.Name = "textboxanswerUpdate";
            this.textboxanswerUpdate.Size = new System.Drawing.Size(210, 83);
            this.textboxanswerUpdate.TabIndex = 8;
            this.textboxanswerUpdate.Text = "";
            this.textboxanswerUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textboxanswerUpdate_MouseClick);
            // 
            // textboxquestionUpdate
            // 
            this.textboxquestionUpdate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxquestionUpdate.Location = new System.Drawing.Point(12, 183);
            this.textboxquestionUpdate.Name = "textboxquestionUpdate";
            this.textboxquestionUpdate.Size = new System.Drawing.Size(210, 83);
            this.textboxquestionUpdate.TabIndex = 7;
            this.textboxquestionUpdate.Text = "";
            this.textboxquestionUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textboxquestionUpdate_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 107;
            this.label4.Text = "Cevap";
            // 
            // labelsoruupdate
            // 
            this.labelsoruupdate.AutoSize = true;
            this.labelsoruupdate.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsoruupdate.Location = new System.Drawing.Point(97, 157);
            this.labelsoruupdate.Name = "labelsoruupdate";
            this.labelsoruupdate.Size = new System.Drawing.Size(41, 27);
            this.labelsoruupdate.TabIndex = 106;
            this.labelsoruupdate.Text = "Soru";
            // 
            // dataGridUPDATE
            // 
            this.dataGridUPDATE.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.dataGridUPDATE.AllowUserToDeleteRows = false;
            this.dataGridUPDATE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUPDATE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUPDATE.Location = new System.Drawing.Point(13, 326);
            this.dataGridUPDATE.Name = "dataGridUPDATE";
            this.dataGridUPDATE.RowHeadersWidth = 51;
            this.dataGridUPDATE.RowTemplate.Height = 24;
            this.dataGridUPDATE.Size = new System.Drawing.Size(432, 200);
            this.dataGridUPDATE.TabIndex = 113;
            this.dataGridUPDATE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUPDATE_CellContentClick);
            this.dataGridUPDATE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUPDATE_CellDoubleClick);
            // 
            // formUpdate
            // 
            this.AcceptButton = this.btngüncelleupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 680);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridUPDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linknewlistUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combochooselistUpdate);
            this.Controls.Add(this.btnvazgecinUpdate);
            this.Controls.Add(this.btngüncelleupdate);
            this.Controls.Add(this.textboxanswerUpdate);
            this.Controls.Add(this.textboxquestionUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelsoruupdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Güncelle";
            this.Load += new System.EventHandler(this.formUpdate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUPDATE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümVerileriGösterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsearchidUpdate;
        private System.Windows.Forms.MaskedTextBox maskedtextIdUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem listelerimToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linknewlistUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combochooselistUpdate;
        private System.Windows.Forms.Button btnvazgecinUpdate;
        private System.Windows.Forms.Button btngüncelleupdate;
        private System.Windows.Forms.RichTextBox textboxanswerUpdate;
        private System.Windows.Forms.RichTextBox textboxquestionUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelsoruupdate;
        private System.Windows.Forms.DataGridView dataGridUPDATE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}