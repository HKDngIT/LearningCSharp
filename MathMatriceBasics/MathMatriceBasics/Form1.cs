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
        double[,] m_matrix2 = new double[3, 3];
        double[,] m_matrixL = new double[3, 3];

        double[] m_vector1 = new double[3];
        double[] m_vectorL = new double[3];

        // TEXTBOX INPUT CHECKS
        /*#############################################################################################################################*/



        /* MATRIX 1 CHECK (1/2)
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

        /* MATRIX 2 CHECK (1/2)
         * checks if the textboxes for matrix 2 are empty or not
         * returns true if there is at least one empty text box
         * returns false if there are no empty text boxes
         */
        private bool checkM2HasNullOrEmpty()
        {
            bool check = false;
            if (string.IsNullOrEmpty(textBoxM2m1n1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM2m1n2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM2m1n3.Text))
            {
                check = true;
            }

            if (string.IsNullOrEmpty(textBoxM2m2n1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM2m2n2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM2m2n3.Text))
            {
                check = true;
            }

            if (string.IsNullOrEmpty(textBoxM2m3n1.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM2m3n2.Text))
            {
                check = true;
            }
            if (string.IsNullOrEmpty(textBoxM2m3n3.Text))
            {
                check = true;
            }

            if (check == true)
            {
                MessageBox.Show("MATRIX 2 CONTAINS EMPTY SPACES!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return check;
        }

        /* MATRIX 1 CHECK (2/2)
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

        /* MATRIX 2 CHECK (2/2)
         * checks if matrix 2 contains any non numbers
         * returns true if there is a non number
         * returns false if not
         */
        private bool checkM2HasNonNumber()
        {
            bool check = false;
            foreach (char c in textBoxM2m1n1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM2m1n2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM2m1n3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }

            foreach (char c in textBoxM2m2n1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM2m2n2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM2m2n3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }

            foreach (char c in textBoxM2m3n1.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM2m3n2.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }
            foreach (char c in textBoxM2m3n3.Text)
            {
                if (!char.IsDigit(c) && c != '-' && c != ',')
                {
                    check = true;
                }
            }

            if (check == true)
            {
                MessageBox.Show("MATRIX 2 CONTAINS NON-DIGITS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return check;
        }

        /* VECTOR 1 CHECK (1/2)
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

        /* VECTOR 1 CHECK (2/2)
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

        /* MATRIX 2
         * writes the value of the textboxes of matrix 2 into the member variable of matrix 2
         */
        private void processM2()
        {
            double.TryParse(textBoxM2m1n1.Text, out m_matrix2[0, 0]);
            double.TryParse(textBoxM2m1n2.Text, out m_matrix2[0, 1]);
            double.TryParse(textBoxM2m1n3.Text, out m_matrix2[0, 2]);

            double.TryParse(textBoxM2m2n1.Text, out m_matrix2[1, 0]);
            double.TryParse(textBoxM2m2n2.Text, out m_matrix2[1, 1]);
            double.TryParse(textBoxM2m2n3.Text, out m_matrix2[1, 2]);

            double.TryParse(textBoxM2m3n1.Text, out m_matrix2[2, 0]);
            double.TryParse(textBoxM2m3n2.Text, out m_matrix2[2, 1]);
            double.TryParse(textBoxM2m3n3.Text, out m_matrix2[2, 2]);
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

        /* OPERATION 2
         * multiplies the matrix 1 with matrix 2
         */
        private void calculateM1MulM2()
        {
            m_matrixL[0, 0] = m_matrix1[0, 0] * m_matrix2[0, 0] + m_matrix1[0, 1] * m_matrix2[1, 0] + m_matrix1[0, 2] * m_matrix2[2, 0];
            m_matrixL[1, 0] = m_matrix1[1, 0] * m_matrix2[0, 0] + m_matrix1[1, 1] * m_matrix2[1, 0] + m_matrix1[1, 2] * m_matrix2[2, 0];
            m_matrixL[2, 0] = m_matrix1[2, 0] * m_matrix2[0, 0] + m_matrix1[2, 1] * m_matrix2[1, 0] + m_matrix1[2, 2] * m_matrix2[2, 0];

            m_matrixL[0, 1] = m_matrix1[0, 0] * m_matrix2[0, 1] + m_matrix1[0, 1] * m_matrix2[1, 1] + m_matrix1[0, 2] * m_matrix2[2, 1];
            m_matrixL[1, 1] = m_matrix1[1, 0] * m_matrix2[0, 1] + m_matrix1[1, 1] * m_matrix2[1, 1] + m_matrix1[1, 2] * m_matrix2[2, 1];
            m_matrixL[2, 1] = m_matrix1[2, 0] * m_matrix2[0, 1] + m_matrix1[2, 1] * m_matrix2[1, 1] + m_matrix1[2, 2] * m_matrix2[2, 1];

            m_matrixL[0, 2] = m_matrix1[0, 0] * m_matrix2[0, 2] + m_matrix1[0, 1] * m_matrix2[1, 2] + m_matrix1[0, 2] * m_matrix2[2, 2];
            m_matrixL[1, 2] = m_matrix1[1, 0] * m_matrix2[0, 2] + m_matrix1[1, 1] * m_matrix2[1, 2] + m_matrix1[1, 2] * m_matrix2[2, 2];
            m_matrixL[2, 2] = m_matrix1[2, 0] * m_matrix2[0, 2] + m_matrix1[2, 1] * m_matrix2[1, 2] + m_matrix1[2, 2] * m_matrix2[2, 2];
        }

        // OUTPUT
        /*#############################################################################################################################*/

        /* Vector L
         * writes the contents of vector L from the member variable to its textboxes
         */
        private void outputVL()
        {
            textBoxVL1m1.Text = m_vectorL[0].ToString();
            textBoxVL1m2.Text = m_vectorL[1].ToString();
            textBoxVL1m3.Text = m_vectorL[2].ToString();
        }

        /* Matrix L
         * writes the contents of Matrix L from the member variable to its textboxes
         */
        private void outputML()
        {
            textBoxMLm1n1.Text = m_matrixL[0, 0].ToString();
            textBoxMLm1n2.Text = m_matrixL[0, 1].ToString();
            textBoxMLm1n3.Text = m_matrixL[0, 2].ToString();

            textBoxMLm2n1.Text = m_matrixL[1, 0].ToString();
            textBoxMLm2n2.Text = m_matrixL[1, 1].ToString();
            textBoxMLm2n3.Text = m_matrixL[1, 2].ToString();

            textBoxMLm3n1.Text = m_matrixL[2, 0].ToString();
            textBoxMLm3n2.Text = m_matrixL[2, 1].ToString();
            textBoxMLm3n3.Text = m_matrixL[2, 2].ToString();

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

        //MessageBox.Show("ALLGOOD!", "ALLGOOD", MessageBoxButtons.OK, MessageBoxIcon.Information);

        /*
         * BUTTON PRESS handling to multiply matrix with the other matrix
         */
        private void buttonMulM2_Click(object sender, EventArgs e)
        {
            bool validInputs = true;
            if (checkM1HasNullOrEmpty() || checkM2HasNullOrEmpty())
            {
                validInputs = false;
            }
            if (checkM1HasNonNumber() || checkM2HasNonNumber())
            {
                validInputs = false;
            }

            if(validInputs)
            {
                processM1();
                processM2();
                calculateM1MulM2();
                outputML();
            }
        }
    }
}
