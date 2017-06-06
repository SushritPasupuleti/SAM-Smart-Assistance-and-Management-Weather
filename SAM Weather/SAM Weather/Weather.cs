using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Net;
using SAM_Weather.Properties;

namespace SAM_Weather
{
    public partial class Weather : Form
    {
        string QEvent;
        string code;
        string ProcWindow;
        string Temperature;
        string Condition;
        string Humidity;
        string WindSpeed;
        string Town;
        string TFCond;
        string TFHigh;
        string TFLow;
        string sunr;
        string suns;
        string date;


        string Username = Environment.UserName;
        public Weather()
        {
            InitializeComponent();
            GetWeather();
            BackColor = Color.Pink;
            TransparencyKey = Color.Pink;
            WT.Text = code;
            HMDY.Text = Humidity + " %";
            Temp.Text = Temperature + "°F";
            CNDN.Text = Condition;
            WSP.Text = WindSpeed + " mile(s)/hour";
            TWN.Text = Town;
            sr.Text = sunr;
            Dt.Text = date;
            ss.Text = suns;
            if (WT.Text == "27" || WT.Text == "30" || WT.Text == "29")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/partly_cloudy.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "28")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/cloudy.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "26")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/cloudy.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "20" || WT.Text == "22" || WT.Text == "21" || WT.Text == "19" || WT.Text == "18")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/64/fog.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Foggy;
            }
            else if (WT.Text == "32" || WT.Text == "36")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/sunny.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Sunny;
            }
            else if (WT.Text == "12" || WT.Text == "11")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/rain.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Rainy;
            }
            else if (WT.Text == "44")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/sunny_s_cloudy.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "5" || WT.Text == "13" || WT.Text == "14" || WT.Text == "15" || WT.Text == "16" || WT.Text == "17")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/snow_s_rain.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Snow;
            }
            else if (WT.Text == "9" || WT.Text == "8")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/rain_s_cloudy.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "4" || WT.Text == "38" || WT.Text == "39")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/64/thunderstorms.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Thunder;

            }
            else if (WT.Text == "21" || WT.Text == "7" || WT.Text == "6" || WT.Text == "13" || WT.Text == "14" || WT.Text == "17")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/snow_s_rain.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Rainy;

            }
            else if (WT.Text == "31" || WT.Text == "32" || WT.Text == "33" || WT.Text == "34" || CNDN.Text == "Clear")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/sunny.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Clear;
                //BckScrn.Visible = false;
            }
            
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void GetWeather()
        {
            try
            {
                string query = String.Format("https://weather.yahooapis.com/forecastrss?w=" + Settings.Default.WOEID.ToString());
                XmlDocument wData = new XmlDocument();
                wData.Load(query);
                XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
                manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");
                XmlNode channel = wData.SelectSingleNode("rss").SelectSingleNode("channel");
                XmlNodeList nodes = wData.SelectNodes("/rss/channel/item/yweather:forecast", manager);
                Temperature = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;
                Condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;
                Humidity = channel.SelectSingleNode("yweather:atmosphere", manager).Attributes["humidity"].Value;
                WindSpeed = channel.SelectSingleNode("yweather:wind", manager).Attributes["speed"].Value;
                Town = channel.SelectSingleNode("yweather:location", manager).Attributes["city"].Value;
                TFCond = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["text"].Value;
                TFHigh = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
                TFLow = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;
                code = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["code"].Value;
                sunr = channel.SelectSingleNode("yweather:astronomy", manager).Attributes["sunrise"].Value;
                suns = channel.SelectSingleNode("yweather:astronomy", manager).Attributes["sunset"].Value;
                date = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["date"].Value;

                QEvent = "connected";
            }
            catch { QEvent = "failed"; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //WBTN.BackgroundImage = Image.FromFile(@"C:\Users\" + Username + "\\AppData\\Roaming\\SAM.2015.Media\\\\WeatherBack.png");
            //BckScrn.BackgroundImage = Image.FromFile(@"C:\Users\" + Username + "\\AppData\\Roaming\\SAM.2015.Media\\\\GreyScrn.png");
            WT.Text = code;
           // code = WT.Text;
            CNDN.Text = Condition;
            WSP.Text = WindSpeed + " mile(s)/hour";
            TWN.Text = Town;
            HMDY.Text = Humidity + " %";
            Temp.Text = Temperature + "°F";
            sr.Text = sunr;
            Dt.Text = date;
            ss.Text = suns;

            if (WT.Text == "27" || WT.Text == "30" || WT.Text == "29")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/partly_cloudy.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "28")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/cloudy.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "26")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/cloudy.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "20" || WT.Text == "22" || WT.Text == "21" || WT.Text == "19" || WT.Text == "18")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/64/fog.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Foggy;
            }
            else if (WT.Text == "32" || WT.Text == "36")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/sunny.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Sunny;
            }
            else if (WT.Text == "12" || WT.Text == "11")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/rain.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Rainy;
            }
            else if (WT.Text == "44")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/sunny_s_cloudy.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "5" || WT.Text == "13" || WT.Text == "14" || WT.Text == "15" || WT.Text == "16" || WT.Text == "17")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/snow_s_rain.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Snow;
            }
            else if (WT.Text == "9" || WT.Text == "8")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/rain_s_cloudy.png";

                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Cloudy;
            }
            else if (WT.Text == "4" || WT.Text == "38" || WT.Text == "39")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/64/thunderstorms.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Thunder;

            }
            else if (WT.Text == "21" || WT.Text == "7" || WT.Text == "6" || WT.Text == "13" || WT.Text == "14" || WT.Text == "17")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/snow_s_rain.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Rainy;

            }
            else if (WT.Text == "31" || WT.Text == "32" || WT.Text == "33" || WT.Text == "34" || CNDN.Text == "Clear")
            {
                WI.ImageLocation = "https://ssl.gstatic.com/onebox/weather/48/sunny.png";
                WeatherBox2.BackgroundImage = global::SAM_Weather.Properties.Resources.Clear;
                //BckScrn.Visible = false;
            }
            
        }

        private void WOEIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sr_Click(object sender, EventArgs e)
        {

        }

        private void Closethis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WT_TextChanged(object sender, EventArgs e)
        {

        }

        private void WI_Click(object sender, EventArgs e)
        {

        }

        private void WI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         //   WT.Visible = true;
        }

        private void Weather_Load(object sender, EventArgs e)
        {

        }
    }
}
