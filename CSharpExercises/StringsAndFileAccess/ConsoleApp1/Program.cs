internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Variables
        int m_iNum1;
        int m_INum2;
        string m_input;
        int m_result = 0;
        
        bool running = true;

        while(running) {
            Console.Write("Term: ");
            m_input = Convert.ToString(Console.ReadLine());

            if(m_input == "quit") {
                running = false;
                Console.WriteLine("Quiting....");
            } else {

                string[] parts = m_input.Split(' ');
    
                m_iNum1 = int.Parse(parts[0]);
                char op = char.Parse(parts[1]);
                m_INum2 = int.Parse(parts[2]);
    
                switch(op) 
                {
                    case '+': 
                        m_result = m_iNum1 + m_INum2;
                        break;
    
                    case '-':
                        m_result = m_iNum1 - m_INum2;
                        break;
                    
                    case '*':
                        m_result = m_iNum1 * m_INum2;
                        break;
    
                    case '/':
                        m_result = m_iNum1 + m_INum2;
                        break;
                }
                Console.WriteLine($"{m_input} = {m_result}");
            }
        }
    }
}