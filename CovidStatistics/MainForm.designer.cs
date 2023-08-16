using System.Windows.Forms;

namespace CovidStatistics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.citiesButton = new System.Windows.Forms.Button();
            this.personsButton = new System.Windows.Forms.Button();
            this.casesButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.casesPage = new System.Windows.Forms.TabPage();
            this.casesDataGrid = new System.Windows.Forms.DataGridView();
            this.caseMessageLabel = new System.Windows.Forms.Label();
            this.caseResetButton = new System.Windows.Forms.Button();
            this.hospitalized_label = new System.Windows.Forms.Label();
            this.severity_label = new System.Windows.Forms.Label();
            this.patient_state_label = new System.Windows.Forms.Label();
            this.covid_variant_label = new System.Windows.Forms.Label();
            this.infected_by_label = new System.Windows.Forms.Label();
            this.test_id_label = new System.Windows.Forms.Label();
            this.case_id_label = new System.Windows.Forms.Label();
            this.hospitalized_textBox = new System.Windows.Forms.TextBox();
            this.severity_textBox = new System.Windows.Forms.TextBox();
            this.patient_state_textBox = new System.Windows.Forms.TextBox();
            this.covid_variant_textBox = new System.Windows.Forms.TextBox();
            this.infected_by_textBox = new System.Windows.Forms.TextBox();
            this.test_id_textBox = new System.Windows.Forms.TextBox();
            this.case_id_textBox = new System.Windows.Forms.TextBox();
            this.casesByVariantButton = new System.Windows.Forms.Button();
            this.casesBySeverityButton = new System.Windows.Forms.Button();
            this.casesByPatientStateButton = new System.Windows.Forms.Button();
            this.deleteCaseButton = new System.Windows.Forms.Button();
            this.updateCaseButton = new System.Windows.Forms.Button();
            this.showAllActiveCasesButton = new System.Windows.Forms.Button();
            this.casesDataGridView = new System.Windows.Forms.DataGridView();
            this.case_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infected_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.covid_variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalized = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsPage = new System.Windows.Forms.TabPage();
            this.testsDataGrid = new System.Windows.Forms.DataGridView();
            this.testMessageLabel = new System.Windows.Forms.Label();
            this.positive_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.test_person_id_textBox = new System.Windows.Forms.TextBox();
            this.test_city_id_textBox = new System.Windows.Forms.TextBox();
            this.test_test_id_textBox = new System.Windows.Forms.TextBox();
            this.test_date_textBox = new System.Windows.Forms.TextBox();
            this.testsPerMonthButton = new System.Windows.Forms.Button();
            this.showAllTestsButton = new System.Windows.Forms.Button();
            this.deleteTestButton = new System.Windows.Forms.Button();
            this.updateTestButton = new System.Windows.Forms.Button();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.test_test_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_city_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_test_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_positive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTestButton = new System.Windows.Forms.Button();
            this.personsPage = new System.Windows.Forms.TabPage();
            this.personsDataGrid = new System.Windows.Forms.DataGridView();
            this.personMessageLabel = new System.Windows.Forms.Label();
            this.person_vaccine_doses_textBox = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.person_birth_date_textBox = new System.Windows.Forms.TextBox();
            this.person_fullname_textBox = new System.Windows.Forms.TextBox();
            this.person_person_id_textBox = new System.Windows.Forms.TextBox();
            this.person_comorbidities_textBox = new System.Windows.Forms.TextBox();
            this.casesByComorbiditiesButton = new System.Windows.Forms.Button();
            this.casesPerDosesButton = new System.Windows.Forms.Button();
            this.peopleByDosesButton = new System.Windows.Forms.Button();
            this.showAllPersonsButton = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.updatePersonButton = new System.Windows.Forms.Button();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.person_person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_comorbidities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_vaccine_doses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.citiesPage = new System.Windows.Forms.TabPage();
            this.citiesStatsData = new System.Windows.Forms.DataGridView();
            this.button15 = new System.Windows.Forms.Button();
            this.cityMessageLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.city_country_name_textBox = new System.Windows.Forms.TextBox();
            this.city_city_name_textBox = new System.Windows.Forms.TextBox();
            this.city_city_id_textBox = new System.Windows.Forms.TextBox();
            this.numberOfVaccinatedPerCityButton = new System.Windows.Forms.Button();
            this.hospitalizedPerCityButton = new System.Windows.Forms.Button();
            this.casesPerCityButton = new System.Windows.Forms.Button();
            this.percentageOfPositiveTestsButton = new System.Windows.Forms.Button();
            this.showAllCitiesButton = new System.Windows.Forms.Button();
            this.deleteCityButton = new System.Windows.Forms.Button();
            this.updateCityButton = new System.Windows.Forms.Button();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.city_city_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_city_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_country_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCityButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl.SuspendLayout();
            this.casesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGridView)).BeginInit();
            this.testsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            this.personsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.citiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesStatsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.testButton);
            this.menuPanel.Controls.Add(this.pictureBox3);
            this.menuPanel.Controls.Add(this.pictureBox2);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.citiesButton);
            this.menuPanel.Controls.Add(this.personsButton);
            this.menuPanel.Controls.Add(this.casesButton);
            this.menuPanel.ForeColor = System.Drawing.Color.Crimson;
            this.menuPanel.Location = new System.Drawing.Point(0, 4);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(209, 1600);
            this.menuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.testButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.testButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.testButton.Image = ((System.Drawing.Image)(resources.GetObject("testButton.Image")));
            this.testButton.Location = new System.Drawing.Point(0, 259);
            this.testButton.Margin = new System.Windows.Forms.Padding(0);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(209, 52);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Tests ";
            this.testButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testsButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 104);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "COVID-19 Stats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // citiesButton
            // 
            this.citiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.citiesButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.citiesButton.FlatAppearance.BorderSize = 0;
            this.citiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citiesButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.citiesButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.citiesButton.Image = ((System.Drawing.Image)(resources.GetObject("citiesButton.Image")));
            this.citiesButton.Location = new System.Drawing.Point(0, 363);
            this.citiesButton.Margin = new System.Windows.Forms.Padding(0);
            this.citiesButton.Name = "citiesButton";
            this.citiesButton.Size = new System.Drawing.Size(209, 52);
            this.citiesButton.TabIndex = 3;
            this.citiesButton.Text = "Cities";
            this.citiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.citiesButton.UseVisualStyleBackColor = false;
            this.citiesButton.Click += new System.EventHandler(this.citiesButton_Click);
            // 
            // personsButton
            // 
            this.personsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.personsButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.personsButton.FlatAppearance.BorderSize = 0;
            this.personsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personsButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.personsButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.personsButton.Image = ((System.Drawing.Image)(resources.GetObject("personsButton.Image")));
            this.personsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personsButton.Location = new System.Drawing.Point(0, 311);
            this.personsButton.Margin = new System.Windows.Forms.Padding(0);
            this.personsButton.Name = "personsButton";
            this.personsButton.Size = new System.Drawing.Size(209, 52);
            this.personsButton.TabIndex = 1;
            this.personsButton.Text = "Persons     ";
            this.personsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.personsButton.UseVisualStyleBackColor = false;
            this.personsButton.Click += new System.EventHandler(this.personsButton_Click);
            // 
            // casesButton
            // 
            this.casesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.casesButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.casesButton.FlatAppearance.BorderSize = 0;
            this.casesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.casesButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.casesButton.Image = ((System.Drawing.Image)(resources.GetObject("casesButton.Image")));
            this.casesButton.Location = new System.Drawing.Point(0, 207);
            this.casesButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesButton.Name = "casesButton";
            this.casesButton.Size = new System.Drawing.Size(209, 52);
            this.casesButton.TabIndex = 0;
            this.casesButton.Text = "Cases  ";
            this.casesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.casesButton.UseVisualStyleBackColor = false;
            this.casesButton.Click += new System.EventHandler(this.casesButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.casesPage);
            this.tabControl.Controls.Add(this.testsPage);
            this.tabControl.Controls.Add(this.personsPage);
            this.tabControl.Controls.Add(this.citiesPage);
            this.tabControl.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl.Location = new System.Drawing.Point(209, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1971, 1600);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // casesPage
            // 
            this.casesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.casesPage.Controls.Add(this.casesDataGrid);
            this.casesPage.Controls.Add(this.caseMessageLabel);
            this.casesPage.Controls.Add(this.caseResetButton);
            this.casesPage.Controls.Add(this.hospitalized_label);
            this.casesPage.Controls.Add(this.severity_label);
            this.casesPage.Controls.Add(this.patient_state_label);
            this.casesPage.Controls.Add(this.covid_variant_label);
            this.casesPage.Controls.Add(this.infected_by_label);
            this.casesPage.Controls.Add(this.test_id_label);
            this.casesPage.Controls.Add(this.case_id_label);
            this.casesPage.Controls.Add(this.hospitalized_textBox);
            this.casesPage.Controls.Add(this.severity_textBox);
            this.casesPage.Controls.Add(this.patient_state_textBox);
            this.casesPage.Controls.Add(this.covid_variant_textBox);
            this.casesPage.Controls.Add(this.infected_by_textBox);
            this.casesPage.Controls.Add(this.test_id_textBox);
            this.casesPage.Controls.Add(this.case_id_textBox);
            this.casesPage.Controls.Add(this.casesByVariantButton);
            this.casesPage.Controls.Add(this.casesBySeverityButton);
            this.casesPage.Controls.Add(this.casesByPatientStateButton);
            this.casesPage.Controls.Add(this.deleteCaseButton);
            this.casesPage.Controls.Add(this.updateCaseButton);
            this.casesPage.Controls.Add(this.showAllActiveCasesButton);
            this.casesPage.Controls.Add(this.casesDataGridView);
            this.casesPage.Location = new System.Drawing.Point(4, 4);
            this.casesPage.Margin = new System.Windows.Forms.Padding(0);
            this.casesPage.Name = "casesPage";
            this.casesPage.Size = new System.Drawing.Size(1963, 1572);
            this.casesPage.TabIndex = 0;
            this.casesPage.Text = "Cases";
            this.casesPage.Click += new System.EventHandler(this.casesPage_Click);
            // 
            // casesDataGrid
            // 
            this.casesDataGrid.AllowUserToAddRows = false;
            this.casesDataGrid.AllowUserToDeleteRows = false;
            this.casesDataGrid.AllowUserToResizeColumns = false;
            this.casesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.casesDataGrid.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.casesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.casesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.casesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.casesDataGrid.EnableHeadersVisualStyles = false;
            this.casesDataGrid.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.casesDataGrid.Location = new System.Drawing.Point(518, 15);
            this.casesDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.casesDataGrid.Name = "casesDataGrid";
            this.casesDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.casesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.casesDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.casesDataGrid.RowTemplate.Height = 24;
            this.casesDataGrid.Size = new System.Drawing.Size(1140, 344);
            this.casesDataGrid.TabIndex = 46;
            // 
            // caseMessageLabel
            // 
            this.caseMessageLabel.AutoSize = true;
            this.caseMessageLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.caseMessageLabel.Location = new System.Drawing.Point(285, 587);
            this.caseMessageLabel.Name = "caseMessageLabel";
            this.caseMessageLabel.Size = new System.Drawing.Size(0, 16);
            this.caseMessageLabel.TabIndex = 28;
            // 
            // caseResetButton
            // 
            this.caseResetButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.caseResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caseResetButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseResetButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.caseResetButton.Location = new System.Drawing.Point(25, 837);
            this.caseResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.caseResetButton.Name = "caseResetButton";
            this.caseResetButton.Size = new System.Drawing.Size(108, 33);
            this.caseResetButton.TabIndex = 27;
            this.caseResetButton.Text = "Reset";
            this.caseResetButton.UseVisualStyleBackColor = false;
            this.caseResetButton.Click += new System.EventHandler(this.caseResetButton_Click);
            // 
            // hospitalized_label
            // 
            this.hospitalized_label.AutoSize = true;
            this.hospitalized_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalized_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.hospitalized_label.Location = new System.Drawing.Point(21, 755);
            this.hospitalized_label.Name = "hospitalized_label";
            this.hospitalized_label.Size = new System.Drawing.Size(103, 20);
            this.hospitalized_label.TabIndex = 26;
            this.hospitalized_label.Text = "hospitalized";
            // 
            // severity_label
            // 
            this.severity_label.AutoSize = true;
            this.severity_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severity_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.severity_label.Location = new System.Drawing.Point(21, 690);
            this.severity_label.Name = "severity_label";
            this.severity_label.Size = new System.Drawing.Size(70, 20);
            this.severity_label.TabIndex = 25;
            this.severity_label.Text = "severity";
            // 
            // patient_state_label
            // 
            this.patient_state_label.AutoSize = true;
            this.patient_state_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_state_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.patient_state_label.Location = new System.Drawing.Point(21, 627);
            this.patient_state_label.Name = "patient_state_label";
            this.patient_state_label.Size = new System.Drawing.Size(110, 20);
            this.patient_state_label.TabIndex = 24;
            this.patient_state_label.Text = "patient_state";
            // 
            // covid_variant_label
            // 
            this.covid_variant_label.AutoSize = true;
            this.covid_variant_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covid_variant_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.covid_variant_label.Location = new System.Drawing.Point(21, 564);
            this.covid_variant_label.Name = "covid_variant_label";
            this.covid_variant_label.Size = new System.Drawing.Size(112, 20);
            this.covid_variant_label.TabIndex = 23;
            this.covid_variant_label.Text = "covid_variant";
            // 
            // infected_by_label
            // 
            this.infected_by_label.AutoSize = true;
            this.infected_by_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infected_by_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.infected_by_label.Location = new System.Drawing.Point(21, 498);
            this.infected_by_label.Name = "infected_by_label";
            this.infected_by_label.Size = new System.Drawing.Size(99, 20);
            this.infected_by_label.TabIndex = 22;
            this.infected_by_label.Text = "infected_by";
            // 
            // test_id_label
            // 
            this.test_id_label.AutoSize = true;
            this.test_id_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_id_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.test_id_label.Location = new System.Drawing.Point(21, 433);
            this.test_id_label.Name = "test_id_label";
            this.test_id_label.Size = new System.Drawing.Size(61, 20);
            this.test_id_label.TabIndex = 21;
            this.test_id_label.Text = "test_id";
            // 
            // case_id_label
            // 
            this.case_id_label.AutoSize = true;
            this.case_id_label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case_id_label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.case_id_label.Location = new System.Drawing.Point(21, 371);
            this.case_id_label.Name = "case_id_label";
            this.case_id_label.Size = new System.Drawing.Size(67, 20);
            this.case_id_label.TabIndex = 20;
            this.case_id_label.Text = "case_id";
            // 
            // hospitalized_textBox
            // 
            this.hospitalized_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.hospitalized_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalized_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.hospitalized_textBox.Location = new System.Drawing.Point(25, 778);
            this.hospitalized_textBox.Name = "hospitalized_textBox";
            this.hospitalized_textBox.Size = new System.Drawing.Size(202, 29);
            this.hospitalized_textBox.TabIndex = 19;
            // 
            // severity_textBox
            // 
            this.severity_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.severity_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severity_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.severity_textBox.Location = new System.Drawing.Point(25, 713);
            this.severity_textBox.Name = "severity_textBox";
            this.severity_textBox.Size = new System.Drawing.Size(202, 29);
            this.severity_textBox.TabIndex = 18;
            // 
            // patient_state_textBox
            // 
            this.patient_state_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.patient_state_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_state_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.patient_state_textBox.Location = new System.Drawing.Point(25, 650);
            this.patient_state_textBox.Name = "patient_state_textBox";
            this.patient_state_textBox.Size = new System.Drawing.Size(202, 29);
            this.patient_state_textBox.TabIndex = 17;
            // 
            // covid_variant_textBox
            // 
            this.covid_variant_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.covid_variant_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covid_variant_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.covid_variant_textBox.Location = new System.Drawing.Point(25, 587);
            this.covid_variant_textBox.Name = "covid_variant_textBox";
            this.covid_variant_textBox.Size = new System.Drawing.Size(202, 29);
            this.covid_variant_textBox.TabIndex = 16;
            // 
            // infected_by_textBox
            // 
            this.infected_by_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.infected_by_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infected_by_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.infected_by_textBox.Location = new System.Drawing.Point(25, 521);
            this.infected_by_textBox.Name = "infected_by_textBox";
            this.infected_by_textBox.Size = new System.Drawing.Size(202, 29);
            this.infected_by_textBox.TabIndex = 15;
            // 
            // test_id_textBox
            // 
            this.test_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.test_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.test_id_textBox.Location = new System.Drawing.Point(25, 456);
            this.test_id_textBox.Name = "test_id_textBox";
            this.test_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.test_id_textBox.TabIndex = 14;
            // 
            // case_id_textBox
            // 
            this.case_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.case_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.case_id_textBox.Location = new System.Drawing.Point(25, 393);
            this.case_id_textBox.Name = "case_id_textBox";
            this.case_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.case_id_textBox.TabIndex = 13;
            // 
            // casesByVariantButton
            // 
            this.casesByVariantButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.casesByVariantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesByVariantButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesByVariantButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.casesByVariantButton.Location = new System.Drawing.Point(25, 138);
            this.casesByVariantButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesByVariantButton.Name = "casesByVariantButton";
            this.casesByVariantButton.Size = new System.Drawing.Size(422, 44);
            this.casesByVariantButton.TabIndex = 12;
            this.casesByVariantButton.Text = "Show the number of cases by covid variant";
            this.casesByVariantButton.UseVisualStyleBackColor = false;
            this.casesByVariantButton.Click += new System.EventHandler(this.casesByVariantButton_Click);
            // 
            // casesBySeverityButton
            // 
            this.casesBySeverityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.casesBySeverityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesBySeverityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesBySeverityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.casesBySeverityButton.Location = new System.Drawing.Point(25, 25);
            this.casesBySeverityButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesBySeverityButton.Name = "casesBySeverityButton";
            this.casesBySeverityButton.Size = new System.Drawing.Size(422, 44);
            this.casesBySeverityButton.TabIndex = 11;
            this.casesBySeverityButton.Text = "Show number of cases by severity";
            this.casesBySeverityButton.UseVisualStyleBackColor = false;
            this.casesBySeverityButton.Click += new System.EventHandler(this.casesBySeverityButton_Click);
            // 
            // casesByPatientStateButton
            // 
            this.casesByPatientStateButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.casesByPatientStateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesByPatientStateButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesByPatientStateButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.casesByPatientStateButton.Location = new System.Drawing.Point(25, 81);
            this.casesByPatientStateButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesByPatientStateButton.Name = "casesByPatientStateButton";
            this.casesByPatientStateButton.Size = new System.Drawing.Size(422, 44);
            this.casesByPatientStateButton.TabIndex = 10;
            this.casesByPatientStateButton.Text = "Show the number of cases by patient state";
            this.casesByPatientStateButton.UseVisualStyleBackColor = false;
            this.casesByPatientStateButton.Click += new System.EventHandler(this.casesByPatientStateButton_Click);
            // 
            // deleteCaseButton
            // 
            this.deleteCaseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteCaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCaseButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCaseButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.deleteCaseButton.Location = new System.Drawing.Point(288, 444);
            this.deleteCaseButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCaseButton.Name = "deleteCaseButton";
            this.deleteCaseButton.Size = new System.Drawing.Size(202, 44);
            this.deleteCaseButton.TabIndex = 5;
            this.deleteCaseButton.Text = "Delete case";
            this.deleteCaseButton.UseVisualStyleBackColor = false;
            this.deleteCaseButton.Click += new System.EventHandler(this.deleteCaseButton_Click);
            // 
            // updateCaseButton
            // 
            this.updateCaseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateCaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCaseButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCaseButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.updateCaseButton.Location = new System.Drawing.Point(288, 381);
            this.updateCaseButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateCaseButton.Name = "updateCaseButton";
            this.updateCaseButton.Size = new System.Drawing.Size(202, 44);
            this.updateCaseButton.TabIndex = 4;
            this.updateCaseButton.Text = "Update case";
            this.updateCaseButton.UseVisualStyleBackColor = false;
            this.updateCaseButton.Click += new System.EventHandler(this.updateCaseButton_Click);
            // 
            // showAllActiveCasesButton
            // 
            this.showAllActiveCasesButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.showAllActiveCasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllActiveCasesButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllActiveCasesButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.showAllActiveCasesButton.Location = new System.Drawing.Point(288, 509);
            this.showAllActiveCasesButton.Margin = new System.Windows.Forms.Padding(0);
            this.showAllActiveCasesButton.Name = "showAllActiveCasesButton";
            this.showAllActiveCasesButton.Size = new System.Drawing.Size(202, 44);
            this.showAllActiveCasesButton.TabIndex = 1;
            this.showAllActiveCasesButton.Text = "Show all active cases";
            this.showAllActiveCasesButton.UseVisualStyleBackColor = false;
            this.showAllActiveCasesButton.Click += new System.EventHandler(this.showAllActiveCasesButton_Click);
            // 
            // casesDataGridView
            // 
            this.casesDataGridView.AllowUserToAddRows = false;
            this.casesDataGridView.AllowUserToDeleteRows = false;
            this.casesDataGridView.AllowUserToResizeColumns = false;
            this.casesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.casesDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.casesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.casesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.case_id,
            this.test_id,
            this.infected_by,
            this.covid_variant,
            this.patient_state,
            this.severity,
            this.hospitalized});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.casesDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.casesDataGridView.EnableHeadersVisualStyles = false;
            this.casesDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.casesDataGridView.Location = new System.Drawing.Point(518, 381);
            this.casesDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.casesDataGridView.Name = "casesDataGridView";
            this.casesDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.casesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.casesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.casesDataGridView.RowTemplate.Height = 24;
            this.casesDataGridView.Size = new System.Drawing.Size(1182, 599);
            this.casesDataGridView.TabIndex = 0;
            this.casesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casesDataGridView_CellClick);
            // 
            // case_id
            // 
            this.case_id.HeaderText = "case_id";
            this.case_id.MinimumWidth = 6;
            this.case_id.Name = "case_id";
            this.case_id.ReadOnly = true;
            // 
            // test_id
            // 
            this.test_id.HeaderText = "test_id";
            this.test_id.MinimumWidth = 6;
            this.test_id.Name = "test_id";
            this.test_id.ReadOnly = true;
            // 
            // infected_by
            // 
            this.infected_by.HeaderText = "infected_by";
            this.infected_by.MinimumWidth = 6;
            this.infected_by.Name = "infected_by";
            this.infected_by.ReadOnly = true;
            // 
            // covid_variant
            // 
            this.covid_variant.HeaderText = "covid_variant";
            this.covid_variant.MinimumWidth = 6;
            this.covid_variant.Name = "covid_variant";
            this.covid_variant.ReadOnly = true;
            // 
            // patient_state
            // 
            this.patient_state.HeaderText = "patient_state";
            this.patient_state.MinimumWidth = 6;
            this.patient_state.Name = "patient_state";
            this.patient_state.ReadOnly = true;
            // 
            // severity
            // 
            this.severity.HeaderText = "serverity";
            this.severity.MinimumWidth = 6;
            this.severity.Name = "severity";
            this.severity.ReadOnly = true;
            // 
            // hospitalized
            // 
            this.hospitalized.HeaderText = "hospitalized";
            this.hospitalized.MinimumWidth = 6;
            this.hospitalized.Name = "hospitalized";
            this.hospitalized.ReadOnly = true;
            // 
            // testsPage
            // 
            this.testsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.testsPage.Controls.Add(this.testsDataGrid);
            this.testsPage.Controls.Add(this.testMessageLabel);
            this.testsPage.Controls.Add(this.positive_textBox);
            this.testsPage.Controls.Add(this.button2);
            this.testsPage.Controls.Add(this.label4);
            this.testsPage.Controls.Add(this.label5);
            this.testsPage.Controls.Add(this.label6);
            this.testsPage.Controls.Add(this.label7);
            this.testsPage.Controls.Add(this.label8);
            this.testsPage.Controls.Add(this.test_person_id_textBox);
            this.testsPage.Controls.Add(this.test_city_id_textBox);
            this.testsPage.Controls.Add(this.test_test_id_textBox);
            this.testsPage.Controls.Add(this.test_date_textBox);
            this.testsPage.Controls.Add(this.testsPerMonthButton);
            this.testsPage.Controls.Add(this.showAllTestsButton);
            this.testsPage.Controls.Add(this.deleteTestButton);
            this.testsPage.Controls.Add(this.updateTestButton);
            this.testsPage.Controls.Add(this.testsDataGridView);
            this.testsPage.Controls.Add(this.addTestButton);
            this.testsPage.Location = new System.Drawing.Point(4, 4);
            this.testsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testsPage.Name = "testsPage";
            this.testsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testsPage.Size = new System.Drawing.Size(1963, 1572);
            this.testsPage.TabIndex = 1;
            this.testsPage.Text = "Tests";
            // 
            // testsDataGrid
            // 
            this.testsDataGrid.AllowUserToAddRows = false;
            this.testsDataGrid.AllowUserToDeleteRows = false;
            this.testsDataGrid.AllowUserToResizeColumns = false;
            this.testsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.testsDataGrid.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.testsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testsDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.testsDataGrid.EnableHeadersVisualStyles = false;
            this.testsDataGrid.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.testsDataGrid.Location = new System.Drawing.Point(532, 16);
            this.testsDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.testsDataGrid.Name = "testsDataGrid";
            this.testsDataGrid.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.testsDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.testsDataGrid.RowTemplate.Height = 24;
            this.testsDataGrid.Size = new System.Drawing.Size(1140, 353);
            this.testsDataGrid.TabIndex = 45;
            // 
            // testMessageLabel
            // 
            this.testMessageLabel.AutoSize = true;
            this.testMessageLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.testMessageLabel.Location = new System.Drawing.Point(271, 644);
            this.testMessageLabel.Name = "testMessageLabel";
            this.testMessageLabel.Size = new System.Drawing.Size(0, 16);
            this.testMessageLabel.TabIndex = 44;
            // 
            // positive_textBox
            // 
            this.positive_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.positive_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positive_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.positive_textBox.Location = new System.Drawing.Point(40, 644);
            this.positive_textBox.Name = "positive_textBox";
            this.positive_textBox.Size = new System.Drawing.Size(202, 29);
            this.positive_textBox.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(40, 698);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 42;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(36, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "positive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(36, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "test_date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(36, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "person_id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(36, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "city_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(34, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "test_id";
            // 
            // test_person_id_textBox
            // 
            this.test_person_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.test_person_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_person_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.test_person_id_textBox.Location = new System.Drawing.Point(38, 522);
            this.test_person_id_textBox.Name = "test_person_id_textBox";
            this.test_person_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.test_person_id_textBox.TabIndex = 34;
            // 
            // test_city_id_textBox
            // 
            this.test_city_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.test_city_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_city_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.test_city_id_textBox.Location = new System.Drawing.Point(40, 466);
            this.test_city_id_textBox.Name = "test_city_id_textBox";
            this.test_city_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.test_city_id_textBox.TabIndex = 33;
            // 
            // test_test_id_textBox
            // 
            this.test_test_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.test_test_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_test_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.test_test_id_textBox.Location = new System.Drawing.Point(38, 406);
            this.test_test_id_textBox.Name = "test_test_id_textBox";
            this.test_test_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.test_test_id_textBox.TabIndex = 32;
            // 
            // test_date_textBox
            // 
            this.test_date_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.test_date_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_date_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.test_date_textBox.Location = new System.Drawing.Point(40, 583);
            this.test_date_textBox.Name = "test_date_textBox";
            this.test_date_textBox.Size = new System.Drawing.Size(202, 29);
            this.test_date_textBox.TabIndex = 31;
            // 
            // testsPerMonthButton
            // 
            this.testsPerMonthButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.testsPerMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testsPerMonthButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsPerMonthButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.testsPerMonthButton.Location = new System.Drawing.Point(49, 16);
            this.testsPerMonthButton.Margin = new System.Windows.Forms.Padding(0);
            this.testsPerMonthButton.Name = "testsPerMonthButton";
            this.testsPerMonthButton.Size = new System.Drawing.Size(426, 69);
            this.testsPerMonthButton.TabIndex = 11;
            this.testsPerMonthButton.Text = "Show number of tests per month in 2021";
            this.testsPerMonthButton.UseVisualStyleBackColor = false;
            this.testsPerMonthButton.Click += new System.EventHandler(this.testsPerMonthButton_Click);
            // 
            // showAllTestsButton
            // 
            this.showAllTestsButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.showAllTestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllTestsButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllTestsButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.showAllTestsButton.Location = new System.Drawing.Point(274, 568);
            this.showAllTestsButton.Margin = new System.Windows.Forms.Padding(0);
            this.showAllTestsButton.Name = "showAllTestsButton";
            this.showAllTestsButton.Size = new System.Drawing.Size(231, 44);
            this.showAllTestsButton.TabIndex = 10;
            this.showAllTestsButton.Text = "Show all tests";
            this.showAllTestsButton.UseVisualStyleBackColor = false;
            this.showAllTestsButton.Click += new System.EventHandler(this.showAllTestsButton_Click);
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTestButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTestButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.deleteTestButton.Location = new System.Drawing.Point(274, 507);
            this.deleteTestButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteTestButton.Name = "deleteTestButton";
            this.deleteTestButton.Size = new System.Drawing.Size(231, 44);
            this.deleteTestButton.TabIndex = 9;
            this.deleteTestButton.Text = "Delete test";
            this.deleteTestButton.UseVisualStyleBackColor = false;
            this.deleteTestButton.Click += new System.EventHandler(this.deleteTestButton_Click);
            // 
            // updateTestButton
            // 
            this.updateTestButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTestButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTestButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.updateTestButton.Location = new System.Drawing.Point(274, 451);
            this.updateTestButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateTestButton.Name = "updateTestButton";
            this.updateTestButton.Size = new System.Drawing.Size(231, 44);
            this.updateTestButton.TabIndex = 7;
            this.updateTestButton.Text = "Update test";
            this.updateTestButton.UseVisualStyleBackColor = false;
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AllowUserToAddRows = false;
            this.testsDataGridView.AllowUserToDeleteRows = false;
            this.testsDataGridView.AllowUserToResizeColumns = false;
            this.testsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.testsDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test_test_id,
            this.test_city_id,
            this.test_person_id,
            this.test_test_date,
            this.test_positive});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testsDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.testsDataGridView.EnableHeadersVisualStyles = false;
            this.testsDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.testsDataGridView.Location = new System.Drawing.Point(532, 391);
            this.testsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.testsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.testsDataGridView.RowTemplate.Height = 24;
            this.testsDataGridView.Size = new System.Drawing.Size(1140, 582);
            this.testsDataGridView.TabIndex = 6;
            this.testsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testsDataGridView_CellClick);
            // 
            // test_test_id
            // 
            this.test_test_id.HeaderText = "test_id";
            this.test_test_id.MinimumWidth = 6;
            this.test_test_id.Name = "test_test_id";
            this.test_test_id.ReadOnly = true;
            // 
            // test_city_id
            // 
            this.test_city_id.HeaderText = "city_id";
            this.test_city_id.MinimumWidth = 6;
            this.test_city_id.Name = "test_city_id";
            this.test_city_id.ReadOnly = true;
            // 
            // test_person_id
            // 
            this.test_person_id.HeaderText = "person_id";
            this.test_person_id.MinimumWidth = 6;
            this.test_person_id.Name = "test_person_id";
            this.test_person_id.ReadOnly = true;
            // 
            // test_test_date
            // 
            this.test_test_date.HeaderText = "test_date";
            this.test_test_date.MinimumWidth = 6;
            this.test_test_date.Name = "test_test_date";
            this.test_test_date.ReadOnly = true;
            // 
            // test_positive
            // 
            this.test_positive.HeaderText = "positive";
            this.test_positive.MinimumWidth = 6;
            this.test_positive.Name = "test_positive";
            this.test_positive.ReadOnly = true;
            // 
            // addTestButton
            // 
            this.addTestButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTestButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTestButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.addTestButton.Location = new System.Drawing.Point(274, 391);
            this.addTestButton.Margin = new System.Windows.Forms.Padding(0);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(231, 44);
            this.addTestButton.TabIndex = 5;
            this.addTestButton.Text = "Add test";
            this.addTestButton.UseVisualStyleBackColor = false;
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // personsPage
            // 
            this.personsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.personsPage.Controls.Add(this.personsDataGrid);
            this.personsPage.Controls.Add(this.personMessageLabel);
            this.personsPage.Controls.Add(this.person_vaccine_doses_textBox);
            this.personsPage.Controls.Add(this.button14);
            this.personsPage.Controls.Add(this.label2);
            this.personsPage.Controls.Add(this.label3);
            this.personsPage.Controls.Add(this.label9);
            this.personsPage.Controls.Add(this.label10);
            this.personsPage.Controls.Add(this.label11);
            this.personsPage.Controls.Add(this.person_birth_date_textBox);
            this.personsPage.Controls.Add(this.person_fullname_textBox);
            this.personsPage.Controls.Add(this.person_person_id_textBox);
            this.personsPage.Controls.Add(this.person_comorbidities_textBox);
            this.personsPage.Controls.Add(this.casesByComorbiditiesButton);
            this.personsPage.Controls.Add(this.casesPerDosesButton);
            this.personsPage.Controls.Add(this.peopleByDosesButton);
            this.personsPage.Controls.Add(this.showAllPersonsButton);
            this.personsPage.Controls.Add(this.deletePersonButton);
            this.personsPage.Controls.Add(this.updatePersonButton);
            this.personsPage.Controls.Add(this.personsDataGridView);
            this.personsPage.Controls.Add(this.addPersonButton);
            this.personsPage.Location = new System.Drawing.Point(4, 4);
            this.personsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personsPage.Name = "personsPage";
            this.personsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personsPage.Size = new System.Drawing.Size(1963, 1572);
            this.personsPage.TabIndex = 2;
            this.personsPage.Text = "Persons";
            // 
            // personsDataGrid
            // 
            this.personsDataGrid.AllowUserToAddRows = false;
            this.personsDataGrid.AllowUserToDeleteRows = false;
            this.personsDataGrid.AllowUserToResizeColumns = false;
            this.personsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.personsDataGrid.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.personsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personsDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.personsDataGrid.EnableHeadersVisualStyles = false;
            this.personsDataGrid.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.personsDataGrid.Location = new System.Drawing.Point(540, 25);
            this.personsDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.personsDataGrid.Name = "personsDataGrid";
            this.personsDataGrid.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.personsDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.personsDataGrid.RowTemplate.Height = 24;
            this.personsDataGrid.Size = new System.Drawing.Size(1131, 334);
            this.personsDataGrid.TabIndex = 56;
            // 
            // personMessageLabel
            // 
            this.personMessageLabel.AutoSize = true;
            this.personMessageLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.personMessageLabel.Location = new System.Drawing.Point(302, 621);
            this.personMessageLabel.Name = "personMessageLabel";
            this.personMessageLabel.Size = new System.Drawing.Size(0, 16);
            this.personMessageLabel.TabIndex = 55;
            // 
            // person_vaccine_doses_textBox
            // 
            this.person_vaccine_doses_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.person_vaccine_doses_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_vaccine_doses_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.person_vaccine_doses_textBox.Location = new System.Drawing.Point(56, 621);
            this.person_vaccine_doses_textBox.Name = "person_vaccine_doses_textBox";
            this.person_vaccine_doses_textBox.Size = new System.Drawing.Size(202, 29);
            this.person_vaccine_doses_textBox.TabIndex = 54;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MidnightBlue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button14.Location = new System.Drawing.Point(56, 675);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 33);
            this.button14.TabIndex = 53;
            this.button14.Text = "Reset";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(52, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "vaccine_doses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(52, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "comorbidities";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(52, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "birth_date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(52, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "full_name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Location = new System.Drawing.Point(50, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "person_id";
            // 
            // person_birth_date_textBox
            // 
            this.person_birth_date_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.person_birth_date_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_birth_date_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.person_birth_date_textBox.Location = new System.Drawing.Point(54, 499);
            this.person_birth_date_textBox.Name = "person_birth_date_textBox";
            this.person_birth_date_textBox.Size = new System.Drawing.Size(202, 29);
            this.person_birth_date_textBox.TabIndex = 47;
            // 
            // person_fullname_textBox
            // 
            this.person_fullname_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.person_fullname_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_fullname_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.person_fullname_textBox.Location = new System.Drawing.Point(56, 443);
            this.person_fullname_textBox.Name = "person_fullname_textBox";
            this.person_fullname_textBox.Size = new System.Drawing.Size(202, 29);
            this.person_fullname_textBox.TabIndex = 46;
            // 
            // person_person_id_textBox
            // 
            this.person_person_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.person_person_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_person_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.person_person_id_textBox.Location = new System.Drawing.Point(54, 383);
            this.person_person_id_textBox.Name = "person_person_id_textBox";
            this.person_person_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.person_person_id_textBox.TabIndex = 45;
            // 
            // person_comorbidities_textBox
            // 
            this.person_comorbidities_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.person_comorbidities_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_comorbidities_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.person_comorbidities_textBox.Location = new System.Drawing.Point(56, 560);
            this.person_comorbidities_textBox.Name = "person_comorbidities_textBox";
            this.person_comorbidities_textBox.Size = new System.Drawing.Size(202, 29);
            this.person_comorbidities_textBox.TabIndex = 44;
            // 
            // casesByComorbiditiesButton
            // 
            this.casesByComorbiditiesButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.casesByComorbiditiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesByComorbiditiesButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesByComorbiditiesButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.casesByComorbiditiesButton.Location = new System.Drawing.Point(54, 185);
            this.casesByComorbiditiesButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesByComorbiditiesButton.Name = "casesByComorbiditiesButton";
            this.casesByComorbiditiesButton.Size = new System.Drawing.Size(450, 51);
            this.casesByComorbiditiesButton.TabIndex = 24;
            this.casesByComorbiditiesButton.Text = "Show the number of cases depending on comorbidities";
            this.casesByComorbiditiesButton.UseVisualStyleBackColor = false;
            this.casesByComorbiditiesButton.Click += new System.EventHandler(this.casesByComorbiditiesButton_Click);
            // 
            // casesPerDosesButton
            // 
            this.casesPerDosesButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.casesPerDosesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesPerDosesButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesPerDosesButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.casesPerDosesButton.Location = new System.Drawing.Point(54, 103);
            this.casesPerDosesButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesPerDosesButton.Name = "casesPerDosesButton";
            this.casesPerDosesButton.Size = new System.Drawing.Size(450, 59);
            this.casesPerDosesButton.TabIndex = 23;
            this.casesPerDosesButton.Text = "Show the number of cases per number of vaccine doses";
            this.casesPerDosesButton.UseVisualStyleBackColor = false;
            this.casesPerDosesButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // peopleByDosesButton
            // 
            this.peopleByDosesButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.peopleByDosesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peopleByDosesButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleByDosesButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.peopleByDosesButton.Location = new System.Drawing.Point(54, 25);
            this.peopleByDosesButton.Margin = new System.Windows.Forms.Padding(0);
            this.peopleByDosesButton.Name = "peopleByDosesButton";
            this.peopleByDosesButton.Size = new System.Drawing.Size(450, 60);
            this.peopleByDosesButton.TabIndex = 21;
            this.peopleByDosesButton.Text = "Show the number of people per number of vaccine doses";
            this.peopleByDosesButton.UseVisualStyleBackColor = false;
            this.peopleByDosesButton.Click += new System.EventHandler(this.peopleByDosesButton_Click);
            // 
            // showAllPersonsButton
            // 
            this.showAllPersonsButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.showAllPersonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllPersonsButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllPersonsButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.showAllPersonsButton.Location = new System.Drawing.Point(302, 545);
            this.showAllPersonsButton.Margin = new System.Windows.Forms.Padding(0);
            this.showAllPersonsButton.Name = "showAllPersonsButton";
            this.showAllPersonsButton.Size = new System.Drawing.Size(202, 44);
            this.showAllPersonsButton.TabIndex = 20;
            this.showAllPersonsButton.Text = "Show all persons";
            this.showAllPersonsButton.UseVisualStyleBackColor = false;
            this.showAllPersonsButton.Click += new System.EventHandler(this.showAllPersonsButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deletePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePersonButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePersonButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.deletePersonButton.Location = new System.Drawing.Point(302, 484);
            this.deletePersonButton.Margin = new System.Windows.Forms.Padding(0);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(202, 44);
            this.deletePersonButton.TabIndex = 19;
            this.deletePersonButton.Text = "Delete person";
            this.deletePersonButton.UseVisualStyleBackColor = false;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.updatePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePersonButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePersonButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.updatePersonButton.Location = new System.Drawing.Point(302, 428);
            this.updatePersonButton.Margin = new System.Windows.Forms.Padding(0);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(202, 44);
            this.updatePersonButton.TabIndex = 17;
            this.updatePersonButton.Text = "Update person";
            this.updatePersonButton.UseVisualStyleBackColor = false;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AllowUserToAddRows = false;
            this.personsDataGridView.AllowUserToDeleteRows = false;
            this.personsDataGridView.AllowUserToResizeColumns = false;
            this.personsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.personsDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.person_person_id,
            this.person_full_name,
            this.person_birth_date,
            this.person_comorbidities,
            this.person_vaccine_doses});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personsDataGridView.DefaultCellStyle = dataGridViewCellStyle22;
            this.personsDataGridView.EnableHeadersVisualStyles = false;
            this.personsDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.personsDataGridView.Location = new System.Drawing.Point(540, 368);
            this.personsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.personsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.personsDataGridView.RowTemplate.Height = 24;
            this.personsDataGridView.Size = new System.Drawing.Size(1131, 577);
            this.personsDataGridView.TabIndex = 16;
            this.personsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsDataGridView_CellClick);
            // 
            // person_person_id
            // 
            this.person_person_id.HeaderText = "person_id";
            this.person_person_id.MinimumWidth = 6;
            this.person_person_id.Name = "person_person_id";
            this.person_person_id.ReadOnly = true;
            // 
            // person_full_name
            // 
            this.person_full_name.HeaderText = "full_name";
            this.person_full_name.MinimumWidth = 6;
            this.person_full_name.Name = "person_full_name";
            this.person_full_name.ReadOnly = true;
            // 
            // person_birth_date
            // 
            this.person_birth_date.HeaderText = "birth_date";
            this.person_birth_date.MinimumWidth = 6;
            this.person_birth_date.Name = "person_birth_date";
            this.person_birth_date.ReadOnly = true;
            // 
            // person_comorbidities
            // 
            this.person_comorbidities.HeaderText = "comorbidities";
            this.person_comorbidities.MinimumWidth = 6;
            this.person_comorbidities.Name = "person_comorbidities";
            this.person_comorbidities.ReadOnly = true;
            // 
            // person_vaccine_doses
            // 
            this.person_vaccine_doses.HeaderText = "vaccine_doses";
            this.person_vaccine_doses.MinimumWidth = 6;
            this.person_vaccine_doses.Name = "person_vaccine_doses";
            this.person_vaccine_doses.ReadOnly = true;
            // 
            // addPersonButton
            // 
            this.addPersonButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.addPersonButton.Location = new System.Drawing.Point(302, 368);
            this.addPersonButton.Margin = new System.Windows.Forms.Padding(0);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(202, 44);
            this.addPersonButton.TabIndex = 15;
            this.addPersonButton.Text = "Add person";
            this.addPersonButton.UseVisualStyleBackColor = false;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // citiesPage
            // 
            this.citiesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.citiesPage.Controls.Add(this.citiesStatsData);
            this.citiesPage.Controls.Add(this.button15);
            this.citiesPage.Controls.Add(this.cityMessageLabel);
            this.citiesPage.Controls.Add(this.label12);
            this.citiesPage.Controls.Add(this.label13);
            this.citiesPage.Controls.Add(this.label14);
            this.citiesPage.Controls.Add(this.city_country_name_textBox);
            this.citiesPage.Controls.Add(this.city_city_name_textBox);
            this.citiesPage.Controls.Add(this.city_city_id_textBox);
            this.citiesPage.Controls.Add(this.numberOfVaccinatedPerCityButton);
            this.citiesPage.Controls.Add(this.hospitalizedPerCityButton);
            this.citiesPage.Controls.Add(this.casesPerCityButton);
            this.citiesPage.Controls.Add(this.percentageOfPositiveTestsButton);
            this.citiesPage.Controls.Add(this.showAllCitiesButton);
            this.citiesPage.Controls.Add(this.deleteCityButton);
            this.citiesPage.Controls.Add(this.updateCityButton);
            this.citiesPage.Controls.Add(this.citiesDataGridView);
            this.citiesPage.Controls.Add(this.addCityButton);
            this.citiesPage.Location = new System.Drawing.Point(4, 4);
            this.citiesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.citiesPage.Name = "citiesPage";
            this.citiesPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.citiesPage.Size = new System.Drawing.Size(1963, 1572);
            this.citiesPage.TabIndex = 3;
            this.citiesPage.Text = "Cities";
            // 
            // citiesStatsData
            // 
            this.citiesStatsData.AllowUserToAddRows = false;
            this.citiesStatsData.AllowUserToDeleteRows = false;
            this.citiesStatsData.AllowUserToResizeColumns = false;
            this.citiesStatsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.citiesStatsData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.citiesStatsData.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.citiesStatsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.citiesStatsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citiesStatsData.DefaultCellStyle = dataGridViewCellStyle26;
            this.citiesStatsData.EnableHeadersVisualStyles = false;
            this.citiesStatsData.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.citiesStatsData.Location = new System.Drawing.Point(68, 287);
            this.citiesStatsData.Margin = new System.Windows.Forms.Padding(0);
            this.citiesStatsData.Name = "citiesStatsData";
            this.citiesStatsData.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.citiesStatsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.citiesStatsData.RowHeadersWidth = 51;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.citiesStatsData.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.citiesStatsData.RowTemplate.Height = 24;
            this.citiesStatsData.Size = new System.Drawing.Size(811, 673);
            this.citiesStatsData.TabIndex = 59;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.MidnightBlue;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button15.Location = new System.Drawing.Point(1258, 202);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(108, 33);
            this.button15.TabIndex = 58;
            this.button15.Text = "Reset";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // cityMessageLabel
            // 
            this.cityMessageLabel.AutoSize = true;
            this.cityMessageLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.cityMessageLabel.Location = new System.Drawing.Point(1518, 25);
            this.cityMessageLabel.Name = "cityMessageLabel";
            this.cityMessageLabel.Size = new System.Drawing.Size(0, 16);
            this.cityMessageLabel.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Location = new System.Drawing.Point(1254, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "country_name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(1252, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "city_name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(1252, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "city_id";
            // 
            // city_country_name_textBox
            // 
            this.city_country_name_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.city_country_name_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_country_name_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.city_country_name_textBox.Location = new System.Drawing.Point(1256, 158);
            this.city_country_name_textBox.Name = "city_country_name_textBox";
            this.city_country_name_textBox.Size = new System.Drawing.Size(202, 29);
            this.city_country_name_textBox.TabIndex = 53;
            // 
            // city_city_name_textBox
            // 
            this.city_city_name_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.city_city_name_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_city_name_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.city_city_name_textBox.Location = new System.Drawing.Point(1256, 97);
            this.city_city_name_textBox.Name = "city_city_name_textBox";
            this.city_city_name_textBox.Size = new System.Drawing.Size(202, 29);
            this.city_city_name_textBox.TabIndex = 52;
            // 
            // city_city_id_textBox
            // 
            this.city_city_id_textBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.city_city_id_textBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_city_id_textBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.city_city_id_textBox.Location = new System.Drawing.Point(1256, 40);
            this.city_city_id_textBox.Name = "city_city_id_textBox";
            this.city_city_id_textBox.Size = new System.Drawing.Size(202, 29);
            this.city_city_id_textBox.TabIndex = 51;
            // 
            // numberOfVaccinatedPerCityButton
            // 
            this.numberOfVaccinatedPerCityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.numberOfVaccinatedPerCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberOfVaccinatedPerCityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfVaccinatedPerCityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.numberOfVaccinatedPerCityButton.Location = new System.Drawing.Point(68, 188);
            this.numberOfVaccinatedPerCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberOfVaccinatedPerCityButton.Name = "numberOfVaccinatedPerCityButton";
            this.numberOfVaccinatedPerCityButton.Size = new System.Drawing.Size(422, 47);
            this.numberOfVaccinatedPerCityButton.TabIndex = 24;
            this.numberOfVaccinatedPerCityButton.Text = "Show the number of vaccinated patients per city";
            this.numberOfVaccinatedPerCityButton.UseVisualStyleBackColor = false;
            this.numberOfVaccinatedPerCityButton.Click += new System.EventHandler(this.numberOfVaccinatedPerCityButton_Click);
            // 
            // hospitalizedPerCityButton
            // 
            this.hospitalizedPerCityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.hospitalizedPerCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hospitalizedPerCityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalizedPerCityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.hospitalizedPerCityButton.Location = new System.Drawing.Point(68, 133);
            this.hospitalizedPerCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.hospitalizedPerCityButton.Name = "hospitalizedPerCityButton";
            this.hospitalizedPerCityButton.Size = new System.Drawing.Size(422, 44);
            this.hospitalizedPerCityButton.TabIndex = 23;
            this.hospitalizedPerCityButton.Text = "Show the number of hospitalized patients per city";
            this.hospitalizedPerCityButton.UseVisualStyleBackColor = false;
            this.hospitalizedPerCityButton.Click += new System.EventHandler(this.hospitalizedPerCityButton_Click);
            // 
            // casesPerCityButton
            // 
            this.casesPerCityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.casesPerCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesPerCityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesPerCityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.casesPerCityButton.Location = new System.Drawing.Point(68, 25);
            this.casesPerCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.casesPerCityButton.Name = "casesPerCityButton";
            this.casesPerCityButton.Size = new System.Drawing.Size(422, 44);
            this.casesPerCityButton.TabIndex = 22;
            this.casesPerCityButton.Text = "Show the number of cases by city";
            this.casesPerCityButton.UseVisualStyleBackColor = false;
            this.casesPerCityButton.Click += new System.EventHandler(this.casesPerCityButton_Click);
            // 
            // percentageOfPositiveTestsButton
            // 
            this.percentageOfPositiveTestsButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.percentageOfPositiveTestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentageOfPositiveTestsButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageOfPositiveTestsButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.percentageOfPositiveTestsButton.Location = new System.Drawing.Point(68, 80);
            this.percentageOfPositiveTestsButton.Margin = new System.Windows.Forms.Padding(0);
            this.percentageOfPositiveTestsButton.Name = "percentageOfPositiveTestsButton";
            this.percentageOfPositiveTestsButton.Size = new System.Drawing.Size(422, 44);
            this.percentageOfPositiveTestsButton.TabIndex = 21;
            this.percentageOfPositiveTestsButton.Text = "Show the number tests per city";
            this.percentageOfPositiveTestsButton.UseVisualStyleBackColor = false;
            this.percentageOfPositiveTestsButton.Click += new System.EventHandler(this.percentageOfPositiveTestsButton_Click);
            // 
            // showAllCitiesButton
            // 
            this.showAllCitiesButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.showAllCitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllCitiesButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllCitiesButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.showAllCitiesButton.Location = new System.Drawing.Point(971, 188);
            this.showAllCitiesButton.Margin = new System.Windows.Forms.Padding(0);
            this.showAllCitiesButton.Name = "showAllCitiesButton";
            this.showAllCitiesButton.Size = new System.Drawing.Size(237, 44);
            this.showAllCitiesButton.TabIndex = 20;
            this.showAllCitiesButton.Text = "Show all cities";
            this.showAllCitiesButton.UseVisualStyleBackColor = false;
            this.showAllCitiesButton.Click += new System.EventHandler(this.showAllCitiesButton_Click);
            // 
            // deleteCityButton
            // 
            this.deleteCityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.deleteCityButton.Location = new System.Drawing.Point(971, 133);
            this.deleteCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCityButton.Name = "deleteCityButton";
            this.deleteCityButton.Size = new System.Drawing.Size(237, 44);
            this.deleteCityButton.TabIndex = 19;
            this.deleteCityButton.Text = "Delete city";
            this.deleteCityButton.UseVisualStyleBackColor = false;
            this.deleteCityButton.Click += new System.EventHandler(this.deleteCityButton_Click);
            // 
            // updateCityButton
            // 
            this.updateCityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.updateCityButton.Location = new System.Drawing.Point(971, 80);
            this.updateCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateCityButton.Name = "updateCityButton";
            this.updateCityButton.Size = new System.Drawing.Size(237, 44);
            this.updateCityButton.TabIndex = 17;
            this.updateCityButton.Text = "Update city";
            this.updateCityButton.UseVisualStyleBackColor = false;
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AllowUserToAddRows = false;
            this.citiesDataGridView.AllowUserToDeleteRows = false;
            this.citiesDataGridView.AllowUserToResizeColumns = false;
            this.citiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.citiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.citiesDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.citiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city_city_id,
            this.city_city_name,
            this.city_country_name});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citiesDataGridView.DefaultCellStyle = dataGridViewCellStyle30;
            this.citiesDataGridView.EnableHeadersVisualStyles = false;
            this.citiesDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.citiesDataGridView.Location = new System.Drawing.Point(962, 287);
            this.citiesDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.citiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.citiesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.citiesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.citiesDataGridView.RowTemplate.Height = 24;
            this.citiesDataGridView.Size = new System.Drawing.Size(703, 673);
            this.citiesDataGridView.TabIndex = 16;
            this.citiesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.citiesDataGridView_CellClick);
            // 
            // city_city_id
            // 
            this.city_city_id.HeaderText = "city_id";
            this.city_city_id.MinimumWidth = 6;
            this.city_city_id.Name = "city_city_id";
            this.city_city_id.ReadOnly = true;
            // 
            // city_city_name
            // 
            this.city_city_name.HeaderText = "city_name";
            this.city_city_name.MinimumWidth = 6;
            this.city_city_name.Name = "city_city_name";
            this.city_city_name.ReadOnly = true;
            // 
            // city_country_name
            // 
            this.city_country_name.HeaderText = "country_name";
            this.city_country_name.MinimumWidth = 6;
            this.city_country_name.Name = "city_country_name";
            this.city_country_name.ReadOnly = true;
            // 
            // addCityButton
            // 
            this.addCityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCityButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCityButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.addCityButton.Location = new System.Drawing.Point(971, 25);
            this.addCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(237, 44);
            this.addCityButton.TabIndex = 15;
            this.addCityButton.Text = "Add city";
            this.addCityButton.UseVisualStyleBackColor = false;
            this.addCityButton.Click += new System.EventHandler(this.addCityButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(2000, 4);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1922, 1053);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVID-19 Stats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.casesPage.ResumeLayout(false);
            this.casesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGridView)).EndInit();
            this.testsPage.ResumeLayout(false);
            this.testsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            this.personsPage.ResumeLayout(false);
            this.personsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.citiesPage.ResumeLayout(false);
            this.citiesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesStatsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button personsButton;
        private Button citiesButton;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button testButton;
        private TabControl tabControl;
        private TabPage casesPage;
        private TabPage testsPage;
        private TabPage personsPage;
        private TabPage citiesPage;
        private Button button1;
        private DataGridViewTextBoxColumn case_id;
        private DataGridViewTextBoxColumn test_id;
        private DataGridViewTextBoxColumn infected_by;
        private DataGridViewTextBoxColumn covid_variant;
        private DataGridViewTextBoxColumn patient_state;
        private DataGridViewTextBoxColumn severity;
        private DataGridViewTextBoxColumn hospitalized;
        private DataGridView casesDataGridView;
        private Button showAllActiveCasesButton;
        private Button updateCaseButton;
        private Button showAllTestsButton;
        private Button deleteTestButton;
        private Button updateTestButton;
        private DataGridView testsDataGridView;
        private Button addTestButton;
        private DataGridViewTextBoxColumn test_test_id;
        private DataGridViewTextBoxColumn test_city_id;
        private DataGridViewTextBoxColumn test_person_id;
        private DataGridViewTextBoxColumn test_test_date;
        private DataGridViewTextBoxColumn test_positive;
        private Button testsPerMonthButton;
        private Button deleteCaseButton;
        private Button casesByVariantButton;
        private Button casesBySeverityButton;
        private Button casesByPatientStateButton;
        private Button casesByComorbiditiesButton;
        private Button casesPerDosesButton;
        private Button peopleByDosesButton;
        private Button showAllPersonsButton;
        private Button deletePersonButton;
        private Button updatePersonButton;
        private DataGridView personsDataGridView;
        private Button addPersonButton;
        private DataGridViewTextBoxColumn person_person_id;
        private DataGridViewTextBoxColumn person_full_name;
        private DataGridViewTextBoxColumn person_birth_date;
        private DataGridViewTextBoxColumn person_comorbidities;
        private DataGridViewTextBoxColumn person_vaccine_doses;
        private Button numberOfVaccinatedPerCityButton;
        private Button hospitalizedPerCityButton;
        private Button casesPerCityButton;
        private Button percentageOfPositiveTestsButton;
        private Button showAllCitiesButton;
        private Button deleteCityButton;
        private Button updateCityButton;
        private DataGridView citiesDataGridView;
        private Button addCityButton;
        private DataGridViewTextBoxColumn city_city_id;
        private DataGridViewTextBoxColumn city_city_name;
        private DataGridViewTextBoxColumn city_country_name;
        private Label hospitalized_label;
        private Label severity_label;
        private Label patient_state_label;
        private Label covid_variant_label;
        private Label infected_by_label;
        private Label test_id_label;
        private Label case_id_label;
        private TextBox hospitalized_textBox;
        private TextBox severity_textBox;
        private TextBox patient_state_textBox;
        private TextBox covid_variant_textBox;
        private TextBox infected_by_textBox;
        private TextBox test_id_textBox;
        private TextBox case_id_textBox;
        private Button caseResetButton;
        private Label caseMessageLabel;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox test_person_id_textBox;
        private TextBox test_city_id_textBox;
        private TextBox test_test_id_textBox;
        private TextBox test_date_textBox;
        private Label testMessageLabel;
        private TextBox positive_textBox;
        private TextBox person_vaccine_doses_textBox;
        private Button button14;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox person_birth_date_textBox;
        private TextBox person_fullname_textBox;
        private TextBox person_person_id_textBox;
        private TextBox person_comorbidities_textBox;
        private Label personMessageLabel;
        private Label cityMessageLabel;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox city_country_name_textBox;
        private TextBox city_city_name_textBox;
        private TextBox city_city_id_textBox;
        private Button button15;
        private Button casesButton;
        private DataGridView citiesStatsData;
        private DataGridView personsDataGrid;
        private DataGridView casesDataGrid;
        private DataGridView testsDataGrid;
    }
}