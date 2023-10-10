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

namespace Zadanie_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,  INotifyPropertyChanged
    {
        public string NameValue { get; set; }
        public string SurnameValue { get; set; }
        public string AgeValue { get; set; }


        private string response;
        public string Response
        {
            get { return response; }
            set
            {
                response = value;
                OnPropertyChanged(nameof(Response));
            }
        }
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
            float wynik;
            if(float.TryParse(AgeValue, out wynik) && NameValue.Trim() != "" && SurnameValue.Trim() !="")
            {
                if(wynik >= 18)
                {
                    Response = "Witaj " +NameValue +" "+SurnameValue +" jesteś pełnoletni";
                }
                else { Response = "Witaj " + NameValue + " " + SurnameValue + " jesteś kiddem"; }
            }
            else
            {
                Response = "Podaj poprawne dane";
                if (NameValue == null) Response = Response + ", nie znam twojego imienia";
                if (SurnameValue == null) Response = Response + ", nie znam twojego nazwiska";

                Response = Response + " :(";
            }
        }
    }
}
