using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Bindowanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public string SourceValue { get; set; }
        public string DayOfTheWeek { get; set; }




        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if(SourceValue == "1")
            {
                DayOfTheWeek = "Poniedziałek";
                OnPropertyChanged(nameof(DayOfTheWeek));
            } if(SourceValue == "2")
            {
                DayOfTheWeek = "Wtorek";
                OnPropertyChanged(nameof(DayOfTheWeek));
            } if(SourceValue == "3")
            {
                DayOfTheWeek = "Środa";
                OnPropertyChanged(nameof(DayOfTheWeek));
            } if(SourceValue == "4")
            {
                DayOfTheWeek = "Czwartek";
                OnPropertyChanged(nameof(DayOfTheWeek));
            } if(SourceValue == "5")
            {
                DayOfTheWeek = "Piątek";
                OnPropertyChanged(nameof(DayOfTheWeek));
            } if(SourceValue == "6")
            {
                DayOfTheWeek = "Sobota";
                OnPropertyChanged(nameof(DayOfTheWeek));
            } if(SourceValue == "7")
            {
                DayOfTheWeek = "Niedziela";
                OnPropertyChanged(nameof(DayOfTheWeek));
            }
        }
    }
}
