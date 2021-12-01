using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UP53
{
    public partial class Form1 : Form
    {
        static string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UP54;Integrated Security=True";
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();

        public Form1()
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            InitializeComponent();


            cod.ConnectionString = constr;
            cmt.Connection = cod;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uP54DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.uP54DataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uP54DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.uP54DataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPPDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.uP54DataSet.Service);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Update(this.uP54DataSet.Service);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cod.Open();
            cmt.CommandText = "insert into Service values ( '" + textBox1.Text + "','" + textBox2.Text + "', '" + Convert.ToInt64(textBox3.Text) + "', '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "' )";
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "DELETE from Service where ID= " + dataGridView1.CurrentRow.Cells[0].Value;
                    string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UP54;Integrated Security=True";
                    using (SqlConnection col = new SqlConnection(constring))
                    {
                        col.Open();
                        SqlCommand cmdd = new SqlCommand(sql, col);
                        sql = "SELECT * from Service";
                        cmdd.ExecuteNonQuery();
                        DataSet ds = new DataSet();
                        SqlDataAdapter ad = new SqlDataAdapter(sql, constring);
                        ad.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        col.Close();
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UP54;Integrated Security=True";
            string sql = "SELECT * FROM Service";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f7 = new Form2(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 zap = new Form5();
            zap.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "DELETE from Service where ID= " + dataGridView1.CurrentRow.Cells[0].Value;
                    string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UP54;Integrated Security=True";
                    using (SqlConnection col = new SqlConnection(constring))
                    {
                        col.Open();
                        SqlCommand cmdd = new SqlCommand(sql, col);
                        sql = "SELECT * from Service";
                        cmdd.ExecuteNonQuery();
                        DataSet ds = new DataSet();
                        SqlDataAdapter ad = new SqlDataAdapter(sql, constring);
                        ad.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        col.Close();
                    }
                }

            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UP54;Integrated Security=True";
            string sql = "SELECT * FROM Service";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form2 f7 = new Form2(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            f7.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            cod.Open();
            cmt.CommandText = "insert into Service values ( '" + textBox1.Text + "','" + textBox2.Text + "', '" + Convert.ToInt64(textBox3.Text) + "', '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "' )";
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form5 zap = new Form5();
            zap.ShowDialog(); ;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox7.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                        dataGridView1.Rows[i].Selected = false;

                    }
                }
            }
        }
    }
}