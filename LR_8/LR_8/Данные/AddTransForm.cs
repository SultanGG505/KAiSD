using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LR_8
{
    public partial class AddTransForm : Form
    {

        string m_TransDate;
        string m_TransPrice;
        string m_TransSeller_ID;
        string m_TransSender_ID;

        public AddTransForm(string TransDate, string TransPrice, string TransSeller_ID, string TransSender_ID)
        {
            InitializeComponent();
            m_TransDate = TransDate;
            m_TransPrice = TransPrice;
            m_TransSeller_ID = TransSeller_ID;
            m_TransSender_ID = TransSender_ID;
            try
            {
                if (m_TransDate != null && m_TransPrice != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT SellerSurname, SellerFirstname, SellerID, SellerLastname, SellerSalary, SellerWorkTime, SenderID, " +
                        "SenderSurname, SenderFirstname, SenderLastname, TransPrice, TransDate, TransSenderID, TransSellerID, TransID  FROM VIEW_T WHERE TransDate = '" + m_TransDate + "'";
                    cmd.Connection = Program.MainForm.connect;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        m_TransSeller_ID = rd.GetValue(1).ToString();
                        m_TransSender_ID = rd.GetValue(2).ToString();
                        sellerComboBox.SelectedValue = m_TransSeller_ID;
                        senderComboBox.SelectedValue = m_TransSender_ID;
                        DateBox.Text = (rd.GetValue(3).ToString().Trim());
                        PriceBox.Text = (rd.GetValue(4).ToString().Trim());
                    }
                    rd.Close();
                }
                if (TransSeller_ID != null && TransSender_ID != null)
                {
                    sellerComboBox.SelectedValue = TransSeller_ID;
                    senderComboBox.SelectedValue = TransSender_ID;
                }

            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }

        }
        private void AddTransForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_MOMENT.Senders". При необходимости она может быть перемещена или удалена.
            this.sendersTableAdapter.Fill(this.sQL_MOMENT.Senders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQL_MOMENT.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.sQL_MOMENT.Sellers);

        }


        private void okBT_Click(object sender, EventArgs e)
        {
            if (DateBox.Text.Length == 0)
            {
                MessageBox.Show("Введите дату транзакции", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (PriceBox.Text.Length == 0)
            {
                MessageBox.Show("Введите цену транзакции", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sellerComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о продавце", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (senderComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о поставщике", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if(m_TransDate != null && m_TransPrice != null)
            {
                string sqlExpression = "UPDATE Transactions " +
                    "SET TransSellerID = '" + sellerComboBox.SelectedValue +
                    ", TransSenderID = '" + senderComboBox.SelectedValue +
                    ", TransDate = '" + DateBox.Text + "'" +
                    ", TransPrice = '" + PriceBox.Text + "'" +
                    " WHERE TransDate = '" + m_TransDate + "' and TransSenderID = " + m_TransSender_ID;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
            }
            else
            {
                string sqlExpression = "INSERT INTO Transactions (TransDate, TransPrice, TransSellerID, TransSenderID)" +
                                        "VALUES (@date, @price, @seller,@sender)";
                command = new SqlCommand(sqlExpression,Program.MainForm.connect);
                SqlParameter Param;
                //string n
                Param = new SqlParameter("@date",DateBox.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@price", PriceBox.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@seller", sellerComboBox.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@sender", senderComboBox.SelectedValue.ToString());
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();

        }

        private void noOKBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
