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
    public partial class Category_add_edit : Form
    {
        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);
        public Category_add_edit()
        {
            InitializeComponent();
            if (data.add == true)
            {
                button1.Text = "Add";
                this.Text = "Add";
            }
            else
            {
                button1.Text = "Save";
                this.Text = "Edit";
                textBox1.Text = data.cat_kod;
                textBox2.Text = data.categ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.add == true)
            {
                conn.Open();
                string com = "Insert into категория(Код_категории,Категория) Values(@cod,@categ)";
                MySqlCommand cmd = new MySqlCommand(com, conn);
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    cmd.Parameters.AddWithValue("@cod", textBox1.Text);
                    cmd.Parameters.AddWithValue("@categ", textBox2.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Hide();
                        conn.Close();
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
            }
            else if(data.add==false)
            {
                conn.Open();
                string s = data.cat_kod;
                int i = Convert.ToInt32(s);
                string comm = "update категория set Код_категории=@cod,Категория=@categ where Код_категории=" + i;
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    cmd.Parameters.AddWithValue("@cod", textBox1.Text);
                    cmd.Parameters.AddWithValue("@categ", textBox2.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
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
    }
}
