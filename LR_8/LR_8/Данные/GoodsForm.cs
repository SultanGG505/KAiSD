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
    public partial class GoodsForm : Form
    {
        SqlDataAdapter dataAdapter = null;
        public GoodsForm()
        {
            InitializeComponent();
        }
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT GoodID, GoodSenderID, GoodName, GoodPrice, GoodWeight, SenderSurname, SenderFirstname, SenderLastname, SenderTimeToSend, SenderCoWorkTime  FROM VIEW_G WHERE SenderSurname = '" + comboBox.Text + "'", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void UpdateView1()
        {
            dataAdapter = new SqlDataAdapter("SELECT GoodID, GoodSenderID, GoodName, GoodPrice, GoodWeight, SenderSurname, SenderFirstname, SenderLastname, SenderTimeToSend, SenderCoWorkTime  FROM Goods ", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox.SelectionLength = 0;
            if (comboBox.SelectedIndex >= 0)
                UpdateView();
        }
        private void GoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_MOMENT.VIEW_G". При необходимости она может быть перемещена или удалена.
            this.vIEW_GTableAdapter.Fill(this.sQL_MOMENT.VIEW_G);
            

        }
        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SenderID;
            DialogResult g;
            if (!(comboBox.SelectedIndex < 0))
            {
                SenderID = comboBox.SelectedValue.ToString();
                g = new AddGoodsForm(null, null,null, SenderID).ShowDialog();
            }
            else
                g = new AddGoodsForm(null, null, null,null).ShowDialog();
            this.vIEW_GTableAdapter.Fill(this.sQL_MOMENT.VIEW_G);
            if (dataAdapter != null) UpdateView1();

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string GoodName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string GoodPrice = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string GoodWeight = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string SenderID = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DialogResult g = new AddGoodsForm(GoodName,GoodPrice,GoodWeight,SenderID).ShowDialog();
            this.vIEW_GTableAdapter.Fill(this.sQL_MOMENT.VIEW_G);
            if (dataAdapter != null) UpdateView1();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить текущую запись с ID " + s + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Goods WHERE GoodID = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                int number = command.ExecuteNonQuery();
            }
            this.vIEW_GTableAdapter.Fill(this.sQL_MOMENT.VIEW_G);
            
            if (dataAdapter != null) UpdateView1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

