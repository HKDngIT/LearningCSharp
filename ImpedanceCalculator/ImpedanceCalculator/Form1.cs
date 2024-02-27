namespace ImpedanceCalculator
{
    public partial class Form1 : Form
    {
        // Member variables
        /*####################################################################################################*/

        private double m_real = 0.0;

        // Toggles
        private bool m_ResistorKiloisToggled = false;

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