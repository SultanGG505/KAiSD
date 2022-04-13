namespace LR_8
{
    partial class TransactionsForm
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
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQL_StorageDataSet3 = new LR_8.SQL_StorageDataSet();
            this.vIEWTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_TTableAdapter = new LR_8.SQL_StorageDataSetTableAdapters.VIEW_TTableAdapter();
            this.sellerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1420, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите ID продавца";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vIEWTBindingSource1;
            this.comboBox1.DisplayMember = "SellerID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(385, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "SellerID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerSurnameDataGridViewTextBoxColumn,
            this.sellerFirstnameDataGridViewTextBoxColumn,
            this.sellerIDDataGridViewTextBoxColumn,
            this.sellerLastnameDataGridViewTextBoxColumn,
            this.sellerSalaryDataGridViewTextBoxColumn,
            this.sellerWorkTimeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.vIEWTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1380, 664);
            this.dataGridView1.TabIndex = 4;
            // 
            // sQL_StorageDataSet3
            // 
            this.sQL_StorageDataSet3.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWTBindingSource
            // 
            this.vIEWTBindingSource.DataMember = "VIEW_T";
            this.vIEWTBindingSource.DataSource = this.sQL_StorageDataSet3;
            // 
            // vIEW_TTableAdapter
            // 
            this.vIEW_TTableAdapter.ClearBeforeFill = true;
            // 
            // sellerSurnameDataGridViewTextBoxColumn
            // 
            this.sellerSurnameDataGridViewTextBoxColumn.DataPropertyName = "SellerSurname";
            this.sellerSurnameDataGridViewTextBoxColumn.HeaderText = "SellerSurname";
            this.sellerSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerSurnameDataGridViewTextBoxColumn.Name = "sellerSurnameDataGridViewTextBoxColumn";
            this.sellerSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerFirstnameDataGridViewTextBoxColumn
            // 
            this.sellerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "SellerFirstname";
            this.sellerFirstnameDataGridViewTextBoxColumn.HeaderText = "SellerFirstname";
            this.sellerFirstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerFirstnameDataGridViewTextBoxColumn.Name = "sellerFirstnameDataGridViewTextBoxColumn";
            this.sellerFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerFirstnameDataGridViewTextBoxColumn.Width = 150;
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
            // sellerLastnameDataGridViewTextBoxColumn
            // 
            this.sellerLastnameDataGridViewTextBoxColumn.DataPropertyName = "SellerLastname";
            this.sellerLastnameDataGridViewTextBoxColumn.HeaderText = "SellerLastname";
            this.sellerLastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerLastnameDataGridViewTextBoxColumn.Name = "sellerLastnameDataGridViewTextBoxColumn";
            this.sellerLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerLastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerSalaryDataGridViewTextBoxColumn
            // 
            this.sellerSalaryDataGridViewTextBoxColumn.DataPropertyName = "SellerSalary";
            this.sellerSalaryDataGridViewTextBoxColumn.HeaderText = "SellerSalary";
            this.sellerSalaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerSalaryDataGridViewTextBoxColumn.Name = "sellerSalaryDataGridViewTextBoxColumn";
            this.sellerSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerSalaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerWorkTimeDataGridViewTextBoxColumn
            // 
            this.sellerWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "SellerWorkTime";
            this.sellerWorkTimeDataGridViewTextBoxColumn.HeaderText = "SellerWorkTime";
            this.sellerWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerWorkTimeDataGridViewTextBoxColumn.Name = "sellerWorkTimeDataGridViewTextBoxColumn";
            this.sellerWorkTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerWorkTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransPrice";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TransDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "TransDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TransSenderID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TransSenderID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TransSellerID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TransSellerID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TransID";
            this.dataGridViewTextBoxColumn5.HeaderText = "TransID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // vIEWTBindingSource1
            // 
            this.vIEWTBindingSource1.DataMember = "VIEW_T";
            this.vIEWTBindingSource1.DataSource = this.sQL_StorageDataSet3;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private SQL_StorageDataSet sQL_StorageDataSet;
        private SQL_StorageDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transSellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transSenderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transPriceDataGridViewTextBoxColumn;
        private SQL_StorageDataSet sQL_StorageDataSet1;
        private SQL_StorageDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SQL_StorageDataSet sQL_StorageDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_StorageDataSet sQL_StorageDataSet3;
        private System.Windows.Forms.BindingSource vIEWTBindingSource;
        private SQL_StorageDataSetTableAdapters.VIEW_TTableAdapter vIEW_TTableAdapter;
        private System.Windows.Forms.BindingSource vIEWTBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerWorkTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}