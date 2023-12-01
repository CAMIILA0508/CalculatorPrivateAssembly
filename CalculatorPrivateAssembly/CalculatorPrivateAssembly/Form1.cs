namespace CalculatorPrivateAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Operators = new string[]
        {
            "+" , "-" , "*" , "/"
        };
            for (int i = 0; i < 4; i++)
            {
                cbOperator.Items.Add(Operators[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            string solve = cbOperator.Text;

            if (solve == "+")
            {
                txtResult.Text = CalculatorPrivateAssembly.BasicComputation.Addition(num1 , num2).ToString();
            }
            else if (solve == "-") 
            {
                txtResult.Text = CalculatorPrivateAssembly.BasicComputation.Subtraction(num1, num2).ToString();
            }
            else if (solve == "*") 
            {
                txtResult.Text = CalculatorPrivateAssembly.BasicComputation.Multiplication(num1, num2).ToString();
            }
            else if (solve == "/") 
            {
                txtResult.Text = CalculatorPrivateAssembly.BasicComputation.Division(num1, num2).ToString();
            }

        }
    }