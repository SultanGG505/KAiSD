using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LR_8
{
    public partial class AddGoodsForm : Form
    {
        string m_GoodName;
        string m_GoodPrice;
        string m_GoodWeight;
        string m_GoodSender_ID;

        public AddGoodsForm(string GoodName, string GoodPrice, string GoodWeight, string GoodSender_ID)
        {
            InitializeComponent();
            m_GoodName = GoodName;
            m_GoodPrice = GoodPrice;
            m_GoodWeight = GoodWeight;
            m_GoodSender_ID = GoodSender_ID;
            try
            {
                if (m_GoodName != null && m_GoodPrice != null && m_GoodWeight != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT GoodID, GoodSenderID, GoodName, GoodPrice, GoodWeight, SenderSurname, SenderFirstname, SenderLastname, SenderTimeToSend," +
                        " SenderCoWorkTime  FROM VIEW_G WHERE GoodName = '" + m_GoodName + "'";
                    cmd.Connection = Program.MainForm.connect;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        m_GoodSender_ID = rd.GetValue(1).ToString();
                        comboBox1.SelectedValue = m_GoodSender_ID;
                        goodName.Text = (rd.GetValue(2).ToString().Trim());
                        goodPrice.Text = (rd.GetValue(3).ToString().Trim());
                        goodWeight.Text = (rd.GetValue(4).ToString().Trim());
                    }
                    rd.Close();
                }
                if (GoodSender_ID != null)
                    comboBox1.SelectedValue = GoodSender_ID;
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }
        }

        private void AddGoodsForm_Load(object sender, EventArgs e)
        {
            this.sendersTableAdapter.Fill(this.sQL_StorageDataSet.Senders);
        }

        private void okBT_Click(object sender, EventArgs e)
        {
            if (goodName.Text.Length == 0)
            {
                MessageBox.Show("Введите название товара", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (goodPrice.Text.Length == 0)
            {
                MessageBox.Show("Введите цену товара", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (goodWeight.Text.Length == 0)
            {
                MessageBox.Show("Введите вес товара", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о поставщике.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (m_GoodName != null && m_GoodPrice != null && m_GoodWeight != null) //изменение
            {
                string sqlExpression = "UPDATE Goods " +
                    "SET GoodSenderID = " + comboBox1.SelectedValue +
                    ", GoodName = '" + goodName.Text + "'" +
                    ", GoodWeight = '" + goodWeight.Text + "'" +
                    ", GoodPrice = '" + goodPrice.Text + "'" +
                    " WHERE GoodName = '" + m_GoodName + "' and GoodSenderID = " + m_GoodSender_ID;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            }
            else
            {
                string sqlExpression = "INSERT INTO Goods (GoodSenderID, GoodName, GoodPrice, GoodWeight)" +
                                        "VALUES (@sender, @name,@price,@weight)";
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                SqlParameter Param;
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@sender", comboBox1.SelectedValue.ToString());    
                command.Parameters.Add(Param);
                Param = new SqlParameter("@name", goodName.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@price", goodPrice.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@weight", goodWeight.Text);
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();
        }

        private void noOkBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
