using System.Windows;
using FragrantWorld.Pages;

namespace FragrantWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.CurrentFrame = DefaultFrame;
            DefaultFrame.Navigate(new AuthPage());
        }
    }
}