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
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(270, 157);
            label1.Name = "label1";
            label1.Size = new Size(37, 37);
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
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(141, 37);
            label3.TabIndex = 3;
            label3.Text = "RESISTOR";
            // 
            // textBoxResistor
            // 
            textBoxResistor.Font = new Font("Segoe UI", 20F);
            textBoxResistor.Location = new Point(12, 154);
            textBoxResistor.Name = "textBoxResistor";
            textBoxResistor.Size = new Size(252, 43);
            textBoxResistor.TabIndex = 4;
            // 
            // buttonResADDSerial
            // 
            buttonResADDSerial.Font = new Font("Segoe UI", 20F);
            buttonResADDSerial.Location = new Point(313, 151);
            buttonResADDSerial.Name = "buttonResADDSerial";
            buttonResADDSerial.Size = new Size(141, 48);
            buttonResADDSerial.TabIndex = 5;
            buttonResADDSerial.Text = "+ SERIAL";
            buttonResADDSerial.UseVisualStyleBackColor = true;
            // 
            // buttonResADDParallel
            // 
            buttonResADDParallel.Font = new Font("Segoe UI", 20F);
            buttonResADDParallel.Location = new Point(460, 151);
            buttonResADDParallel.Name = "buttonResADDParallel";
            buttonResADDParallel.Size = new Size(173, 48);
            buttonResADDParallel.TabIndex = 6;
            buttonResADDParallel.Text = "+ PARALLEL";
            buttonResADDParallel.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1753, 953);
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
    }
}
