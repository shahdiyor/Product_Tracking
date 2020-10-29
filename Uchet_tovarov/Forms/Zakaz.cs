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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
            if (data.print == true)
            {
                print();
            }
            load();
        }
        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);
        private object sum;

        public void print()
        {
            printDialog1.ShowDialog();
            Hide();
        }

        public void load()
        {
            try
            {
                conn.Open();
                string z = data.zakaz_id;
                int i = Convert.ToInt32(z);
                string comm = "select Идентификатор,товары.Название as Товар,товары.Стоимость as Цена,Количество,(товары.Стоимость*Количество) as Сумма from заказ inner join товары on заказ.товар=товары.ID where Покупатели=" + z;
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                MySqlDataReader z_reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(z_reader);
                dataGridView1.DataSource = table;
                sum = table.Compute("SUM(Сумма)", null);
                label2.Text = sum.ToString() + " ₽";
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error while connect to DB", "Error", MessageBoxButtons.OK);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                string z = data.zakaz_id;
                int i = Convert.ToInt32(z);
                conn.Open();
                string comm = "delete from заказ where Идентификатор=" + dataGridView1.CurrentRow.Cells[0].Value;
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                load();
            }
            catch
            {
                MessageBox.Show("Delete faild","Error",MessageBoxButtons.OK);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            data.add = true;
            About_add_edit a = new About_add_edit();
            a.ShowDialog();
            load();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            data.add = false;
            data.iden = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            data.tovar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            data.kol = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            About_add_edit a = new About_add_edit();
            a.ShowDialog();
            load();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
