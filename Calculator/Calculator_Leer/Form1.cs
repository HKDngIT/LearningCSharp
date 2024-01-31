using System.Globalization;

namespace Calculator_Leer
{
    public partial class buttonDeleteAll : Form
    {
        //Variables

        // contains the current results
        private double _result;

        // check if there's a number for the first input number
        private bool _isNewNumber;

        // check if there's a math sign for the first input number or sign
        private bool _isMathSign;

        // check if the last input number has been calculated yet or not
        private bool _wasLastInputNumber;

        // for enum class math signs
        private MathSigns _lastMathSign;


        //enums classes
        private enum MathSigns
        {
            Plus,
            Minus,
            Divide,
            Multiply
        }

        //initialize function
        public buttonDeleteAll()
        {
            InitializeComponent();
        }


        /********************************************************************/
        // Button number functions

        /* button specific action for button 1
         * 
         * checks first if the _isNewNumber is true or not
         * (if there's already a number added)
         * if true it modifies the textBoxResult(lower textbox) and writes a 1 into it
         * if false it just adds the number in the textboxResult(lower textbox)
         * 
         * after that the _isNewNumber set to false because there is already a new added number
         * the pointer _wasLastInputNumber is set to true
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {
                textBoxResult.Text = @"1";
            }
            else
            {
                textBoxResult.Text += 1;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }


        // BUTTON 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"2";
            }
            else
            {
                textBoxResult.Text += 2;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"4";
            }
            else
            {
                textBoxResult.Text += 4;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"3";
            }
            else
            {
                textBoxResult.Text += 3;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"5";
            }
            else
            {
                textBoxResult.Text += 5;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 6
        private void button6_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"6";
            }
            else
            {
                textBoxResult.Text += 6;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 7
        private void button7_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"7";
            }
            else
            {
                textBoxResult.Text += 7;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"8";
            }
            else
            {
                textBoxResult.Text += 8;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"9";
            }
            else
            {
                textBoxResult.Text += 9;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }

        // BUTTON 0
        private void button10_Click(object sender, EventArgs e)
        {
            if (_isNewNumber && !_isMathSign)
            {

                textBoxResult.Text = @"0";
            }
            else
            {
                textBoxResult.Text += 0;
            }
            _isNewNumber = false;
            _wasLastInputNumber = true;
        }


        /********************************************************************/
        // calculate button and its function

        /* calculate function
         * depending on what the mathsign is
         */
        private void Calculate(MathSigns mathSign, string mathSignString)
        {
            if (!_wasLastInputNumber) return;
            if (!string.IsNullOrEmpty(textBoxCalculate.Text))
            {
                var textBoxResultValue = textBoxResult.Text;
                double number;
                double.TryParse(textBoxResult.Text, out number);
                if (mathSign == MathSigns.Plus)
                {
                    _result = _result + number;
                    textBoxCalculate.Text += textBoxResultValue + mathSignString;
                }
                if (mathSign == MathSigns.Minus)
                {
                    _result = _result - number;
                    textBoxCalculate.Text += textBoxResultValue + mathSignString;
                }
                if (mathSign == MathSigns.Multiply)
                {
                    _result = _result * number;
                    textBoxCalculate.Text += textBoxResultValue + mathSignString;
                }
                if (mathSign == MathSigns.Divide)
                {
                    _result = _result / number;
                    textBoxCalculate.Text += textBoxResultValue + mathSignString;
                }

                textBoxResult.Text = _result.ToString(CultureInfo.InvariantCulture);

            }
            else
            {
                double.TryParse(textBoxResult.Text, out _result);
                textBoxCalculate.Text += textBoxResult.Text + mathSignString;
            }
        }

        // the equal button action uses the calculate function
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CalculateEqual(_lastMathSign);
        }

        /* calculate equal function
         * calculates everything in both textboxes, writes the result in the lower and deletes everything
         * in the upper
         */
        private void CalculateEqual(MathSigns mathSign)
        {
            if (!string.IsNullOrEmpty(textBoxCalculate.Text))
            {
                double number;
                double.TryParse(textBoxResult.Text, out number);
                if (mathSign == MathSigns.Plus)
                {
                    _result = _result + number;
                }
                if (mathSign == MathSigns.Minus)
                {
                    _result = _result - number;
                }
                if (mathSign == MathSigns.Divide)
                {
                    _result = _result / number;
                }
                if (mathSign == MathSigns.Multiply)
                {
                    _result = _result * number;
                }
            }
            else
            {
                double.TryParse(textBoxResult.Text, out _result);
            }
            textBoxCalculate.Text = string.Empty;
            textBoxResult.Text = _result.ToString(CultureInfo.InvariantCulture);
            _result = 0;
            _isNewNumber = true;
        }

        /********************************************************************/
        // simple arithmetic operations + buttons

        /* BUTTON PLUS
         * when the + button is clicked, it adds the numbers from the upper textbox to the lower and writes
         * it into the lower textbox but just ONCE! until a new number is added.
         */
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Calculate(_lastMathSign, " + ");
            _isNewNumber = true;
            _lastMathSign = MathSigns.Plus;
            _wasLastInputNumber = false;
        }

        /* BUTTON MINUS
         */
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!_wasLastInputNumber && !_isMathSign)
            {
                textBoxResult.Text = @"-";
                _isMathSign = true;
            }
            else
            {
                Calculate(_lastMathSign, " - ");
                _isNewNumber = true;
                _lastMathSign = MathSigns.Minus;
                _wasLastInputNumber = false;
            }
        }

        /* BUTTON MULTIPLY
         */
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Calculate(_lastMathSign, " * ");
            _isNewNumber = true;
            _lastMathSign = MathSigns.Multiply;
            _wasLastInputNumber = false;
        }

        /* BUTTON DIVIDE
         */
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Calculate(_lastMathSign, " / ");
            _isNewNumber = true;
            _lastMathSign = MathSigns.Divide;
            _wasLastInputNumber = false;
        }

        /********************************************************************/
        //DELETE FUNCTIONS

        /* BUTTON DELETE
         * deletes the result line
         */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = @"";
            _isMathSign = false;
        }

        /* BUTTON DELETE ALL
         * clears both text boxes
         */
        private void buttonDelA_Click(object sender, EventArgs e)
        {
            textBoxCalculate.Text = @"";
            textBoxResult.Text = @"";
            _isMathSign = false;
        }

        /* BUTTON DELETE ONE
         * deletes the last character/ number in the result/ input line
         */
        private void buttonDelOne_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxResult.Text))
            {
                string currentNumber = textBoxResult.Text;
                currentNumber = currentNumber.Remove(currentNumber.Length - 1, 1);
                textBoxResult.Text = currentNumber;
                if (string.IsNullOrEmpty(textBoxResult.Text))
                {
                    _isMathSign = false;
                }
            }
        }

        /********************************************************************/
        //special functions

        /* comma button function
         */
        private void buttonKomma_Click(object sender, EventArgs e)
        {
            if (!_isNewNumber)
            {
                textBoxResult.Text += ",";
            }
        }

        /* inverse button function
         */
        private void buttonInverse_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBoxResult.Text, out number);
            number = 1.0 / number;
            textBoxResult.Text = number.ToString(CultureInfo.InvariantCulture);
        }

        /* root button function
         */
        private void buttonRoot_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBoxResult.Text, out number);
            number = Math.Sqrt(number);
            textBoxResult.Text = number.ToString(CultureInfo.InvariantCulture);
        }

        /* square button function
         */
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBoxResult.Text, out number);
            number = number * number;
            textBoxResult.Text = number.ToString(CultureInfo.InvariantCulture);
        }

    }
}