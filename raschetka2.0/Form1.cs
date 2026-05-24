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
            if ((new acess_to_db()).ShowDialog() == DialogResult.OK)
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
            dataGridView2.DataSource = ((new add_new_ceh(list.Distinct().ToList())).ShowDialog() == DialogResult.OK)
                ? (await server.open_db("цех")).цех
                : dataGridView2.DataSource;
        }

        private async void удалитьЦехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ((new confirm_del(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString(), "цех")).ShowDialog() == DialogResult.OK)
                ? (await server.open_db("цех")).цех
                : dataGridView2.DataSource;
        }

        private async void удалитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ((new confirm_del(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(), "сотрудник")).ShowDialog() == DialogResult.OK)
                ? (await server.open_db("сотрудники")).сотрудники
                : dataGridView1.DataSource;
        }

        private async void добавитьНовогоРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list_ceh = new List<string>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
                list_ceh.Add(dataGridView2[1, i].Value.ToString());
            dataGridView1.DataSource = ((new add_new_worker(list_ceh.Distinct().ToList())).ShowDialog() == DialogResult.OK)
                ? (await server.open_db("сотрудники")).сотрудники
                : dataGridView1.DataSource;
        }

        private async void изменитьСведенияОЦехеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell == null)
            {
                MessageBox.Show("Выберите цех для изменения");
                return;
            }
            List<string> list = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
                list.Add(dataGridView1[2, i].Value.ToString());
            var writer = new data_цех();
            writer.ceh_name = dataGridView2["Название_цеха", dataGridView2.CurrentCell.RowIndex].Value.ToString();
            writer.ceh_admin = dataGridView2["Начальник_цеха", dataGridView2.CurrentCell.RowIndex].Value.ToString();
            writer.production = dataGridView2["Продукция", dataGridView2.CurrentCell.RowIndex].Value.ToString();
            writer.phone_number = dataGridView2["Телефон", dataGridView2.CurrentCell.RowIndex].Value.ToString();
            writer.adres = dataGridView2["Адрес", dataGridView2.CurrentCell.RowIndex].Value.ToString();
            dataGridView2.DataSource = ((new change_ceh(writer, list)).ShowDialog() == DialogResult.OK)
                ? (await server.change_table(dataGridView2["Счётчик_цеха", dataGridView2.CurrentCell.RowIndex].Value.ToString(), "цех", writer, null)).цех
                : dataGridView2.DataSource;
        }

        private async void изменитьСведенияОСотрудникеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Выберите цех для изменения");
                return;
            }
            List<string> list = new List<string>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
                list.Add(dataGridView2[1, i].Value.ToString());
            var writer = new data_сотрудник();
            writer.ceh_name = dataGridView1["Название_цеха", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.surname = dataGridView1["Фамилия", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.name = dataGridView1["Имя", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.father_name = dataGridView1["Отчество", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.dolznost = dataGridView1["Должность", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.oklad = dataGridView1["Оклад", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.phone_number = dataGridView1["Телефон", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            writer.adres = dataGridView1["Адрес", dataGridView1.CurrentCell.RowIndex].Value?.ToString() ?? string.Empty;
            dataGridView1.DataSource = ((new change_rab(writer, list)).ShowDialog() == DialogResult.OK)
                ? (await server.change_table(dataGridView1["Счётчик_сотрудника", dataGridView1.CurrentCell.RowIndex].Value.ToString(), "сотрудники", null, writer)).сотрудники
                : dataGridView1.DataSource;
        }

        private void просмотрПоЦехамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
