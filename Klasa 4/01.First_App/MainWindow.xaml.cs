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

namespace _01.First_App
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
            Wrap_Panel_Window wrap_Panel_Window = new Wrap_Panel_Window();
            wrap_Panel_Window.Show();   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Doc_Panel_Window doc_Panel_Window = new Doc_Panel_Window();
            doc_Panel_Window.Show();
        }
    }
}
