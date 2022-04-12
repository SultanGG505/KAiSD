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
    public partial class AboutMeForm : Form
    {
        public AboutMeForm()
        {
            InitializeComponent();
           
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.Text = "Приложение разработано студентом группы 26/2 \nГордовым Султаном Николаевичем \n для выполнения 8-ой лабораторной задачи по КАиСД";
            textBox2.Text = "Ссылка на гит https://github.com/SultanGG505/KAiSD";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        private void закрытьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
