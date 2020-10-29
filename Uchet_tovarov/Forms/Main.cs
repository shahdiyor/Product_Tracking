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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Ocsp;

namespace Uchet_tovarov
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            add.Enabled = false;
            edit.Enabled = false;
            del.Enabled = false;
            button4.Enabled = false;
            about.Visible = false;
            nazRad.Enabled = false;
            cateRad.Enabled = false;
            posrad.Enabled = false;
        }
        public static string connString = ConfigurationManager.AppSettings.Get("ConnDB");
        MySqlConnection conn = new MySqlConnection(connString);

        DataTable table = new DataTable();
        DataTable table_zak = new DataTable();
        DataTable table_pos = new DataTable();
        DataTable table_cat = new DataTable();

        public void Tovar()
        {
            if (about.Visible == true)
            {
                about.Visible = false;
            }
            if (add.Enabled == false)
            {
                add.Enabled = true;
                edit.Enabled = true;
                del.Enabled = true;
            }
            try
            {
                conn.Open();
                string quarry = "select ID,Название,Всего,Стоимость,категория.Категория,поставщик.Поставщик,Заметка from товары inner join категория on товары.Категория=категория.Код_категории inner join поставщик on товары.Поставщик=поставщик.Код_поставщика;";
                MySqlCommand com = new MySqlCommand(quarry, conn);
                MySqlDataReader reader = com.ExecuteReader();
                table.Load(reader);
                dataGridView1.DataSource = table;
                conn.Close();
            }
            catch
            {
                message_box();
            }
        }
        public void zakaz()
        {

            if (add.Enabled == false)
            {
                add.Enabled = true;
                edit.Enabled =true;
                del.Enabled = true;
            }
            try
            {
                conn.Open();
                string zakazi = "select * from заказы;";
                MySqlCommand zakaz = new MySqlCommand(zakazi, conn);
                MySqlDataReader read_zakaz = zakaz.ExecuteReader();
                table_zak.Load(read_zakaz);
                dataGridView1.DataSource = table_zak;

                conn.Close();
            }
            catch
            {
                message_box();
            }
        }
       
        public void postav()
        {
            if (about.Visible == true)
            {
                about.Visible = false;
            }
            if (add.Enabled == false)
            {
                add.Enabled = true;
                edit.Enabled = true;
                del.Enabled = true;
            }
            try
            {
                conn.Open();
                string post = "select * from поставщик";
                MySqlCommand pos = new MySqlCommand(post, conn);
                MySqlDataReader reader_pos = pos.ExecuteReader();
                table_pos.Load(reader_pos);
                dataGridView1.DataSource = table_pos;
                conn.Close();
            }
            catch
            {
                message_box();
            }
        }
        public void categ()
        {
            if (about.Visible == true)
            {
                about.Visible = false;
            }
            else if (add.Enabled == false)
            {
                add.Enabled = true;
                edit.Enabled = true;
                del.Enabled = true;
            }
            try
            {
                conn.Open();
                string otd = "select * from категория;";
                MySqlCommand otdel = new MySqlCommand(otd, conn);
                MySqlDataReader reader_otdel = otdel.ExecuteReader();
                table_cat.Load(reader_otdel);
                dataGridView1.DataSource = table_cat;
                conn.Close();
            }
            catch
            {
                message_box();
            }
        }

        public void message_box()
        {
            MessageBox.Show("DB no found!", "Error", MessageBoxButtons.OK);
        }
        private void Tovar_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox1.Mask = "";
            posrad.Visible = true;
            nazRad.Enabled = true;
            posrad.Enabled = true;
            cateRad.Enabled = true;
            nazRad.Text = "Названию";
            cateRad.Text = "Категории";
            postavs.Enabled = true;
            zaka.Enabled = true;
            tov.Enabled = false;
            catego.Enabled = true;
            Tovar();
        }

        private void zakaz_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            maskedTextBox1.Enabled = true;
            if (cateRad.Checked == true)
            { maskedTextBox1.Mask = "00/00/0000"; }
            nazRad.Enabled = true;
            cateRad.Enabled = true;
            posrad.Visible = false;
            nazRad.Text = "ФИО";
            cateRad.Text = "Дате заказа";
            postavs.Enabled = true;
            zaka.Enabled = false;
            tov.Enabled = true;
            catego.Enabled = true;
            about.Visible = true;
            zakaz();
        }

        private void postav_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            nazRad.Enabled = true;
            cateRad.Enabled = true;
            maskedTextBox1.Enabled = true;
            postavs.Enabled = false;
            zaka.Enabled = true;
            tov.Enabled = true;
            catego.Enabled = true;
            posrad.Visible = false;
            nazRad.Text = "Названию";
            cateRad.Text = "Контактному лицу";
            postav();
        }

        private void categ_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button4.Enabled = false;
            maskedTextBox1.Enabled = false;
            cateRad.Enabled = false;
            nazRad.Enabled = false;
            posrad.Enabled = false;
            postavs.Enabled = true;
            zaka.Enabled = true;
            tov.Enabled = true;
            catego.Enabled = false;
            categ();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource.ToString() == "заказы")
            {
                data.add = true;
                Zakaz_add_edit z = new Zakaz_add_edit();
                z.ShowDialog();
                zakaz();
            }
            else if (dataGridView1.DataSource.ToString() == "")
            {
                data.add = true;
                Tovar_add_edit t = new Tovar_add_edit();
                t.ShowDialog();
                Tovar();
            }
            else if (dataGridView1.DataSource.ToString() == "поставщик")
            {
                data.add = true;
                Postavshik_add_edit p = new Postavshik_add_edit();
                p.ShowDialog();
                postav();
            }
            else if (dataGridView1.DataSource.ToString() == "категория")
            {
                data.add = true;
                Category_add_edit c = new Category_add_edit();
                c.ShowDialog();
                categ();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource.ToString() == "заказы")
            {
                data.Row = dataGridView1.CurrentRow.Index.ToString();
                data.add = false;
                data.number = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                data.pokup = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                data.tel = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                data.date = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Zakaz_add_edit z = new Zakaz_add_edit();
                z.ShowDialog();
                zakaz();
            }
            else if (dataGridView1.DataSource.ToString()=="категория")
            {
                data.add = false;
                data.categ = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                data.cat_kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Category_add_edit c = new Category_add_edit();
                c.ShowDialog();
                categ();
            }
            else if (dataGridView1.DataSource.ToString() == "поставщик")
            {
                data.add = false;
                data.pos_cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                data.pos = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                data.pos_tel = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                data.pos_kont = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                data.inn = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                data.adress = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Postavshik_add_edit p = new Postavshik_add_edit();
                p.ShowDialog();
                postav();
            }
            else if (dataGridView1.DataSource.ToString() == "")
            {
                data.add = false;
                data.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                data.naz = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                data.cat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                data.postav = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                data.vsego = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                data.stoim = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                data.zam = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Tovar_add_edit t = new Tovar_add_edit();
                t.ShowDialog();
                Tovar();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource.ToString() == "заказы")
            {
                conn.Open();
                string delete = "delete from заказы where Номер_заказа=" + dataGridView1.CurrentRow.Cells[0].Value;
                MySqlCommand cmd = new MySqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                zakaz();
            }
            else if (dataGridView1.DataSource.ToString() == "")
            {
                conn.Open();
                string delete = "delete from товары where ID=" + dataGridView1.CurrentRow.Cells[0].Value;
                MySqlCommand cmd = new MySqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Tovar();
            }
            else if (dataGridView1.DataSource.ToString() == "поставщик")
            {
                conn.Open();
                string delete = "delete from поставщик where Код_поставщика=" + dataGridView1.CurrentRow.Cells[0].Value;
                MySqlCommand cmd = new MySqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                postav();
            }
            else if (dataGridView1.DataSource.ToString() == "категория")
            {
                conn.Open();
                string delete = "delete from категория where Код_категории=" + dataGridView1.CurrentRow.Cells[0].Value;
                MySqlCommand cmd = new MySqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                categ();
            }
            else
            {
                MessageBox.Show("Row not selected","Attention",MessageBoxButtons.OK);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            data.print = false;
            data.zakaz_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Zakaz z = new Zakaz();
            z.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource.ToString() == "заказы")
            {
                if(maskedTextBox1.Text != "")
                {
                    if (nazRad.Checked == true)
                    {

                        DataView zak_t = table_zak.DefaultView;
                        zak_t.RowFilter = string.Format("Покупатель like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource = zak_t.ToTable();
                    }
                    else if (cateRad.Checked == true)
                    {
                        DataView date = table_zak.DefaultView;
                        date.RowFilter = string.Format("Дата_заказа like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource = date.ToTable();
                    }
                    else { MessageBox.Show("The search category must be selected", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    MessageBox.Show("Field must be fill!", "Attention", MessageBoxButtons.OK);
                }
            }
            else if (dataGridView1.DataSource.ToString() == "")
            {
                if (maskedTextBox1.Text != "")
                {
                    if (nazRad.Checked == true)
                    {
                        DataView naz = table.DefaultView;
                        naz.RowFilter = string.Format("Название like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource = naz.ToTable();
                    }
                    else if (cateRad.Checked == true)
                    {
                        DataView cat = table.DefaultView;
                        cat.RowFilter = string.Format("Категория like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource = cat.ToTable();
                    }
                    else if (posrad.Checked == true)
                    {
                        DataView pos = table.DefaultView;
                        pos.RowFilter = string.Format("Поставщик like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource = pos.ToTable();
                    }
                    else { MessageBox.Show("The search category must be selected", "Attention",MessageBoxButtons.OK,MessageBoxIcon.Information); }
                }
                else
                {
                    MessageBox.Show("Field must be fill!", "Attention", MessageBoxButtons.OK);
                }
            }
            else if (dataGridView1.DataSource.ToString() == "поставщик")
            {
                if (maskedTextBox1.Text != "")
                {
                    if (nazRad.Checked == true)
                    {
                        DataView nai_t = table_pos.DefaultView;
                        nai_t.RowFilter = string.Format("Поставщик like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource =nai_t.ToTable();
                    }
                    else if (cateRad.Checked == true)
                    {
                        DataView cont = table_pos.DefaultView;
                        cont.RowFilter = string.Format("Контактное_лицо like '%{0}%'", maskedTextBox1.Text);
                        dataGridView1.DataSource = cont.ToTable();
                    }
                    else { MessageBox.Show("The search category must be selected", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    MessageBox.Show("Field must be fill!", "Attention", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox1.Mask="";
            button4.Enabled = false;
            if (dataGridView1.DataSource.ToString() == "заказы")
            {
                table_zak.DefaultView.RowFilter = string.Empty;
                zakaz();
            }
            else if (dataGridView1.DataSource.ToString() == "")
            {
                table.DefaultView.RowFilter = string.Empty;
                Tovar();
            }
            else if (dataGridView1.DataSource.ToString() == "поставщик")
            {
                table_pos.DefaultView.RowFilter = string.Empty;
                postav();
            }
            else if (dataGridView1.DataSource.ToString() == "категория")
            {
                table_cat.DefaultView.RowFilter = string.Empty;
                categ();
            }
        }

        private void cateRad_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource.ToString() == "заказы")
            {
                maskedTextBox1.Mask = "00/00/0000";
            }
            else { maskedTextBox1.Mask = ""; }
        }

        private void nazRad_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "";
        }

        private void posrad_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void invoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Naklad n = new Naklad();
            n.ShowDialog();
        }

        private void списокТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tovar();
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postav();
            printDialog1.ShowDialog();
        }
    }
}
