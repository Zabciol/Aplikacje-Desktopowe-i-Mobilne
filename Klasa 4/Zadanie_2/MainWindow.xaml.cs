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

namespace Zadanie_2
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string HeightValue { get; set; }
        public string WeightValue { get; set; }

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
        private string bmi;
        public string BMI_Text
        {
            get { return bmi; }
            set
            {
                bmi = value;
                OnPropertyChanged(nameof(BMI_Text));
            }
        } private string responseColor;
        public string ResponseColor
        {
            get { return responseColor; }
            set
            {
                responseColor = value;
                OnPropertyChanged(nameof(ResponseColor));
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

        private float CalculateBMI(float height, float weight)
        {
            height = height / 100;
            float BMI = weight /( height * height);
            return BMI;
        }

        private string GetDescribeBMI(float BMI)
        {
            if (BMI < 16) {
                ResponseColor = "#FFD82020";
                return "wygłodzenie"; }
            if (BMI < 17) {
                ResponseColor = "#FFD85656";
                return "wychudzenie"; }
            if (BMI < 18.5) {
                ResponseColor = "#FFC17979";
                return "niedowaga"; }
            if (BMI < 25) {
                ResponseColor = "Black"; 
                return "waga prawidłowa"; }
            if (BMI < 30) {
                ResponseColor = "#FFC17979";
                return "nadwaga"; }
            if (BMI < 35) {
                ResponseColor = "#FFD85656"; 
                return "I stopień otyłości"; }
            if (BMI < 40) {
                ResponseColor = "#FFD82020"; 
                return "II stopień otyłości"; }
            if (BMI > 40) {
                ResponseColor = "#FFD82020"; 
                return "III stopień otyłości"; }

            return "brak opisu";
        }

        private void CreateResponse(float BMI)
        {
            BMI_Text = "BMI: " + BMI;
            Response = GetDescribeBMI(BMI);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float heightValue, weightValue;
            if(float.TryParse(HeightValue,out heightValue) && float.TryParse(WeightValue, out weightValue))
            {
            float BMI = CalculateBMI(heightValue, weightValue);
            CreateResponse(BMI);
            }
            else
            {
                ResponseColor = "Black";
                BMI_Text = "";
                Response = "Podaj prawidłowe dane";
            }


        }
    }
}
