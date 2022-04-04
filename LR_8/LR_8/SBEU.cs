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
    public partial class SBEU : Form
    {
        public SBEU()
        {
            InitializeComponent();
        }
        public System.Data.SqlClient.SqlConnection connect;
        private void SBEU_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source=SultanGG505;Initial Catalog=SQL_Storage;Integrated Security=True";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
        }

        

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void продавцыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SBEU senders = new SBEU();
            senders.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
