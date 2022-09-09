using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockHound
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            Form1 weatherTracker = new Form1();
            weatherTracker.Show();
            this.Hide();
        }

        private void btnTracker_Click(object sender, EventArgs e)
        {
            ClimbData newScreen = new ClimbData();
            newScreen.Show();
            this.Hide();
              
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //This will be an enhancement to run an API of Air Quality directly within the app, similar to current weather

        private void btnAir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gispub.epa.gov/airnow/?showgreencontours=false");

        }
    }
}
