using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace raschetka2._0
{
    partial class add_new_worker
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 21);
            label1.TabIndex = 1;
            label1.Text = "Добавить нового сотрудника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Название цеха";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(99, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += text;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 75);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Фамилия";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(99, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += text;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 104);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Имя";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(99, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 133);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Отчество";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(99, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += text;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 162);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 11;
            label6.Text = "Должность";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(99, 188);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 23);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += text;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 191);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 13;
            label7.Text = "Оклад";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(99, 217);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(139, 23);
            textBox7.TabIndex = 16;
            textBox7.TextChanged += text;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 220);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "Телефон";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(99, 246);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(139, 23);
            textBox8.TabIndex = 18;
            textBox8.TextChanged += text;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 249);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 17;
            label9.Text = "Адрес";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 275);
            button1.Name = "button1";
            button1.Size = new Size(125, 32);
            button1.TabIndex = 19;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += add_button;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(143, 275);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 20;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += cancel_button;
            // 
            // add_new_worker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 315);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "add_new_worker";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private Button button1;
        private Button button2;
    }
}