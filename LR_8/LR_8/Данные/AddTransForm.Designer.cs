namespace LR_8
{
    partial class AddTransForm
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
            this.okBT = new System.Windows.Forms.Button();
            this.sellerComboBox = new System.Windows.Forms.ComboBox();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_MOMENT = new LR_8.SQL_MOMENT();
            this.senderComboBox = new System.Windows.Forms.ComboBox();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sellersTableAdapter = new LR_8.SQL_MOMENTTableAdapters.SellersTableAdapter();
            this.sendersTableAdapter = new LR_8.SQL_MOMENTTableAdapters.SendersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_MOMENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // okBT
            // 
            this.okBT.Location = new System.Drawing.Point(192, 350);
            this.okBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBT.Name = "okBT";
            this.okBT.Size = new System.Drawing.Size(114, 59);
            this.okBT.TabIndex = 0;
            this.okBT.Text = "Ок";
            this.okBT.UseVisualStyleBackColor = true;
            this.okBT.Click += new System.EventHandler(this.okBT_Click);
            // 
            // sellerComboBox
            // 
            this.sellerComboBox.DataSource = this.sellersBindingSource;
            this.sellerComboBox.DisplayMember = "SellerSurname";
            this.sellerComboBox.FormattingEnabled = true;
            this.sellerComboBox.Location = new System.Drawing.Point(192, 254);
            this.sellerComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sellerComboBox.Name = "sellerComboBox";
            this.sellerComboBox.Size = new System.Drawing.Size(136, 28);
            this.sellerComboBox.TabIndex = 2;
            this.sellerComboBox.ValueMember = "SellerID";
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.sQL_MOMENT;
            // 
            // sQL_MOMENT
            // 
            this.sQL_MOMENT.DataSetName = "SQL_MOMENT";
            this.sQL_MOMENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // senderComboBox
            // 
            this.senderComboBox.DataSource = this.sendersBindingSource;
            this.senderComboBox.DisplayMember = "SenderSurname";
            this.senderComboBox.FormattingEnabled = true;
            this.senderComboBox.Location = new System.Drawing.Point(469, 250);
            this.senderComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.senderComboBox.Name = "senderComboBox";
            this.senderComboBox.Size = new System.Drawing.Size(136, 28);
            this.senderComboBox.TabIndex = 3;
            this.senderComboBox.ValueMember = "SenderID";
            // 
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.sQL_MOMENT;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(349, 68);
            this.DateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(211, 26);
            this.DateBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(349, 119);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(211, 26);
            this.PriceBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата транзакции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стоимость транзакции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Продавец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Поставщик";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 78);
            this.button1.TabIndex = 10;
            this.button1.Text = "отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
            // 
            // AddTransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.senderComboBox);
            this.Controls.Add(this.sellerComboBox);
            this.Controls.Add(this.okBT);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddTransForm";
            this.Text = "AddTransForm";
            this.Load += new System.EventHandler(this.AddTransForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL_MOMENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBT;
        private System.Windows.Forms.ComboBox sellerComboBox;
        
        private System.Windows.Forms.ComboBox senderComboBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
       
        private System.Windows.Forms.Button button1;
        private SQL_MOMENT sQL_MOMENT;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private SQL_MOMENTTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private SQL_MOMENTTableAdapters.SendersTableAdapter sendersTableAdapter;
    }
}