using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GematriaCalc
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            byte[] licenseFile = GematriaCalc.Resource1.LICENSE;
            Stream stream = new MemoryStream(licenseFile);
            StreamReader reader = new StreamReader(stream);
            string lice = reader.ReadToEnd();
            LicenseBx.Text = lice;
        }

        private void CloseBtnClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
