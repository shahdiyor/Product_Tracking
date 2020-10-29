using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet_tovarov
{
    public partial class Naklad : Form
    {
        public Naklad()
        {
            InitializeComponent();
            load();
        }
        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);

        public void load()
        {
            conn.Open();
            string c = "Select * from заказы";
            MySqlCommand category = new MySqlCommand(c, conn);
            MySqlDataReader c_reader = category.ExecuteReader();
            DataTable table_1 = new DataTable();
            table_1.Load(c_reader);
            comboBox1.DataSource = table_1;
            comboBox1.DisplayMember = "Покупатель";
            comboBox1.ValueMember = "Номер_заказа";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.print = true;
            data.zakaz_id = comboBox1.SelectedValue.ToString();
            Zakaz z = new Zakaz();
            z.ShowDialog();
            Hide();
        }
    }
}
