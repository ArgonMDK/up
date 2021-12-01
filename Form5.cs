using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace UP53
{
    public partial class Form5 : Form
    {
        static string conSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UP54;Integrated Security=True";
        DataContext cont = new DataContext(conSTR);
        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Table<ClientServ> cservs = cont.GetTable<ClientServ>();
            dataGridView2.DataSource = cservs.ToList();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uP54DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.uP54DataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uP54DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.uP54DataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uP54DataSet.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.uP54DataSet.ClientService);

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Добавить", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                ClientServ clientServ = new ClientServ { ClientID = comboBox2.SelectedIndex, ServiceID = comboBox1.SelectedIndex, StartTime = dateTimePicker1.Value };
                cont.GetTable<ClientServ>().InsertOnSubmit(clientServ);
                cont.SubmitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
