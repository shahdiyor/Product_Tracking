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
    public partial class Postavshik_add_edit : Form
    {
        public Postavshik_add_edit()
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
                textBox1.Text = data.pos_cod;
                textBox2.Text = data.pos;
                maskedTextBox1.Text = data.pos_tel;
                textBox4.Text = data.pos_kont;
                textBox5.Text = data.inn;
                textBox6.Text = data.adress;
            }
        }

        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.add == true)
            {
                conn.Open();
                string comm = "insert into поставщик(Код_поставщика,Поставщик,Телефон,Контактное_лицо,ИНН,Адрес) Values(@cod,@post,@tel,@cont,@inn,@adress);";
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox1.MaskFull == true && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    cmd.Parameters.AddWithValue("@cod", textBox1.Text);
                    cmd.Parameters.AddWithValue("@post", textBox2.Text);
                    cmd.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@cont", textBox4.Text);
                    cmd.Parameters.AddWithValue("@inn", textBox5.Text);
                    cmd.Parameters.AddWithValue("@adress", textBox6.Text);
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
                string s = data.pos_cod;
                int i = Convert.ToInt32(s);
                string quarry = "update поставщик set Код_поставщика=@cod,Поставщик=@post,Телефон=@tel,Контактное_лицо=@cont,ИНН=@inn,Адрес=@adress where Код_поставщика=" + i;
                MySqlCommand command = new MySqlCommand(quarry, conn);
                if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox1.MaskFull == true && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    command.Parameters.AddWithValue("@cod", textBox1.Text);
                    command.Parameters.AddWithValue("@post", textBox2.Text);
                    command.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("@cont", textBox4.Text);
                    command.Parameters.AddWithValue("@inn", textBox5.Text);
                    command.Parameters.AddWithValue("@adress", textBox6.Text);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >=58) && n != 8)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && n != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && n != 8)
            {
                e.Handled = true;
            }
        }
    }
}
