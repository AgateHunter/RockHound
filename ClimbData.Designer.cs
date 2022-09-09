namespace RockHound
{
    partial class ClimbData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClimbData));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.climbGridView1 = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnMtnPrj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateAdd = new System.Windows.Forms.Button();
            this.comboRockType = new System.Windows.Forms.ComboBox();
            this.comboRating = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblRockType = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnForecast = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnImageAdd = new System.Windows.Forms.Button();
            this.btnClimbTypeGloss = new System.Windows.Forms.Button();
            this.btnDifficultyGloss = new System.Windows.Forms.Button();
            this.btnRockTypeGloss = new System.Windows.Forms.Button();
            this.panelTerms = new System.Windows.Forms.Panel();
            this.dataGridType = new System.Windows.Forms.DataGridView();
            this.dataGridDifficulty = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefreshTerms = new System.Windows.Forms.Button();
            this.dataGridRock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.climbGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTerms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(158, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Climb";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(33, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Existing Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMenu.Location = new System.Drawing.Point(33, 436);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(113, 42);
            this.btnDeleteMenu.TabIndex = 3;
            this.btnDeleteMenu.Text = "Delete Climb";
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Location = new System.Drawing.Point(33, 309);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 42);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select Record";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // climbGridView1
            // 
            this.climbGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.climbGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.climbGridView1.Location = new System.Drawing.Point(26, 34);
            this.climbGridView1.Name = "climbGridView1";
            this.climbGridView1.RowHeadersWidth = 62;
            this.climbGridView1.Size = new System.Drawing.Size(744, 198);
            this.climbGridView1.TabIndex = 5;
            this.climbGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.climbGridView1_CellClick);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.Location = new System.Drawing.Point(33, 371);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(113, 42);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Update";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Location = new System.Drawing.Point(525, 309);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(97, 42);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import Image";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnMtnPrj
            // 
            this.btnMtnPrj.BackColor = System.Drawing.Color.Transparent;
            this.btnMtnPrj.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMtnPrj.Location = new System.Drawing.Point(808, 34);
            this.btnMtnPrj.Name = "btnMtnPrj";
            this.btnMtnPrj.Size = new System.Drawing.Size(175, 54);
            this.btnMtnPrj.TabIndex = 9;
            this.btnMtnPrj.Text = "Find A New Climb";
            this.btnMtnPrj.UseVisualStyleBackColor = false;
            this.btnMtnPrj.Click += new System.EventHandler(this.btnMtnPrj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefreshTerms);
            this.panel1.Controls.Add(this.btnRockTypeGloss);
            this.panel1.Controls.Add(this.btnDifficultyGloss);
            this.panel1.Controls.Add(this.btnClimbTypeGloss);
            this.panel1.Controls.Add(this.btnUpdateAdd);
            this.panel1.Controls.Add(this.comboRockType);
            this.panel1.Controls.Add(this.comboRating);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblRockType);
            this.panel1.Controls.Add(this.lblDifficulty);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(158, 309);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 235);
            this.panel1.TabIndex = 10;
            // 
            // btnUpdateAdd
            // 
            this.btnUpdateAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateAdd.Location = new System.Drawing.Point(290, 156);
            this.btnUpdateAdd.Name = "btnUpdateAdd";
            this.btnUpdateAdd.Size = new System.Drawing.Size(69, 62);
            this.btnUpdateAdd.TabIndex = 11;
            this.btnUpdateAdd.Text = "Add to Database";
            this.btnUpdateAdd.UseVisualStyleBackColor = false;
            this.btnUpdateAdd.Click += new System.EventHandler(this.btnUpdateAdd_Click);
            // 
            // comboRockType
            // 
            this.comboRockType.FormattingEnabled = true;
            this.comboRockType.Location = new System.Drawing.Point(137, 197);
            this.comboRockType.Margin = new System.Windows.Forms.Padding(2);
            this.comboRockType.Name = "comboRockType";
            this.comboRockType.Size = new System.Drawing.Size(82, 21);
            this.comboRockType.TabIndex = 16;
            // 
            // comboRating
            // 
            this.comboRating.FormattingEnabled = true;
            this.comboRating.Location = new System.Drawing.Point(137, 165);
            this.comboRating.Margin = new System.Windows.Forms.Padding(2);
            this.comboRating.Name = "comboRating";
            this.comboRating.Size = new System.Drawing.Size(82, 21);
            this.comboRating.TabIndex = 15;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(137, 131);
            this.comboType.Margin = new System.Windows.Forms.Padding(2);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(82, 21);
            this.comboType.TabIndex = 14;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(137, 68);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(152, 20);
            this.txtLocation.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(137, 98);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(152, 20);
            this.txtDate.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 12);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 20);
            this.txtId.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(13, 70);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(76, 23);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location";
            // 
            // lblRockType
            // 
            this.lblRockType.AutoSize = true;
            this.lblRockType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRockType.ForeColor = System.Drawing.Color.White;
            this.lblRockType.Location = new System.Drawing.Point(13, 193);
            this.lblRockType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRockType.Name = "lblRockType";
            this.lblRockType.Size = new System.Drawing.Size(89, 23);
            this.lblRockType.TabIndex = 5;
            this.lblRockType.Text = "Rock Type";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblDifficulty.Location = new System.Drawing.Point(13, 161);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(86, 23);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Difficulty ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(13, 131);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(116, 23);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type of Climb";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(13, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Climb Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(13, 100);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(117, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date Climbed";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(13, 12);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Location = new System.Drawing.Point(397, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 42);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox1.Location = new System.Drawing.Point(627, 250);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadImage.Location = new System.Drawing.Point(525, 371);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(97, 42);
            this.btnUploadImage.TabIndex = 13;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnForecast
            // 
            this.btnForecast.BackColor = System.Drawing.Color.Transparent;
            this.btnForecast.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForecast.Location = new System.Drawing.Point(808, 94);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(175, 65);
            this.btnForecast.TabIndex = 14;
            this.btnForecast.Text = "Climbing Weather Forecast";
            this.btnForecast.UseVisualStyleBackColor = false;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblFileName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFileName.Location = new System.Drawing.Point(641, 524);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(90, 23);
            this.lblFileName.TabIndex = 16;
            this.lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(737, 524);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(340, 33);
            this.txtFileName.TabIndex = 17;
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnImageAdd.Location = new System.Drawing.Point(277, 250);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.Size = new System.Drawing.Size(113, 42);
            this.btnImageAdd.TabIndex = 18;
            this.btnImageAdd.Text = "Add New Image";
            this.btnImageAdd.UseVisualStyleBackColor = false;
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // btnClimbTypeGloss
            // 
            this.btnClimbTypeGloss.Location = new System.Drawing.Point(239, 132);
            this.btnClimbTypeGloss.Name = "btnClimbTypeGloss";
            this.btnClimbTypeGloss.Size = new System.Drawing.Size(30, 20);
            this.btnClimbTypeGloss.TabIndex = 17;
            this.btnClimbTypeGloss.Text = "?";
            this.btnClimbTypeGloss.UseVisualStyleBackColor = true;
            this.btnClimbTypeGloss.Click += new System.EventHandler(this.btnClimbTypeGloss_Click);
            // 
            // btnDifficultyGloss
            // 
            this.btnDifficultyGloss.Location = new System.Drawing.Point(239, 164);
            this.btnDifficultyGloss.Name = "btnDifficultyGloss";
            this.btnDifficultyGloss.Size = new System.Drawing.Size(30, 20);
            this.btnDifficultyGloss.TabIndex = 18;
            this.btnDifficultyGloss.Text = "?";
            this.btnDifficultyGloss.UseVisualStyleBackColor = true;
            this.btnDifficultyGloss.Click += new System.EventHandler(this.btnDifficultyGloss_Click);
            // 
            // btnRockTypeGloss
            // 
            this.btnRockTypeGloss.Location = new System.Drawing.Point(239, 196);
            this.btnRockTypeGloss.Name = "btnRockTypeGloss";
            this.btnRockTypeGloss.Size = new System.Drawing.Size(30, 20);
            this.btnRockTypeGloss.TabIndex = 19;
            this.btnRockTypeGloss.Text = "?";
            this.btnRockTypeGloss.UseVisualStyleBackColor = true;
            this.btnRockTypeGloss.Click += new System.EventHandler(this.btnRockTypeGloss_Click);
            // 
            // panelTerms
            // 
            this.panelTerms.BackColor = System.Drawing.Color.Transparent;
            this.panelTerms.Controls.Add(this.dataGridRock);
            this.panelTerms.Controls.Add(this.dataGridDifficulty);
            this.panelTerms.Controls.Add(this.dataGridType);
            this.panelTerms.Location = new System.Drawing.Point(525, 250);
            this.panelTerms.Name = "panelTerms";
            this.panelTerms.Size = new System.Drawing.Size(580, 307);
            this.panelTerms.TabIndex = 20;
            // 
            // dataGridType
            // 
            this.dataGridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridType.Location = new System.Drawing.Point(16, 16);
            this.dataGridType.Name = "dataGridType";
            this.dataGridType.Size = new System.Drawing.Size(318, 261);
            this.dataGridType.TabIndex = 0;
            // 
            // dataGridDifficulty
            // 
            this.dataGridDifficulty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDifficulty.Location = new System.Drawing.Point(31, 4);
            this.dataGridDifficulty.Name = "dataGridDifficulty";
            this.dataGridDifficulty.Size = new System.Drawing.Size(243, 300);
            this.dataGridDifficulty.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(808, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "Return Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefreshTerms
            // 
            this.btnRefreshTerms.Location = new System.Drawing.Point(290, 127);
            this.btnRefreshTerms.Name = "btnRefreshTerms";
            this.btnRefreshTerms.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTerms.TabIndex = 20;
            this.btnRefreshTerms.Text = "Refresh Terms";
            this.btnRefreshTerms.UseVisualStyleBackColor = true;
            this.btnRefreshTerms.Click += new System.EventHandler(this.btnRefreshTerms_Click);
            // 
            // dataGridRock
            // 
            this.dataGridRock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRock.Location = new System.Drawing.Point(16, 4);
            this.dataGridRock.Name = "dataGridRock";
            this.dataGridRock.Size = new System.Drawing.Size(274, 273);
            this.dataGridRock.TabIndex = 2;
            // 
            // ClimbData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelTerms);
            this.Controls.Add(this.btnImageAdd);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMtnPrj);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.climbGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDeleteMenu);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "ClimbData";
            this.Text = "Climb Data Tracker";
            this.Load += new System.EventHandler(this.ClimbData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.climbGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTerms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView climbGridView1;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnMtnPrj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboRating;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblRockType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboRockType;
        private System.Windows.Forms.Button btnUpdateAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnImageAdd;
        private System.Windows.Forms.Button btnRockTypeGloss;
        private System.Windows.Forms.Button btnDifficultyGloss;
        private System.Windows.Forms.Button btnClimbTypeGloss;
        private System.Windows.Forms.Panel panelTerms;
        private System.Windows.Forms.DataGridView dataGridType;
        private System.Windows.Forms.DataGridView dataGridDifficulty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefreshTerms;
        private System.Windows.Forms.DataGridView dataGridRock;
    }
}