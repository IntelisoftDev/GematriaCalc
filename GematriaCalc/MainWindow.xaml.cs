using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GematriaCalc
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
        static Window Window { get { return Application.Current.MainWindow; } }
        private void TitleBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    AdjustWindowSize();
                }
                else
                {
                    Window.DragMove();
                }
            }
        }

        internal static void AdjustWindowSize()
        {
            if (Window.WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(Window);
            }
            else
            {
                SystemCommands.MaximizeWindow(Window);
            }

        }

        private void XloseClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
