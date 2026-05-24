using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace raschetka2._0
{
    public partial class change_ceh : Form
    {
        public data_цех writer=new data_цех();
        public change_ceh(data_цех reader,List<string> list)
        {
            InitializeComponent();
            foreach (string item in list)
                comboBox1.Items.Add(item);
            textBox2.Text = reader.ceh_name;
            textBox6.Text = reader.production;
            textBox7.Text = reader.phone_number;
            textBox8.Text = reader.adres;
            comboBox1.Text = reader.ceh_admin;
            writer = reader;
            button1.Enabled = false;
            button1.BackColor = Color.LightGray;
        }
        public void text(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text) &&//название
                    !string.IsNullOrEmpty(comboBox1.Text) &&//начальник_цеха
                    !string.IsNullOrEmpty(textBox6.Text) &&//продекция
                    !string.IsNullOrEmpty(textBox7.Text) &&//телеф
                    !string.IsNullOrEmpty(textBox8.Text) && (//адрес
                    textBox2.Text != writer.ceh_name ||
                    textBox6.Text != writer.production ||
                    textBox7.Text != writer.phone_number ||
                    textBox8.Text != writer.adres ||
                    comboBox1.Text != writer.ceh_admin))
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button1_Click (object sender, EventArgs e)
        {
            writer.ceh_name = textBox2.Text;
            writer.ceh_admin = comboBox1.Text;
            writer.production = textBox6.Text;
            writer.phone_number = textBox7.Text;
            writer.adres = textBox8.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void button2_Click(object sender, EventArgs e) => Close(); 
    }
}
