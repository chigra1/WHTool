namespace WorkingHours.UI
{
    partial class AdminMainForm
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
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowInternalEmployees = new System.Windows.Forms.Button();
            this.btnShowExternalEmployees = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddWorkingHours = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumberOFHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHours = new System.Windows.Forms.DataGridView();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(543, 176);
            this.dataGridViewProjects.TabIndex = 0;
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.Location = new System.Drawing.Point(17, 19);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.Size = new System.Drawing.Size(109, 23);
            this.btnShowAllEmployees.TabIndex = 2;
            this.btnShowAllEmployees.Text = "Show All Employess";
            this.btnShowAllEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(18, 48);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(376, 147);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProjects);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowInternalEmployees);
            this.groupBox2.Controls.Add(this.btnShowExternalEmployees);
            this.groupBox2.Controls.Add(this.dataGridViewEmployees);
            this.groupBox2.Controls.Add(this.btnShowAllEmployees);
            this.groupBox2.Location = new System.Drawing.Point(703, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // btnShowInternalEmployees
            // 
            this.btnShowInternalEmployees.Location = new System.Drawing.Point(247, 19);
            this.btnShowInternalEmployees.Name = "btnShowInternalEmployees";
            this.btnShowInternalEmployees.Size = new System.Drawing.Size(109, 23);
            this.btnShowInternalEmployees.TabIndex = 5;
            this.btnShowInternalEmployees.Text = "Show Internal";
            this.btnShowInternalEmployees.UseVisualStyleBackColor = true;
            this.btnShowInternalEmployees.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnShowExternalEmployees
            // 
            this.btnShowExternalEmployees.Location = new System.Drawing.Point(132, 19);
            this.btnShowExternalEmployees.Name = "btnShowExternalEmployees";
            this.btnShowExternalEmployees.Size = new System.Drawing.Size(109, 23);
            this.btnShowExternalEmployees.TabIndex = 4;
            this.btnShowExternalEmployees.Text = "Show External";
            this.btnShowExternalEmployees.UseVisualStyleBackColor = true;
            this.btnShowExternalEmployees.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(12, 234);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 6;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddWorkingHours);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Calendar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbNumberOFHours);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbProjects);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 251);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add working hours";
            // 
            // btnAddWorkingHours
            // 
            this.btnAddWorkingHours.Location = new System.Drawing.Point(430, 210);
            this.btnAddWorkingHours.Name = "btnAddWorkingHours";
            this.btnAddWorkingHours.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorkingHours.TabIndex = 6;
            this.btnAddWorkingHours.Text = "Add";
            this.btnAddWorkingHours.UseVisualStyleBackColor = true;
            this.btnAddWorkingHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Date:";
            // 
            // Calendar
            // 
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Location = new System.Drawing.Point(278, 36);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of hours";
            // 
            // tbNumberOFHours
            // 
            this.tbNumberOFHours.Location = new System.Drawing.Point(95, 47);
            this.tbNumberOFHours.Name = "tbNumberOFHours";
            this.tbNumberOFHours.Size = new System.Drawing.Size(121, 20);
            this.tbNumberOFHours.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name";
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(95, 20);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(121, 21);
            this.cmbProjects.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1038, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewHours);
            this.groupBox4.Location = new System.Drawing.Point(599, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 251);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Working Hours";
            // 
            // dataGridViewHours
            // 
            this.dataGridViewHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHours.Location = new System.Drawing.Point(7, 28);
            this.dataGridViewHours.Name = "dataGridViewHours";
            this.dataGridViewHours.Size = new System.Drawing.Size(418, 205);
            this.dataGridViewHours.TabIndex = 0;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(672, 252);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(118, 21);
            this.cmbMonth.TabIndex = 10;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Month";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 582);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminMainForm";
            this.ShowIcon = false;
            this.Text = "Working Hours";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowAllEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnShowInternalEmployees;
        private System.Windows.Forms.Button btnShowExternalEmployees;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddWorkingHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumberOFHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewHours;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridViewProjects;
    }
}

