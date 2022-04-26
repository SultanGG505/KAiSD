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
    public partial class SendersForm : Form
    {
        public SendersForm()
        {
            InitializeComponent();
        }

        private void выйтиИзПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        private void SendersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_StorageDataSet1.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.sQL_StorageDataSet1.Senders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_StorageDataSet1.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.sQL_StorageDataSet1.Senders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_StorageDataSet.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.sQL_StorageDataSet.Senders);

        }

        private void удалитьТекущуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];// в буферную таблицу записывается
                                                                                                             // текущая таблица из DataGrid
            if(CurMan.Count > 0) // если таблица не пустая
            {
                CurMan.RemoveAt(CurMan.Position);
                sendersTableAdapter.Update(sQL_StorageDataSet);
            }
   
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sQL_StorageDataSet.Senders;
                sendersTableAdapter.Update(sQL_StorageDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
