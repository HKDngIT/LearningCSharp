namespace ImpedanceCalculator
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
            label2 = new Label();
            label1 = new Label();
            textBoxReImp = new TextBox();
            label3 = new Label();
            textBoxResistor = new TextBox();
            buttonResADDSerial = new Button();
            buttonResADDParallel = new Button();
            label4 = new Label();
            label5 = new Label();
            textBoxImgImp = new TextBox();
            textBoxAbsValue = new TextBox();
            label6 = new Label();
            buttonRESET = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(197, 37);
            label2.TabIndex = 2;
            label2.Text = "IMPEDANCE Z";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 425);
            label1.Name = "label1";
            label1.Size = new Size(38, 37);
            label1.TabIndex = 1;
            label1.Text = "Ω";
            // 
            // textBoxReImp
            // 
            textBoxReImp.Font = new Font("Segoe UI", 20F);
            textBoxReImp.Location = new Point(136, 49);
            textBoxReImp.Name = "textBoxReImp";
            textBoxReImp.Size = new Size(252, 43);
            textBoxReImp.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 382);
            label3.Name = "label3";
            label3.Size = new Size(141, 37);
            label3.TabIndex = 3;
            label3.Text = "RESISTOR";
            // 
            // textBoxResistor
            // 
            textBoxResistor.Font = new Font("Segoe UI", 20F);
            textBoxResistor.Location = new Point(12, 422);
            textBoxResistor.Name = "textBoxResistor";
            textBoxResistor.Size = new Size(252, 43);
            textBoxResistor.TabIndex = 4;
            // 
            // buttonResADDSerial
            // 
            buttonResADDSerial.Font = new Font("Segoe UI", 20F);
            buttonResADDSerial.Location = new Point(509, 419);
            buttonResADDSerial.Name = "buttonResADDSerial";
            buttonResADDSerial.Size = new Size(141, 48);
            buttonResADDSerial.TabIndex = 5;
            buttonResADDSerial.Text = "+ SERIAL";
            buttonResADDSerial.UseVisualStyleBackColor = true;
            buttonResADDSerial.Click += buttonResADDSerial_Click;
            // 
            // buttonResADDParallel
            // 
            buttonResADDParallel.Font = new Font("Segoe UI", 20F);
            buttonResADDParallel.Location = new Point(656, 419);
            buttonResADDParallel.Name = "buttonResADDParallel";
            buttonResADDParallel.Size = new Size(173, 48);
            buttonResADDParallel.TabIndex = 6;
            buttonResADDParallel.Text = "+ PARALLEL";
            buttonResADDParallel.UseVisualStyleBackColor = true;
            buttonResADDParallel.Click += buttonResADDParallel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Size = new Size(118, 37);
            label4.TabIndex = 7;
            label4.Text = "RE{Z} = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 52);
            label5.Name = "label5";
            label5.Size = new Size(140, 37);
            label5.TabIndex = 8;
            label5.Text = "IMG{Z} = ";
            // 
            // textBoxImgImp
            // 
            textBoxImgImp.Font = new Font("Segoe UI", 20F);
            textBoxImgImp.Location = new Point(540, 49);
            textBoxImgImp.Name = "textBoxImgImp";
            textBoxImgImp.Size = new Size(252, 43);
            textBoxImgImp.TabIndex = 9;
            // 
            // textBoxAbsValue
            // 
            textBoxAbsValue.Font = new Font("Segoe UI", 20F);
            textBoxAbsValue.Location = new Point(892, 49);
            textBoxAbsValue.Name = "textBoxAbsValue";
            textBoxAbsValue.Size = new Size(252, 43);
            textBoxAbsValue.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(802, 52);
            label6.Name = "label6";
            label6.Size = new Size(84, 37);
            label6.TabIndex = 10;
            label6.Text = "|Z| = ";
            // 
            // buttonRESET
            // 
            buttonRESET.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRESET.Location = new Point(1390, 46);
            buttonRESET.Name = "buttonRESET";
            buttonRESET.Size = new Size(173, 48);
            buttonRESET.TabIndex = 12;
            buttonRESET.Text = "RESET";
            buttonRESET.UseVisualStyleBackColor = true;
            buttonRESET.Click += buttonRESET_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(656, 505);
            button1.Name = "button1";
            button1.Size = new Size(173, 48);
            button1.TabIndex = 17;
            button1.Text = "+ PARALLEL";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(509, 505);
            button2.Name = "button2";
            button2.Size = new Size(141, 48);
            button2.TabIndex = 16;
            button2.Text = "+ SERIAL";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(12, 508);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 43);
            textBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 468);
            label7.Name = "label7";
            label7.Size = new Size(157, 37);
            label7.TabIndex = 14;
            label7.Text = "INDUCTOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(270, 511);
            label8.Name = "label8";
            label8.Size = new Size(38, 37);
            label8.TabIndex = 13;
            label8.Text = "H";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(656, 593);
            button3.Name = "button3";
            button3.Size = new Size(173, 48);
            button3.TabIndex = 22;
            button3.Text = "+ PARALLEL";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(509, 593);
            button4.Name = "button4";
            button4.Size = new Size(141, 48);
            button4.TabIndex = 21;
            button4.Text = "+ SERIAL";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(12, 596);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 43);
            textBox2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 556);
            label9.Name = "label9";
            label9.Size = new Size(166, 37);
            label9.TabIndex = 19;
            label9.Text = "CAPACITOR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(270, 599);
            label10.Name = "label10";
            label10.Size = new Size(31, 37);
            label10.TabIndex = 18;
            label10.Text = "F";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(314, 419);
            button5.Name = "button5";
            button5.Size = new Size(52, 48);
            button5.TabIndex = 23;
            button5.Text = "k";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(314, 505);
            button6.Name = "button6";
            button6.Size = new Size(52, 48);
            button6.TabIndex = 24;
            button6.Text = "m";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(372, 505);
            button7.Name = "button7";
            button7.Size = new Size(52, 48);
            button7.TabIndex = 25;
            button7.Text = "µ";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(430, 505);
            button8.Name = "button8";
            button8.Size = new Size(52, 48);
            button8.TabIndex = 26;
            button8.Text = "n";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20F);
            button9.Location = new Point(430, 593);
            button9.Name = "button9";
            button9.Size = new Size(52, 48);
            button9.TabIndex = 29;
            button9.Text = "n";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(372, 593);
            button10.Name = "button10";
            button10.Size = new Size(52, 48);
            button10.TabIndex = 28;
            button10.Text = "µ";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 20F);
            button11.Location = new Point(314, 593);
            button11.Name = "button11";
            button11.Size = new Size(52, 48);
            button11.TabIndex = 27;
            button11.Text = "m";
            button11.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(12, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 43);
            textBox3.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(270, 173);
            label11.Name = "label11";
            label11.Size = new Size(101, 37);
            label11.TabIndex = 30;
            label11.Text = "Ω + jw";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(377, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(252, 43);
            textBox4.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 130);
            label12.Name = "label12";
            label12.Size = new Size(234, 37);
            label12.TabIndex = 33;
            label12.Text = "R + jwL + 1 / jwC";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(635, 173);
            label13.Name = "label13";
            label13.Size = new Size(115, 37);
            label13.TabIndex = 34;
            label13.Text = "+ 1 / jw";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 216);
            label14.Name = "label14";
            label14.Size = new Size(175, 37);
            label14.TabIndex = 35;
            label14.Text = "w = 2 * pi * f";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 20F);
            textBox5.Location = new Point(756, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 43);
            textBox5.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1753, 953);
            Controls.Add(textBox5);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(buttonRESET);
            Controls.Add(textBoxAbsValue);
            Controls.Add(label6);
            Controls.Add(textBoxImgImp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonResADDParallel);
            Controls.Add(buttonResADDSerial);
            Controls.Add(textBoxResistor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxReImp);
            Name = "Form1";
            Text = "Impedance Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox textBoxReImp;
        private Label label3;
        private TextBox textBoxResistor;
        private Button buttonResADDSerial;
        private Button buttonResADDParallel;
        private Label label4;
        private Label label5;
        private TextBox textBoxImgImp;
        private TextBox textBoxAbsValue;
        private Label label6;
        private Button buttonRESET;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label9;
        private Label label10;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox4;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox5;
    }
}
