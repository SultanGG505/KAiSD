namespace LR_8
{
    partial class AddGoodsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goodName = new System.Windows.Forms.TextBox();
            this.goodPrice = new System.Windows.Forms.TextBox();
            this.goodWeight = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_StorageDataSet = new LR_8.SQL_StorageDataSet();
            this.sendersTableAdapter = new LR_8.SQL_StorageDataSetTableAdapters.SendersTableAdapter();
            this.okBT = new System.Windows.Forms.Button();
            this.noOkBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вес товара(кг)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Поставщик товара";
            // 
            // goodName
            // 
            this.goodName.Location = new System.Drawing.Point(232, 44);
            this.goodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goodName.Name = "goodName";
            this.goodName.Size = new System.Drawing.Size(192, 22);
            this.goodName.TabIndex = 4;
            // 
            // goodPrice
            // 
            this.goodPrice.Location = new System.Drawing.Point(232, 81);
            this.goodPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goodPrice.Name = "goodPrice";
            this.goodPrice.Size = new System.Drawing.Size(192, 22);
            this.goodPrice.TabIndex = 5;
            // 
            // goodWeight
            // 
            this.goodWeight.Location = new System.Drawing.Point(232, 113);
            this.goodWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goodWeight.Name = "goodWeight";
            this.goodWeight.Size = new System.Drawing.Size(192, 22);
            this.goodWeight.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sendersBindingSource;
            this.comboBox1.DisplayMember = "SenderSurname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 148);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "SenderID";
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
            // okBT
            // 
            this.okBT.Location = new System.Drawing.Point(94, 217);
            this.okBT.Name = "okBT";
            this.okBT.Size = new System.Drawing.Size(94, 40);
            this.okBT.TabIndex = 8;
            this.okBT.Text = "ок";
            this.okBT.UseVisualStyleBackColor = true;
            this.okBT.Click += new System.EventHandler(this.okBT_Click);
            // 
            // noOkBT
            // 
            this.noOkBT.Location = new System.Drawing.Point(223, 217);
            this.noOkBT.Name = "noOkBT";
            this.noOkBT.Size = new System.Drawing.Size(106, 40);
            this.noOkBT.TabIndex = 9;
            this.noOkBT.Text = "отмена";
            this.noOkBT.UseVisualStyleBackColor = true;
            this.noOkBT.Click += new System.EventHandler(this.noOkBT_Click);
            // 
            // AddGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 311);
            this.Controls.Add(this.noOkBT);
            this.Controls.Add(this.okBT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.goodWeight);
            this.Controls.Add(this.goodPrice);
            this.Controls.Add(this.goodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddGoodsForm";
            this.Text = "AddGoodsForm";
            this.Load += new System.EventHandler(this.AddGoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_StorageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox goodName;
        private System.Windows.Forms.TextBox goodPrice;
        private System.Windows.Forms.TextBox goodWeight;
        private System.Windows.Forms.ComboBox comboBox1;
        private SQL_StorageDataSet sQL_StorageDataSet;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private SQL_StorageDataSetTableAdapters.SendersTableAdapter sendersTableAdapter;
        private System.Windows.Forms.Button okBT;
        private System.Windows.Forms.Button noOkBT;
    }
}