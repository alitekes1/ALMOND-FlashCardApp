namespace formsApp
{
    partial class formPuanTable
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
            this.datagridPuanTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPuanTable)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridPuanTable
            // 
            this.datagridPuanTable.AllowUserToDeleteRows = false;
            this.datagridPuanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPuanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPuanTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridPuanTable.Location = new System.Drawing.Point(0, 0);
            this.datagridPuanTable.Name = "datagridPuanTable";
            this.datagridPuanTable.ReadOnly = true;
            this.datagridPuanTable.RowHeadersWidth = 51;
            this.datagridPuanTable.RowTemplate.Height = 24;
            this.datagridPuanTable.Size = new System.Drawing.Size(452, 633);
            this.datagridPuanTable.TabIndex = 0;
            // 
            // formPuanTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 633);
            this.Controls.Add(this.datagridPuanTable);
            this.Name = "formPuanTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Puan Tablosu";
            this.Load += new System.EventHandler(this.formMyMistakes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPuanTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridPuanTable;
    }
}