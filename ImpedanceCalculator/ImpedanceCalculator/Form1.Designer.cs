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
            buttonIndADDParallel = new Button();
            buttonIndADDSerial = new Button();
            textBoxInductor = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            buttonResistorKilo = new Button();
            buttonIndMil = new Button();
            buttonIndmic = new Button();
            buttonIndNano = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBoxFrequency = new TextBox();
            label15 = new Label();
            label16 = new Label();
            button5 = new Button();
            label11 = new Label();
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
            textBoxAbsValue.Text = "0 Ω + j 0 Ω";
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
            // buttonIndADDParallel
            // 
            buttonIndADDParallel.Font = new Font("Segoe UI", 20F);
            buttonIndADDParallel.Location = new Point(1074, 237);
            buttonIndADDParallel.Name = "buttonIndADDParallel";
            buttonIndADDParallel.Size = new Size(173, 48);
            buttonIndADDParallel.TabIndex = 17;
            buttonIndADDParallel.Text = "+ PARALLEL";
            buttonIndADDParallel.UseVisualStyleBackColor = true;
            // 
            // buttonIndADDSerial
            // 
            buttonIndADDSerial.Font = new Font("Segoe UI", 20F);
            buttonIndADDSerial.Location = new Point(927, 237);
            buttonIndADDSerial.Name = "buttonIndADDSerial";
            buttonIndADDSerial.Size = new Size(141, 48);
            buttonIndADDSerial.TabIndex = 16;
            buttonIndADDSerial.Text = "+ SERIAL";
            buttonIndADDSerial.UseVisualStyleBackColor = true;
            buttonIndADDSerial.Click += buttonIndADDSerial_Click;
            // 
            // textBoxInductor
            // 
            textBoxInductor.Font = new Font("Segoe UI", 20F);
            textBoxInductor.Location = new Point(430, 240);
            textBoxInductor.Name = "textBoxInductor";
            textBoxInductor.Size = new Size(252, 43);
            textBoxInductor.TabIndex = 15;
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
            // buttonIndMil
            // 
            buttonIndMil.Font = new Font("Segoe UI", 20F);
            buttonIndMil.Location = new Point(732, 237);
            buttonIndMil.Name = "buttonIndMil";
            buttonIndMil.Size = new Size(52, 48);
            buttonIndMil.TabIndex = 24;
            buttonIndMil.Text = "m";
            buttonIndMil.UseVisualStyleBackColor = true;
            // 
            // buttonIndmic
            // 
            buttonIndmic.Font = new Font("Segoe UI", 20F);
            buttonIndmic.Location = new Point(790, 237);
            buttonIndmic.Name = "buttonIndmic";
            buttonIndmic.Size = new Size(52, 48);
            buttonIndmic.TabIndex = 25;
            buttonIndmic.Text = "µ";
            buttonIndmic.UseVisualStyleBackColor = true;
            // 
            // buttonIndNano
            // 
            buttonIndNano.Font = new Font("Segoe UI", 20F);
            buttonIndNano.Location = new Point(848, 237);
            buttonIndNano.Name = "buttonIndNano";
            buttonIndNano.Size = new Size(52, 48);
            buttonIndNano.TabIndex = 26;
            buttonIndNano.Text = "n";
            buttonIndNano.UseVisualStyleBackColor = true;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(732, 407);
            label11.Name = "label11";
            label11.Size = new Size(275, 37);
            label11.TabIndex = 44;
            label11.Text = "Use ',' instead of '.' !";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 463);
            Controls.Add(label11);
            Controls.Add(button5);
            Controls.Add(label16);
            Controls.Add(textBoxFrequency);
            Controls.Add(label15);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(buttonIndNano);
            Controls.Add(buttonIndmic);
            Controls.Add(buttonIndMil);
            Controls.Add(buttonResistorKilo);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(buttonIndADDParallel);
            Controls.Add(buttonIndADDSerial);
            Controls.Add(textBoxInductor);
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
        private Button buttonIndADDParallel;
        private Button buttonIndADDSerial;
        private TextBox textBoxInductor;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label9;
        private Label label10;
        private Button buttonResistorKilo;
        private Button buttonIndMil;
        private Button buttonIndmic;
        private Button buttonIndNano;
        private Button button9;
        private Button button10;
        private Button button11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBoxFrequency;
        private Label label15;
        private Label label16;
        private Button button5;
        private Label label11;
    }
}
