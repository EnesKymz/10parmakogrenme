﻿namespace OnParmakProgram
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button2 = new Button();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label13 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            time = new Label();
            label9 = new Label();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dogrukelimesayac = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label11 = new Label();
            label12 = new Label();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dogrukelimesayac);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 168);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(11, 16);
            button2.Name = "button2";
            button2.Size = new Size(110, 38);
            button2.TabIndex = 21;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(913, 82);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 17;
            textBox1.Tag = "";
            textBox1.Text = "İsim Giriniz.";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1. Kısım" });
            comboBox2.Location = new Point(449, 8);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 29);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(304, 8);
            label13.Name = "label13";
            label13.Size = new Size(130, 25);
            label13.TabIndex = 15;
            label13.Text = "Kısım Seçiniz :";
            // 
            // button1
            // 
            button1.Location = new Point(913, 107);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(181, 52);
            button1.TabIndex = 14;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(time);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(318, 98);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 63);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.FlatStyle = FlatStyle.Flat;
            time.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            time.ForeColor = Color.Red;
            time.Location = new Point(121, 26);
            time.Name = "time";
            time.Size = new Size(97, 37);
            time.TabIndex = 15;
            time.Text = "03 : 00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(116, 1);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 14;
            label9.Text = "Kalan Süre";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1022, 8);
            label8.Name = "label8";
            label8.Size = new Size(16, 25);
            label8.TabIndex = 12;
            label8.Text = ":";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(1044, 5);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(43, 32);
            numericUpDown2.TabIndex = 11;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(974, 6);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 32);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(913, 5);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 9;
            label7.Text = "Süre:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBox1);
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Controls.Add(checkBox5);
            flowLayoutPanel1.Controls.Add(checkBox6);
            flowLayoutPanel1.Controls.Add(checkBox7);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(690, 2);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 161);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 2);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Zaman Gösterimi Kapat";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 25);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Silmeyi Kapat";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(3, 48);
            checkBox5.Margin = new Padding(3, 2, 3, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(130, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Yazım Alanını Kapat";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(3, 71);
            checkBox6.Margin = new Padding(3, 2, 3, 2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(95, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Kelime Takibi";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Checked = true;
            checkBox7.CheckState = CheckState.Checked;
            checkBox7.Location = new Point(3, 94);
            checkBox7.Margin = new Padding(3, 2, 3, 2);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(92, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Serbest Mod";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1. Ders: K", "2. Ders: A", "3. Ders: Ü", "4. Ders: T", "5. Ders: E", "6. Ders: M", "7. Ders: İ", "8. Ders: L", "9. Ders: U", "10. Ders: Y", "11. Ders: Ş", "12. Ders: İ", "13. Ders: R", "14. Ders: Ğ", "15. Ders: N", "16. Ders: G", "17. Ders: H", "18. Ders: F", "19. Ders: P ", "20. Ders: O", "21. Ders: D", "22. Ders: C", "23. Ders: S", "24. Ders: V", "25. Ders: B", "26. Ders: Ö", "27. Ders: Z", "28. Ders: Ç", "29. Ders: J", "30. Ders: Q", "31. Ders: W", "32. Ders: X", "33. Ders: Shift", "34. Ders: Caps Lock", "35. Ders: Kesme İşareti (')", "36. Ders: Nokta (.)", "37. Ders: İki Nokta (:)", "38. Ders: Virgül (,)", "39. Ders: Noktalı Virgül (;)", "40. Ders: Soru İşareti (?)", "41. Ders: Ünlem (!)", "42. Ders: Kısa Çizgi (-)" });
            comboBox1.Location = new Point(449, 44);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 29);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(306, 46);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 6;
            label6.Text = "Ders Seçiniz  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(236, 130);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 5;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(236, 106);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 4;
            label4.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(236, 82);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 3;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 128);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 2;
            label2.Text = "Toplam Kelime Sayısı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 104);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 1;
            label1.Text = "Yanlış Kelime Sayısı    :";
            // 
            // dogrukelimesayac
            // 
            dogrukelimesayac.AutoSize = true;
            dogrukelimesayac.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dogrukelimesayac.Location = new Point(10, 80);
            dogrukelimesayac.Name = "dogrukelimesayac";
            dogrukelimesayac.Size = new Size(198, 25);
            dogrukelimesayac.TabIndex = 0;
            dogrukelimesayac.Text = "Doğru Kelime Sayısı   :";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(108, 25);
            label11.TabIndex = 14;
            label11.Text = "Ders Metni:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(0, 244);
            label12.Name = "label12";
            label12.Size = new Size(113, 25);
            label12.TabIndex = 16;
            label12.Text = "Yazım Alanı:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Courier New", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(0, 271);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(845, 210);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown;
            textBox2.MouseDown += textBox2_MouseDown;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(0, 27);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(845, 210);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(richTextBox1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(0, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(845, 525);
            panel3.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(709, 484);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(133, 39);
            button3.TabIndex = 22;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1099, 727);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "10 Parmak Klavye Dersleri";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label dogrukelimesayac;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Label time;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox2;
        private Label label13;
        private CheckBox checkBox5;
        private RichTextBox richTextBox1;
        private CheckBox checkBox6;
        private TextBox textBox1;
        private CheckBox checkBox7;
        private System.Windows.Forms.Timer timer2;
        private Button button2;
        private Panel panel3;
        private Button button3;
    }
}
