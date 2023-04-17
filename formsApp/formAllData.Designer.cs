namespace formsApp
{
    partial class formAllData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAllData));
            this.tümVerileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datagridAllData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // tümVerileriGösterToolStripMenuItem
            // 
            this.tümVerileriGösterToolStripMenuItem.Name = "tümVerileriGösterToolStripMenuItem";
            this.tümVerileriGösterToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.tümVerileriGösterToolStripMenuItem.Text = "Veri Ekle";
            this.tümVerileriGösterToolStripMenuItem.Click += new System.EventHandler(this.tümVerileriGösterToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.addToolStripMenuItem.Text = "Veri Sil";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.updateToolStripMenuItem.Text = "Veri Güncelle";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // listelerimToolStripMenuItem
            // 
            this.listelerimToolStripMenuItem.Name = "listelerimToolStripMenuItem";
            this.listelerimToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.listelerimToolStripMenuItem.Text = "Listelerim";
            this.listelerimToolStripMenuItem.Click += new System.EventHandler(this.listelerimToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümVerileriGösterToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.listelerimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(452, 30);
            this.menuStrip1.TabIndex = 97;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datagridAllData
            // 
            this.datagridAllData.AllowUserToDeleteRows = false;
            this.datagridAllData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridAllData.Location = new System.Drawing.Point(0, 30);
            this.datagridAllData.Name = "datagridAllData";
            this.datagridAllData.ReadOnly = true;
            this.datagridAllData.RowHeadersWidth = 51;
            this.datagridAllData.RowTemplate.Height = 24;
            this.datagridAllData.Size = new System.Drawing.Size(452, 603);
            this.datagridAllData.TabIndex = 98;
            // 
            // formAllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 633);
            this.Controls.Add(this.datagridAllData);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAllData";
            this.Text = "Tüm Verilerim";
            this.Load += new System.EventHandler(this.formAllData_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAllData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tümVerileriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelerimToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView datagridAllData;
    }
}