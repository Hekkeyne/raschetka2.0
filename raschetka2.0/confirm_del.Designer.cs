using System.Xml.Linq;

namespace raschetka2._0
{
    partial class confirm_del
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 25);
            label1.TabIndex = 0;
            label1.Text = "Вы уврены, что хотите удалить элемент?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.Location = new Point(68, 34);
            label2.Name = "label2";
            label2.Size = new Size(239, 15);
            label2.TabIndex = 1;
            label2.Text = "Это действие невозможно будет изменить";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(11, 65);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 2;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += delete_button;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(153, 65);
            button2.Name = "button2";
            button2.Size = new Size(217, 39);
            button2.TabIndex = 3;
            button2.Text = "Выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += exit_button;
            // 
            // confirm_del
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 115);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "confirm_del";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}