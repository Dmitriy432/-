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

namespace УП
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6)
                    {
                        string userLogin = textBox1.Text.Trim();
                        string userPass = textBox2.Text.Trim();

                        SqlConnection con = new SqlConnection(@"Data source= MSI; Initial Catalog=Cherepanov avtosalon;Integrated Security=True ");
                        string query = "Select * FROM Polzovateli WHERE Login= '" + userLogin + "'";
                        con.Open();

                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже существует");
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            string insertquery = "INSERT INTO Polzovateli (Login, Password) VALUES ('" + userLogin + "','" + userPass + "')";
                            SqlCommand cmd2 = new SqlCommand(insertquery, con);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы!");
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен иметь длину меньше или равно 6 символов!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
