namespace raschetka2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
        }

        private async void lod(object sender, EventArgs e)
        {
            acess_to_db atdb = new acess_to_db();
            if (atdb.ShowDialog() == DialogResult.OK)
            {
                dataGridView2.DataSource = (await server.open_db("цех")).цех;
                dataGridView2.Columns[0].Visible = false;
                dataGridView1.DataSource = (await server.open_db("сотрудники")).сотрудники;
                dataGridView1.Columns[0].Visible = false;
            }
            else Close();
        }
        private void resize_form1(object sender, EventArgs e) => groupBox1.Width = ClientSize.Width / 3;

        private void selection_changed_цех(object sender, EventArgs e)
        {
            //вывод толко нужных сотрудников
        }

        private async void добавитьНоыйЦехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
                list.Add(dataGridView1[2, i].Value.ToString());
            var add = new add_new_ceh(list.Distinct().ToList());
            if (add.ShowDialog() == DialogResult.OK)
                dataGridView2.DataSource = (await server.open_db("цех")).цех;
        }

        private async void удалитьЦехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conf_del = new confirm_del(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString(), "цех");
            if (conf_del.ShowDialog() == DialogResult.OK)
                dataGridView2.DataSource = (await server.open_db("цех")).цех;
        }

        private async void удалитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conf_del = new confirm_del(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(), "сотрудник");
            if (conf_del.ShowDialog() == DialogResult.OK)
                dataGridView1.DataSource = (await server.open_db("сотрудники")).сотрудники;
        }
    }
}
