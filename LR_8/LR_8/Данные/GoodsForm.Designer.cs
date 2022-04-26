namespace LR_8
{
    partial class GoodsForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.senderID_combobox_source = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_StorageDataSet3 = new LR_8.SQL_StorageDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vIEWGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_GTableAdapter1 = new LR_8.SQL_StorageDataSetTableAdapters.VIEW_GTableAdapter();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderID_combobox_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1500, 28);
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
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.senderID_combobox_source;
            this.comboBox1.DisplayMember = "SenderSurname";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "SenderSurname";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // senderID_combobox_source
            // 
            this.senderID_combobox_source.DataMember = "VIEW_G";
            this.senderID_combobox_source.DataSource = this.sQL_StorageDataSet3;
            // 
            // sQL_StorageDataSet3
            // 
            this.sQL_StorageDataSet3.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите ID-поставщика";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.GoodWeight,
            this.SenderID,
            this.senderSurnameDataGridViewTextBoxColumn,
            this.senderFirstnameDataGridViewTextBoxColumn,
            this.senderLastnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1500, 530);
            this.dataGridView1.TabIndex = 5;
            // 
            // vIEWGBindingSource
            // 
            this.vIEWGBindingSource.DataMember = "VIEW_G";
            this.vIEWGBindingSource.DataSource = this.sQL_StorageDataSet3;
            // 
            // vIEW_GTableAdapter1
            // 
            this.vIEW_GTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GoodID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GoodID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GoodName";
            this.dataGridViewTextBoxColumn7.HeaderText = "GoodName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GoodPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "GoodPrice";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // GoodWeight
            // 
            this.GoodWeight.DataPropertyName = "GoodWeight";
            this.GoodWeight.HeaderText = "GoodWeight";
            this.GoodWeight.MinimumWidth = 6;
            this.GoodWeight.Name = "GoodWeight";
            this.GoodWeight.ReadOnly = true;
            this.GoodWeight.Width = 125;
            // 
            // SenderID
            // 
            this.SenderID.DataPropertyName = "SenderID";
            this.SenderID.HeaderText = "SenderID";
            this.SenderID.MinimumWidth = 6;
            this.SenderID.Name = "SenderID";
            this.SenderID.ReadOnly = true;
            this.SenderID.Width = 125;
            // 
            // senderSurnameDataGridViewTextBoxColumn
            // 
            this.senderSurnameDataGridViewTextBoxColumn.DataPropertyName = "SenderSurname";
            this.senderSurnameDataGridViewTextBoxColumn.HeaderText = "SenderSurname";
            this.senderSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderSurnameDataGridViewTextBoxColumn.Name = "senderSurnameDataGridViewTextBoxColumn";
            this.senderSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderFirstnameDataGridViewTextBoxColumn
            // 
            this.senderFirstnameDataGridViewTextBoxColumn.DataPropertyName = "SenderFirstname";
            this.senderFirstnameDataGridViewTextBoxColumn.HeaderText = "SenderFirstname";
            this.senderFirstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderFirstnameDataGridViewTextBoxColumn.Name = "senderFirstnameDataGridViewTextBoxColumn";
            this.senderFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderFirstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderLastnameDataGridViewTextBoxColumn
            // 
            this.senderLastnameDataGridViewTextBoxColumn.DataPropertyName = "SenderLastname";
            this.senderLastnameDataGridViewTextBoxColumn.HeaderText = "SenderLastname";
            this.senderLastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderLastnameDataGridViewTextBoxColumn.Name = "senderLastnameDataGridViewTextBoxColumn";
            this.senderLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderLastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderID_combobox_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private SQL_StorageDataSet sQL_StorageDataSet;
        private SQL_StorageDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodSenderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private SQL_StorageDataSet sQL_StorageDataSet1;
        private SQL_StorageDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private SQL_StorageDataSet sQL_StorageDataSet2;
        private SQL_StorageDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter2;
        private SQL_StorageDataSetTableAdapters.VIEW_GTableAdapter vIEW_GTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_StorageDataSet sQL_StorageDataSet3;
        private System.Windows.Forms.BindingSource senderID_combobox_source;
        private System.Windows.Forms.BindingSource vIEWGBindingSource;
        private SQL_StorageDataSetTableAdapters.VIEW_GTableAdapter vIEW_GTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderLastnameDataGridViewTextBoxColumn;
    }
}