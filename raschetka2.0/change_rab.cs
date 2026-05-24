using Npgsql;

namespace raschetka2._0
{
    public partial class change_rab : Form
    {
        public data_сотрудник writer = new data_сотрудник();
        public change_rab(data_сотрудник reader, List<string> list)
        {
            InitializeComponent();
            writer = reader;
            comboBox1.Text = writer.ceh_name;
            textBox2.Text = writer.surname;
            textBox3.Text = writer.phone_number;
            textBox4.Text = writer.oklad;
            textBox1.Text = writer.adres;
            textBox6.Text = writer.name;
            textBox7.Text = writer.father_name;
            textBox8.Text = writer.dolznost;
            foreach (string item in list)
                comboBox1.Items.Add(item);
        }
        private void text(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) &&      // ceh_name
    !string.IsNullOrEmpty(textBox2.Text) &&        // surname
    !string.IsNullOrEmpty(textBox3.Text) &&        // phone_number
    !string.IsNullOrEmpty(textBox4.Text) &&        // oklad
    !string.IsNullOrEmpty(textBox1.Text) &&        // adres
    !string.IsNullOrEmpty(textBox6.Text) &&        // name
    !string.IsNullOrEmpty(textBox7.Text) &&        // father_name
    !string.IsNullOrEmpty(textBox8.Text) &&        // dolznost
    (comboBox1.Text != writer.ceh_name ||
     textBox2.Text != writer.surname ||
     textBox3.Text != writer.phone_number ||
     textBox4.Text != writer.oklad ||
     textBox1.Text != writer.adres ||
     textBox6.Text != writer.name ||
     textBox7.Text != writer.father_name ||
     textBox8.Text != writer.dolznost))
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

        private void button2_Click(object sender, EventArgs e) => Close();

        private void button1_Click(object sender, EventArgs e)
        {
            writer.ceh_name = comboBox1.Text;
            writer.surname = textBox2.Text;
            writer.phone_number = textBox3.Text;
            writer.oklad = textBox4.Text;
            writer.adres = textBox1.Text;
            writer.name = textBox6.Text;
            writer.father_name = textBox7.Text;
            writer.dolznost = textBox8.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
