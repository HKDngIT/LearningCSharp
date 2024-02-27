namespace ImpedanceCalculator
{
    public partial class Form1 : Form
    {
        // Member variables
        /*####################################################################################################*/

        private double m_real = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void update()
        {
            textBoxReImp.Text = m_real.ToString();
        }

        private void buttonResADDSerial_Click(object sender, EventArgs e)
        {
            double resistor;
            double.TryParse(textBoxResistor.Text, out resistor);
            m_real += resistor;
            update();
        }

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

        private void buttonRESET_Click(object sender, EventArgs e)
        {
            m_real = 0.0;
            update();
        }
    }
}