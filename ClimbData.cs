using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockHound
{

    public partial class ClimbData : Form
    {
        List<ClimbGlossary> climbGlossary;
        List<RockGlossary> rockGlossary;
        List<DifficultyGlossary> difficultyGlossary;
        ClimbRepository climbRepository;
        public ClimbData()
        {
            InitializeComponent();
            InitializeComboBox1();
            InitializeComboBox2();
            InitializeComboBox3();
        }

        private void InitializeComboBox3()
        {
            comboType.Items.AddRange(Enum.GetNames(typeof(ClimbType)));
        }

        private void Insert(string fileName, byte[] image)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ClimbingEntities.Properties.Settings.DataBaseConnectionString"].ConnectionString)) 
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into pictures(filename, image) values(@filename, @image)"))
                {
                    cmd.CommandType=CommandType.Text;
                    cmd.Parameters.AddWithValue("@filename", txtFileName.Text);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                       
                }
            }
        }

        public void LoadData()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ClimbingEntities"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                using (DataTable dt = new DataTable("Pictures"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select *from pictures", cn);
                    adapter.Fill(dt);
                    climbGridView1.DataSource = dt;
                }
            }

            }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }

        private void InitializeComboBox2()
        {
            comboRating.Items.AddRange(Enum.GetNames(typeof(Difficulty)));
        }

        private void InitializeComboBox1()
        {
            comboRockType.Items.AddRange(Enum.GetNames(typeof(RockType)));
        }

        private void Clear()
        {
            txtDate.Clear();
            txtId.Clear();
            txtLocation.Clear();
            txtName.Clear();
            comboRating.ResetText();
            comboRockType.ResetText();
            comboType.ResetText();
            txtFileName.Clear();

        }
        private void ClimbData_Load(object sender, EventArgs e)
        {

            climbGlossary = new List<ClimbGlossary>();
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Top Rope", ClimbTypeDefinition = "The climber is always below the point that the rope is fixed to the wall" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Lead", ClimbTypeDefinition = "Climbing with a rope and clipping in to fixed protection along the route. Bolts are drilled into the rock" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Bouldering", ClimbTypeDefinition = "Rock climbing without rope or harness. Typically with a crash pad and rock 13ft or below" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Sport", ClimbTypeDefinition = "Relies on permanent anchors fixed into the rock for climber protection. The rope is attached to the climber and anchors" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Multi Pitch", ClimbTypeDefinition = "Two or more climbers traversing multipe routes. Longer distances and each route is a pitch" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Trad", ClimbTypeDefinition = "Carrying and placing protection (chocks, cams, etc..) into rock rather than clipping into pre-established bolts" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Canyoneering", ClimbTypeDefinition = "Traveling through canyons through a mix of hiking, rappelling, climbing, caving, and reading the water" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Aid", ClimbTypeDefinition = "Climbing using equipment to make upward progress by pulling oneself up to devices attached to harness" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Free solo", ClimbTypeDefinition = "Climbing with no protection to catch a fall. Unlike bouldering, routes are well above 13ft" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "Deep water solo", ClimbTypeDefinition = "Combination of bouldering and free soloing which takes place above water deep enough to safely fall into" });
            climbGlossary.Add(new ClimbGlossary() { ClimbType = "", ClimbTypeDefinition = "" });

            difficultyGlossary = new List<DifficultyGlossary>();
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V0", DifficultyDefinition = "5.9 YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V1", DifficultyDefinition = "5.10+ YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V2", DifficultyDefinition = "5.11- YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V3", DifficultyDefinition = "5.11+ YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V4", DifficultyDefinition = "5.12- YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V5", DifficultyDefinition = "5.12 YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V6", DifficultyDefinition = "5.12+ YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V7", DifficultyDefinition = "5.13- YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V8", DifficultyDefinition = "5.13 YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V9", DifficultyDefinition = "5.13+ YDS" });
            difficultyGlossary.Add(new DifficultyGlossary() { Difficulty = "V10", DifficultyDefinition = "5.14- YDS" });

            rockGlossary = new List<RockGlossary>();
            rockGlossary.Add(new RockGlossary() {RockComposition = "Granite", RockTypeDefinition = "Coarse grain igneous rock. Most common type of climbing rock"});
            rockGlossary.Add(new RockGlossary() { RockComposition = "Sandstone", RockTypeDefinition = "Fine grained sedimentary rock. Careful climbing after a rainstorm" });
            rockGlossary.Add(new RockGlossary() { RockComposition = "Limestone", RockTypeDefinition = "Well cemented and durable with great cliffs. Best climbed in Europe" });
            rockGlossary.Add(new RockGlossary() { RockComposition = "Basalt", RockTypeDefinition = "Great cracks and corners for crack climbing. Weathered basalt is dangerous to climb on" });
            rockGlossary.Add(new RockGlossary() { RockComposition = "Shale", RockTypeDefinition = "Fine grained and made from compacted mud. Breaks easily; be careful" });
            rockGlossary.Add(new RockGlossary() { RockComposition = "", RockTypeDefinition = "" });
            rockGlossary.Add(new RockGlossary() { RockComposition = "", RockTypeDefinition = "" });
            rockGlossary.Add(new RockGlossary() { RockComposition = "", RockTypeDefinition = "" });

            climbRepository = new ClimbRepository();
            climbGridView1.DataSource = climbRepository.GetAllRecords();
            btnComplete.Visible = false;
            btnSelect.Visible = false;
            panel1.Visible = false;
            btnDeleteMenu.Visible = false;
            btnImport.Visible = false;
            txtFileName.Visible = false;
            lblFileName.Visible = false;
            btnUploadImage.Visible = false;
            pictureBox1.Visible = false;
            panelTerms.Visible = false;


        }

        // Clicking on this button will allow the user to open a new web browser to visit The Mountain Project and to search for new climbs
        // and to discover the grade/rating, location, etc... of previous climbs.
        private void btnMtnPrj_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mountainproject.com/route-guide");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnUpdateAdd.Visible = true;


            //When adding a new record, it's important to set the Id (primary key) appropriately
            txtId.Text = (climbRepository.GetMaxId()  +1).ToString();
            txtId.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            btnSelect.Visible = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            btnUpdateAdd.Visible = false;
            btnComplete.Visible = true;
            btnDeleteMenu.Visible = true;
            var Id = climbGridView1.CurrentRow.Cells[0].Value;
            var climbupdate = climbRepository.FindClimb((int)Id);

            txtId.Text = Id.ToString();
            txtName.Text = climbupdate.Name;
            txtDate.Text = climbupdate.Date;
            txtLocation.Text = climbupdate.Location;
            comboRockType.SelectedText = climbupdate.Rock_Type;
            comboRating.SelectedText = climbupdate.Difficulty;
            comboType.SelectedText = climbupdate.Climb_Type;
         }

        private void btnUpdateAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtDate.Text) && !string.IsNullOrEmpty(txtLocation.Text) && !string.IsNullOrEmpty(txtName.Text) &&
                     !string.IsNullOrEmpty(comboRockType.Text) && !string.IsNullOrEmpty(comboRating.Text) && !string.IsNullOrEmpty(comboType.Text))

            {
                var newClimb = new Climb();
                newClimb.Name = txtName.Text;
                newClimb.Id = Int32.Parse(txtId.Text);
                newClimb.Location = txtLocation.Text;
                newClimb.Date = txtDate.Text;
                newClimb.Rock_Type = comboRockType.SelectedItem.ToString();
                newClimb.Climb_Type = comboType.SelectedItem.ToString();
                newClimb.Difficulty = comboRating.SelectedItem.ToString();
                climbRepository.AddRecord(newClimb);
                climbGridView1.DataSource = climbRepository.GetAllRecords();

                var result = MessageBox.Show($"New climb has been Added.", "Would you like to add another climb?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Clear();
                }

                if (result == DialogResult.No)
                {
                    Clear();
                    panel1.Visible = false;
                }


            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            panel1.Visible = false;
            btnSelect.Visible = false;
            btnComplete.Visible = false;
            btnDeleteMenu.Visible = false;
            btnImport.Visible = false;
            txtFileName.Visible = false;
            lblFileName.Visible = false;
            btnUploadImage.Visible = false;
            pictureBox1.Visible = false;
            climbGridView1.DataSource = null;
            climbGridView1.DataSource = climbRepository.GetAllRecords();
            panelTerms.Visible = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtDate.Text) && !string.IsNullOrEmpty(txtLocation.Text) && !string.IsNullOrEmpty(txtName.Text) &&
               !string.IsNullOrEmpty(comboRockType.Text) && !string.IsNullOrEmpty(comboRating.Text) && !string.IsNullOrEmpty(comboType.Text))

            {
                var newClimb = new Climb();
                newClimb.Name = txtName.Text;
                newClimb.Id = Int32.Parse(txtId.Text);
                newClimb.Location = txtLocation.Text;
                newClimb.Date = txtDate.Text;
                newClimb.Rock_Type = comboRockType.SelectedItem.ToString();
                newClimb.Climb_Type = comboType.SelectedItem.ToString();
                newClimb.Difficulty = comboRating.SelectedItem.ToString();
                climbRepository.UpdateRecord(newClimb.Id, newClimb);

                MessageBox.Show("Record has been updated");

                Clear();
                climbGridView1.DataSource = null;
                climbGridView1.DataSource = climbRepository.GetAllRecords();

            }

        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            var Id = climbGridView1.CurrentRow.Cells[0].Value;
            var climbtodelete = climbRepository.FindClimb((int)Id);

            var result = MessageBox.Show($"This climb will be permenatly deleted.", "Are you sure you wish to delete?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                climbRepository.DeleteRecord(climbtodelete);
                Clear();
                climbGridView1.DataSource = null;
                climbGridView1.DataSource = climbRepository.GetAllRecords();
                MessageBox.Show("Record has been deleted.");
            }

            if (result == DialogResult.No)
            {
                Clear();
                climbGridView1.DataSource = null;
                climbGridView1.DataSource = climbRepository.GetAllRecords();

            }

        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    txtFileName.Text = ofd.FileName;
                }
            }
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            Form1 weatherForecast = new Form1();
            weatherForecast.Show();
            this.Hide();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            Insert(txtFileName.Text, ConvertImageToBytes(pictureBox1.Image));
                LoadData();

            MessageBox.Show("Image Has Been Uploaded");

            Clear();
            climbGridView1.DataSource = null;
            climbGridView1.DataSource = climbRepository.GetAllRecords();

        }

        private void climbGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = climbGridView1.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = ConvertByteArrayToImage((byte[])row["Image"]);
            }
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            btnImport.Visible = true;
            txtFileName.Visible = true;
            lblFileName.Visible = true;
            btnUploadImage.Visible = true;
            pictureBox1.Visible = true;
        }

        private void btnTerms_Click(object sender, EventArgs e)
        {

        }

        private void btnClimbTypeGloss_Click(object sender, EventArgs e)
        { 
            panelTerms.Visible = true;
            dataGridDifficulty.Visible = false;
            dataGridType.Visible = true;
            dataGridRock.Visible = false;
            dataGridType.DataSource = climbGlossary;
           
        }

        private void btnDifficultyGloss_Click(object sender, EventArgs e)
        {
           panelTerms.Visible=true;
            dataGridType.Visible = false;
            dataGridDifficulty.Visible=true;
            dataGridRock.Visible = false;
            dataGridDifficulty.DataSource = difficultyGlossary;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homeScreen = new Home();
            homeScreen.Show();
            this.Hide();

        }

        private void btnRefreshTerms_Click(object sender, EventArgs e)
        {
            
            dataGridDifficulty.Visible=false;
            dataGridRock.Visible =false;
            dataGridType.Visible = false;
            dataGridType.Visible = false;
            panelTerms.Visible=false;
        }

        private void btnRockTypeGloss_Click(object sender, EventArgs e)
        {
            dataGridRock.Visible = true;
            dataGridRock.DataSource = rockGlossary;
            dataGridDifficulty.Visible = false;
            dataGridType.Visible = false;
            panelTerms.Visible = true;
        }
    }
}
