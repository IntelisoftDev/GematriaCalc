using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
        static Window Window { get { return System.Windows.Application.Current.MainWindow; } }
        public int m_grSum = 0;

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

        private void XloseMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            xloseBtn.Background = Brushes.Gray;
        }

        private void XcloseMouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            xloseBtn.Background = Brushes.Black;
        }

        private void exitBtnClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void aBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "a";
        }

        private void bBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "b";
        }

        private void gBtnclicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "g";
        }

        private void dBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "d";
        }

        private void eBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "e";
        }

        private void wauBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "ϝ";
        }

        private void zBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "z";
        }

        private void hBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "h";
        }

        private void thBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "q";
        }

        private void iBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "i";
        }

        private void kBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "k";
        }

        private void lBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "l";
        }

        private void mBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "m";
        }

        private void nBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "n";
        }

        private void xBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "x";
        }

        private void oBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "o";
        }

        private void pBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "p";
        }

        private void rBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "r";
        }

        private void sBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "s";
        }

        private void tBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "t";
        }

        private void uBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "u";
        }

        private void fBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "f";
        }

        private void chBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "c";
        }

        private void psBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "y";
        }

        private void omBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "w";
        }

        private void clearBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text = "";
        }

        private void calcBtnClicked(object sender, RoutedEventArgs e)
        {
            int len = 0;
            int Σ = 0;
            while (len <= logosBx.Text.Length)
            {
                if(logosBx.Text == "a")
                {
                    Σ += 1;
                }
                len += 1;
            }
            sumLbn.Content = Σ.ToString();
        }
    }
}
