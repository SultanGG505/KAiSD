using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LR_8
{
    public partial class TransactionsForm : Form
    {
        SqlDataAdapter dataAdapter = null;

        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_MOMENT.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.sQL_MOMENT.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_MOMENT.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.sQL_MOMENT.Senders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_MOMENT.VIEW_T". При необходимости она может быть перемещена или удалена.
            this.vIEW_TTableAdapter.Fill(this.sQL_MOMENT.VIEW_T);


        }
        private void UpdateView_Seller()
        {
            dataAdapter = new SqlDataAdapter("SELECT SellerSurname, SellerFirstname, SellerID, SellerLastname, SellerSalary, SellerWorkTime, TransPrice, TransDate, TransSenderID, TransSellerID, TransID  FROM VIEW_T WHERE SellerSurname = '" + sellerBox.Text + "'", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void UpdateView_Sender()
        {
            dataAdapter = new SqlDataAdapter("SELECT SellerSurname, SellerFirstname, SellerID, SellerLastname, SellerSalary, SellerWorkTime, SenderID, SenderSurname, SenderFirstname, SenderLastname, TransPrice, TransDate, TransSenderID, TransSellerID, TransID  FROM VIEW_T WHERE SenderSurname = '" + senderBox.Text + "'", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void UpdateView1()
        {
            dataAdapter = new SqlDataAdapter("SELECT SellerSurname, SellerFirstname, SellerID, SellerLastname, SellerSalary, SellerWorkTime, SenderID, SenderSurname, SenderFirstname, SenderLastname, TransPrice, TransDate, TransSenderID, TransSellerID, TransID  FROM VIEW_T", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void SenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            senderBox.SelectionLength = 0;
            if (senderBox.SelectedIndex >= 0)
                UpdateView_Sender();
        }
        private void senderBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sellerBox.SelectionLength = 0;
            if (sellerBox.SelectedIndex >= 0)
                UpdateView_Seller();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SenderID;
            string SellerID;
            DialogResult g;
            if (!(sellerBox.SelectedIndex < 0) && !(senderBox.SelectedIndex < 0))
            {
                SenderID = senderBox.SelectedValue.ToString();
                SellerID = sellerBox.SelectedValue.ToString();
                g = new AddTransForm(null, null, SellerID, SenderID).ShowDialog();
            }
            else
                g = new AddTransForm(null, null, null, null).ShowDialog();
            this.vIEW_TTableAdapter.Fill(this.sQL_MOMENT.VIEW_T);
            
            if (dataAdapter != null) UpdateView1();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TransDate = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string TransPrice = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string SenderID = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string SellerID = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            DialogResult g = new AddTransForm(TransDate, TransPrice, SellerID, SenderID).ShowDialog();

            this.vIEW_TTableAdapter.Fill(this.sQL_MOMENT.VIEW_T);
            if (dataAdapter != null) UpdateView1();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую запись с ID " + s + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Transactions WHERE TransID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                int number = command.ExecuteNonQuery();
            }
            this.vIEW_TTableAdapter.Fill(this.sQL_MOMENT.VIEW_T);


            if (dataAdapter != null) UpdateView1();
        }

        private void BySenders_CheckedChanged(object sender, EventArgs e)
        {
            if (BySenders.Checked)
            {
                BySellers.Checked = false;
                sellerBox.Visible = false;
                senderBox.Visible = true;
            }
        }

        private void BySellers_CheckedChanged(object sender, EventArgs e)
        {
            if (BySellers.Checked)
            {
                BySenders.Checked = false;
                senderBox.Visible = false;
                sellerBox.Visible = true;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
