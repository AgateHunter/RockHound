namespace RockHound
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnLocalSearch = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.gbWashington = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCitylocal = new System.Windows.Forms.Label();
            this.btnGlobalSearch = new System.Windows.Forms.Button();
            this.gbUSA = new System.Windows.Forms.GroupBox();
            this.txtStateCN = new System.Windows.Forms.TextBox();
            this.txtCityCN = new System.Windows.Forms.TextBox();
            this.lblStateCountry = new System.Windows.Forms.Label();
            this.lblCityNation = new System.Windows.Forms.Label();
            this.btnSearchNational = new System.Windows.Forms.Button();
            this.gbGlobal = new System.Windows.Forms.GroupBox();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnNational = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCountry = new System.Windows.Forms.DataGridView();
            this.gbWashington.SuspendLayout();
            this.gbUSA.SuspendLayout();
            this.gbGlobal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(206, 28);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(48, 24);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(6, 19);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 33);
            this.txtCity.TabIndex = 1;
            // 
            // btnLocalSearch
            // 
            this.btnLocalSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalSearch.Location = new System.Drawing.Point(86, 75);
            this.btnLocalSearch.Name = "btnLocalSearch";
            this.btnLocalSearch.Size = new System.Drawing.Size(75, 23);
            this.btnLocalSearch.TabIndex = 2;
            this.btnLocalSearch.Text = "Search";
            this.btnLocalSearch.UseVisualStyleBackColor = false;
            this.btnLocalSearch.Click += new System.EventHandler(this.btnLocalSearch_Click);
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(6, 58);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(155, 33);
            this.txtState.TabIndex = 3;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(6, 97);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(155, 33);
            this.txtCountry.TabIndex = 4;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(192, 61);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 24);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountry.Location = new System.Drawing.Point(167, 97);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(91, 24);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // gbWashington
            // 
            this.gbWashington.BackColor = System.Drawing.Color.CadetBlue;
            this.gbWashington.Controls.Add(this.textBox1);
            this.gbWashington.Controls.Add(this.lblCitylocal);
            this.gbWashington.Controls.Add(this.btnLocalSearch);
            this.gbWashington.Location = new System.Drawing.Point(11, 179);
            this.gbWashington.Name = "gbWashington";
            this.gbWashington.Size = new System.Drawing.Size(258, 116);
            this.gbWashington.TabIndex = 0;
            this.gbWashington.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 33);
            this.textBox1.TabIndex = 2;
            // 
            // lblCitylocal
            // 
            this.lblCitylocal.AutoSize = true;
            this.lblCitylocal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitylocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCitylocal.Location = new System.Drawing.Point(167, 36);
            this.lblCitylocal.Name = "lblCitylocal";
            this.lblCitylocal.Size = new System.Drawing.Size(77, 39);
            this.lblCitylocal.TabIndex = 1;
            this.lblCitylocal.Text = "City";
            // 
            // btnGlobalSearch
            // 
            this.btnGlobalSearch.Location = new System.Drawing.Point(86, 148);
            this.btnGlobalSearch.Name = "btnGlobalSearch";
            this.btnGlobalSearch.Size = new System.Drawing.Size(75, 23);
            this.btnGlobalSearch.TabIndex = 0;
            this.btnGlobalSearch.Text = "Search";
            this.btnGlobalSearch.UseVisualStyleBackColor = true;
            this.btnGlobalSearch.Click += new System.EventHandler(this.btnGlobalSearch_Click);
            // 
            // gbUSA
            // 
            this.gbUSA.BackColor = System.Drawing.Color.CadetBlue;
            this.gbUSA.Controls.Add(this.txtStateCN);
            this.gbUSA.Controls.Add(this.txtCityCN);
            this.gbUSA.Controls.Add(this.lblStateCountry);
            this.gbUSA.Controls.Add(this.lblCityNation);
            this.gbUSA.Controls.Add(this.btnSearchNational);
            this.gbUSA.Location = new System.Drawing.Point(10, 281);
            this.gbUSA.Name = "gbUSA";
            this.gbUSA.Size = new System.Drawing.Size(260, 145);
            this.gbUSA.TabIndex = 1;
            this.gbUSA.TabStop = false;
            // 
            // txtStateCN
            // 
            this.txtStateCN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateCN.Location = new System.Drawing.Point(6, 68);
            this.txtStateCN.Name = "txtStateCN";
            this.txtStateCN.Size = new System.Drawing.Size(101, 33);
            this.txtStateCN.TabIndex = 4;
            // 
            // txtCityCN
            // 
            this.txtCityCN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCityCN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityCN.Location = new System.Drawing.Point(6, 26);
            this.txtCityCN.Name = "txtCityCN";
            this.txtCityCN.Size = new System.Drawing.Size(101, 33);
            this.txtCityCN.TabIndex = 3;
            // 
            // lblStateCountry
            // 
            this.lblStateCountry.AutoSize = true;
            this.lblStateCountry.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStateCountry.Location = new System.Drawing.Point(114, 62);
            this.lblStateCountry.Name = "lblStateCountry";
            this.lblStateCountry.Size = new System.Drawing.Size(140, 39);
            this.lblStateCountry.TabIndex = 2;
            this.lblStateCountry.Text = "Country";
            this.lblStateCountry.Click += new System.EventHandler(this.lblStateCountry_Click);
            // 
            // lblCityNation
            // 
            this.lblCityNation.AutoSize = true;
            this.lblCityNation.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityNation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCityNation.Location = new System.Drawing.Point(125, 26);
            this.lblCityNation.Name = "lblCityNation";
            this.lblCityNation.Size = new System.Drawing.Size(61, 39);
            this.lblCityNation.TabIndex = 1;
            this.lblCityNation.Text = "Zip";
            // 
            // btnSearchNational
            // 
            this.btnSearchNational.Location = new System.Drawing.Point(100, 111);
            this.btnSearchNational.Name = "btnSearchNational";
            this.btnSearchNational.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNational.TabIndex = 0;
            this.btnSearchNational.Text = "Search";
            this.btnSearchNational.UseVisualStyleBackColor = true;
            this.btnSearchNational.Click += new System.EventHandler(this.btnSearchNational_Click);
            // 
            // gbGlobal
            // 
            this.gbGlobal.BackColor = System.Drawing.Color.CadetBlue;
            this.gbGlobal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbGlobal.Controls.Add(this.txtCity);
            this.gbGlobal.Controls.Add(this.lblCountry);
            this.gbGlobal.Controls.Add(this.btnGlobalSearch);
            this.gbGlobal.Controls.Add(this.lblCity);
            this.gbGlobal.Controls.Add(this.lblState);
            this.gbGlobal.Controls.Add(this.txtCountry);
            this.gbGlobal.Controls.Add(this.txtState);
            this.gbGlobal.Location = new System.Drawing.Point(10, 418);
            this.gbGlobal.Name = "gbGlobal";
            this.gbGlobal.Size = new System.Drawing.Size(260, 177);
            this.gbGlobal.TabIndex = 1;
            this.gbGlobal.TabStop = false;
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLocal.Location = new System.Drawing.Point(12, 127);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Local Search";
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnNational
            // 
            this.btnNational.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNational.Location = new System.Drawing.Point(98, 127);
            this.btnNational.Name = "btnNational";
            this.btnNational.Size = new System.Drawing.Size(75, 23);
            this.btnNational.TabIndex = 3;
            this.btnNational.Text = "National Search";
            this.btnNational.UseVisualStyleBackColor = false;
            this.btnNational.Click += new System.EventHandler(this.btnNational_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGlobal.Location = new System.Drawing.Point(191, 127);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(75, 23);
            this.btnGlobal.TabIndex = 4;
            this.btnGlobal.Text = "Global Search";
            this.btnGlobal.UseVisualStyleBackColor = false;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblWind);
            this.groupBox1.Controls.Add(this.lblTemp);
            this.groupBox1.Controls.Add(this.lblSunrise);
            this.groupBox1.Controls.Add(this.lblSunset);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDetail);
            this.groupBox1.Controls.Add(this.lblMain);
            this.groupBox1.Location = new System.Drawing.Point(278, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(163, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 109);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.Color.White;
            this.lblWind.Location = new System.Drawing.Point(526, 94);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(66, 33);
            this.lblWind.TabIndex = 9;
            this.lblWind.Text = "N/A";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(526, 39);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(66, 33);
            this.lblTemp.TabIndex = 8;
            this.lblTemp.Text = "N/A";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.ForeColor = System.Drawing.Color.White;
            this.lblSunrise.Location = new System.Drawing.Point(526, 146);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(66, 33);
            this.lblSunrise.TabIndex = 7;
            this.lblSunrise.Text = "N/A";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.ForeColor = System.Drawing.Color.White;
            this.lblSunset.Location = new System.Drawing.Point(526, 191);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(66, 33);
            this.lblSunset.TabIndex = 6;
            this.lblSunset.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(319, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sunset (PST)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(319, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sunrise (PST)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wind Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.Color.White;
            this.lblDetail.Location = new System.Drawing.Point(17, 76);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(93, 33);
            this.lblDetail.TabIndex = 1;
            this.lblDetail.Text = "Detail";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(17, 39);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(146, 33);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Condition";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Location = new System.Drawing.Point(83, 159);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(976, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 51);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 637);
            this.panel1.TabIndex = 8;
            // 
            // dataGridCountry
            // 
            this.dataGridCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCountry.Location = new System.Drawing.Point(301, 294);
            this.dataGridCountry.Name = "dataGridCountry";
            this.dataGridCountry.Size = new System.Drawing.Size(211, 327);
            this.dataGridCountry.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 633);
            this.Controls.Add(this.dataGridCountry);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnNational);
            this.Controls.Add(this.gbGlobal);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.gbUSA);
            this.Controls.Add(this.gbWashington);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbWashington.ResumeLayout(false);
            this.gbWashington.PerformLayout();
            this.gbUSA.ResumeLayout(false);
            this.gbUSA.PerformLayout();
            this.gbGlobal.ResumeLayout(false);
            this.gbGlobal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnLocalSearch;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox gbGlobal;
        private System.Windows.Forms.GroupBox gbUSA;
        private System.Windows.Forms.GroupBox gbWashington;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnNational;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCitylocal;
        private System.Windows.Forms.Button btnGlobalSearch;
        private System.Windows.Forms.TextBox txtStateCN;
        private System.Windows.Forms.TextBox txtCityCN;
        private System.Windows.Forms.Label lblStateCountry;
        private System.Windows.Forms.Label lblCityNation;
        private System.Windows.Forms.Button btnSearchNational;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCountry;
    }
}

