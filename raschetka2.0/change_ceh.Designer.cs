using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace raschetka2._0
{
    partial class change_ceh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 23);
            comboBox1.TabIndex = 34;
            comboBox1.TextChanged += text;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(141, 188);
            button2.Name = "button2";
            button2.Size = new Size(77, 41);
            button2.TabIndex = 32;
            button2.Text = "Отменить изменения";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(19, 188);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 31;
            button1.Text = "Сохранить изменения";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 162);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 30;
            label9.Text = "Адрес";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(99, 159);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(119, 23);
            textBox8.TabIndex = 29;
            textBox8.TextChanged += text;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 133);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 28;
            label8.Text = "Телефон";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(99, 130);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(119, 23);
            textBox7.TabIndex = 27;
            textBox7.TextChanged += text;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 104);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 26;
            label7.Text = "Продукция";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(99, 101);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(119, 23);
            textBox6.TabIndex = 25;
            textBox6.TextChanged += text;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 74);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 24;
            label4.Text = "Начальник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 46);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 23;
            label3.Text = "Название цеха";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(99, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += text;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 21);
            label1.TabIndex = 21;
            label1.Text = "Изменить сведения о цехе";
            // 
            // change_ceh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 242);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "change_ceh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private Label label9;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
    }
}