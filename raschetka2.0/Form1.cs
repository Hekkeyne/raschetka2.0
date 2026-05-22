namespace raschetka2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_form1(object sender, EventArgs e)
        {
            acess_to_db atdb = new acess_to_db();
            atdb.ShowDialog();
        }
    }
}
