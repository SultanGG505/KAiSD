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
            this.sellerBox = new System.Windows.Forms.ComboBox();
            this.vIEWTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_MOMENT = new LR_8.SQL_MOMENT();
            this.BySellers = new System.Windows.Forms.CheckBox();
            this.BySenders = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senderBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transSellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transSenderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEW_TTableAdapter = new LR_8.SQL_MOMENTTableAdapters.VIEW_TTableAdapter();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sendersTableAdapter = new LR_8.SQL_MOMENTTableAdapters.SendersTableAdapter();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new LR_8.SQL_MOMENTTableAdapters.SellersTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_MOMENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1547, 29);
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
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(688, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите ID продавца";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sellerBox
            // 
            this.sellerBox.DataSource = this.sellersBindingSource;
            this.sellerBox.DisplayMember = "SellerSurname";
            this.sellerBox.FormattingEnabled = true;
            this.sellerBox.Location = new System.Drawing.Point(931, 25);
            this.sellerBox.Margin = new System.Windows.Forms.Padding(0);
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Size = new System.Drawing.Size(286, 28);
            this.sellerBox.TabIndex = 0;
            this.sellerBox.ValueMember = "SellerID";
            this.sellerBox.SelectedIndexChanged += new System.EventHandler(this.SenderBox_SelectedIndexChanged);
            // 
            // vIEWTBindingSource
            // 
            this.vIEWTBindingSource.DataMember = "VIEW_T";
            this.vIEWTBindingSource.DataSource = this.sQL_MOMENT;
            // 
            // sQL_MOMENT
            // 
            this.sQL_MOMENT.DataSetName = "SQL_MOMENT";
            this.sQL_MOMENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BySellers
            // 
            this.BySellers.AutoSize = true;
            this.BySellers.Location = new System.Drawing.Point(662, 30);
            this.BySellers.Margin = new System.Windows.Forms.Padding(0);
            this.BySellers.Name = "BySellers";
            this.BySellers.Size = new System.Drawing.Size(22, 21);
            this.BySellers.TabIndex = 5;
            this.BySellers.UseVisualStyleBackColor = true;
            this.BySellers.CheckedChanged += new System.EventHandler(this.BySellers_CheckedChanged);
            // 
            // BySenders
            // 
            this.BySenders.AutoSize = true;
            this.BySenders.Location = new System.Drawing.Point(8, 31);
            this.BySenders.Margin = new System.Windows.Forms.Padding(0);
            this.BySenders.Name = "BySenders";
            this.BySenders.Size = new System.Drawing.Size(22, 21);
            this.BySenders.TabIndex = 6;
            this.BySenders.UseVisualStyleBackColor = true;
            this.BySenders.CheckedChanged += new System.EventHandler(this.BySenders_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите ID поставщика";
            // 
            // senderBox
            // 
            this.senderBox.DataSource = this.sendersBindingSource;
            this.senderBox.DisplayMember = "SenderSurname";
            this.senderBox.FormattingEnabled = true;
            this.senderBox.Location = new System.Drawing.Point(280, 24);
            this.senderBox.Margin = new System.Windows.Forms.Padding(0);
            this.senderBox.Name = "senderBox";
            this.senderBox.Size = new System.Drawing.Size(304, 28);
            this.senderBox.TabIndex = 8;
            this.senderBox.ValueMember = "SenderID";
            this.senderBox.SelectedIndexChanged += new System.EventHandler(this.senderBox_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transIDDataGridViewTextBoxColumn,
            this.transSellerIDDataGridViewTextBoxColumn,
            this.transSenderIDDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.transPriceDataGridViewTextBoxColumn,
            this.senderIDDataGridViewTextBoxColumn,
            this.senderSurnameDataGridViewTextBoxColumn,
            this.senderFirstnameDataGridViewTextBoxColumn,
            this.senderLastnameDataGridViewTextBoxColumn,
            this.sellerIDDataGridViewTextBoxColumn,
            this.sellerSurnameDataGridViewTextBoxColumn,
            this.sellerFirstnameDataGridViewTextBoxColumn,
            this.sellerLastnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1523, 624);
            this.dataGridView1.TabIndex = 9;
            // 
            // transIDDataGridViewTextBoxColumn
            // 
            this.transIDDataGridViewTextBoxColumn.DataPropertyName = "TransID";
            this.transIDDataGridViewTextBoxColumn.HeaderText = "TransID";
            this.transIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transIDDataGridViewTextBoxColumn.Name = "transIDDataGridViewTextBoxColumn";
            this.transIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // transSellerIDDataGridViewTextBoxColumn
            // 
            this.transSellerIDDataGridViewTextBoxColumn.DataPropertyName = "TransSellerID";
            this.transSellerIDDataGridViewTextBoxColumn.HeaderText = "TransSellerID";
            this.transSellerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transSellerIDDataGridViewTextBoxColumn.Name = "transSellerIDDataGridViewTextBoxColumn";
            this.transSellerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transSellerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // transSenderIDDataGridViewTextBoxColumn
            // 
            this.transSenderIDDataGridViewTextBoxColumn.DataPropertyName = "TransSenderID";
            this.transSenderIDDataGridViewTextBoxColumn.HeaderText = "TransSenderID";
            this.transSenderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transSenderIDDataGridViewTextBoxColumn.Name = "transSenderIDDataGridViewTextBoxColumn";
            this.transSenderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transSenderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transPriceDataGridViewTextBoxColumn
            // 
            this.transPriceDataGridViewTextBoxColumn.DataPropertyName = "TransPrice";
            this.transPriceDataGridViewTextBoxColumn.HeaderText = "TransPrice";
            this.transPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transPriceDataGridViewTextBoxColumn.Name = "transPriceDataGridViewTextBoxColumn";
            this.transPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.transPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderIDDataGridViewTextBoxColumn
            // 
            this.senderIDDataGridViewTextBoxColumn.DataPropertyName = "SenderID";
            this.senderIDDataGridViewTextBoxColumn.HeaderText = "SenderID";
            this.senderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderIDDataGridViewTextBoxColumn.Name = "senderIDDataGridViewTextBoxColumn";
            this.senderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderIDDataGridViewTextBoxColumn.Width = 150;
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
            // sellerLastnameDataGridViewTextBoxColumn
            // 
            this.sellerLastnameDataGridViewTextBoxColumn.DataPropertyName = "SellerLastname";
            this.sellerLastnameDataGridViewTextBoxColumn.HeaderText = "SellerLastname";
            this.sellerLastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellerLastnameDataGridViewTextBoxColumn.Name = "sellerLastnameDataGridViewTextBoxColumn";
            this.sellerLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerLastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // vIEW_TTableAdapter
            // 
            this.vIEW_TTableAdapter.ClearBeforeFill = true;
            // 
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.sQL_MOMENT;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.sQL_MOMENT;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.senderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BySenders);
            this.Controls.Add(this.BySellers);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_MOMENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
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
       
      
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sellerBox;
     
        private System.Windows.Forms.CheckBox BySellers;
        private System.Windows.Forms.CheckBox BySenders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox senderBox; 
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQL_MOMENT sQL_MOMENT;
        private System.Windows.Forms.BindingSource vIEWTBindingSource;
        private SQL_MOMENTTableAdapters.VIEW_TTableAdapter vIEW_TTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr17DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transSellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transSenderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private SQL_MOMENTTableAdapters.SendersTableAdapter sendersTableAdapter;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private SQL_MOMENTTableAdapters.SellersTableAdapter sellersTableAdapter;
    }
}