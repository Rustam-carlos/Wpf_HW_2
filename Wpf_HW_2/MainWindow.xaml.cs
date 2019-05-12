using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Windows.Forms;
using System.Drawing.Imaging;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Wpf_HW_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, RoutedEventArgs e)
        {
            string answer = string.Empty;       
            WebClient client = new WebClient();            
            
            string sity = TextBox1.Text;
            if (TextBox1.Text == "")
                MessageBox.Show("Введите корректно название города");

            string url = "https://" + "api.openweathermap.org/data/2.5/forecast?q=" + sity + "&units=metric&appid=b62a9285d307539ed1e10c18635c238e&lang=ru&cnt=47";

            using (Stream stream = client.OpenRead(url))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    answer = reader.ReadToEnd();
                }
            }
            OpenWeather.OpenWeather openWeather = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);
            
            string icon1 = openWeather.list[0].weather[0].icon;           
            Image1.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/"+ icon1 +".png"));
            Label1.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label2.Content = openWeather.list[0].dt_txt;
            Label3.Content = openWeather.list[0].weather[0].description;
            Label4.Content = "Средняя  t утром        " + openWeather.list[0].main.temp.ToString("0.##") + "  С*";
            Label5.Content = "Средняя  t днем         " + openWeather.list[2].main.temp.ToString("0.##") + "  С*";
            Label6.Content = "Давление     -  " + openWeather.list[0].main.pressure;
            Label7.Content = "Влажность   -  " + openWeather.list[0].main.humidity + "  %";
            Label8.Content = "Облачность -  " + openWeather.list[0].clouds.all + "  %";
            Label9.Content = "Средняя  t вечером   " + openWeather.list[5].main.temp.ToString("0.##") + "  С*";
            Label10.Content = "Скорость ветра        -  " + openWeather.list[4].wind.speed;
            Label11.Content = "Направление ветра -  " + openWeather.list[4].wind.deg.ToString();

            string icon2 = openWeather.list[8].weather[0].icon;
            Image2.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + icon2 + ".png"));
            Label12.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label13.Content = openWeather.list[8].dt_txt;
            Label14.Content = openWeather.list[12].weather[0].description;
            Label15.Content = "Средняя  t утром        " + openWeather.list[5].main.temp.ToString("0.##") + "  С*";
            Label16.Content = "Средняя  t днем         " + openWeather.list[8].main.temp.ToString("0.##") + "  С*";
            Label17.Content = "Давление     -  " + openWeather.list[8].main.pressure;
            Label18.Content = "Влажность   -  " + openWeather.list[8].main.humidity + "  %";
            Label19.Content = "Облачность -  " + openWeather.list[8].clouds.all + "  %";
            Label20.Content = "Средняя  t вечером   " + openWeather.list[10].main.temp.ToString("0.##") + "  С*";
            Label21.Content = "Скорость ветра        -  " + openWeather.list[8].wind.speed;
            Label22.Content = "Направление ветра -  " + openWeather.list[8].wind.deg.ToString();

            string icon3 = openWeather.list[16].weather[0].icon;
            Image3.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + icon3 + ".png"));
            Label23.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label24.Content = openWeather.list[16].dt_txt;
            Label25.Content = openWeather.list[16].weather[0].description;
            Label26.Content = "Средняя  t утром        " + openWeather.list[14].main.temp.ToString("0.##") + "  С*";
            Label27.Content = "Средняя  t днем         " + openWeather.list[16].main.temp.ToString("0.##") + "  С*";
            Label28.Content = "Давление     -  " + openWeather.list[16].main.pressure;
            Label29.Content = "Влажность   -  " + openWeather.list[16].main.humidity + "  %";
            Label30.Content = "Облачность -  " + openWeather.list[16].clouds.all + "  %";
            Label31.Content = "Средняя  t вечером   " + openWeather.list[19].main.temp.ToString("0.##") + "  С*";
            Label32.Content = "Скорость ветра        -  " + openWeather.list[16].wind.speed;
            Label33.Content = "Направление ветра -  " + openWeather.list[16].wind.deg.ToString();

            string icon4 = openWeather.list[24].weather[0].icon;
            Image4.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + icon4 + ".png"));
            Label34.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label35.Content = openWeather.list[24].dt_txt;
            Label36.Content = openWeather.list[24].weather[0].description;
            Label37.Content = "Средняя  t утром        " + openWeather.list[22].main.temp.ToString("0.##") + "  С*";
            Label38.Content = "Средняя  t днем         " + openWeather.list[24].main.temp.ToString("0.##") + "  С*";
            Label39.Content = "Давление     -  " + openWeather.list[24].main.pressure;
            Label40.Content = "Влажность   -  " + openWeather.list[24].main.humidity + "  %";
            Label41.Content = "Облачность -  " + openWeather.list[24].clouds.all + "  %";
            Label42.Content = "Средняя  t вечером   " + openWeather.list[27].main.temp.ToString("0.##") + "  С*";
            Label43.Content = "Скорость ветра        -  " + openWeather.list[24].wind.speed;
            Label44.Content = "Направление ветра -  " + openWeather.list[24].wind.deg.ToString();

            string icon5 = openWeather.list[32].weather[0].icon;
            Image5.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + icon5 + ".png"));
            Label45.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label46.Content = openWeather.list[32].dt_txt;
            Label47.Content = openWeather.list[32].weather[0].description;
            Label48.Content = "Средняя  t утром        " + openWeather.list[30].main.temp.ToString("0.##") + "  С*";
            Label49.Content = "Средняя  t днем         " + openWeather.list[32].main.temp.ToString("0.##") + "  С*";
            Label50.Content = "Давление     -  " + openWeather.list[32].main.pressure;
            Label51.Content = "Влажность   -  " + openWeather.list[32].main.humidity + "  %";
            Label52.Content = "Облачность -  " + openWeather.list[32].clouds.all + "  %";
            Label53.Content = "Средняя  t вечером   " + openWeather.list[36].main.temp.ToString("0.##") + "  С*";
            Label54.Content = "Скорость ветра        -  " + openWeather.list[32].wind.speed;
            Label55.Content = "Направление ветра -  " + openWeather.list[32].wind.deg.ToString();

            string icon6 = openWeather.list[39].weather[0].icon;
            Image6.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + icon6 + ".png"));
            Label56.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label57.Content = openWeather.list[39].dt_txt;
            Label58.Content = openWeather.list[39].weather[0].description;
            Label59.Content = "Средняя  t утром        " + openWeather.list[36].main.temp.ToString("0.##") + "  С*";
            Label60.Content = "Средняя  t днем         " + openWeather.list[39].main.temp.ToString("0.##") + "  С*";
            Label61.Content = "Давление     -  " + openWeather.list[39].main.pressure;
            Label62.Content = "Влажность   -  " + openWeather.list[39].main.humidity + "  %";
            Label63.Content = "Облачность -  " + openWeather.list[39].clouds.all + "  %";
            Label64.Content = "Средняя  t вечером   " + openWeather.list[35].main.temp.ToString("0.##") + "  С*";
            Label65.Content = "Скорость ветра        -  " + openWeather.list[39].wind.speed;
            Label66.Content = "Направление ветра -  " + openWeather.list[39].wind.deg.ToString();

            string icon7 = openWeather.list[33].weather[0].icon;
            Image7.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + icon7 + ".png"));
            Label67.Content = openWeather.city.name + "    " + openWeather.city.country;
            Label68.Content = openWeather.list[39].dt_txt;
            Label69.Content = openWeather.list[33].weather[0].description;
            Label70.Content = "Средняя  t утром        " + openWeather.list[30].main.temp.ToString("0.##") + "  С*";
            Label71.Content = "Средняя  t днем         " + openWeather.list[33].main.temp.ToString("0.##") + "  С*";
            Label72.Content = "Давление     -  " + openWeather.list[33].main.pressure;
            Label73.Content = "Влажность   -  " + openWeather.list[33].main.humidity + "  %";
            Label74.Content = "Облачность -  " + openWeather.list[33].clouds.all + "  %";
            Label75.Content = "Средняя  t вечером   " + openWeather.list[36].main.temp.ToString("0.##") + "  С*";
            Label76.Content = "Скорость ветра        -  " + openWeather.list[33].wind.speed;
            Label77.Content = "Направление ветра -  " + openWeather.list[33].wind.deg.ToString();
        }
    }
}
