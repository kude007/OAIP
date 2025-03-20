namespace My_calculaa
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
            Panel_up = new Panel();
            Output_text = new TextBox();
            panel2 = new Panel();
            history_text = new TextBox();
            equal = new Button();
            tochka = new Button();
            zero = new Button();
            unarn_min = new Button();
            add = new Button();
            sub = new Button();
            multiply = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            division = new Button();
            koren = new Button();
            square = new Button();
            one_div_x = new Button();
            procent = new Button();
            half_clear = new Button();
            full_clear = new Button();
            last_symbol_clear = new Button();
            Panel_up.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_up
            // 
            Panel_up.BackColor = Color.FromArgb(129, 68, 214);
            Panel_up.Controls.Add(Output_text);
            Panel_up.Dock = DockStyle.Top;
            Panel_up.Location = new Point(0, 0);
            Panel_up.Name = "Panel_up";
            Panel_up.Size = new Size(333, 128);
            Panel_up.TabIndex = 0;
            // 
            // Output_text
            // 
            Output_text.BackColor = Color.FromArgb(129, 68, 214);
            Output_text.BorderStyle = BorderStyle.None;
            Output_text.Font = new Font("Segoe UI", 34F);
            Output_text.ForeColor = SystemColors.Window;
            Output_text.Location = new Point(8, 12);
            Output_text.Multiline = true;
            Output_text.Name = "Output_text";
            Output_text.Size = new Size(318, 50);
            Output_text.TabIndex = 0;
            Output_text.Text = "0";
            Output_text.TextAlign = HorizontalAlignment.Right;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 41, 130);
            panel2.Controls.Add(history_text);
            panel2.Controls.Add(equal);
            panel2.Controls.Add(tochka);
            panel2.Controls.Add(zero);
            panel2.Controls.Add(unarn_min);
            panel2.Controls.Add(add);
            panel2.Controls.Add(sub);
            panel2.Controls.Add(multiply);
            panel2.Controls.Add(three);
            panel2.Controls.Add(two);
            panel2.Controls.Add(one);
            panel2.Controls.Add(six);
            panel2.Controls.Add(five);
            panel2.Controls.Add(four);
            panel2.Controls.Add(nine);
            panel2.Controls.Add(eight);
            panel2.Controls.Add(seven);
            panel2.Controls.Add(division);
            panel2.Controls.Add(koren);
            panel2.Controls.Add(square);
            panel2.Controls.Add(one_div_x);
            panel2.Controls.Add(procent);
            panel2.Controls.Add(half_clear);
            panel2.Controls.Add(full_clear);
            panel2.Controls.Add(last_symbol_clear);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 373);
            panel2.TabIndex = 1;
            // 
            // history_text
            // 
            history_text.BackColor = Color.FromArgb(78, 41, 130);
            history_text.BorderStyle = BorderStyle.None;
            history_text.Font = new Font("Segoe UI", 16F);
            history_text.ForeColor = SystemColors.Window;
            history_text.Location = new Point(8, 9);
            history_text.Multiline = true;
            history_text.Name = "history_text";
            history_text.Size = new Size(318, 34);
            history_text.TabIndex = 1;
            history_text.Text = "Ожидание ввода...";
            // 
            // equal
            // 
            equal.BackColor = Color.FromArgb(151, 107, 214);
            equal.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            equal.FlatAppearance.MouseDownBackColor = Color.Black;
            equal.FlatAppearance.MouseOverBackColor = Color.Black;
            equal.FlatStyle = FlatStyle.Popup;
            equal.Font = new Font("Segoe UI", 9F);
            equal.ForeColor = SystemColors.Control;
            equal.Location = new Point(251, 319);
            equal.Name = "equal";
            equal.Size = new Size(75, 48);
            equal.TabIndex = 23;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += Ravno;
            // 
            // tochka
            // 
            tochka.BackColor = Color.FromArgb(151, 107, 214);
            tochka.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            tochka.FlatAppearance.MouseDownBackColor = Color.Black;
            tochka.FlatAppearance.MouseOverBackColor = Color.Black;
            tochka.FlatStyle = FlatStyle.Popup;
            tochka.Font = new Font("Segoe UI", 9F);
            tochka.ForeColor = SystemColors.Control;
            tochka.Location = new Point(170, 319);
            tochka.Name = "tochka";
            tochka.Size = new Size(75, 48);
            tochka.TabIndex = 22;
            tochka.Text = ",";
            tochka.UseVisualStyleBackColor = false;
            // 
            // zero
            // 
            zero.BackColor = Color.FromArgb(151, 107, 214);
            zero.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            zero.FlatAppearance.MouseDownBackColor = Color.Black;
            zero.FlatAppearance.MouseOverBackColor = Color.Black;
            zero.FlatStyle = FlatStyle.Popup;
            zero.Font = new Font("Segoe UI", 9F);
            zero.ForeColor = SystemColors.Control;
            zero.Location = new Point(89, 319);
            zero.Name = "zero";
            zero.Size = new Size(75, 48);
            zero.TabIndex = 21;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += Multi_num;
            // 
            // unarn_min
            // 
            unarn_min.BackColor = Color.FromArgb(151, 107, 214);
            unarn_min.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            unarn_min.FlatAppearance.MouseDownBackColor = Color.Black;
            unarn_min.FlatAppearance.MouseOverBackColor = Color.Black;
            unarn_min.FlatStyle = FlatStyle.Popup;
            unarn_min.Font = new Font("Segoe UI", 9F);
            unarn_min.ForeColor = SystemColors.Control;
            unarn_min.Location = new Point(8, 319);
            unarn_min.Name = "unarn_min";
            unarn_min.Size = new Size(75, 48);
            unarn_min.TabIndex = 20;
            unarn_min.Text = "+/-";
            unarn_min.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(151, 107, 214);
            add.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            add.FlatAppearance.MouseDownBackColor = Color.Black;
            add.FlatAppearance.MouseOverBackColor = Color.Black;
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Segoe UI", 9F);
            add.ForeColor = SystemColors.Control;
            add.Location = new Point(251, 265);
            add.Name = "add";
            add.Size = new Size(75, 48);
            add.TabIndex = 19;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += Easy_operation;
            // 
            // sub
            // 
            sub.BackColor = Color.FromArgb(151, 107, 214);
            sub.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            sub.FlatAppearance.MouseDownBackColor = Color.Black;
            sub.FlatAppearance.MouseOverBackColor = Color.Black;
            sub.FlatStyle = FlatStyle.Popup;
            sub.Font = new Font("Segoe UI", 9F);
            sub.ForeColor = SystemColors.Control;
            sub.Location = new Point(251, 211);
            sub.Name = "sub";
            sub.Size = new Size(75, 48);
            sub.TabIndex = 18;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += Easy_operation;
            // 
            // multiply
            // 
            multiply.BackColor = Color.FromArgb(151, 107, 214);
            multiply.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            multiply.FlatAppearance.MouseDownBackColor = Color.Black;
            multiply.FlatAppearance.MouseOverBackColor = Color.Black;
            multiply.FlatStyle = FlatStyle.Popup;
            multiply.Font = new Font("Segoe UI", 9F);
            multiply.ForeColor = SystemColors.Control;
            multiply.Location = new Point(251, 157);
            multiply.Name = "multiply";
            multiply.Size = new Size(75, 48);
            multiply.TabIndex = 17;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += Easy_operation;
            // 
            // three
            // 
            three.BackColor = Color.FromArgb(151, 107, 214);
            three.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            three.FlatAppearance.MouseDownBackColor = Color.Black;
            three.FlatAppearance.MouseOverBackColor = Color.Black;
            three.FlatStyle = FlatStyle.Popup;
            three.Font = new Font("Segoe UI", 9F);
            three.ForeColor = SystemColors.Control;
            three.Location = new Point(170, 265);
            three.Name = "three";
            three.Size = new Size(75, 48);
            three.TabIndex = 16;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += Multi_num;
            // 
            // two
            // 
            two.BackColor = Color.FromArgb(151, 107, 214);
            two.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            two.FlatAppearance.MouseDownBackColor = Color.Black;
            two.FlatAppearance.MouseOverBackColor = Color.Black;
            two.FlatStyle = FlatStyle.Popup;
            two.Font = new Font("Segoe UI", 9F);
            two.ForeColor = SystemColors.Control;
            two.Location = new Point(89, 265);
            two.Name = "two";
            two.Size = new Size(75, 48);
            two.TabIndex = 15;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += Multi_num;
            // 
            // one
            // 
            one.BackColor = Color.FromArgb(151, 107, 214);
            one.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            one.FlatAppearance.MouseDownBackColor = Color.Black;
            one.FlatAppearance.MouseOverBackColor = Color.Black;
            one.FlatStyle = FlatStyle.Popup;
            one.Font = new Font("Segoe UI", 9F);
            one.ForeColor = SystemColors.Control;
            one.Location = new Point(8, 265);
            one.Name = "one";
            one.Size = new Size(75, 48);
            one.TabIndex = 14;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += Multi_num;
            // 
            // six
            // 
            six.BackColor = Color.FromArgb(151, 107, 214);
            six.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            six.FlatAppearance.MouseDownBackColor = Color.Black;
            six.FlatAppearance.MouseOverBackColor = Color.Black;
            six.FlatStyle = FlatStyle.Popup;
            six.Font = new Font("Segoe UI", 9F);
            six.ForeColor = SystemColors.Control;
            six.Location = new Point(170, 211);
            six.Name = "six";
            six.Size = new Size(75, 48);
            six.TabIndex = 13;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += Multi_num;
            // 
            // five
            // 
            five.BackColor = Color.FromArgb(151, 107, 214);
            five.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            five.FlatAppearance.MouseDownBackColor = Color.Black;
            five.FlatAppearance.MouseOverBackColor = Color.Black;
            five.FlatStyle = FlatStyle.Popup;
            five.Font = new Font("Segoe UI", 9F);
            five.ForeColor = SystemColors.Control;
            five.Location = new Point(89, 211);
            five.Name = "five";
            five.Size = new Size(75, 48);
            five.TabIndex = 12;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += Multi_num;
            // 
            // four
            // 
            four.BackColor = Color.FromArgb(151, 107, 214);
            four.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            four.FlatAppearance.MouseDownBackColor = Color.Black;
            four.FlatAppearance.MouseOverBackColor = Color.Black;
            four.FlatStyle = FlatStyle.Popup;
            four.Font = new Font("Segoe UI", 9F);
            four.ForeColor = SystemColors.Control;
            four.Location = new Point(8, 211);
            four.Name = "four";
            four.Size = new Size(75, 48);
            four.TabIndex = 11;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += Multi_num;
            // 
            // nine
            // 
            nine.BackColor = Color.FromArgb(151, 107, 214);
            nine.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            nine.FlatAppearance.MouseDownBackColor = Color.Black;
            nine.FlatAppearance.MouseOverBackColor = Color.Black;
            nine.FlatStyle = FlatStyle.Popup;
            nine.Font = new Font("Segoe UI", 9F);
            nine.ForeColor = SystemColors.Control;
            nine.Location = new Point(170, 157);
            nine.Name = "nine";
            nine.Size = new Size(75, 48);
            nine.TabIndex = 10;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += Multi_num;
            // 
            // eight
            // 
            eight.BackColor = Color.FromArgb(151, 107, 214);
            eight.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            eight.FlatAppearance.MouseDownBackColor = Color.Black;
            eight.FlatAppearance.MouseOverBackColor = Color.Black;
            eight.FlatStyle = FlatStyle.Popup;
            eight.Font = new Font("Segoe UI", 9F);
            eight.ForeColor = SystemColors.Control;
            eight.Location = new Point(89, 157);
            eight.Name = "eight";
            eight.Size = new Size(75, 48);
            eight.TabIndex = 9;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += Multi_num;
            // 
            // seven
            // 
            seven.BackColor = Color.FromArgb(151, 107, 214);
            seven.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            seven.FlatAppearance.MouseDownBackColor = Color.Black;
            seven.FlatAppearance.MouseOverBackColor = Color.Black;
            seven.FlatStyle = FlatStyle.Popup;
            seven.Font = new Font("Segoe UI", 9F);
            seven.ForeColor = SystemColors.Control;
            seven.Location = new Point(8, 157);
            seven.Name = "seven";
            seven.Size = new Size(75, 48);
            seven.TabIndex = 8;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += Multi_num;
            // 
            // division
            // 
            division.BackColor = Color.FromArgb(151, 107, 214);
            division.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            division.FlatAppearance.MouseDownBackColor = Color.Black;
            division.FlatAppearance.MouseOverBackColor = Color.Black;
            division.FlatStyle = FlatStyle.Popup;
            division.Font = new Font("Segoe UI", 9F);
            division.ForeColor = SystemColors.Control;
            division.Location = new Point(251, 103);
            division.Name = "division";
            division.Size = new Size(75, 48);
            division.TabIndex = 7;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            division.Click += Easy_operation;
            // 
            // koren
            // 
            koren.BackColor = Color.FromArgb(151, 107, 214);
            koren.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            koren.FlatAppearance.MouseDownBackColor = Color.Black;
            koren.FlatAppearance.MouseOverBackColor = Color.Black;
            koren.FlatStyle = FlatStyle.Popup;
            koren.Font = new Font("Segoe UI", 9F);
            koren.ForeColor = SystemColors.Control;
            koren.Location = new Point(170, 103);
            koren.Name = "koren";
            koren.Size = new Size(75, 48);
            koren.TabIndex = 6;
            koren.Text = "√x";
            koren.UseVisualStyleBackColor = false;
            // 
            // square
            // 
            square.BackColor = Color.FromArgb(151, 107, 214);
            square.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            square.FlatAppearance.MouseDownBackColor = Color.Black;
            square.FlatAppearance.MouseOverBackColor = Color.Black;
            square.FlatStyle = FlatStyle.Popup;
            square.Font = new Font("Segoe UI", 9F);
            square.ForeColor = SystemColors.Control;
            square.Location = new Point(89, 103);
            square.Name = "square";
            square.Size = new Size(75, 48);
            square.TabIndex = 5;
            square.Text = "x²";
            square.UseVisualStyleBackColor = false;
            // 
            // one_div_x
            // 
            one_div_x.BackColor = Color.FromArgb(151, 107, 214);
            one_div_x.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            one_div_x.FlatAppearance.MouseDownBackColor = Color.Black;
            one_div_x.FlatAppearance.MouseOverBackColor = Color.Black;
            one_div_x.FlatStyle = FlatStyle.Popup;
            one_div_x.Font = new Font("Segoe UI", 9F);
            one_div_x.ForeColor = SystemColors.Control;
            one_div_x.Location = new Point(8, 103);
            one_div_x.Name = "one_div_x";
            one_div_x.Size = new Size(75, 48);
            one_div_x.TabIndex = 4;
            one_div_x.Text = "1/x";
            one_div_x.UseVisualStyleBackColor = false;
            // 
            // procent
            // 
            procent.BackColor = Color.FromArgb(151, 107, 214);
            procent.FlatStyle = FlatStyle.Popup;
            procent.Font = new Font("Segoe UI", 9F);
            procent.ForeColor = SystemColors.Control;
            procent.Location = new Point(8, 49);
            procent.Name = "procent";
            procent.Size = new Size(75, 48);
            procent.TabIndex = 3;
            procent.Text = "%";
            procent.UseVisualStyleBackColor = false;
            // 
            // half_clear
            // 
            half_clear.BackColor = Color.FromArgb(151, 107, 214);
            half_clear.FlatStyle = FlatStyle.Popup;
            half_clear.Font = new Font("Segoe UI", 9F);
            half_clear.ForeColor = SystemColors.Control;
            half_clear.Location = new Point(89, 49);
            half_clear.Name = "half_clear";
            half_clear.Size = new Size(75, 48);
            half_clear.TabIndex = 2;
            half_clear.Text = "CE";
            half_clear.UseVisualStyleBackColor = false;
            // 
            // full_clear
            // 
            full_clear.BackColor = Color.FromArgb(151, 107, 214);
            full_clear.FlatStyle = FlatStyle.Popup;
            full_clear.Font = new Font("Segoe UI", 9F);
            full_clear.ForeColor = SystemColors.Control;
            full_clear.Location = new Point(170, 49);
            full_clear.Name = "full_clear";
            full_clear.Size = new Size(75, 48);
            full_clear.TabIndex = 1;
            full_clear.Text = "C";
            full_clear.UseVisualStyleBackColor = false;
            // 
            // last_symbol_clear
            // 
            last_symbol_clear.BackColor = Color.FromArgb(151, 107, 214);
            last_symbol_clear.FlatAppearance.BorderColor = Color.FromArgb(151, 107, 214);
            last_symbol_clear.FlatAppearance.MouseDownBackColor = Color.Black;
            last_symbol_clear.FlatAppearance.MouseOverBackColor = Color.Black;
            last_symbol_clear.FlatStyle = FlatStyle.Popup;
            last_symbol_clear.Font = new Font("Segoe UI", 9F);
            last_symbol_clear.ForeColor = SystemColors.Control;
            last_symbol_clear.Location = new Point(251, 49);
            last_symbol_clear.Name = "last_symbol_clear";
            last_symbol_clear.Size = new Size(75, 48);
            last_symbol_clear.TabIndex = 0;
            last_symbol_clear.Text = "<=";
            last_symbol_clear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 441);
            Controls.Add(panel2);
            Controls.Add(Panel_up);
            Name = "Form1";
            Text = "Form1";
            Panel_up.ResumeLayout(false);
            Panel_up.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_up;
        private Panel panel2;
        private Button last_symbol_clear;
        private Button full_clear;
        private Button half_clear;
        private Button square;
        private Button one_div_x;
        private Button procent;
        private Button six;
        private Button five;
        private Button four;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button division;
        private Button koren;
        private Button add;
        private Button sub;
        private Button multiply;
        private Button three;
        private Button two;
        private Button one;
        private Button equal;
        private Button tochka;
        private Button zero;
        private Button unarn_min;
        private TextBox Output_text;
        private TextBox history_text;
    }
}
