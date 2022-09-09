using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RockHound
{
    public partial class Form1 : Form
    {
        CountryList countryList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            gbWashington.Visible = false;
            gbUSA.Visible = false;
            gbGlobal.Visible = false;
            dataGridCountry.Visible = false;


        }
        private void btnLocal_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            gbWashington.Visible = true;
            gbUSA.Visible = false;
            gbGlobal.Visible = false;
        }

        private void btnGlobal_Click(object sender, EventArgs e)
        {

            gbWashington.Visible = false;
            gbUSA.Visible = false;
            gbGlobal.Visible = true;
            groupBox1.Visible = true;
        }

        private void btnNational_Click(object sender, EventArgs e)
        {

            gbWashington.Visible = false;
            gbUSA.Visible = true;
            groupBox1.Visible = true;
            gbGlobal.Visible = false;
        }



        string APIKey = "08453489e43c62e7602e816977e41f52";
        // This is where the program reaches out to the API to collect the data needed based on the button click. Clicking the button will call the data based on parameters in city search
        private void btnLocalSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())

            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text + "&appid=" + APIKey + "&units=imperial");
                var json = web.DownloadString(url);
                WeatherData.root Data = JsonConvert.DeserializeObject<WeatherData.root>(json);



                //Now it's necessary to populate the Form with the Json data that has been deserialized
                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Data.weather[0].icon + ".png";
                lblMain.Text = Data.weather[0].main;
                lblDetail.Text = Data.weather[0].description;
                lblTemp.Text = Data.main.temp.ToString();
                lblWind.Text = Data.wind.speed.ToString();
                lblSunrise.Text = convertDateTime(Data.sys.sunrise).ToShortTimeString();
                lblSunset.Text = convertDateTime(Data.sys.sunset).ToShortTimeString();

            }

        }



        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }


        private void btnSearchNational_Click(object sender, EventArgs e)
        {
            getWeather1(); //National Search 
        }

        //I need to add a catch block for erroneous input
        void getWeather1()
        {
            using (WebClient web = new WebClient())

            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + txtCityCN.Text + "," + txtStateCN.Text + "&appid=" + APIKey + "&units=imperial");
                var json = web.DownloadString(url);
                WeatherData.root Data = JsonConvert.DeserializeObject<WeatherData.root>(json);



                //Now it's necessary to populate the Form with the Json data that has been deserialized
                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Data.weather[0].icon + ".png";
                lblMain.Text = Data.weather[0].main;
                lblDetail.Text = Data.weather[0].description;
                lblTemp.Text = Data.main.temp.ToString();
                lblWind.Text = Data.wind.speed.ToString();
                lblSunrise.Text = convertDateTime(Data.sys.sunrise).ToShortTimeString();
                lblSunset.Text = convertDateTime(Data.sys.sunset).ToShortTimeString();


            }

            DateTime convertDateTime(long millisec)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddMilliseconds(millisec).ToLocalTime();

                return day;
            }




        }
        private void Clear()
        {
            txtCity.Clear();
            txtCountry.Clear();
            txtStateCN.Clear();
            txtState.Clear();
            txtCityCN.Clear();
            textBox1.Clear();


            groupBox1.Visible = false;
        }

        private void dataClear()
        {
            lblMain.Text = "Condition";
            lblDetail.Text = "Detail";
            lblSunrise.Text = null;
            lblSunset.Text = null;
            lblTemp.Text = null;
            lblWind.Text = null;
            pictureBox1.Image = null;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            dataClear();

            gbGlobal.Visible = false;
            gbUSA.Visible = false;
            gbWashington.Visible = false;
            dataGridCountry.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home homeScreen = new Home();
            homeScreen.Show();
            this.Hide();
        }

        private void btnGlobalSearch_Click(object sender, EventArgs e)
        {
         
                {
                    getWeather2(); //Global Search 
                }
                void getWeather2()
                {


                    using (WebClient web = new WebClient())

                    {

                        {
                            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + txtCity.Text + "," + txtState.Text + "," + txtCountry + "&appid=" + APIKey + "&units=imperial");
                            var json = web.DownloadString(url);
                            WeatherData.root Data = JsonConvert.DeserializeObject<WeatherData.root>(json);



                            //Now it's necessary to populate the Form with the Json data that has been deserialized
                            pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Data.weather[0].icon + ".png";
                            lblMain.Text = Data.weather[0].main;
                            lblDetail.Text = Data.weather[0].description;
                            lblTemp.Text = Data.main.temp.ToString();
                            lblWind.Text = Data.wind.speed.ToString();
                            lblSunrise.Text = convertDateTime(Data.sys.sunrise).ToShortTimeString();
                            lblSunset.Text = convertDateTime(Data.sys.sunset).ToShortTimeString();
                        }

                    }


                }
            }

                private void lblStateCountry_Click(object sender, EventArgs e)
        {

            dataGridCountry.Visible = true;
            countryList = new CountryList();
            dataGridCountry.DataSource = countryList.GetAllRecords();
        }
    }
    }
    
    
    
