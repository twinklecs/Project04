using System.Windows;

namespace Project04
{
    /// <summary>
    /// Логика взаимодействия для WinNewtonCotes.xaml
    /// </summary>
    public partial class WinNewtonCotes : Window
    {
        public WinNewtonCotes()
        {
            InitializeComponent();
        }

        private void S_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private double Steps(double a, double b, double n)
        {
            return (b - a) / n;
        }


    }
}
