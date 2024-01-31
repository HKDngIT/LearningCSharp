namespace Memory
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
            buttonStart = new Button();
            labelTries = new Label();
            buttonRestart = new Button();
            textBoxTries = new TextBox();
            labelTimer = new Label();
            textBoxTimer = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(642, 13);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(139, 44);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelTries
            // 
            labelTries.AutoSize = true;
            labelTries.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTries.Location = new Point(666, 110);
            labelTries.Name = "labelTries";
            labelTries.Size = new Size(92, 25);
            labelTries.TabIndex = 1;
            labelTries.Text = "TRIES: ";
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRestart.Location = new Point(642, 63);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(139, 44);
            buttonRestart.TabIndex = 2;
            buttonRestart.Text = "RESTART";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // textBoxTries
            // 
            textBoxTries.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTries.Location = new Point(642, 138);
            textBoxTries.Name = "textBoxTries";
            textBoxTries.ReadOnly = true;
            textBoxTries.Size = new Size(139, 31);
            textBoxTries.TabIndex = 3;
            textBoxTries.Text = "0";
            textBoxTries.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.Location = new Point(669, 185);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(89, 25);
            labelTimer.TabIndex = 4;
            labelTimer.Text = "TIMER:";
            // 
            // textBoxTimer
            // 
            textBoxTimer.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTimer.Location = new Point(642, 213);
            textBoxTimer.Name = "textBoxTimer";
            textBoxTimer.ReadOnly = true;
            textBoxTimer.Size = new Size(139, 31);
            textBoxTimer.TabIndex = 5;
            textBoxTimer.Text = "0:00";
            textBoxTimer.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(138, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(264, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(390, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 120);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(516, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 120);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(12, 138);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 120);
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(138, 138);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(120, 120);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(264, 138);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(120, 120);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(390, 138);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(120, 120);
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(516, 138);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(120, 120);
            pictureBox10.TabIndex = 15;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(12, 264);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(120, 120);
            pictureBox11.TabIndex = 16;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(138, 264);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 120);
            pictureBox12.TabIndex = 17;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(264, 264);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(120, 120);
            pictureBox13.TabIndex = 18;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(390, 264);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(120, 120);
            pictureBox14.TabIndex = 19;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(516, 264);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(120, 120);
            pictureBox15.TabIndex = 20;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(12, 390);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(120, 120);
            pictureBox16.TabIndex = 21;
            pictureBox16.TabStop = false;
            pictureBox16.Click += pictureBox16_Click;
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(138, 390);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(120, 120);
            pictureBox17.TabIndex = 22;
            pictureBox17.TabStop = false;
            pictureBox17.Click += pictureBox17_Click;
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(264, 390);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(120, 120);
            pictureBox18.TabIndex = 23;
            pictureBox18.TabStop = false;
            pictureBox18.Click += pictureBox18_Click;
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(390, 390);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(120, 120);
            pictureBox19.TabIndex = 24;
            pictureBox19.TabStop = false;
            pictureBox19.Click += pictureBox19_Click;
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(516, 390);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(120, 120);
            pictureBox20.TabIndex = 25;
            pictureBox20.TabStop = false;
            pictureBox20.Click += pictureBox20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 634);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxTimer);
            Controls.Add(labelTimer);
            Controls.Add(textBoxTries);
            Controls.Add(buttonRestart);
            Controls.Add(labelTries);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label labelTries;
        private Button buttonRestart;
        private TextBox textBoxTries;
        private Label labelTimer;
        private TextBox textBoxTimer;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        public PictureBox pictureBox1;
    }
}