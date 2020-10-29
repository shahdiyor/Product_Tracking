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
    public partial class Tovar_add_edit : Form
    {
        public Tovar_add_edit()
        {
            InitializeComponent();
            if (data.add == true)
            {
                this.Text = "Add";
                button1.Text = "Add";
            }
            else
            {
                this.Text = "Edit";
                button1.Text = "Save";
                textBox1.Text = data.id;
                textBox2.Text = data.naz;
                comboBox1.Text = data.cat;
                comboBox2.Text = data.postav;
                textBox3.Text = data.vsego;
                textBox4.Text = data.stoim;
                textBox5.Text = data.zam;
            }
            load();
        }

        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);

        public void load()
        {
            conn.Open();
            string c = "Select * from категория";
            MySqlCommand category = new MySqlCommand(c, conn);
            MySqlDataReader c_reader = category.ExecuteReader();
            DataTable table_1 = new DataTable();
            table_1.Load(c_reader);
            comboBox1.DataSource = table_1;
            comboBox1.DisplayMember = "Категория";
            comboBox1.ValueMember = "Код_категории";
            string p = "Select * from поставщик";
            MySqlCommand postav = new MySqlCommand(p, conn);
            MySqlDataReader p_reader = postav.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(p_reader);
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "Поставщик";
            comboBox2.ValueMember = "Код_поставщика";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.add == true)
            {
                conn.Open();
                string comm = "insert into товары(ID,Название,Категория,Поставщик,Всего,Стоимость,Заметка) Values(@id,@naz,@cat,@post,@vsego,@stoi,@zam);";
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox2.Text != "")
                {
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@naz", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cat", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@post", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@vsego", textBox3.Text);
                    cmd.Parameters.AddWithValue("@stoi", textBox4.Text);
                    cmd.Parameters.AddWithValue("@zam", textBox5.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Hide();

                    }
                    catch
                    {
                        MessageBox.Show("Couldn't be added", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("All fields must be fill!", "Attention", MessageBoxButtons.OK);
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                string s = data.id;
                int i = Convert.ToInt32(s);
                string quarry = "update товары set ID=@id,Название=@naz,Категория=@cat,Поставщик=@post,Всего=@vsego,Стоимость=@stoi,Заметка=@zam where ID=" + i;
                MySqlCommand command = new MySqlCommand(quarry, conn);
                if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox2.Text != "")
                {
                    command.Parameters.AddWithValue("@id", textBox1.Text);
                    command.Parameters.AddWithValue("@naz", textBox2.Text);
                    command.Parameters.AddWithValue("@cat", comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@post", comboBox2.SelectedValue);
                    command.Parameters.AddWithValue("@vsego", textBox3.Text);
                    command.Parameters.AddWithValue("@stoi", textBox4.Text);
                    command.Parameters.AddWithValue("@zam", textBox5.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't be saved", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be fill!", "Attention", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
