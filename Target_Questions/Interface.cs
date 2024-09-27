using Target_Questions.Providers;

namespace Target_Questions
{
	public partial class Interface : Form
	{
		public Interface()
		{
			InitializeComponent();
		}

		private void Interface_Load(object sender, EventArgs e)
		{

		}

		private void Button_Fibonacci_Click(object sender, EventArgs e)
		{
			int numberFibonacci = Convert.ToInt32(TextBox_Fibonacci.Text);
			string message = numberFibonacci.IsFibonacciNumber();
			Return_Fibonacci.Text = message;

		}

		private void Button_StringHasA_Click(object sender, EventArgs e)
		{
			string phrase = TextBox_StringHasA.Text;
			string message = phrase.StringHasA();
			Return_StringHasA.Text = message;
		}
	}
}
