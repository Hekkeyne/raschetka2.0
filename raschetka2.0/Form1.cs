namespace raschetka2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void lod(object sender, EventArgs e)
        {
            acess_to_db atdb = new acess_to_db();
            if (atdb.ShowDialog() == DialogResult.OK)
            {
                dataGridView2.DataSource = server.open_db("цех").цех;
                dataGridView2.Columns[0].Visible = false;
                dataGridView1.DataSource = server.open_db("сотрудники").сотрудники;
                dataGridView1.Columns[0].Visible = false;
            }
            else Close();
        }
        private void resize_form1(object sender, EventArgs e) => groupBox1.Width = ClientSize.Width / 3;
    }
}
