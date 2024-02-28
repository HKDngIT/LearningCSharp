namespace ImpedanceCalculator
{
    public partial class Form1 : Form
    {
        // Member variables
        /*####################################################################################################*/

        private double m_real = 0.0;
        private double m_img = 0.0;

        private double frequency = 1000;

        // Toggles
        private bool m_ResistorKiloisToggled = false;

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
            textBoxAbsValue.Text = m_real.ToString() + " \u2126 + jw " + m_img.ToString() + " \u2126";
        }

        // CHECK TEXTBOXES
        /*####################################################################################################*/

        /* RESISTOR CHECK (1/3)
         * checks if the textboxes for resistor is empty or not
         * returns true if it is empty
         * returns false if it is not empty
         */
        private bool checkResistorTextBoxIsEmpty()
        {
            bool check = false;
            if(string.IsNullOrEmpty(textBoxResistor.Text))
            {
                check = true;
            }
            if(check == true)
            {
                MessageBox.Show("Resistor text box is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* RESISTOR CHECK (2/3)
         * checks if the textboxes for the resistor contains any non numbers
         * returns true is there is a non number
         * returns false if not
         */
        private bool checkResistorTextBoxHasNonNumber()
        {
            bool check = false;
            foreach(char c in textBoxResistor.Text)
            {
                if(!char.IsDigit(c) && c != '-' && c != ',')
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
            if(value <= 0)
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
            if(checkResistorTextBoxIsEmpty() == true)
            {
                check = false;
            }
            if(checkResistorTextBoxHasNonNumber() == true)
            {
                check = false;
            }
            if(checkResistorIsNullOrNegative() == true)
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
            if(validInput == true)
            {
                double.TryParse(textBoxResistor.Text, out resistor);
                m_real += resistor;
                update();
            }
        }

        /* BUTTON ADD Resistor SERIAL
         */
        private void buttonResADDParallel_Click(object sender, EventArgs e)
        {
            double resistor;
            double.TryParse(textBoxResistor.Text, out resistor);
            if (m_real == 0.0)
            {
                m_real = resistor;
            }
            else
            {
                m_real = (m_real * resistor) / (m_real + resistor);
            }
            update();
        }

        /* BUTTON RESET resistor values
         */
        private void buttonRESET_Click(object sender, EventArgs e)
        {
            m_real = 0.0;
            m_img = 0.0;
            update();
        }

        /* BUTTON TOGGLE RESISTOR kg
         */
        private void buttonResistorKilo_Click(object sender, EventArgs e)
        {
            m_ResistorKiloisToggled = !m_ResistorKiloisToggled;
            if(m_ResistorKiloisToggled)
            {
                buttonResistorKilo.BackColor = Color.Gray;
            } else
            {
                buttonResistorKilo.BackColor = DefaultBackColor;
            }
        }
    }
}