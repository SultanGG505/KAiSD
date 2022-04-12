namespace LR_8
{
    partial class SellersForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПроектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLStorageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_StorageDataSet = new LR_8.SQL_StorageDataSet();
            this.sellersTableAdapter = new LR_8.SQL_StorageDataSetTableAdapters.SellersTableAdapter();
            this.sQL_StorageDataSet1 = new LR_8.SQL_StorageDataSet();
            this.sellersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sellersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLStorageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.сохранитьИзмененияToolStripMenuItem,
            this.удалитьТекущуюЗаписьToolStripMenuItem,
            this.вернутьсяToolStripMenuItem,
            this.выйтиИзПроектаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 29);
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(207, 29);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьТекущуюЗаписьToolStripMenuItem
            // 
            this.удалитьТекущуюЗаписьToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.удалитьТекущуюЗаписьToolStripMenuItem.Name = "удалитьТекущуюЗаписьToolStripMenuItem";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(229, 29);
            this.удалитьТекущуюЗаписьToolStripMenuItem.Text = "Удалить текущую запись";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущуюЗаписьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // выйтиИзПроектаToolStripMenuItem
            // 
            this.выйтиИзПроектаToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.выйтиИзПроектаToolStripMenuItem.Name = "выйтиИзПроектаToolStripMenuItem";
            this.выйтиИзПроектаToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.выйтиИзПроектаToolStripMenuItem.Text = "Выйти из проекта";
            this.выйтиИзПроектаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПроектаToolStripMenuItem_Click);
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.sQLStorageDataSetBindingSource;
            // 
            // sQLStorageDataSetBindingSource
            // 
            this.sQLStorageDataSetBindingSource.DataSource = this.sQL_StorageDataSet;
            this.sQLStorageDataSetBindingSource.Position = 0;
            // 
            // sQL_StorageDataSet
            // 
            this.sQL_StorageDataSet.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // sQL_StorageDataSet1
            // 
            this.sQL_StorageDataSet1.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellersBindingSource1
            // 
            this.sellersBindingSource1.DataMember = "Sellers";
            this.sellersBindingSource1.DataSource = this.sQL_StorageDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerIDDataGridViewTextBoxColumn,
            this.sellerSurnameDataGridViewTextBoxColumn,
            this.sellerFirstnameDataGridViewTextBoxColumn,
            this.sellerLastnameDataGridViewTextBoxColumn,
            this.sellerSalaryDataGridViewTextBoxColumn,
            this.sellerWorkTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 476);
            this.dataGridView1.TabIndex = 1;
            // 
            // sellersBindingSource2
            // 
            this.sellersBindingSource2.DataMember = "Sellers";
            this.sellersBindingSource2.DataSource = this.sQL_StorageDataSet1;
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            this.sellerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerSurnameDataGridViewTextBoxColumn
            // 
            this.sellerSurnameDataGridViewTextBoxColumn.DataPropertyName = "SellerSurname";
            this.sellerSurnameDataGridViewTextBoxColumn.HeaderText = "SellerSurname";
            this.sellerSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerSurnameDataGridViewTextBoxColumn.Name = "sellerSurnameDataGridViewTextBoxColumn";
            this.sellerSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerFirstnameDataGridViewTextBoxColumn
            // 
            this.sellerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "SellerFirstname";
            this.sellerFirstnameDataGridViewTextBoxColumn.HeaderText = "SellerFirstname";
            this.sellerFirstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerFirstnameDataGridViewTextBoxColumn.Name = "sellerFirstnameDataGridViewTextBoxColumn";
            this.sellerFirstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerLastnameDataGridViewTextBoxColumn
            // 
            this.sellerLastnameDataGridViewTextBoxColumn.DataPropertyName = "SellerLastname";
            this.sellerLastnameDataGridViewTextBoxColumn.HeaderText = "SellerLastname";
            this.sellerLastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerLastnameDataGridViewTextBoxColumn.Name = "sellerLastnameDataGridViewTextBoxColumn";
            this.sellerLastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerSalaryDataGridViewTextBoxColumn
            // 
            this.sellerSalaryDataGridViewTextBoxColumn.DataPropertyName = "SellerSalary";
            this.sellerSalaryDataGridViewTextBoxColumn.HeaderText = "SellerSalary";
            this.sellerSalaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerSalaryDataGridViewTextBoxColumn.Name = "sellerSalaryDataGridViewTextBoxColumn";
            this.sellerSalaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerWorkTimeDataGridViewTextBoxColumn
            // 
            this.sellerWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "SellerWorkTime";
            this.sellerWorkTimeDataGridViewTextBoxColumn.HeaderText = "SellerWorkTime";
            this.sellerWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerWorkTimeDataGridViewTextBoxColumn.Name = "sellerWorkTimeDataGridViewTextBoxColumn";
            this.sellerWorkTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // SellersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellersForm";
            this.Text = "Sellers";
            this.Load += new System.EventHandler(this.SellersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLStorageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПроектаToolStripMenuItem;
        private System.Windows.Forms.BindingSource sQLStorageDataSetBindingSource;
        private SQL_StorageDataSet sQL_StorageDataSet;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private SQL_StorageDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private SQL_StorageDataSet sQL_StorageDataSet1;
        private System.Windows.Forms.BindingSource sellersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sellersBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerWorkTimeDataGridViewTextBoxColumn;
    }
}