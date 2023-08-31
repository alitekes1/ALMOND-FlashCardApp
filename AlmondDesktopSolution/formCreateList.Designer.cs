namespace formsApp
{
    partial class formCreateList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCreateList));
            this.label1 = new System.Windows.Forms.Label();
            this.btncreateList = new System.Windows.Forms.Button();
            this.textboxCREATEList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Liste Adı:";
            // 
            // btncreateList
            // 
            this.btncreateList.Location = new System.Drawing.Point(178, 119);
            this.btncreateList.Name = "btncreateList";
            this.btncreateList.Size = new System.Drawing.Size(162, 36);
            this.btncreateList.TabIndex = 2;
            this.btncreateList.Text = "Oluştur";
            this.btncreateList.UseVisualStyleBackColor = true;
            this.btncreateList.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxCREATEList
            // 
            this.textboxCREATEList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxCREATEList.Location = new System.Drawing.Point(132, 82);
            this.textboxCREATEList.Name = "textboxCREATEList";
            this.textboxCREATEList.Size = new System.Drawing.Size(262, 31);
            this.textboxCREATEList.TabIndex = 1;
            this.textboxCREATEList.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 44);
            this.label2.TabIndex = 40;
            this.label2.Text = "Yeni Liste Oluştur";
            // 
            // formCreateList
            // 
            this.AcceptButton = this.btncreateList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(452, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxCREATEList);
            this.Controls.Add(this.btncreateList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formCreateList";
            this.Text = "Liste Oluştur";
            this.Load += new System.EventHandler(this.formCreateList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreateList;
        private System.Windows.Forms.RichTextBox textboxCREATEList;
        private System.Windows.Forms.Label label2;
    }
}