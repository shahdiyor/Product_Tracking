using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Uchet_tovarov
{
    public partial class Zakaz_add_edit : Form
    {
        public static String connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);

        public Zakaz_add_edit()
        {
            InitializeComponent();
            if (data.add == true)
            {
                button1.Text = "Add";
                this.Text = "Add";
            }
            else 
            {
                textBox1.Text = data.number;
                textBox2.Text = data.pokup;
                maskedTextBox2.Text = data.tel;
                maskedTextBox1.Text = data.date;
                button1.Text = "Save";
                this.Text = "Edit";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.add == true)
            {
                conn.Open();
                string quarry = "Insert into заказы(Номер_заказа,Покупатель,Телефон,Дата_заказа) values(@nom,@pok,@tel,@date)";
                MySqlCommand con = new MySqlCommand(quarry, conn);
                if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox1.MaskFull == true && maskedTextBox2.MaskFull == true)
                {
                    con.Parameters.AddWithValue("@nom", textBox1.Text);
                    con.Parameters.AddWithValue("@pok", textBox2.Text);
                    con.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
                    con.Parameters.AddWithValue("@date", maskedTextBox1.Text);
                    try
                    {
                        con.ExecuteNonQuery();
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't be added", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("All fields must be filled", "Attention", MessageBoxButtons.OK);
                }
                conn.Close();
            }
            else
            {
                string s = data.number;
                int i = Convert.ToInt32(s);
                conn.Open();
                string quar = "update заказы set Номер_заказа=@nom,Покупатель=@pok,Телефон=@tel,Дата_заказа=@date where Номер_заказа=" + i;
                MySqlCommand qua = new MySqlCommand(quar, conn);
                if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox1.MaskFull==true && maskedTextBox2.MaskFull == true)
                {
                    qua.Parameters.AddWithValue("@nom", textBox1.Text);
                    qua.Parameters.AddWithValue("@pok", textBox2.Text);
                    qua.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
                    qua.Parameters.AddWithValue("@date", maskedTextBox1.Text);
                    try
                    {
                        qua.ExecuteNonQuery();
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't be saved", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled", "Attention", MessageBoxButtons.OK);
                }

                conn.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && n != 8)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && n != 8)
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
    }
}
