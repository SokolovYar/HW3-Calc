using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string buttonContent = (sender as Button).Content.ToString();

            switch (buttonContent) 
            {
                case "CE":
                    CalcStr.Text = "";
                    Rezult.Text = "";
                    break;

                case "C":
                    Rezult.Text = "";
                    break;

                case "<":
                    if (CalcStr.Text.Length > 1) CalcStr.Text = CalcStr.Text.Remove(CalcStr.Text.Length - 1);
                    else CalcStr.Text = "";
                    break;

                case "=":
                    try
                    {
                        Rezult.Text = new DataTable().Compute(CalcStr.Text, "").ToString();
                    }
                    catch { Rezult.Text = "ERROR"; }   
                    break;

                default:
                    CalcStr.Text += buttonContent;
                    break;
            }
        }
    }
}
