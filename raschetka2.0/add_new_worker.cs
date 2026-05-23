using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace raschetka2._0
{
    public partial class add_new_worker : Form
    {
        public add_new_worker(List<string> name_ceh)
        {
            InitializeComponent();
            foreach(string name in name_ceh) 
                comboBox1.Items.Add(name);
            comboBox1.Items.Add("Пусто");
            comboBox1.SelectedIndex = 0;
        }
        private void text(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox8.Text))
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

        private void add_button(object sender, EventArgs e)
        {
            server.add_сотрудник(comboBox1.Text, textBox3.Text, 
                textBox2.Text, textBox4.Text,
                textBox5.Text, textBox6.Text, 
                textBox7.Text, textBox8.Text);
            DialogResult = DialogResult.OK;
        }

        private void cancel_button(object sender, EventArgs e)=>Close();
    }
}
