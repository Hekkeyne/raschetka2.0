using Npgsql.Internal;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace raschetka2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public class DBDataGridView : DataGridView { protected override bool DoubleBuffered { get => true; } }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            работаСЦехомToolStripMenuItem = new ToolStripMenuItem();
            добавитьНоыйЦехToolStripMenuItem = new ToolStripMenuItem();
            изменитьСведенияОЦехеToolStripMenuItem = new ToolStripMenuItem();
            удалитьЦехToolStripMenuItem = new ToolStripMenuItem();
            работаССотрудникамиToolStripMenuItem = new ToolStripMenuItem();
            добавитьНовогоРаботникаToolStripMenuItem = new ToolStripMenuItem();
            изменитьСведенияОСотрудникеToolStripMenuItem = new ToolStripMenuItem();
            удалитьСотрудникаToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DBDataGridView();
            dataGridView2 = new DBDataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            добавитьНовогоСотрудникаToolStripMenuItem = new ToolStripMenuItem();
            изменитьСведенияОСотрудникеToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьСотрудникаToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            добавитьНовыйЦехToolStripMenuItem = new ToolStripMenuItem();
            изменитьСведенияОЦехеToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьЦехToolStripMenuItem1 = new ToolStripMenuItem();
            просмотрПоЦехамToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Items.AddRange(new ToolStripItem[] { работаСЦехомToolStripMenuItem, работаССотрудникамиToolStripMenuItem, просмотрПоЦехамToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1085, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // работаСЦехомToolStripMenuItem
            // 
            работаСЦехомToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьНоыйЦехToolStripMenuItem, изменитьСведенияОЦехеToolStripMenuItem, удалитьЦехToolStripMenuItem });
            работаСЦехомToolStripMenuItem.Name = "работаСЦехомToolStripMenuItem";
            работаСЦехомToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            работаСЦехомToolStripMenuItem.Text = "Работа с цехом";
            // 
            // добавитьНоыйЦехToolStripMenuItem
            // 
            добавитьНоыйЦехToolStripMenuItem.Name = "добавитьНоыйЦехToolStripMenuItem";
            добавитьНоыйЦехToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            добавитьНоыйЦехToolStripMenuItem.Text = "Добавить ноый цех";
            добавитьНоыйЦехToolStripMenuItem.Click += добавитьНоыйЦехToolStripMenuItem_Click;
            // 
            // изменитьСведенияОЦехеToolStripMenuItem
            // 
            изменитьСведенияОЦехеToolStripMenuItem.Name = "изменитьСведенияОЦехеToolStripMenuItem";
            изменитьСведенияОЦехеToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            изменитьСведенияОЦехеToolStripMenuItem.Text = "Изменить сведения о цехе";
            изменитьСведенияОЦехеToolStripMenuItem.Click += изменитьСведенияОЦехеToolStripMenuItem_Click;
            // 
            // удалитьЦехToolStripMenuItem
            // 
            удалитьЦехToolStripMenuItem.Name = "удалитьЦехToolStripMenuItem";
            удалитьЦехToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            удалитьЦехToolStripMenuItem.Text = "Удалить цех";
            удалитьЦехToolStripMenuItem.Click += удалитьЦехToolStripMenuItem_Click;
            // 
            // работаССотрудникамиToolStripMenuItem
            // 
            работаССотрудникамиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьНовогоРаботникаToolStripMenuItem, изменитьСведенияОСотрудникеToolStripMenuItem, удалитьСотрудникаToolStripMenuItem });
            работаССотрудникамиToolStripMenuItem.Name = "работаССотрудникамиToolStripMenuItem";
            работаССотрудникамиToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            работаССотрудникамиToolStripMenuItem.Text = "Работа с сотрудниками";
            // 
            // добавитьНовогоРаботникаToolStripMenuItem
            // 
            добавитьНовогоРаботникаToolStripMenuItem.Name = "добавитьНовогоРаботникаToolStripMenuItem";
            добавитьНовогоРаботникаToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            добавитьНовогоРаботникаToolStripMenuItem.Text = "Добавить нового работника";
            добавитьНовогоРаботникаToolStripMenuItem.Click += добавитьНовогоРаботникаToolStripMenuItem_Click;
            // 
            // изменитьСведенияОСотрудникеToolStripMenuItem
            // 
            изменитьСведенияОСотрудникеToolStripMenuItem.Name = "изменитьСведенияОСотрудникеToolStripMenuItem";
            изменитьСведенияОСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            изменитьСведенияОСотрудникеToolStripMenuItem.Text = "Изменить сведения о сотруднике";
            изменитьСведенияОСотрудникеToolStripMenuItem.Click += изменитьСведенияОСотрудникеToolStripMenuItem_Click;
            // 
            // удалитьСотрудникаToolStripMenuItem
            // 
            удалитьСотрудникаToolStripMenuItem.Name = "удалитьСотрудникаToolStripMenuItem";
            удалитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            удалитьСотрудникаToolStripMenuItem.Text = "Удалить сотрудника";
            удалитьСотрудникаToolStripMenuItem.Click += удалитьСотрудникаToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Desktop;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new System.Drawing.Size(780, 555);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.GridColor = SystemColors.Desktop;
            dataGridView2.Location = new Point(3, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new System.Drawing.Size(293, 555);
            dataGridView2.TabIndex = 3;
            dataGridView2.SelectionChanged += selection_changed_цех;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(299, 577);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Цех";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(299, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(786, 577);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сотрудники";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { добавитьНовогоСотрудникаToolStripMenuItem, изменитьСведенияОСотрудникеToolStripMenuItem1, удалитьСотрудникаToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(258, 70);
            contextMenuStrip1.Text = "Работа с сотрудниками";
            // 
            // добавитьНовогоСотрудникаToolStripMenuItem
            // 
            добавитьНовогоСотрудникаToolStripMenuItem.Name = "добавитьНовогоСотрудникаToolStripMenuItem";
            добавитьНовогоСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            добавитьНовогоСотрудникаToolStripMenuItem.Text = "Добавить нового сотрудника";
            // 
            // изменитьСведенияОСотрудникеToolStripMenuItem1
            // 
            изменитьСведенияОСотрудникеToolStripMenuItem1.Name = "изменитьСведенияОСотрудникеToolStripMenuItem1";
            изменитьСведенияОСотрудникеToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            изменитьСведенияОСотрудникеToolStripMenuItem1.Text = "Изменить сведения о сотруднике";
            // 
            // удалитьСотрудникаToolStripMenuItem1
            // 
            удалитьСотрудникаToolStripMenuItem1.Name = "удалитьСотрудникаToolStripMenuItem1";
            удалитьСотрудникаToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            удалитьСотрудникаToolStripMenuItem1.Text = "Удалить сотрудника";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { добавитьНовыйЦехToolStripMenuItem, изменитьСведенияОЦехеToolStripMenuItem1, удалитьЦехToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(219, 70);
            contextMenuStrip2.Text = "Работа с цехом";
            // 
            // добавитьНовыйЦехToolStripMenuItem
            // 
            добавитьНовыйЦехToolStripMenuItem.Name = "добавитьНовыйЦехToolStripMenuItem";
            добавитьНовыйЦехToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            добавитьНовыйЦехToolStripMenuItem.Text = "Добавить новый цех";
            // 
            // изменитьСведенияОЦехеToolStripMenuItem1
            // 
            изменитьСведенияОЦехеToolStripMenuItem1.Name = "изменитьСведенияОЦехеToolStripMenuItem1";
            изменитьСведенияОЦехеToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            изменитьСведенияОЦехеToolStripMenuItem1.Text = "Изменить сведения о цехе";
            // 
            // удалитьЦехToolStripMenuItem1
            // 
            удалитьЦехToolStripMenuItem1.Name = "удалитьЦехToolStripMenuItem1";
            удалитьЦехToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            удалитьЦехToolStripMenuItem1.Text = "Удалить цех";
            // 
            // просмотрПоЦехамToolStripMenuItem
            // 
            просмотрПоЦехамToolStripMenuItem.Name = "просмотрПоЦехамToolStripMenuItem";
            просмотрПоЦехамToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            просмотрПоЦехамToolStripMenuItem.Text = "Просмотр по цехам";
            просмотрПоЦехамToolStripMenuItem.Click += просмотрПоЦехамToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1085, 601);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "База данных";
            Load += lod;
            Resize += resize_form1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem работаСЦехомToolStripMenuItem;
        private ToolStripMenuItem добавитьНоыйЦехToolStripMenuItem;
        private ToolStripMenuItem изменитьСведенияОЦехеToolStripMenuItem;
        private ToolStripMenuItem удалитьЦехToolStripMenuItem;
        private ToolStripMenuItem работаССотрудникамиToolStripMenuItem;
        private ToolStripMenuItem добавитьНовогоРаботникаToolStripMenuItem;
        private ToolStripMenuItem изменитьСведенияОСотрудникеToolStripMenuItem;
        private ToolStripMenuItem удалитьСотрудникаToolStripMenuItem;
        private DBDataGridView dataGridView1;
        private DBDataGridView dataGridView2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьНовогоСотрудникаToolStripMenuItem;
        private ToolStripMenuItem изменитьСведенияОСотрудникеToolStripMenuItem1;
        private ToolStripMenuItem удалитьСотрудникаToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem добавитьНовыйЦехToolStripMenuItem;
        private ToolStripMenuItem изменитьСведенияОЦехеToolStripMenuItem1;
        private ToolStripMenuItem удалитьЦехToolStripMenuItem1;
        private ToolStripMenuItem просмотрПоЦехамToolStripMenuItem;
    }
}
