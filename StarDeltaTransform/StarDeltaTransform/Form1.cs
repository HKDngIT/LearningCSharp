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
                if(!char.IsDigit(c) && c != '.' && c != '-')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxR2Delta.Text)
            {
                if (!char.IsDigit(c) && c != '.' && c != '-')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxR3Delta.Text)
            {
                if (!char.IsDigit(c) && c != '.' && c != '-')
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
         * checks if any resistor values are zero or negative
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

        // Button handling
        /*####################################################################################################*/
        
        /*
         * button press handling which calculates the new values of the resistor in star form
         */
        private void buttonToStar_Click(object sender, EventArgs e)
        {
            if(checkDeltaHasNonNumbers())
            {
                MessageBox.Show("TEXT BOXES CONTAIN NON-NUMBERS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(checkDeltaHasNullOrEmpty())
            {
                MessageBox.Show("RESISTOR VALUES CANNOT BE EMPTY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(checkDeltaHasNullResistor())
            {
                MessageBox.Show("RESISTOR VALUES CANNOT BE ZERO OR NEGATIVE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * button press handling which calculates the new values of the resistor in delta form
         */
        private void buttonToDelta_Click(object sender, EventArgs e)
        {

        }
    }
}