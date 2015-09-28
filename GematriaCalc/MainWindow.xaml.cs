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
        List<string> logosList = new List<string>();
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
        // alpha
        private void aBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "a";
        }
        // beta
        private void bBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "b";
        }
        // gamma
        private void gBtnclicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "g";
        }
        // delta
        private void dBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "d";
        }
        // epsilon
        private void eBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "e";
        }
        // digamma
        private void wauBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "#";
        }
        // zeta
        private void zBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "z";
        }
        // eta
        private void hBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "h";
        }
        // theta
        private void thBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "q";
        }
        // iota
        private void iBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "i";
        }
        // kappa
        private void kBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "k";
        }
        // lambda
        private void lBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "l";
        }
        // mu
        private void mBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "m";
        }
        // nu
        private void nBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "n";
        }
        // xi
        private void xBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "x";
        }
        // omicron
        private void oBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "o";
        }
        // pi
        private void pBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "p";
        }
        // rho
        private void rBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "r";
        }
        // sigma
        private void sBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "s";
        }
        // tau
        private void tBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "t";
        }
        // upsilon
        private void uBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "u";
        }
        // phi
        private void fBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "f";
        }
        // chi
        private void chBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "c";
        }
        // psi
        private void psBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "y";
        }
        // omega
        private void omBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text += "w";
        }

        private void clearBtnClicked(object sender, RoutedEventArgs e)
        {
            logosBx.Text = "";
            logosList.Clear();
            sumLbn.Content = "";
        }

        private void calcBtnClicked(object sender, RoutedEventArgs e)
        {
            int len = 0;
            int Σ = 0;

            // Convert the string into an array and push it into logosList
            foreach(char c in logosBx.Text)
            {
                logosList.Add(c.ToString());
            }
            while (len < logosList.Count)
            {
                if(logosList[len].Contains("a"))
                {
                    Σ += 1;
                }
                if(logosList[len].Contains("b"))
                {
                    Σ += 2;
                }
                if(logosList[len].Contains("g"))
                {
                    Σ += 3;
                }
                if (logosList[len].Contains("d"))
                {
                    Σ += 4;
                }
                if (logosList[len].Contains("e"))
                {
                    Σ += 5;
                }
                if (logosList[len].Contains("#"))
                {
                    Σ += 6;
                }
                if (logosList[len].Contains("z"))
                {
                    Σ += 7;
                }
                if (logosList[len].Contains("h"))
                {
                    Σ += 8;
                }
                if (logosList[len].Contains("q"))
                {
                    Σ += 9;
                }
                if (logosList[len].Contains("i"))
                {
                    Σ += 10;
                }
                if (logosList[len].Contains("k"))
                {
                    Σ += 20;
                }
                if (logosList[len].Contains("l"))
                {
                    Σ += 30;
                }
                if (logosList[len].Contains("m"))
                {
                    Σ += 40;
                }
                if (logosList[len].Contains("n"))
                {
                    Σ += 50;
                }
                if (logosList[len].Contains("x"))
                {
                    Σ += 60;
                }
                if (logosList[len].Contains("o"))
                {
                    Σ += 70;
                }
                if (logosList[len].Contains("p"))
                {
                    Σ += 80;
                }
                if (logosList[len].Contains("r"))
                {
                    Σ += 100;
                }
                if (logosList[len].Contains("s"))
                {
                    Σ += 200;
                }
                if (logosList[len].Contains("t"))
                {
                    Σ += 300;
                }
                if (logosList[len].Contains("u"))
                {
                    Σ += 400;
                }
                if (logosList[len].Contains("f"))
                {
                    Σ += 500;
                }
                if (logosList[len].Contains("c"))
                {
                    Σ += 600;
                }
                if (logosList[len].Contains("y"))
                {
                    Σ += 700;
                }
                if (logosList[len].Contains("w"))
                {
                    Σ += 800;
                }
                len += 1;
            }
            sumLbn.Content = Σ.ToString();
            Σ = 0;
        }
    }
}
