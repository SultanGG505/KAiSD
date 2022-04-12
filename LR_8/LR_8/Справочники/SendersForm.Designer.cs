namespace LR_8
{
    partial class SendersForm
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
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПроектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_StorageDataSet = new LR_8.SQL_StorageDataSet();
            this.sendersTableAdapter = new LR_8.SQL_StorageDataSetTableAdapters.SendersTableAdapter();
            this.sQL_StorageDataSet1 = new LR_8.SQL_StorageDataSet();
            this.sendersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sendersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.senderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderCoWorkTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderTimeToSendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.sQL_StorageDataSet;
            // 
            // sQL_StorageDataSet
            // 
            this.sQL_StorageDataSet.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
            // 
            // sQL_StorageDataSet1
            // 
            this.sQL_StorageDataSet1.DataSetName = "SQL_StorageDataSet";
            this.sQL_StorageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sendersBindingSource1
            // 
            this.sendersBindingSource1.DataMember = "Senders";
            this.sendersBindingSource1.DataSource = this.sQL_StorageDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.senderIDDataGridViewTextBoxColumn,
            this.senderSurnameDataGridViewTextBoxColumn,
            this.senderFirstnameDataGridViewTextBoxColumn,
            this.senderLastnameDataGridViewTextBoxColumn,
            this.senderCoWorkTimeDataGridViewTextBoxColumn,
            this.senderTimeToSendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sendersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 545);
            this.dataGridView1.TabIndex = 1;
            // 
            // sendersBindingSource2
            // 
            this.sendersBindingSource2.DataMember = "Senders";
            this.sendersBindingSource2.DataSource = this.sQL_StorageDataSet1;
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
            this.senderSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderFirstnameDataGridViewTextBoxColumn
            // 
            this.senderFirstnameDataGridViewTextBoxColumn.DataPropertyName = "SenderFirstname";
            this.senderFirstnameDataGridViewTextBoxColumn.HeaderText = "SenderFirstname";
            this.senderFirstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderFirstnameDataGridViewTextBoxColumn.Name = "senderFirstnameDataGridViewTextBoxColumn";
            this.senderFirstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderLastnameDataGridViewTextBoxColumn
            // 
            this.senderLastnameDataGridViewTextBoxColumn.DataPropertyName = "SenderLastname";
            this.senderLastnameDataGridViewTextBoxColumn.HeaderText = "SenderLastname";
            this.senderLastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderLastnameDataGridViewTextBoxColumn.Name = "senderLastnameDataGridViewTextBoxColumn";
            this.senderLastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderCoWorkTimeDataGridViewTextBoxColumn
            // 
            this.senderCoWorkTimeDataGridViewTextBoxColumn.DataPropertyName = "SenderCoWorkTime";
            this.senderCoWorkTimeDataGridViewTextBoxColumn.HeaderText = "SenderCoWorkTime";
            this.senderCoWorkTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderCoWorkTimeDataGridViewTextBoxColumn.Name = "senderCoWorkTimeDataGridViewTextBoxColumn";
            this.senderCoWorkTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderTimeToSendDataGridViewTextBoxColumn
            // 
            this.senderTimeToSendDataGridViewTextBoxColumn.DataPropertyName = "SenderTimeToSend";
            this.senderTimeToSendDataGridViewTextBoxColumn.HeaderText = "SenderTimeToSend";
            this.senderTimeToSendDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderTimeToSendDataGridViewTextBoxColumn.Name = "senderTimeToSendDataGridViewTextBoxColumn";
            this.senderTimeToSendDataGridViewTextBoxColumn.Width = 150;
            // 
            // SendersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SendersForm";
            this.Text = "Senders";
            this.Load += new System.EventHandler(this.SendersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПроектаToolStripMenuItem;
        private SQL_StorageDataSet sQL_StorageDataSet;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private SQL_StorageDataSetTableAdapters.SendersTableAdapter sendersTableAdapter;
        private SQL_StorageDataSet sQL_StorageDataSet1;
        private System.Windows.Forms.BindingSource sendersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sendersBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderCoWorkTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderTimeToSendDataGridViewTextBoxColumn;
    }
}