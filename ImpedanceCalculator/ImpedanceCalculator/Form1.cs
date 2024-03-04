using System.Numerics;

namespace ImpedanceCalculator
{
    public partial class Form1 : Form
    {
        // Member variables
        /*####################################################################################################*/

        private double m_real = 0.0;
        private double m_img = 0.0;

        private double m_frequency = 1000;

        // Toggles
        private bool m_ResistorKiloisToggled = false;

        private bool m_IndMilIsToggled = false;
        private bool m_IndMikroIsToggled = false;
        private bool m_IndNanoIsToggled = false;

        // Special functions
        /*####################################################################################################*/

        // Initializer
        public Form1()
        {
            InitializeComponent();
        }

        // UPDATE TEXTBOXES
        /*####################################################################################################*/
        private void update()
        {
            m_img = Math.Round(m_img, 2);
            m_real = Math.Round(m_real, 2);
            textBoxReImp.Text = m_real.ToString() + " \u2126";
            textBoxImgImp.Text = m_img.ToString() + " \u2126";
            textBoxAbsValue.Text = m_real.ToString() + " \u2126 + j " + m_img.ToString() + " \u2126";
        }

        // CHECK TEXTBOXES
        /*####################################################################################################*/

        /* RESISTOR CHECK (1/3)
         * checks if the textbox for resistor is empty or not
         * returns true if it is empty
         * returns false if it is not empty
         */
        private bool checkResistorTextBoxIsEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxResistor.Text))
            {
                check = true;
            }
            if (check == true)
            {
                MessageBox.Show("Resistor text box is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* RESISTOR CHECK (2/3)
         * checks if the textbox for the resistor contains any non numbers
         * returns true is there is a non number
         * returns false if not
         */
        private bool checkResistorTextBoxHasNonNumber()
        {
            bool check = false;
            foreach (char c in textBoxResistor.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Resistor text box contains non-digits!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* RESISTOR CHECK (3/3)
         * checks if the input value is null or negative
         * returns true if null or negative
         * returns false if not
         */
        private bool checkResistorIsNullOrNegative()
        {
            bool check = false;
            double value;
            double.TryParse(textBoxResistor.Text, out value);
            if (value <= 0)
            {
                check = true;
                MessageBox.Show("Resistor value cannot be zero or negative!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* RESISTOR CHECK (X)
         * sumarizes the checks into one compact operation
         * returns true if the values are valid
         * return false if not
         */
        private bool checkResistorTextBoxIsValid()
        {
            bool check = true;
            if (checkResistorTextBoxIsEmpty() == true)
            {
                check = false;
            }
            if (checkResistorTextBoxHasNonNumber() == true && check == true)
            {
                check = false;
            }
            if (checkResistorIsNullOrNegative() == true && check == true)
            {
                check = false;
            }
            return check;
        }

        /* INDUCTOR CHECK (1/3)
         * checks if the textbox for the inductor is empty or not
         * returns true if it is empty
         * returns false if it is not empty
         */
        private bool checkIndTBIsEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxInductor.Text))
            {
                check = true;
            }
            if (check == true)
            {
                MessageBox.Show("Resistor text box is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* INDUCTOR CHECK (2/3)
         * checks if the textbox for the inductor contains any non numbers
         * returns true if there is a non number
         * returns false if not
         */
        private bool checkIndTBHasNonNumber()
        {
            bool check = false;
            foreach (char c in textBoxInductor.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Inductor text box contains non-digits!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* INDUCTOR CHECK (3/3)
         * checks if the input value is null or negative
         * returns true if null or negative
         * returns false if not
         */
        private bool checkIndIsNullOrNegative()
        {
            bool check = false;
            double value;
            double.TryParse(textBoxInductor.Text, out value);
            if (value <= 0)
            {
                check = true;
                MessageBox.Show("Inductor value cannot be zero or negative!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* INDUCTOR CHECK (X)
         * sumarizes the checks into one compact operation
         * returns true if the values are valid
         * returns false if not
         */
        private bool checkIndTBIsValid()
        {
            bool check = true;
            if (checkIndTBIsEmpty() == true)
            {
                check = false;
            }
            if (checkIndTBHasNonNumber() == true && check == true)
            {
                check = false;
            }
            if (checkIndIsNullOrNegative() == true && check == true)
            {
                check = false;
            }
            return check;
        }

        /* CAPACITOR CHECK (1/3)
         * checks if the textbox for capacitor is empty or not
         * returns ture if it is empty
         * returns false if it is not empty
         */
        private bool checkCapTBisEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxCapacitor.Text))
            {
                check = true;
            }
            if (check)
            {
                MessageBox.Show("Capacitor text box is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* CAPACITOR CHECK(2/3)
         * checks if the textbox for the inductor contains any non numbers
         * returns true if there is a non number
         * returns false if not
         */
        private bool checkCapTBHasNonNumber()
        {
            bool check = false;
            foreach (char c in textBoxCapacitor.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            if (check)
            {
                MessageBox.Show("Capacitor text box contains non-digits!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* CAPACITOR CHECK (3/3)
         * checks if the input value is null or negative
         * returns true if null or negative
         * returns false if not
         */
        private bool checkCapIsNullOrNegative()
        {
            bool check = false;
            double value;
            double.TryParse(textBoxCapacitor.Text, out value);
            if (value <= 0)
            {
                check = true;
                MessageBox.Show("Capacitor value cannot be zero or negative!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* CAPACITOR CHECK (X)
         */
        private bool checkCapTBIsValid()
        {
            bool check = true;
            if (checkCapTBisEmpty() == true)
            {
                check = false;
            }
            if (checkCapTBHasNonNumber() && check)
            {
                check = false;
            }
            if (checkCapIsNullOrNegative() && check == true)
            {
                check = false;
            }
            return check;
        }
        // BUTTON HANDLING
        /*####################################################################################################*/

        /* BUTTON ADD Resistor SERIAL
         */
        private void buttonResADDSerial_Click(object sender, EventArgs e)
        {
            double resistor;
            bool validInput = checkResistorTextBoxIsValid();
            if (validInput == true)
            {
                double.TryParse(textBoxResistor.Text, out resistor);
                if (m_ResistorKiloisToggled)
                {
                    resistor *= 1000;
                }
                m_real += resistor;
                update();
            }
        }

        /* BUTTON ADD Resistor PARALLEL
         */
        private void buttonResADDParallel_Click(object sender, EventArgs e)
        {
            double resistor;
            bool validInput = checkResistorTextBoxIsValid();
            if (validInput == true)
            {
                double.TryParse(textBoxResistor.Text, out resistor);
                if (m_ResistorKiloisToggled)
                {
                    resistor *= 1000;
                }
                Complex z1 = new Complex(m_real, m_img);
                Complex z2 = new Complex(resistor, 0);

                Complex z3 = (z1 * z2) / (z1 + z2);

                m_real = z3.Real;
                m_img = z3.Imaginary;
                update();
                update();
            }
        }

        /* BUTTON RESET resistor values
         */
        private void buttonRESET_Click(object sender, EventArgs e)
        {
            m_real = 0.0;
            m_img = 0.0;
            update();
        }

        /* BUTTON ADD Inductor SERIAL
         */
        private void buttonIndADDSerial_Click(object sender, EventArgs e)
        {
            double inductor;
            bool validInput = checkIndTBIsValid();
            if (validInput == true)
            {
                double.TryParse(textBoxInductor.Text, out inductor);
                if (m_IndMilIsToggled)
                {
                    inductor *= 0.001;
                }
                m_img += 2 * Math.PI * m_frequency * inductor;
                update();
            }
        }

        /* BUTTON ADD Inductor PARALLEL - TO BE IMPLEMENTED FURTHER!!!!!!!!!!!!!!!!!!!!!!!!!
         */
        private void buttonIndADDParallel_Click(object sender, EventArgs e)
        {
            double inductor;
            bool validInput = checkIndTBIsValid();
            if (validInput == true)
            {
                double.TryParse(textBoxInductor.Text, out inductor);
                m_img = (m_img * inductor) / (m_img + inductor); // THIS IS FALSE!
                update();
            }
        }

        /* BUTTON ADD Capacitor SERIAL
         */
        private void buttonCapADDSerial_Click(object sender, EventArgs e)
        {
            double capacitor;
            bool validInput = checkCapTBIsValid();
            if (validInput)
            {
                double.TryParse(textBoxCapacitor.Text, out capacitor);
                m_img += -(1.0 / (2.0 * Math.PI * m_frequency * capacitor));
                update();
            }
        }

        /* BUTTON ADD Capacitor PARALLEL
         */
        private void buttonCapADDParallel_Click(object sender, EventArgs e)
        {
            double capacitor;
            bool validInput = checkCapTBIsValid();
            if (validInput)
            {
                double.TryParse(textBoxCapacitor.Text, out capacitor);
                capacitor = -(1.0 / (2.0 * Math.PI * m_frequency * capacitor));
                Complex z1 = new Complex(m_real, m_img);
                Complex z2 = new Complex(0, capacitor);

                Complex z3 = (z1 * z2) / (z1 + z2);

                m_real = z3.Real;
                m_img = z3.Imaginary;
                update();
            }
        }

        // TOGGLE BUTTON HANDLING
        /*####################################################################################################*/

        /* BUTTON TOGGLE RESISTOR kg
         */
        private void buttonResistorKilo_Click(object sender, EventArgs e)
        {
            m_ResistorKiloisToggled = !m_ResistorKiloisToggled;
            if (m_ResistorKiloisToggled)
            {
                buttonResistorKilo.BackColor = Color.Gray;
            }
            else
            {
                buttonResistorKilo.BackColor = DefaultBackColor;
            }
        }

        /* BUTTON TOGGLE INDUCTOR milli
         */
        private void buttonIndMil_Click(object sender, EventArgs e)
        {
            m_IndMilIsToggled = !m_IndMilIsToggled;
            if (m_IndMilIsToggled)
            {
                buttonIndMil.BackColor = Color.Gray;
            }
            else
            {
                buttonIndMil.BackColor = DefaultBackColor;
            }
        }
    }
}