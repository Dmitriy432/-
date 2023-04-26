using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod_zayavki = textBox1.Text;
            string kod_pokupatelya = textBox2.Text;
            string kod_avtomobilya = textBox3.Text;
            string data_zayavki = maskedTextBox1.Text;
            

            SqlConnection con = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
            con.Open();
            string query = "INSERT INTO Zayavka (kod_zayavki,kod_pokupatelya,kod_avtomobilya,data_zayavki) VALUES ('" + kod_zayavki + "','" + kod_pokupatelya + "','" + kod_avtomobilya + "','" + data_zayavki + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Заявка добавлено");
        }
    }
}
