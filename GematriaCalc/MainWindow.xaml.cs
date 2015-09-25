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
        private List<string> logosList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            //InputLanguageManager.SetInputLanguage(logosBx, CultureInfo.CreateSpecificCulture("el-GR"));
        }
        static Window Window { get { return System.Windows.Application.Current.MainWindow; } }
        public int m_grSum = 0;
        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                    return lang;
            }
            return null;
        }

        public void SetKeyboardLayout(InputLanguage layout)
        {
            InputLanguage.CurrentInputLanguage = layout;
        }

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

        }

        private void bBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void gBtnclicked(object sender, RoutedEventArgs e)
        {

        }

        private void dBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void eBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void wauBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void zBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void hBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void thBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void iBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void kBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void lBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void mBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void nBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void xBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void oBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void pBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void rBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void sBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void tBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void uBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void fBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void chBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void psBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void omBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void clearBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void calcBtnClicked(object sender, RoutedEventArgs e)
        {
            int len = 0;
            while(len <= logosBx.Text.Length)
            {
                switch(logosBx.Text)
                {
                    case "":
                    case "a":
                        m_grSum += 1;
                }
            }
        }

        private void mainGridLostMouse(object sender, System.Windows.Input.MouseEventArgs e)
        {
            InputLanguageManager.SetInputLanguage(logosBx, CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void mainGridHasMouse(object sender, System.Windows.Input.MouseEventArgs e)
        {
            InputLanguageManager.SetInputLanguage(logosBx, CultureInfo.CreateSpecificCulture("el-GR"));
        }
    }
}
