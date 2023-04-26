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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "Admin" && textBox2.Text == "123456")
            {
                Form2 fm1 = new Form2();
                fm1.Show();
            }



            else if (textBox1.Text == "Users" && textBox2.Text == "74523")
            {
                Form2 fm2 = new Form2();
                fm2.Show();

            }*/

            SqlConnection DataAvtosalon= new SqlConnection(@"Data source= MSI; Initial Catalog=Cherepanov avtosalon;Integrated Security=True ");
            string query = "Select * FROM Polzovateli  WHERE Login='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            DataAvtosalon.Open();

            SqlCommand cmd = new SqlCommand(query, DataAvtosalon);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    object Login = rdr.GetValue(0);
                    object Password = rdr.GetValue(1);
                    object Rol = rdr.GetValue(2);

                    string user_Login = Login.ToString();
                    string password_Login = Password.ToString();
                    string role_Login = Rol.ToString();

                    if (role_Login == "True")
                    {
                        Form2 fm2 = new Form2();
                        fm2.button4.Visible = true;
                        fm2.button3.Visible = true;
                        fm2.button8.Visible = true;
                        fm2.button5.Visible = true;
                        fm2.label3.Text = "Добро пожаловать, " + user_Login;
                        fm2.Show();
                        this.Hide();
                    }

                    else if (role_Login == "False")
                    {
                        Form2 fm3 = new Form2();
                        fm3.Show();
                        fm3.button4.Visible = false;
                        fm3.button3.Visible = false;
                        fm3.button8.Visible = true;
                        fm3.button5.Visible = false;
                        fm3.label3.Text = "Добро пожаловать, " + user_Login;
                        this.Hide();
                    }
                }
            }
            else MessageBox.Show(
                "Неправильно ввели логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }
    }
}
