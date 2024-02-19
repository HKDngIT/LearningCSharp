namespace MathMatriceBasics
{
    public partial class Form1 : Form
    {
        // Initialize
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        /*#############################################################################################################################*/
        double[,] m_matrix1 = new double[3, 3];
        double[] m_vector1 = new double[3];

        // TEXTBOX INPUT CHECKS
        /*#############################################################################################################################*/

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
         * checks if matrix 1 contains any non numbers
         * returns true if there is a non number
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

        /* VECTOR 1 CHECK
         * checks if the textboxes for vector 1 are empty or not
         * returns true if there is at least one empty text box
         * returns false if there are no empty text boxes
         */
        private bool checkV1HasNullOrEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxV1m1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxV1m2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxV1m3.Text))
            {
                check = true;
            }

            if (check == true)
            {
                MessageBox.Show("VECTOR 1 CONTAINS EMPTY SPACES!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* MATRIX 1 CHECK
         * checks if vector 1 contains any non numbers
         * returns true if there is a non number
         * returns false if not
         */
        private bool checkV1HasNonNumber()
        {
            bool check = false;
            foreach (char c in textBoxV1m1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxV1m2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxV1m3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }

            if (check == true)
            {
                MessageBox.Show("VECTOR 1 CONTAINS NON-DIGITS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        // PROCESS INPUT FROM TEXT BOXES
        /*#############################################################################################################################*/

        private void processM1()
        {
            double.TryParse(textBoxM1m1n1.Text, out m_matrix1[0, 0]);
            double.TryParse(textBoxM1m1n2.Text, out m_matrix1[0, 1]);
            double.TryParse(textBoxM1m1n3.Text, out m_matrix1[0, 2]);

            double.TryParse(textBoxM1m2n1.Text, out m_matrix1[1, 0]);
            double.TryParse(textBoxM1m2n2.Text, out m_matrix1[1, 1]);
            double.TryParse(textBoxM1m2n3.Text, out m_matrix1[1, 2]);

            double.TryParse(textBoxM1m3n1.Text, out m_matrix1[2, 0]);
            double.TryParse(textBoxM1m3n2.Text, out m_matrix1[2, 1]);
            double.TryParse(textBoxM1m3n3.Text, out m_matrix1[2, 2]);
        }

        // BUTTON PRESS
        /*#############################################################################################################################*/

        /*
         * BUTTON PRESS handling to multiply matrix with the vector
         */
        private void buttonCalcMulV1_Click(object sender, EventArgs e)
        {
            bool validInputs = true;
            if(checkM1HasNullOrEmpty() || checkV1HasNullOrEmpty())
            {
                validInputs = false;
            }
            if (checkM1HasNonNumber() || checkV1HasNonNumber())
            {
                validInputs = false;
            }

            if(validInputs)
            {
                processM1();
                textBoxVL1m1.Text = m_matrix1[0, 0].ToString();
                textBoxVL1m2.Text = m_matrix1[1, 0].ToString();
                textBoxVL1m3.Text = m_matrix1[2, 0].ToString();
            }
        }
    }
}
