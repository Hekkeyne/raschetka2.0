using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace raschetka2._0
{
    partial class change_rab
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 47;
            comboBox1.TextChanged += text;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(166, 270);
            button2.Name = "button2";
            button2.Size = new Size(90, 41);
            button2.TabIndex = 46;
            button2.Text = "Отменить изменения";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 270);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 45;
            button1.Text = "Сохранить \r\nизменения";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 156);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 44;
            label9.Text = "Должность";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(112, 154);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(144, 23);
            textBox8.TabIndex = 43;
            textBox8.TextChanged += text;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 127);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 42;
            label8.Text = "Отчество";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(112, 125);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(144, 23);
            textBox7.TabIndex = 41;
            textBox7.TextChanged += text;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 98);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 40;
            label7.Text = "Имя";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(112, 96);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(144, 23);
            textBox6.TabIndex = 39;
            textBox6.TextChanged += text;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 69);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 38;
            label4.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 41);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 37;
            label3.Text = "Название цеха";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(112, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 36;
            textBox2.TextChanged += text;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 21);
            label1.TabIndex = 35;
            label1.Text = "Изменить сведения о работнике";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(112, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += text;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(112, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 49;
            textBox3.TextChanged += text;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(112, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 48;
            textBox4.TextChanged += text;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 243);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 53;
            label2.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 214);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 52;
            label5.Text = "Телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 185);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 51;
            label6.Text = "Оклад";
            // 
            // change_rab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 321);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
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
            Name = "change_rab";
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
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label5;
        private Label label6;
    }
}