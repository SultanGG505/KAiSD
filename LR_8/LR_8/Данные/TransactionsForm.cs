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
            this.transactionsTableAdapter1.Fill(this.sQL_StorageDataSet1.Transactions);
        }
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT GoodID, GoodSenderID, GoodName, GoodPrice, GoodWeight FROM VIEW_1 WHERE GoodSenderID = '" + comboBox1.Text + "'", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectionLength = 0;
            if (comboBox1.SelectedIndex >= 0)
                UpdateView();
        }
    }
}
