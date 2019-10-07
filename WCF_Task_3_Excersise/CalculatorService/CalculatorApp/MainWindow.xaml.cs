using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReference1.CalculatorServiceClient client = null;

        public MainWindow()
        {
            InitializeComponent();
            this.client = new ServiceReference1.CalculatorServiceClient("BasicHttpBinding_ICalculatorService");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n1 = System.Convert.ToInt16(this.txtBoxN1.Text);
            int n2 = System.Convert.ToInt16(this.txtBoxN2.Text);
            int result = 0;

            foreach (RadioButton childControl in this.ArithmeticOperationPanel.Children)
            {
                if (childControl.IsChecked.GetValueOrDefault())
                {
                    switch (childControl.Tag.ToString())
                    {
                        case "+":
                            result = this.client.AddTwoNumbers(n1, n2);
                            break;
                        case "-":
                            result = this.client.SubtractTwoNumbers(n1, n2);
                            break;
                        case "*":
                            result = this.client.MultiplyTwoNumbers(n1, n2);
                            break;
                        case "/":
                            result = this.client.DivideTwoNumbers(n1, n2);
                            break;
                    }
                }
                else
                    continue;
            }

            this.lblResult.Content = result;
        }
    }
}