using Microsoft.VisualBasic;
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

namespace reg_resource
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
          if((txtname.Text==" ")&&(txtemail.Text==" ")&&(txtadd.Text==" "))
                {
                MessageBox.Show("REGISTERED SUCCESSFULLY","REGISTER" ,MessageBoxButton.OK, MessageBoxImage.Information);
                }
          else
            {
                MessageBox.Show("ERROR!!!!!ENTER ALL DETAILS","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
