namespace LR_8
{
    partial class ExportMoment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excel = new System.Windows.Forms.CheckBox();
            this.html = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.goods_FilterTableAdapter1 = new LR_8.SQL_MOMENTTableAdapters.Goods_FilterTableAdapter();
            this.trans_ViewTableAdapter1 = new LR_8.SQL_MOMENTTableAdapters.Trans_ViewTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sqL_MOMENT1 = new LR_8.SQL_MOMENT();
            this.button2 = new System.Windows.Forms.Button();
            this.goods = new System.Windows.Forms.CheckBox();
            this.trans_ = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqL_MOMENT1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.excel);
            this.groupBox1.Controls.Add(this.html);
            this.groupBox1.Location = new System.Drawing.Point(185, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Экспорт";
            // 
            // excel
            // 
            this.excel.AutoSize = true;
            this.excel.Location = new System.Drawing.Point(7, 54);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(88, 24);
            this.excel.TabIndex = 6;
            this.excel.Text = "эксель";
            this.excel.UseVisualStyleBackColor = true;
            // 
            // html
            // 
            this.html.AutoSize = true;
            this.html.Location = new System.Drawing.Point(6, 25);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(72, 24);
            this.html.TabIndex = 5;
            this.html.Text = "хтмл";
            this.html.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goods_FilterTableAdapter1
            // 
            this.goods_FilterTableAdapter1.ClearBeforeFill = true;
            // 
            // trans_ViewTableAdapter1
            // 
            this.trans_ViewTableAdapter1.ClearBeforeFill = true;
            // 
            // sqL_MOMENT1
            // 
            this.sqL_MOMENT1.DataSetName = "SQL_MOMENT";
            this.sqL_MOMENT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "экспорт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // goods
            // 
            this.goods.AutoSize = true;
            this.goods.Location = new System.Drawing.Point(185, 88);
            this.goods.Name = "goods";
            this.goods.Size = new System.Drawing.Size(285, 24);
            this.goods.TabIndex = 3;
            this.goods.Text = "Товары, цена которых больше 5к";
            this.goods.UseVisualStyleBackColor = true;
            // 
            // trans_
            // 
            this.trans_.AutoSize = true;
            this.trans_.Location = new System.Drawing.Point(185, 118);
            this.trans_.Name = "trans_";
            this.trans_.Size = new System.Drawing.Size(606, 24);
            this.trans_.TabIndex = 4;
            this.trans_.Text = "Транзакции, цена которых больше 5к и зарплата проводивших больше 10к";
            this.trans_.UseVisualStyleBackColor = true;
            // 
            // ExportMoment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 599);
            this.Controls.Add(this.trans_);
            this.Controls.Add(this.goods);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExportMoment";
            this.Text = "ExportMoment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqL_MOMENT1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private SQL_MOMENTTableAdapters.Goods_FilterTableAdapter goods_FilterTableAdapter1;
        private SQL_MOMENTTableAdapters.Trans_ViewTableAdapter trans_ViewTableAdapter1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private SQL_MOMENT sqL_MOMENT1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox goods;
        private System.Windows.Forms.CheckBox trans_;
        private System.Windows.Forms.CheckBox excel;
        private System.Windows.Forms.CheckBox html;
    }
}