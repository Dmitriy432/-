using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class Form2 : Form
    {
        //DataBase dataBase = new DataBase();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Поиск через запрос
            string searchString = textBox1.Text;
            string query = "SELECT * FROM Avtomobil WHERE kompliktaciya LIKE @searchString";

            using (SqlConnection con = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Динамический поиск
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.cherepanov_avtosalonDataSet.Avtomobil;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"kompliktaciya LIKE '%{textBox2.Text}%'";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cherepanovavtosalonDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            /*this.avtomobilTableAdapter1.Fill(this.cherepanovavtosalonDataSet.Avtomobil);*/
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cherepanov_avtosalonDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            /*this.avtomobilTableAdapter.Fill(this.cherepanov_avtosalonDataSet.Avtomobil);*/
            this.avtomobilTableAdapter.Fill(this.cherepanov_avtosalonDataSet.Avtomobil);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Кнопка назад
            Form1 f1= new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Кнопка добавление автомобиля
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Удаление
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            //deleteRow();

            string Message;
            Message = "вы действительно хотите удалить выделенную запись?";

            if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.No)
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Сохранение
            avtomobilTableAdapter.Update(cherepanov_avtosalonDataSet);
            try
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM  Avtomobil", con2);
                //dataGridView1.DataSource = this.studentDataSet2.Student;
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataGridView1.EndEdit();
                adapter.Update(dt);
                MessageBox.Show("Изменения сохранены успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
            /*UpdateDB();*/
            
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible= true;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString()==string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            
        }

        

        private void UpdateDB()
        {
            //Обновление
            string sql = (@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
            SqlConnection con1 = new SqlConnection(sql);
            SqlDataAdapter avtomobilTableAdapter = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(avtomobilTableAdapter);
            CherepanovavtosalonDataSet cherepanovavtosalonDataSet = new CherepanovavtosalonDataSet();
            avtomobilTableAdapter.Update(cherepanovavtosalonDataSet.Avtomobil);

            //SqlConnection con1 = new SqlConnection();
            //for(int index =0; index<dataGridView1.Rows.Count;index++)
            //{
            //    var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

            //    if (rowState == RowState.Existed)
            //        continue;

            //    if (rowState == RowState.Deleted)
            //    {
            //        var kod_avtomobilya = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            //        var deleteQuery = $"delete from Avtomobil where kod_avtomobilya = {kod_avtomobilya}";

            //       var command= new SqlCommand(deleteQuery, con1);
            //        command.ExecuteNonQuery();
            //    }    
            //}

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Обновление
            UpdateDB();
            /*UpdateDefaultButton();*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Сортировка по названием автомобиля
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Avtomobil Order by nazvanie desc", con1);
            con1.Open();
            da.Fill(ds, "Cherepanov avtosalon");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5();
            f5.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Сортировка по цветам
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Avtomobil Order by color desc", con1);
            con1.Open();
            da.Fill(ds, "Cherepanov avtosalon");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Сортировка по ценам
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=MSI; Initial Catalog=Cherepanov avtosalon; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Avtomobil Order by cena desc", con1);
            con1.Open();
            da.Fill(ds, "Cherepanov avtosalon");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
