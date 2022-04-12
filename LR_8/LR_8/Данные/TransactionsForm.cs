using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_8
{
    public partial class TransactionsForm : Form
    {
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
    }
}
