using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace raschetka2._0
{
    public partial class acess_to_db : Form
    {
        public acess_to_db()
        {
            InitializeComponent();
            Action check_textbox = () =>
            {
                button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text);
                enable_gtdb(false);
                comboBox1.Items.Clear();
            };
            Action check_button2 = () =>
            {
                if (button2.Text == "Создать базу") button2.Enabled = !string.IsNullOrEmpty(textBox5.Text);
                else button2.Enabled = true;
            };
            textBox5.TextChanged += (s, e) => check_button2();
            textBox1.TextChanged += (s, e) => check_textbox();
            textBox2.TextChanged += (s, e) => check_textbox();
            textBox3.TextChanged += (s, e) => check_textbox();
            textBox4.TextChanged += (s, e) => check_textbox();
            check_textbox();
        }
        public void enable_gtdb(bool enab)
        {
            label6.Enabled = enab;
            comboBox1.Enabled = enab;
            button2.Enabled = enab;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
            label7.Text = "Подключение...";
            button1.Text = "Подключение...";
            button1.Enabled = false;
            if (int.TryParse(textBox2.Text, out int port))
            {
                try
                {
                    data_for_connection.host = textBox1.Text;
                    data_for_connection.port = textBox2.Text;
                    data_for_connection.username = textBox3.Text;
                    data_for_connection.password = textBox4.Text;
                    var conn = server.connect_or_create("view");
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange((await conn).combobox_items.ToArray());
                    comboBox1.Items.Add("Создать базу...");
                    button1.Text = "Подключиться";
                    button1.Enabled = true;
                    label7.ForeColor = Color.Green;
                    label7.Text = "Успешно покдлючено!";
                    comboBox1.SelectedIndex = 0;
                    enable_gtdb(true);
                }
                catch
                {
                    enable_gtdb(false);
                    label7.ForeColor = Color.Red;
                    label7.Text = "Не удалось подключиться";
                    button1.Text = "Подключиться";
                    button1.Enabled = true;
                }
            }
            else { MessageBox.Show("Порт должен состоять из цифр"); button1.Text = "Подключиться"; button1.Enabled = true; ; return; }

        }
        private void combobox1_selectedondexchanched(object sender, EventArgs e)
        {
            string choose = comboBox1.Text;
            if (choose == "Создать базу...")
            {
                button2.Text = "Создать базу";
                button2.Enabled = false;
                button2.Location = new Point(107, 260);
                textBox5.Visible = true;
                label8.Visible = true;
            }
            else
            {
                button2.Text = "Перейти к базе";
                button2.Enabled = true;
                button2.Location = new Point(107, 231);
                textBox5.Visible = false;
                label8.Visible = false;
            }
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if (button2.Text == "Перейти к базе")
            {
                button2.Enabled = false;
                button2.Text = "Открываем...";
                data_for_connection.database = comboBox1.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                button2.Enabled = false;
                button2.Text = "Создание...";
                data_for_connection.database = textBox5.Text;
                var create = server.connect_or_create("create");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
