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
        double[] m_vectorL = new double[3];

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
            foreach (char c in textBoxM1m1n1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
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

        /* MATRIX 1
         * writes the value of the textboxes of matrix 1 into the member variables of matrix 1
         */
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

        /* VECTOR 1
         * writes the value of the textboxes of vector 1 into the member variables of vector 1
         */
        private void processV1()
        {
            double.TryParse(textBoxV1m1.Text, out m_vector1[0]);
            double.TryParse(textBoxV1m2.Text, out m_vector1[1]);
            double.TryParse(textBoxV1m3.Text, out m_vector1[2]);
        }

        // CALCULATIONS
        /*#############################################################################################################################*/

        /* OPERATION 1
         * multiplies the matrix 1 with vector 1
         */
        private void calculateM1mulV1()
        {
            m_vectorL[0] = m_matrix1[0, 0] * m_vector1[0] + m_matrix1[0, 1] * m_vector1[1] + m_matrix1[0, 2] * m_vector1[2];
            m_vectorL[1] = m_matrix1[1, 0] * m_vector1[0] + m_matrix1[1, 1] * m_vector1[1] + m_matrix1[1, 2] * m_vector1[2];
            m_vectorL[2] = m_matrix1[2, 0] * m_vector1[0] + m_matrix1[2, 1] * m_vector1[1] + m_matrix1[2, 2] * m_vector1[2];
        }

        // OUTPUT
        /*#############################################################################################################################*/

        /* Vector L
         * writes the contents of vector 1 from the member variable to its textbox
         */
        private void outputVL()
        {
            textBoxVL1m1.Text = m_vectorL[0].ToString();
            textBoxVL1m2.Text = m_vectorL[1].ToString();
            textBoxVL1m3.Text = m_vectorL[2].ToString();
        }

        // BUTTON PRESS
        /*#############################################################################################################################*/

        /*
         * BUTTON PRESS handling to multiply matrix with the vector
         */
        private void buttonCalcMulV1_Click(object sender, EventArgs e)
        {
            bool validInputs = true;
            if (checkM1HasNullOrEmpty() || checkV1HasNullOrEmpty())
            {
                validInputs = false;
            }
            if (checkM1HasNonNumber() || checkV1HasNonNumber())
            {
                validInputs = false;
            }

            if (validInputs)
            {
                processM1();
                processV1();
                calculateM1mulV1();
                outputVL();
            }
        }

        private void buttonCalcMulM2_Click(object sender, EventArgs e)
        {

        }
    }
}
