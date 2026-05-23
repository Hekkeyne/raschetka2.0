using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace raschetka2._0
{
    public partial class add_new_ceh : Form
    {
        public add_new_ceh(List<string> value)
        {
            InitializeComponent();
            comboBox1.Items.Add("Пусто");
            if (value != null )
            foreach (string i in value)
                comboBox1.Items.Add(i);
            comboBox1.SelectedIndex = 0;
        }

        private void null_or_fill(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) &&//название
                !string.IsNullOrEmpty(comboBox1.Text) &&//начальник_цеха
                !string.IsNullOrEmpty(textBox6.Text) &&//продекция
                !string.IsNullOrEmpty(textBox7.Text) &&//телеф
                !string.IsNullOrEmpty(textBox8.Text))//адрес
            {
                button1.Enabled = true;
                button1.BackColor = Color.LightGreen;
            }
            else
            {
                button1.Enabled = false;
                button1.BackColor = Color.LightGray;
            }
        }

        private void cancel_button(object sender, EventArgs e) => Close();

        private void add_button(object sender, EventArgs e)
        {
            button1.BackColor= Color.LightGray;
            button1.Text = "Добавляем...";
            try
            {
                server.do_цех(textBox2.Text,
                    comboBox1.Text,
                    textBox6.Text,
                    textBox7.Text,
                    textBox8.Text);
                DialogResult = DialogResult.OK;
                label10.ForeColor = Color.Green;
                label10.Text = "Успешно добавлено!";
                Close();
            }catch (Exception ex) { throw new ArgumentException($"{ex}"); }
        }
    }
}
