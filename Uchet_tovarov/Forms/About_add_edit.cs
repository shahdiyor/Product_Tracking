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
    public partial class About_add_edit : Form
    {
        public About_add_edit()
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
                iden.Text = data.iden;
                tovCom.Text = data.tovar;
                col.Text =data.kol;
            }
            load();
        }

        public void load()
        {
            conn.Open();
            string tov = "select * from товары;";
            MySqlCommand comm = new MySqlCommand(tov, conn);
            MySqlDataReader t_reader = comm.ExecuteReader();
            DataTable tovar = new DataTable();
            tovar.Load(t_reader);
            tovCom.DataSource = tovar;
            tovCom.DisplayMember = "Название";
            tovCom.ValueMember = "ID";
            conn.Close();
        }

        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.add == true)
            {
                conn.Open();
                string comm = "insert into заказ(Идентификатор,Товар,Количество,Покупатели) values(@id,@tov,@col,@pok);";
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                if (iden.Text != "" && tovCom.Items != null && col.Text != "")
                {
                    cmd.Parameters.AddWithValue("@id", iden.Text);
                    cmd.Parameters.AddWithValue("@tov", tovCom.SelectedValue);
                    cmd.Parameters.AddWithValue("@col", col.Text);
                    cmd.Parameters.AddWithValue("@pok", data.zakaz_id);
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
                    MessageBox.Show("All fileds must be fill", "Attention", MessageBoxButtons.OK);
                }
                conn.Close();
            }
            else
            {
                string z = data.iden;
                int i = Convert.ToInt32(z);
                conn.Open();
                string ed = "update заказ set Идентификатор=@id,Товар=@tov,Количество=@col,Покупатели=@pok where Идентификатор="+i;
                MySqlCommand cm = new MySqlCommand(ed, conn);
                if (iden.Text != "" && tovCom.Items != null && col.Text != "")
                {
                    cm.Parameters.AddWithValue("@id", iden.Text);
                    cm.Parameters.AddWithValue("@tov", tovCom.SelectedValue);
                    cm.Parameters.AddWithValue("@col", col.Text);
                    cm.Parameters.AddWithValue("@pok", data.zakaz_id);
                    try
                    {
                        cm.ExecuteNonQuery();
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't be saved", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("All fileds must be fill", "Attention", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }
    }
}
