namespace formsApp
{
    partial class formDelete
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDelete));
            this.maskedtextIdindelete = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedtextanswerindelete = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.msktextquesitonindelete = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearchidDelete = new System.Windows.Forms.Button();
            this.btnanswersearchDelete = new System.Windows.Forms.Button();
            this.btnquestionsearchDelete = new System.Windows.Forms.Button();
            this.veriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümVerileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridDELETE = new System.Windows.Forms.DataGridView();
            this.idNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quesitonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enGuncelapplicationDatabaseDataSet = new formsApp.enGuncelapplicationDatabaseDataSet();
            this.data_tableTableAdapter = new formsApp.enGuncelapplicationDatabaseDataSetTableAdapters.data_tableTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDELETE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enGuncelapplicationDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedtextIdindelete
            // 
            this.maskedtextIdindelete.Location = new System.Drawing.Point(139, 149);
            this.maskedtextIdindelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedtextIdindelete.Mask = "0000";
            this.maskedtextIdindelete.Name = "maskedtextIdindelete";
            this.maskedtextIdindelete.Size = new System.Drawing.Size(189, 22);
            this.maskedtextIdindelete.TabIndex = 5;
            this.maskedtextIdindelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedtextIdindelete_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "ID numarasına göre:";
            // 
            // maskedtextanswerindelete
            // 
            this.maskedtextanswerindelete.Location = new System.Drawing.Point(139, 92);
            this.maskedtextanswerindelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedtextanswerindelete.Name = "maskedtextanswerindelete";
            this.maskedtextanswerindelete.Size = new System.Drawing.Size(189, 22);
            this.maskedtextanswerindelete.TabIndex = 3;
            this.maskedtextanswerindelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedtextanswerindelete_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Cevaba göre:";
            // 
            // msktextquesitonindelete
            // 
            this.msktextquesitonindelete.Location = new System.Drawing.Point(139, 32);
            this.msktextquesitonindelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktextquesitonindelete.Name = "msktextquesitonindelete";
            this.msktextquesitonindelete.Size = new System.Drawing.Size(189, 22);
            this.msktextquesitonindelete.TabIndex = 1;
            this.msktextquesitonindelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.msktextquesitonindelete_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 90;
            this.label11.Text = "Soruya Göre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(162, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 35);
            this.label12.TabIndex = 89;
            this.label12.Text = "Veri Sil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearchidDelete);
            this.groupBox1.Controls.Add(this.btnanswersearchDelete);
            this.groupBox1.Controls.Add(this.btnquestionsearchDelete);
            this.groupBox1.Controls.Add(this.maskedtextIdindelete);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.maskedtextanswerindelete);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.msktextquesitonindelete);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(11, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(429, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsearchidDelete
            // 
            this.btnsearchidDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsearchidDelete.Location = new System.Drawing.Point(331, 149);
            this.btnsearchidDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchidDelete.Name = "btnsearchidDelete";
            this.btnsearchidDelete.Size = new System.Drawing.Size(75, 23);
            this.btnsearchidDelete.TabIndex = 6;
            this.btnsearchidDelete.Text = "Sil";
            this.btnsearchidDelete.UseVisualStyleBackColor = false;
            this.btnsearchidDelete.Click += new System.EventHandler(this.btnsearchidDelete_Click);
            // 
            // btnanswersearchDelete
            // 
            this.btnanswersearchDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnanswersearchDelete.Location = new System.Drawing.Point(331, 92);
            this.btnanswersearchDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnanswersearchDelete.Name = "btnanswersearchDelete";
            this.btnanswersearchDelete.Size = new System.Drawing.Size(75, 23);
            this.btnanswersearchDelete.TabIndex = 4;
            this.btnanswersearchDelete.Text = "Sil";
            this.btnanswersearchDelete.UseVisualStyleBackColor = false;
            this.btnanswersearchDelete.Click += new System.EventHandler(this.btnanswersearchDelete_Click);
            // 
            // btnquestionsearchDelete
            // 
            this.btnquestionsearchDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnquestionsearchDelete.Location = new System.Drawing.Point(331, 32);
            this.btnquestionsearchDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnquestionsearchDelete.Name = "btnquestionsearchDelete";
            this.btnquestionsearchDelete.Size = new System.Drawing.Size(75, 23);
            this.btnquestionsearchDelete.TabIndex = 2;
            this.btnquestionsearchDelete.Text = "Sil";
            this.btnquestionsearchDelete.UseVisualStyleBackColor = false;
            this.btnquestionsearchDelete.Click += new System.EventHandler(this.btnquestionsearchDelete_Click);
            // 
            // veriEkleToolStripMenuItem
            // 
            this.veriEkleToolStripMenuItem.Name = "veriEkleToolStripMenuItem";
            this.veriEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.veriEkleToolStripMenuItem.Text = "Veri Ekle";
            this.veriEkleToolStripMenuItem.Click += new System.EventHandler(this.veriEkleToolStripMenuItem_Click);
            // 
            // veriGüncelleToolStripMenuItem
            // 
            this.veriGüncelleToolStripMenuItem.Name = "veriGüncelleToolStripMenuItem";
            this.veriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.veriGüncelleToolStripMenuItem.Text = "Veri Güncelle";
            this.veriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.veriGüncelleToolStripMenuItem_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriEkleToolStripMenuItem,
            this.veriGüncelleToolStripMenuItem,
            this.tümVerileriGösterToolStripMenuItem,
            this.listelerimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(452, 28);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridDELETE
            // 
            this.dataGridDELETE.AllowUserToDeleteRows = false;
            this.dataGridDELETE.AutoGenerateColumns = false;
            this.dataGridDELETE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDELETE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDELETE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNumberDataGridViewTextBoxColumn,
            this.quesitonDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.listNameDataGridViewTextBoxColumn,
            this.soruNoDataGridViewTextBoxColumn});
            this.dataGridDELETE.DataSource = this.datatableBindingSource;
            this.dataGridDELETE.Location = new System.Drawing.Point(13, 256);
            this.dataGridDELETE.Name = "dataGridDELETE";
            this.dataGridDELETE.ReadOnly = true;
            this.dataGridDELETE.RowHeadersWidth = 51;
            this.dataGridDELETE.RowTemplate.Height = 24;
            this.dataGridDELETE.Size = new System.Drawing.Size(427, 325);
            this.dataGridDELETE.TabIndex = 97;
            this.dataGridDELETE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idNumberDataGridViewTextBoxColumn
            // 
            this.idNumberDataGridViewTextBoxColumn.DataPropertyName = "idNumber";
            this.idNumberDataGridViewTextBoxColumn.HeaderText = "ID No";
            this.idNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idNumberDataGridViewTextBoxColumn.Name = "idNumberDataGridViewTextBoxColumn";
            this.idNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quesitonDataGridViewTextBoxColumn
            // 
            this.quesitonDataGridViewTextBoxColumn.DataPropertyName = "quesiton";
            this.quesitonDataGridViewTextBoxColumn.HeaderText = "Soru";
            this.quesitonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quesitonDataGridViewTextBoxColumn.Name = "quesitonDataGridViewTextBoxColumn";
            this.quesitonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Cevap";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listNameDataGridViewTextBoxColumn
            // 
            this.listNameDataGridViewTextBoxColumn.DataPropertyName = "listName";
            this.listNameDataGridViewTextBoxColumn.HeaderText = "listName";
            this.listNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.listNameDataGridViewTextBoxColumn.Name = "listNameDataGridViewTextBoxColumn";
            this.listNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.listNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // soruNoDataGridViewTextBoxColumn
            // 
            this.soruNoDataGridViewTextBoxColumn.DataPropertyName = "soruNo";
            this.soruNoDataGridViewTextBoxColumn.HeaderText = "soruNo";
            this.soruNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soruNoDataGridViewTextBoxColumn.Name = "soruNoDataGridViewTextBoxColumn";
            this.soruNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.soruNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // datatableBindingSource
            // 
            this.datatableBindingSource.DataMember = "data_table";
            this.datatableBindingSource.DataSource = this.enGuncelapplicationDatabaseDataSet;
            // 
            // enGuncelapplicationDatabaseDataSet
            // 
            this.enGuncelapplicationDatabaseDataSet.DataSetName = "enGuncelapplicationDatabaseDataSet";
            this.enGuncelapplicationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_tableTableAdapter
            // 
            this.data_tableTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(411, 34);
            this.label7.TabIndex = 98;
            this.label7.Text = "**Veri tablosunda sileceğiniz hücreye çift tıklayarak\r\nverinin kutucuklara otomat" +
    "ik dolmasını sağlayabilirsiniz.\r\n";
            // 
            // formDelete
            // 
            this.AcceptButton = this.btnquestionsearchDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 633);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridDELETE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "formDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Sil";
            this.Load += new System.EventHandler(this.formDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDELETE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enGuncelapplicationDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedtextIdindelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedtextanswerindelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox msktextquesitonindelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnquestionsearchDelete;
        private System.Windows.Forms.Button btnsearchidDelete;
        private System.Windows.Forms.Button btnanswersearchDelete;
        private System.Windows.Forms.ToolStripMenuItem veriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümVerileriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelerimToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridDELETE;
        private enGuncelapplicationDatabaseDataSet enGuncelapplicationDatabaseDataSet;
        private System.Windows.Forms.BindingSource datatableBindingSource;
        private enGuncelapplicationDatabaseDataSetTableAdapters.data_tableTableAdapter data_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesitonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}