using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace raschetka2._0
{
    public partial class confirm_del : Form
    {
        string delete_id;
        string tabel;
        public confirm_del(string di, string tba)
        {
            InitializeComponent();
            delete_id = di;
            tabel = tba;
            del();
        }
        public async void del()
        {
            button1.Enabled = false;
            button1.BackColor = Color.LightGray;
            for (int i = 1; i <= 3; i++)
            {
                button1.Text = $"Удалить через {4 - i} сек.";
                await Task.Delay(1000);
            }
            button1.Text = "Удалить";
            button1.Enabled = true;
            button1.BackColor = Color.FromArgb(255, 192, 192);

        }

        private void exit_button(object sender, EventArgs e) => Close();

        private void delete_button(object sender, EventArgs e)
        {
            server.delete_zap(delete_id, tabel);
            DialogResult=DialogResult.OK;
            Close();
        }
    }
}
