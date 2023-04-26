namespace formsApp
{
    partial class formAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdd));
            this.btnvazgecinadd = new System.Windows.Forms.Button();
            this.btnkaydetinadd = new System.Windows.Forms.Button();
            this.textboxanwserAdd = new System.Windows.Forms.RichTextBox();
            this.textboxquestionAdd = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümVerileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combochooselistAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linklabelnewlistAdd = new System.Windows.Forms.LinkLabel();
            this.datagridADD = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridADD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvazgecinadd
            // 
            this.btnvazgecinadd.Location = new System.Drawing.Point(16, 277);
            this.btnvazgecinadd.Name = "btnvazgecinadd";
            this.btnvazgecinadd.Size = new System.Drawing.Size(92, 47);
            this.btnvazgecinadd.TabIndex = 6;
            this.btnvazgecinadd.Text = "Vazgeç";
            this.btnvazgecinadd.UseVisualStyleBackColor = true;
            this.btnvazgecinadd.Click += new System.EventHandler(this.btnvazgecinadd_Click);
            // 
            // btnkaydetinadd
            // 
            this.btnkaydetinadd.Location = new System.Drawing.Point(114, 277);
            this.btnkaydetinadd.Name = "btnkaydetinadd";
            this.btnkaydetinadd.Size = new System.Drawing.Size(326, 47);
            this.btnkaydetinadd.TabIndex = 5;
            this.btnkaydetinadd.Text = "Kaydet";
            this.btnkaydetinadd.UseVisualStyleBackColor = true;
            this.btnkaydetinadd.Click += new System.EventHandler(this.btnkaydetinadd_Click);
            // 
            // textboxanwserAdd
            // 
            this.textboxanwserAdd.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxanwserAdd.Location = new System.Drawing.Point(227, 100);
            this.textboxanwserAdd.Name = "textboxanwserAdd";
            this.textboxanwserAdd.Size = new System.Drawing.Size(213, 96);
            this.textboxanwserAdd.TabIndex = 2;
            this.textboxanwserAdd.Text = "";
            // 
            // textboxquestionAdd
            // 
            this.textboxquestionAdd.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxquestionAdd.Location = new System.Drawing.Point(11, 100);
            this.textboxquestionAdd.Name = "textboxquestionAdd";
            this.textboxquestionAdd.Size = new System.Drawing.Size(210, 96);
            this.textboxquestionAdd.TabIndex = 1;
            this.textboxquestionAdd.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cevap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 35);
            this.label3.TabIndex = 28;
            this.label3.Text = "Veri Ekle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.tümVerileriGösterToolStripMenuItem,
            this.listelerimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 28);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.addToolStripMenuItem.Text = "Veri Sil";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.updateToolStripMenuItem.Text = "Veri Güncelle";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
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
            // combochooselistAdd
            // 
            this.combochooselistAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combochooselistAdd.FormattingEnabled = true;
            this.combochooselistAdd.Location = new System.Drawing.Point(132, 216);
            this.combochooselistAdd.MaxDropDownItems = 4;
            this.combochooselistAdd.Name = "combochooselistAdd";
            this.combochooselistAdd.Size = new System.Drawing.Size(307, 24);
            this.combochooselistAdd.TabIndex = 3;
            this.combochooselistAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combochooselistAdd_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Listeye Kaydet:";
            // 
            // linklabelnewlistAdd
            // 
            this.linklabelnewlistAdd.AutoSize = true;
            this.linklabelnewlistAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.linklabelnewlistAdd.Location = new System.Drawing.Point(320, 244);
            this.linklabelnewlistAdd.Name = "linklabelnewlistAdd";
            this.linklabelnewlistAdd.Size = new System.Drawing.Size(120, 17);
            this.linklabelnewlistAdd.TabIndex = 4;
            this.linklabelnewlistAdd.TabStop = true;
            this.linklabelnewlistAdd.Text = "Yeni Liste Oluştur";
            this.linklabelnewlistAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelnewlistAdd_LinkClicked);
            // 
            // datagridADD
            // 
            this.datagridADD.AllowUserToDeleteRows = false;
            this.datagridADD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridADD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridADD.Location = new System.Drawing.Point(11, 334);
            this.datagridADD.Name = "datagridADD";
            this.datagridADD.ReadOnly = true;
            this.datagridADD.RowHeadersWidth = 51;
            this.datagridADD.RowTemplate.Height = 24;
            this.datagridADD.Size = new System.Drawing.Size(429, 332);
            this.datagridADD.TabIndex = 103;
            // 
            // formAdd
            // 
            this.
                
            AcceptButton = this.btnkaydetinadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 678);
            this.Controls.Add(this.datagridADD);
            this.Controls.Add(this.linklabelnewlistAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combochooselistAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnvazgecinadd);
            this.Controls.Add(this.btnkaydetinadd);
            this.Controls.Add(this.textboxanwserAdd);
            this.Controls.Add(this.textboxquestionAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Ekle";
            this.Load += new System.EventHandler(this.formAdd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridADD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvazgecinadd;
        private System.Windows.Forms.Button btnkaydetinadd;
        private System.Windows.Forms.RichTextBox textboxanwserAdd;
        private System.Windows.Forms.RichTextBox textboxquestionAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümVerileriGösterToolStripMenuItem;
        private System.Windows.Forms.ComboBox combochooselistAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklabelnewlistAdd;
        private System.Windows.Forms.ToolStripMenuItem listelerimToolStripMenuItem;
        private System.Windows.Forms.DataGridView datagridADD;
    }
}