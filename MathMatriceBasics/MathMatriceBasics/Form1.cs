namespace MathMatriceBasics
{
    public partial class Form1 : Form
    {
        // Initialize
        public Form1()
        {
            InitializeComponent();
        }

        // textBox input checks
        /*####################################################################################################*/

        /* MATRIX 1 CHECK
         * checks if the textboxes for matrix 1 are empty or not
         * returns true if there is at least one empty text box
         * returns false if there are no empty text boxes
         */
        private bool checkM1HasNullOrEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxM1m1n1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m1n2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m1n3.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m2n1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m2n2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m2n3.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m3n1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m3n2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM1m3n3.Text))
            {
                check = true;
            }

            if (check == true)
            {
                MessageBox.Show("MATRIX 1 CONTAINS EMPTY SPACES!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return check;
        }

        /* MATRIX 1 CHECK
         * checks if all values in the textboxes for M1 are valid or not
         * returns true if every input is valid
         * returns false if not
         */
        private bool checkM1HasNonNumber()
        {
            bool check = false;
            foreach(char c in textBoxM1m1n1.Text)
            {
                if(!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM1m1n2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM1m1n3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }


            foreach (char c in textBoxM1m2n1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM1m2n2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM1m2n3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }


            foreach (char c in textBoxM1m3n1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM1m3n2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM1m3n3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }

            if (check == true)
            {
                MessageBox.Show("MATRIX 1 CONTAINS NON-DIGITS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }


        // BUTTON PRESS
        /*####################################################################################################*/
        /*
         * BUTTON PRESS handling to multiply matrix with the vector
         */
        private void buttonCalcMulV1_Click(object sender, EventArgs e)
        {
            //checkM1HasNullOrEmpty();
            checkM1HasNonNumber();
        }
    }
}
