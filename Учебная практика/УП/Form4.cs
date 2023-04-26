using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod_avtomobilya = textBox1.Text;
            string nazvanie = textBox2.Text;
            string cena = textBox3.Text;
            string kompliktaciya= textBox4.Text;
            string kolichestvo= textBox5.Text;
            string color= textBox6.Text;
            string Moshchnost= maskedTextBox2.Text;
            string Data_vypuska= maskedTextBox1.Text;

            SqlConnection con = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
            con.Open();
            string query = "INSERT INTO Avtomobil (kod_avtomobilya,nazvanie,cena,kompliktaciya,kolichestvo,color,Moshchnost,Data_vypuska) VALUES ('" + kod_avtomobilya + "','" + nazvanie + "','" + cena + "','" + kompliktaciya + "','" + kolichestvo + "','" + color + "','" + Moshchnost + "','" + Data_vypuska + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            string Message;
            Message = "вы действительно хотите добавить автомобиль?";

            if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.No)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1= new Form2();
            f1.Show();
            this.Hide();
        }
    }
}
