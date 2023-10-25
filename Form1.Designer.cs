namespace Practica_8
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
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Volume1 = new TextBox();
            volumeCirc = new Label();
            area1 = new TextBox();
            labe = new Label();
            radio1 = new TextBox();
            label = new Label();
            label2 = new Label();
            tabPage1 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 555);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.RosyBrown;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(Volume1);
            tabPage2.Controls.Add(volumeCirc);
            tabPage2.Controls.Add(area1);
            tabPage2.Controls.Add(labe);
            tabPage2.Controls.Add(radio1);
            tabPage2.Controls.Add(label);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(982, 501);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Circunferencia";
            // 
            // button3
            // 
            button3.Location = new Point(683, 408);
            button3.Name = "button3";
            button3.Size = new Size(183, 64);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(378, 408);
            button2.Name = "button2";
            button2.Size = new Size(198, 64);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(99, 408);
            button1.Name = "button1";
            button1.Size = new Size(188, 64);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Volume1
            // 
            Volume1.Location = new Point(732, 310);
            Volume1.Name = "Volume1";
            Volume1.Size = new Size(200, 39);
            Volume1.TabIndex = 6;
            // 
            // volumeCirc
            // 
            volumeCirc.AutoSize = true;
            volumeCirc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            volumeCirc.Location = new Point(562, 304);
            volumeCirc.Name = "volumeCirc";
            volumeCirc.Size = new Size(146, 45);
            volumeCirc.TabIndex = 5;
            volumeCirc.Text = "Volumen";
            // 
            // area1
            // 
            area1.Location = new Point(294, 304);
            area1.Name = "area1";
            area1.Size = new Size(200, 39);
            area1.TabIndex = 4;
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labe.Location = new Point(143, 304);
            labe.Name = "labe";
            labe.Size = new Size(85, 45);
            labe.TabIndex = 3;
            labe.Text = "Area";
            labe.Click += label4_Click;
            // 
            // radio1
            // 
            radio1.Location = new Point(294, 164);
            radio1.Name = "radio1";
            radio1.Size = new Size(200, 39);
            radio1.TabIndex = 2;
            radio1.TextChanged += textBox1_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(143, 158);
            label.Name = "label";
            label.Size = new Size(101, 45);
            label.TabIndex = 1;
            label.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 21);
            label2.Name = "label2";
            label2.Size = new Size(222, 45);
            label2.TabIndex = 0;
            label2.Text = "Circunferencia";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.RosyBrown;
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(982, 501);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Triangulo";
            // 
            // button6
            // 
            button6.Location = new Point(599, 423);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 9;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(365, 423);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 8;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(107, 423);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 7;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(720, 164);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(221, 296);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(221, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(91, 289);
            label9.Name = "label9";
            label9.Size = new Size(85, 45);
            label9.TabIndex = 3;
            label9.Text = "Area";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(502, 162);
            label8.Name = "label8";
            label8.Size = new Size(146, 45);
            label8.TabIndex = 2;
            label8.Text = "Volumen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(78, 162);
            label7.Name = "label7";
            label7.Size = new Size(101, 45);
            label7.TabIndex = 1;
            label7.Text = "Radio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(91, 17);
            label6.Name = "label6";
            label6.Size = new Size(151, 45);
            label6.TabIndex = 0;
            label6.Text = "Triangulo";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(982, 501);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cubo";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(622, 112);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(200, 39);
            textBox9.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(266, 216);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 39);
            textBox8.TabIndex = 8;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(266, 105);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 39);
            textBox7.TabIndex = 7;
            // 
            // button9
            // 
            button9.Location = new Point(598, 427);
            button9.Name = "button9";
            button9.Size = new Size(150, 46);
            button9.TabIndex = 6;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(360, 427);
            button8.Name = "button8";
            button8.Size = new Size(150, 46);
            button8.TabIndex = 5;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(96, 427);
            button7.Name = "button7";
            button7.Size = new Size(150, 46);
            button7.TabIndex = 4;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(513, 120);
            label13.Name = "label13";
            label13.Size = new Size(91, 32);
            label13.TabIndex = 3;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(162, 223);
            label12.Name = "label12";
            label12.Size = new Size(91, 32);
            label12.TabIndex = 2;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(158, 112);
            label11.Name = "label11";
            label11.Size = new Size(91, 32);
            label11.TabIndex = 1;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(51, 22);
            label10.Name = "label10";
            label10.Size = new Size(96, 45);
            label10.TabIndex = 0;
            label10.Text = "Cubo";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(982, 501);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Cilindro";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(8, 46);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(982, 501);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Rombo";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.RosyBrown;
            tabPage6.Controls.Add(label1);
            tabPage6.Location = new Point(8, 46);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(982, 501);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Octaedro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 565);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox radio1;
        private Label label;
        private Label label2;
        private Label label1;
        private Label labe;
        private TextBox area1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox Volume1;
        private Label volumeCirc;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button6;
        private Button button5;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox9;
    }
}