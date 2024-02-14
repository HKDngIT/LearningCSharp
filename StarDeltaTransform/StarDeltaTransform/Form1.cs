namespace StarDeltaTransform
{
    public partial class Form1 : Form
    {
        // Initializer
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        private double r1Delta = 0;
        private double r2Delta = 0;
        private double r3Delta = 0;

        private double r1Star = 0;
        private double r2Star = 0;
        private double r3Star = 0;

        // textBox handling
        /*####################################################################################################*/

        /*
         * checks if there are any non digits in the textboxes in delta
         * returns true if there are non numbers
         * returns false if there are only numbers
         */
        private bool checkDeltaHasNonNumbers()
        {
            bool check = false;
            foreach (char c in textBoxR1Delta.Text)
            {
                if(!char.IsDigit(c)  && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxR2Delta.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxR3Delta.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            return check;
        }

        /*
         * checks if there are any non digits in the textboxes in star
         * returns true if there are non numbers
         * returns false if there are only numbers
         */
        private bool checkStarHasNonNumbers()
        {
            bool check = false;
            foreach (char c in textBoxR1Star.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxR2Star.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxR3Star.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            return check;
        }

        /*
         * checks if the textboxes in delta are empty or not
         * returns true if there is at least one empty text box
         * returns false if there are no empty text boxes
         */
        private bool checkDeltaHasNullOrEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxR1Delta.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxR2Delta.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxR3Delta.Text))
            {
                check = true;
            }
            return check;
        }

        /*
         * checks if the textboxes in star are empty or not
         * returns true if there is at least one empty text box
         * returns false if there are no empty text boxes
         */
        private bool checkStarHasNullOrEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxR1Star.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxR2Star.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxR3Star.Text))
            {
                check = true;
            }
            return check;
        }

        /*
         * checks if any delta resistor values are zero or negative
         * returns true if a value is zero or negative
         * returns false if all values are legal
         */
        private bool checkDeltaHasNullResistor()
        {
            bool check = false;
            double.TryParse(textBoxR1Delta.Text, out r1Delta);
            double.TryParse(textBoxR2Delta.Text, out r2Delta);
            double.TryParse(textBoxR3Delta.Text, out r3Delta);
            if(r1Delta <= 0 || r2Delta <= 0 || r3Delta <= 0)
            {
                check = true;
            }
            return check;
        }

        /*
         * checks if any star resistor values are zero or negative
         * returns true if a value is zero or negative
         * returns false if all values are legal
         */
        private bool checkStarHasNullResistor()
        {
            bool check = false;
            double.TryParse(textBoxR1Star.Text, out r1Star);
            double.TryParse(textBoxR2Star.Text, out r2Star);
            double.TryParse(textBoxR3Star.Text, out r3Star);
            if (r1Star <= 0 || r2Star <= 0 || r3Star <= 0)
            {
                check = true;
            }
            return check;
        }

        // Calculations
        /*####################################################################################################*/

        /*
         * calculates new star resistor values / transforms from delta to star
         */
        private void calculateDeltaToStar()
        {
            r1Star = (r1Delta * r3Delta) / (r1Delta + r2Delta + r3Delta);
            r2Star = (r1Delta * r2Delta) / (r1Delta + r2Delta + r3Delta);
            r3Star = (r2Delta * r3Delta) / (r1Delta + r2Delta + r3Delta);
            r1Star = Math.Round(r1Star, 2);
            r2Star = Math.Round(r2Star, 2);
            r3Star = Math.Round(r3Star, 2);
        }

        /*
         * calculates new delta resistor values / transforms from star to delta
         */
        private void calculateStarToDelta()
        {
            r1Delta = r1Star + r2Star + ((r1Star * r2Star) / r3Star);
            r2Delta = r2Star + r3Star + ((r2Star * r3Star) / r1Star);
            r3Delta = r3Star + r1Star + ((r3Star * r1Star) / r2Star);
            r1Delta = Math.Round(r1Delta, 2);
            r2Delta = Math.Round(r2Delta, 2);
            r3Delta = Math.Round(r3Delta, 2);
        }

        // TextBoxUpdates after calculations
        /*####################################################################################################*/

        /*
         * writes current star resistor values into the star resistor text boxes
         */
        private void updateStarResistorValues()
        {
            textBoxR1Star.Text = r1Star.ToString();
            textBoxR2Star.Text = r2Star.ToString();
            textBoxR3Star.Text = r3Star.ToString();
        }

        /*
         * writes current star resistor values into the star resistor text boxes
         */
        private void updateDeltaResistorValues()
        {
            textBoxR1Delta.Text = r1Delta.ToString();
            textBoxR2Delta.Text = r2Delta.ToString();
            textBoxR3Delta.Text = r3Delta.ToString();
        }

        // Button handling
        /*####################################################################################################*/

        /*
         * button press handling which calculates the new values of the resistor in star form
         */
        private void buttonToStar_Click(object sender, EventArgs e)
        {
            bool checkErrors = false;
            if(checkDeltaHasNonNumbers())
            {
                MessageBox.Show("TEXT BOXES CONTAIN NON-NUMBERS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkErrors = true;
            }
            if(checkDeltaHasNullOrEmpty())
            {
                MessageBox.Show("RESISTOR VALUES CANNOT BE EMPTY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkErrors = true;
            }
            if(checkDeltaHasNullResistor())
            {
                MessageBox.Show("RESISTOR VALUES CANNOT BE ZERO OR NEGATIVE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkErrors = true;
            }

            if(checkErrors == false)
            {
                calculateDeltaToStar();
                updateStarResistorValues();
            }
        }

        /*
         * button press handling which calculates the new values of the resistor in delta form
         */
        private void buttonToDelta_Click(object sender, EventArgs e)
        {
            bool checkErrors = false;
            if(checkStarHasNonNumbers())
            {
                MessageBox.Show("TEXT BOXES CONTAIN NON-NUMBERS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkErrors = true;
            }
            if (checkStarHasNullOrEmpty())
            {
                MessageBox.Show("RESISTOR VALUES CANNOT BE EMPTY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkErrors = true;
            }
            if (checkStarHasNullResistor())
            {
                MessageBox.Show("RESISTOR VALUES CANNOT BE ZERO OR NEGATIVE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkErrors = true;
            }

            if (checkErrors == false)
            {
                calculateStarToDelta();
                updateDeltaResistorValues();
            }
        }
    }
}