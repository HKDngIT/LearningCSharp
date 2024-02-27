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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            buttonResistorKilo = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBoxFrequency = new TextBox();
            label15 = new Label();
            label16 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
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
            label1.Location = new Point(688, 141);
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
            textBoxReImp.ReadOnly = true;
            textBoxReImp.Size = new Size(252, 43);
            textBoxReImp.TabIndex = 0;
            textBoxReImp.Text = "0 Ω";
            textBoxReImp.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(430, 98);
            label3.Name = "label3";
            label3.Size = new Size(141, 37);
            label3.TabIndex = 3;
            label3.Text = "RESISTOR";
            // 
            // textBoxResistor
            // 
            textBoxResistor.Font = new Font("Segoe UI", 20F);
            textBoxResistor.Location = new Point(430, 138);
            textBoxResistor.Name = "textBoxResistor";
            textBoxResistor.Size = new Size(252, 43);
            textBoxResistor.TabIndex = 4;
            // 
            // buttonResADDSerial
            // 
            buttonResADDSerial.Font = new Font("Segoe UI", 20F);
            buttonResADDSerial.Location = new Point(927, 135);
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
            buttonResADDParallel.Location = new Point(1074, 135);
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
            textBoxImgImp.ReadOnly = true;
            textBoxImgImp.Size = new Size(252, 43);
            textBoxImgImp.TabIndex = 9;
            textBoxImgImp.Text = "0 Ω";
            textBoxImgImp.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAbsValue
            // 
            textBoxAbsValue.Font = new Font("Segoe UI", 20F);
            textBoxAbsValue.Location = new Point(892, 49);
            textBoxAbsValue.Name = "textBoxAbsValue";
            textBoxAbsValue.ReadOnly = true;
            textBoxAbsValue.Size = new Size(252, 43);
            textBoxAbsValue.TabIndex = 11;
            textBoxAbsValue.Text = "0 Ω + jw 0 Ω";
            textBoxAbsValue.TextAlign = HorizontalAlignment.Center;
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
            buttonRESET.Location = new Point(1165, 46);
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
            button1.Location = new Point(1074, 237);
            button1.Name = "button1";
            button1.Size = new Size(173, 48);
            button1.TabIndex = 17;
            button1.Text = "+ PARALLEL";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(927, 237);
            button2.Name = "button2";
            button2.Size = new Size(141, 48);
            button2.TabIndex = 16;
            button2.Text = "+ SERIAL";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(430, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 43);
            textBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(430, 200);
            label7.Name = "label7";
            label7.Size = new Size(157, 37);
            label7.TabIndex = 14;
            label7.Text = "INDUCTOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(688, 243);
            label8.Name = "label8";
            label8.Size = new Size(38, 37);
            label8.TabIndex = 13;
            label8.Text = "H";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(1074, 339);
            button3.Name = "button3";
            button3.Size = new Size(173, 48);
            button3.TabIndex = 22;
            button3.Text = "+ PARALLEL";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(927, 339);
            button4.Name = "button4";
            button4.Size = new Size(141, 48);
            button4.TabIndex = 21;
            button4.Text = "+ SERIAL";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(430, 342);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 43);
            textBox2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(430, 302);
            label9.Name = "label9";
            label9.Size = new Size(166, 37);
            label9.TabIndex = 19;
            label9.Text = "CAPACITOR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(688, 345);
            label10.Name = "label10";
            label10.Size = new Size(31, 37);
            label10.TabIndex = 18;
            label10.Text = "F";
            // 
            // buttonResistorKilo
            // 
            buttonResistorKilo.Font = new Font("Segoe UI", 20F);
            buttonResistorKilo.Location = new Point(732, 135);
            buttonResistorKilo.Name = "buttonResistorKilo";
            buttonResistorKilo.Size = new Size(52, 48);
            buttonResistorKilo.TabIndex = 23;
            buttonResistorKilo.Text = "k";
            buttonResistorKilo.UseVisualStyleBackColor = true;
            buttonResistorKilo.Click += buttonResistorKilo_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(732, 237);
            button6.Name = "button6";
            button6.Size = new Size(52, 48);
            button6.TabIndex = 24;
            button6.Text = "m";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(790, 237);
            button7.Name = "button7";
            button7.Size = new Size(52, 48);
            button7.TabIndex = 25;
            button7.Text = "µ";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(848, 237);
            button8.Name = "button8";
            button8.Size = new Size(52, 48);
            button8.TabIndex = 26;
            button8.Text = "n";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20F);
            button9.Location = new Point(848, 339);
            button9.Name = "button9";
            button9.Size = new Size(52, 48);
            button9.TabIndex = 29;
            button9.Text = "n";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(790, 339);
            button10.Name = "button10";
            button10.Size = new Size(52, 48);
            button10.TabIndex = 28;
            button10.Text = "µ";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 20F);
            button11.Location = new Point(732, 339);
            button11.Name = "button11";
            button11.Size = new Size(52, 48);
            button11.TabIndex = 27;
            button11.Text = "m";
            button11.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(840, 410);
            label14.Name = "label14";
            label14.Size = new Size(168, 37);
            label14.TabIndex = 35;
            label14.Text = "w = 2 * pi * f";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(412, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // textBoxFrequency
            // 
            textBoxFrequency.Font = new Font("Segoe UI", 20F);
            textBoxFrequency.Location = new Point(234, 404);
            textBoxFrequency.Name = "textBoxFrequency";
            textBoxFrequency.Size = new Size(252, 43);
            textBoxFrequency.TabIndex = 41;
            textBoxFrequency.Text = "1000";
            textBoxFrequency.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(46, 407);
            label15.Name = "label15";
            label15.Size = new Size(199, 37);
            label15.TabIndex = 40;
            label15.Text = "Frequency f = ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(492, 407);
            label16.Name = "label16";
            label16.Size = new Size(51, 37);
            label16.TabIndex = 42;
            label16.Text = "Hz";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(549, 401);
            button5.Name = "button5";
            button5.Size = new Size(141, 48);
            button5.TabIndex = 43;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 463);
            Controls.Add(button5);
            Controls.Add(label16);
            Controls.Add(textBoxFrequency);
            Controls.Add(label15);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(buttonResistorKilo);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Button buttonResistorKilo;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label label14;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBoxFrequency;
        private Label label15;
        private Label label16;
        private Button button5;
    }
}
