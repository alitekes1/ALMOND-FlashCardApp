namespace formsApp
{
    partial class formDeleteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDeleteList));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxdeleteList = new System.Windows.Forms.ComboBox();
            this.datatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enGuncelapplicationDatabaseDataSet = new formsApp.enGuncelapplicationDatabaseDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.data_tableTableAdapter = new formsApp.enGuncelapplicationDatabaseDataSetTableAdapters.data_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datatableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enGuncelapplicationDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(137, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste Sil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Silmek istediğiniz listeyi seçiniz:";
            // 
            // comboBoxdeleteList
            // 
            this.comboBoxdeleteList.DataSource = this.datatableBindingSource;
            this.comboBoxdeleteList.DisplayMember = "listName";
            this.comboBoxdeleteList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdeleteList.FormattingEnabled = true;
            this.comboBoxdeleteList.Location = new System.Drawing.Point(292, 67);
            this.comboBoxdeleteList.Name = "comboBoxdeleteList";
            this.comboBoxdeleteList.Size = new System.Drawing.Size(156, 24);
            this.comboBoxdeleteList.TabIndex = 1;
            this.comboBoxdeleteList.ValueMember = "listName";
            this.comboBoxdeleteList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxdeleteList_MouseClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.Location = new System.Drawing.Point(8, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "*Listenin içindeki veriler silinmez sadece liste silinir.";
            // 
            // data_tableTableAdapter
            // 
            this.data_tableTableAdapter.ClearBeforeFill = true;
            // 
            // formDeleteList
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(451, 221);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxdeleteList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDeleteList";
            this.Text = "Lsite Sil";
            this.Load += new System.EventHandler(this.formDeleteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enGuncelapplicationDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxdeleteList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private enGuncelapplicationDatabaseDataSet enGuncelapplicationDatabaseDataSet;
        private System.Windows.Forms.BindingSource datatableBindingSource;
        private enGuncelapplicationDatabaseDataSetTableAdapters.data_tableTableAdapter data_tableTableAdapter;
    }
}