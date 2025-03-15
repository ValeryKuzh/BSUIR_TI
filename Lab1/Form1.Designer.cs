namespace Lab1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label6 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1328, 155);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1320, 112);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Алгоритм Децимации";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1113, 14);
            button5.Name = "button5";
            button5.Size = new Size(194, 40);
            button5.TabIndex = 6;
            button5.Text = "Записать в файл";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(899, 15);
            button4.Name = "button4";
            button4.Size = new Size(194, 40);
            button4.TabIndex = 5;
            button4.Text = "Считать с файла";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(8, 80);
            label4.Name = "label4";
            label4.Size = new Size(0, 30);
            label4.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(684, 15);
            button3.Name = "button3";
            button3.Size = new Size(194, 40);
            button3.TabIndex = 4;
            button3.Text = "Очистить поля";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 16);
            button2.Name = "button2";
            button2.Size = new Size(194, 40);
            button2.TabIndex = 3;
            button2.Text = "Дешифрировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(254, 16);
            button1.Name = "button1";
            button1.Size = new Size(194, 40);
            button1.TabIndex = 2;
            button1.Text = "Зашифрировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 35);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 30);
            label1.TabIndex = 0;
            label1.Text = "Key";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1320, 112);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Алгоритм Виженера";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(7, 71);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 14;
            // 
            // button6
            // 
            button6.Location = new Point(1113, 14);
            button6.Name = "button6";
            button6.Size = new Size(194, 40);
            button6.TabIndex = 13;
            button6.Text = "Записать в файл";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(899, 15);
            button7.Name = "button7";
            button7.Size = new Size(194, 40);
            button7.TabIndex = 12;
            button7.Text = "Считать с файла";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(684, 15);
            button8.Name = "button8";
            button8.Size = new Size(194, 40);
            button8.TabIndex = 11;
            button8.Text = "Очистить поля";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(469, 16);
            button9.Name = "button9";
            button9.Size = new Size(194, 40);
            button9.TabIndex = 10;
            button9.Text = "Дешифрировать";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(254, 16);
            button10.Name = "button10";
            button10.Size = new Size(194, 40);
            button10.TabIndex = 9;
            button10.Text = "Зашифрировать";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 35);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 20);
            label5.Name = "label5";
            label5.Size = new Size(46, 30);
            label5.TabIndex = 7;
            label5.Text = "Key";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 215);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1328, 168);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(0, 443);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1328, 161);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(189, 30);
            label2.TabIndex = 2;
            label2.Text = "Шифруемый текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 17);
            label3.Name = "label3";
            label3.Size = new Size(230, 30);
            label3.TabIndex = 3;
            label3.Text = "Зашифрованный текст";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 60);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(1328, 60);
            panel2.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            ClientSize = new Size(1328, 604);
            Controls.Add(richTextBox2);
            Controls.Add(panel2);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private ColorDialog colorDialog1;
        private Button button4;
        private Button button5;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
    }
}
