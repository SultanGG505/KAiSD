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
            this.vIEWGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_StorageDataSet3 = new LR_8.SQL_StorageDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderTimeToSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderCoWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_GTableAdapter1 = new LR_8.SQL_StorageDataSetTableAdapters.VIEW_GTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1687, 36);
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
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
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
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vIEWGBindingSource1;
            this.comboBox1.DisplayMember = "GoodSenderID";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "GoodSenderID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // vIEWGBindingSource1
            // 
            this.vIEWGBindingSource1.DataMember = "VIEW_G";
            this.vIEWGBindingSource1.DataSource = this.sQL_StorageDataSet3;
            // 
            // sQL_StorageDataSet3
            // 
            this.sQL_StorageDataSet3.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
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
            this.senderSurnameDataGridViewTextBoxColumn,
            this.senderFirstnameDataGridViewTextBoxColumn,
            this.senderLastnameDataGridViewTextBoxColumn,
            this.senderTimeToSendDataGridViewTextBoxColumn,
            this.senderCoWorkTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1639, 662);
            this.dataGridView1.TabIndex = 5;
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
            // senderTimeToSendDataGridViewTextBoxColumn
            // 
            this.senderTimeToSendDataGridViewTextBoxColumn.DataPropertyName = "SenderTimeToSend";
            this.senderTimeToSendDataGridViewTextBoxColumn.HeaderText = "SenderTimeToSend";
            this.senderTimeToSendDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderTimeToSendDataGridViewTextBoxColumn.Name = "senderTimeToSendDataGridViewTextBoxColumn";
            this.senderTimeToSendDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderTimeToSendDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderCoWorkTimeDataGridViewTextBoxColumn
            // 
            this.senderCoWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "SenderCoWorkTime";
            this.senderCoWorkTimeDataGridViewTextBoxColumn.HeaderText = "SenderCoWorkTime";
            this.senderCoWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderCoWorkTimeDataGridViewTextBoxColumn.Name = "senderCoWorkTimeDataGridViewTextBoxColumn";
            this.senderCoWorkTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderCoWorkTimeDataGridViewTextBoxColumn.Width = 150;
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
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 747);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource vIEWGBindingSource;
        private SQL_StorageDataSetTableAdapters.VIEW_GTableAdapter vIEW_GTableAdapter1;
        private System.Windows.Forms.BindingSource vIEWGBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderTimeToSendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderCoWorkTimeDataGridViewTextBoxColumn;
    }
}