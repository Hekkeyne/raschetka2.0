using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace raschetka2._0
{
    partial class add_new_ceh
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
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Добавить новый цех";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 57);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Название цеха";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(102, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += null_or_fill;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 85);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Начальник";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 115);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 12;
            label7.Text = "Продукция";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(102, 112);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            textBox6.TextChanged += null_or_fill;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 144);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 14;
            label8.Text = "Телефон";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(102, 141);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += null_or_fill;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 173);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 16;
            label9.Text = "Адрес";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(102, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 15;
            textBox8.TextChanged += null_or_fill;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(102, 199);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 17;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += add_button;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(102, 228);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 18;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += cancel_button;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 199);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 20;
            comboBox1.TextChanged += null_or_fill;
            // 
            // add_new_ceh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 265);
            Controls.Add(comboBox1);
            Controls.Add(label10);
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
            Name = "add_new_ceh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private Label label10;
        private ComboBox comboBox1;
    }
}