using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cherepanov_avtosalonDataSet1.Zayavka". При необходимости она может быть перемещена или удалена.
            this.zayavkaTableAdapter.Fill(this.cherepanov_avtosalonDataSet1.Zayavka);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6= new Form6();
            f6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
