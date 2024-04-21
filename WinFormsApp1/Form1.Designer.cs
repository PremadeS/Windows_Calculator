namespace WinFormsApp1
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
            Button tanh;
            Screen = new TextBox();
            sin = new Button();
            back = new Button();
            divide = new Button();
            clear = new Button();
            factorial = new Button();
            pow = new Button();
            multiply = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            add = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            minus = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            equal = new Button();
            zero = new Button();
            dot = new Button();
            cos = new Button();
            binary = new Button();
            hexa = new Button();
            log = new Button();
            octal = new Button();
            tan = new Button();
            sinh = new Button();
            cosh = new Button();
            Mod = new Button();
            tanh = new Button();
            SuspendLayout();
            // 
            // tanh
            // 
            tanh.Font = new Font("Segoe UI", 10F);
            tanh.Location = new Point(243, 232);
            tanh.Name = "tanh";
            tanh.Size = new Size(58, 75);
            tanh.TabIndex = 40;
            tanh.Text = "tanh";
            tanh.UseVisualStyleBackColor = true;
            tanh.Click += tanh_Click;
            // 
            // Screen
            // 
            Screen.Cursor = Cursors.No;
            Screen.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Screen.Location = new Point(44, 30);
            Screen.MaxLength = 30000;
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            Screen.Size = new Size(524, 87);
            Screen.TabIndex = 0;
            Screen.Text = "0";
            Screen.TextAlign = HorizontalAlignment.Right;
            Screen.TextChanged += textBox1_TextChanged;
            // 
            // sin
            // 
            sin.Font = new Font("Segoe UI", 11F);
            sin.Location = new Point(44, 140);
            sin.Name = "sin";
            sin.Size = new Size(58, 75);
            sin.TabIndex = 1;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = true;
            sin.Click += sin_Click;
            // 
            // back
            // 
            back.BackColor = Color.LavenderBlush;
            back.Font = new Font("Segoe UI", 14F);
            back.Location = new Point(450, 140);
            back.Name = "back";
            back.Size = new Size(118, 75);
            back.TabIndex = 12;
            back.Text = "<-";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 14F);
            divide.Location = new Point(513, 230);
            divide.Name = "divide";
            divide.Size = new Size(55, 75);
            divide.TabIndex = 16;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 14F);
            clear.Location = new Point(450, 230);
            clear.Name = "clear";
            clear.Size = new Size(54, 75);
            clear.TabIndex = 15;
            clear.Text = "CE";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // factorial
            // 
            factorial.Font = new Font("Segoe UI", 14F);
            factorial.Location = new Point(380, 232);
            factorial.Name = "factorial";
            factorial.Size = new Size(54, 75);
            factorial.TabIndex = 14;
            factorial.Text = "!";
            factorial.UseVisualStyleBackColor = true;
            factorial.Click += root_Click;
            // 
            // pow
            // 
            pow.Font = new Font("Segoe UI", 14F);
            pow.Location = new Point(316, 230);
            pow.Name = "pow";
            pow.Size = new Size(58, 75);
            pow.TabIndex = 13;
            pow.Text = "^";
            pow.UseVisualStyleBackColor = true;
            pow.Click += square_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 14F);
            multiply.Location = new Point(450, 327);
            multiply.Name = "multiply";
            multiply.Size = new Size(118, 75);
            multiply.TabIndex = 20;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // nine
            // 
            nine.Font = new Font("Segoe UI", 14F);
            nine.Location = new Point(316, 327);
            nine.Name = "nine";
            nine.Size = new Size(118, 75);
            nine.TabIndex = 19;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.Font = new Font("Segoe UI", 14F);
            eight.Location = new Point(179, 327);
            eight.Name = "eight";
            eight.Size = new Size(118, 75);
            eight.TabIndex = 18;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Font = new Font("Segoe UI", 14F);
            seven.Location = new Point(44, 327);
            seven.Name = "seven";
            seven.Size = new Size(118, 75);
            seven.TabIndex = 17;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 14F);
            add.Location = new Point(450, 426);
            add.Name = "add";
            add.Size = new Size(118, 75);
            add.TabIndex = 24;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // six
            // 
            six.Font = new Font("Segoe UI", 14F);
            six.Location = new Point(316, 426);
            six.Name = "six";
            six.Size = new Size(118, 75);
            six.TabIndex = 23;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // five
            // 
            five.Font = new Font("Segoe UI", 14F);
            five.Location = new Point(179, 426);
            five.Name = "five";
            five.Size = new Size(118, 75);
            five.TabIndex = 22;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // four
            // 
            four.Font = new Font("Segoe UI", 14F);
            four.Location = new Point(44, 426);
            four.Name = "four";
            four.Size = new Size(118, 75);
            four.TabIndex = 21;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 14F);
            minus.Location = new Point(450, 523);
            minus.Name = "minus";
            minus.Size = new Size(118, 75);
            minus.TabIndex = 28;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // three
            // 
            three.Font = new Font("Segoe UI", 14F);
            three.Location = new Point(316, 523);
            three.Name = "three";
            three.Size = new Size(118, 75);
            three.TabIndex = 27;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Font = new Font("Segoe UI", 14F);
            two.Location = new Point(179, 523);
            two.Name = "two";
            two.Size = new Size(118, 75);
            two.TabIndex = 26;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 14F);
            one.Location = new Point(44, 523);
            one.Name = "one";
            one.Size = new Size(118, 75);
            one.TabIndex = 25;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.Info;
            equal.Font = new Font("Segoe UI", 14F);
            equal.Location = new Point(316, 615);
            equal.Name = "equal";
            equal.Size = new Size(252, 75);
            equal.TabIndex = 32;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // zero
            // 
            zero.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zero.Location = new Point(179, 615);
            zero.Name = "zero";
            zero.Size = new Size(118, 75);
            zero.TabIndex = 30;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe UI", 15F);
            dot.Location = new Point(44, 615);
            dot.Name = "dot";
            dot.Size = new Size(118, 37);
            dot.TabIndex = 29;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // cos
            // 
            cos.Font = new Font("Segoe UI", 11F);
            cos.Location = new Point(108, 140);
            cos.Name = "cos";
            cos.Size = new Size(54, 75);
            cos.TabIndex = 10;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = true;
            cos.Click += cos_Click;
            // 
            // binary
            // 
            binary.Font = new Font("Segoe UI", 11F);
            binary.Location = new Point(243, 140);
            binary.Name = "binary";
            binary.Size = new Size(54, 75);
            binary.TabIndex = 34;
            binary.Text = "BIN";
            binary.UseVisualStyleBackColor = true;
            binary.Click += binary_Click;
            // 
            // hexa
            // 
            hexa.Font = new Font("Segoe UI", 11F);
            hexa.Location = new Point(179, 140);
            hexa.Name = "hexa";
            hexa.Size = new Size(58, 75);
            hexa.TabIndex = 33;
            hexa.Text = "HEX";
            hexa.UseVisualStyleBackColor = true;
            hexa.Click += hexa_Click;
            // 
            // log
            // 
            log.Font = new Font("Segoe UI", 11F);
            log.Location = new Point(380, 140);
            log.Name = "log";
            log.Size = new Size(54, 75);
            log.TabIndex = 36;
            log.Text = "log";
            log.UseVisualStyleBackColor = true;
            log.Click += log_Click;
            // 
            // octal
            // 
            octal.Font = new Font("Segoe UI", 11F);
            octal.Location = new Point(316, 140);
            octal.Name = "octal";
            octal.Size = new Size(58, 75);
            octal.TabIndex = 35;
            octal.Text = "OCT";
            octal.UseVisualStyleBackColor = true;
            octal.Click += octal_Click;
            // 
            // tan
            // 
            tan.Font = new Font("Segoe UI", 11F);
            tan.Location = new Point(44, 232);
            tan.Name = "tan";
            tan.Size = new Size(58, 75);
            tan.TabIndex = 37;
            tan.Text = "tan";
            tan.UseVisualStyleBackColor = true;
            tan.Click += tan_Click;
            // 
            // sinh
            // 
            sinh.Font = new Font("Segoe UI", 11F);
            sinh.Location = new Point(108, 232);
            sinh.Name = "sinh";
            sinh.Size = new Size(58, 75);
            sinh.TabIndex = 38;
            sinh.Text = "sinh";
            sinh.UseVisualStyleBackColor = true;
            sinh.Click += sinh_Click;
            // 
            // cosh
            // 
            cosh.Font = new Font("Segoe UI", 10F);
            cosh.Location = new Point(179, 232);
            cosh.Name = "cosh";
            cosh.Size = new Size(58, 75);
            cosh.TabIndex = 39;
            cosh.Text = "cosh";
            cosh.UseVisualStyleBackColor = true;
            cosh.Click += cosh_Click;
            // 
            // Mod
            // 
            Mod.Font = new Font("Segoe UI", 10F);
            Mod.Location = new Point(44, 658);
            Mod.Name = "Mod";
            Mod.Size = new Size(118, 32);
            Mod.TabIndex = 41;
            Mod.Text = "%";
            Mod.UseVisualStyleBackColor = true;
            Mod.Click += Mod_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 702);
            Controls.Add(Mod);
            Controls.Add(tanh);
            Controls.Add(cosh);
            Controls.Add(sinh);
            Controls.Add(tan);
            Controls.Add(log);
            Controls.Add(octal);
            Controls.Add(binary);
            Controls.Add(hexa);
            Controls.Add(equal);
            Controls.Add(zero);
            Controls.Add(dot);
            Controls.Add(minus);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(add);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(multiply);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(divide);
            Controls.Add(clear);
            Controls.Add(factorial);
            Controls.Add(pow);
            Controls.Add(back);
            Controls.Add(cos);
            Controls.Add(sin);
            Controls.Add(Screen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Screen;
        private Button sin;
        private Button back;
        private Button divide;
        private Button clear;
        private Button factorial;
        private Button pow;
        private Button multiply;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button add;
        private Button six;
        private Button five;
        private Button four;
        private Button minus;
        private Button three;
        private Button two;
        private Button one;
        private Button equal;
        private Button zero;
        private Button dot;
        private Button cos;
        private Button binary;
        private Button hexa;
        private Button log;
        private Button octal;
        private Button tan;
        private Button sinh;
        private Button cosh;
        private Button tanh;
        private Button Mod;
    }
}
