namespace WorkingHours.UI
{
    partial class UserMainForm
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
            this.dgvWorkingHours = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.btnAddWorkingHours = new System.Windows.Forms.Button();
            this.tbNumberOFHours = new System.Windows.Forms.TextBox();
            this.calendar = new Calendar.NET.Calendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkingHours
            // 
            this.dgvWorkingHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkingHours.Location = new System.Drawing.Point(12, 442);
            this.dgvWorkingHours.Name = "dgvWorkingHours";
            this.dgvWorkingHours.Size = new System.Drawing.Size(158, 118);
            this.dgvWorkingHours.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(29, 203);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(227, 21);
            this.cmbProjects.TabIndex = 2;
            // 
            // btnAddWorkingHours
            // 
            this.btnAddWorkingHours.Location = new System.Drawing.Point(29, 257);
            this.btnAddWorkingHours.Name = "btnAddWorkingHours";
            this.btnAddWorkingHours.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorkingHours.TabIndex = 4;
            this.btnAddWorkingHours.Text = "Add Hours";
            this.btnAddWorkingHours.UseVisualStyleBackColor = true;
            this.btnAddWorkingHours.Click += new System.EventHandler(this.btnAddWorkingHours_Click);
            // 
            // tbNumberOFHours
            // 
            this.tbNumberOFHours.Location = new System.Drawing.Point(29, 231);
            this.tbNumberOFHours.Name = "tbNumberOFHours";
            this.tbNumberOFHours.Size = new System.Drawing.Size(100, 20);
            this.tbNumberOFHours.TabIndex = 5;
            // 
            // calendar
            // 
            this.calendar.AllowEditingEvents = true;
            this.calendar.CalendarDate = new System.DateTime(2019, 2, 10, 19, 11, 44, 308);
            this.calendar.CalendarView = Calendar.NET.CalendarViews.Month;
            this.calendar.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.calendar.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.calendar.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.calendar.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar.DimDisabledEvents = true;
            this.calendar.HighlightCurrentDay = true;
            this.calendar.LoadPresetHolidays = true;
            this.calendar.Location = new System.Drawing.Point(278, 12);
            this.calendar.Name = "calendar";
            this.calendar.ShowArrowControls = true;
            this.calendar.ShowDashedBorderOnDisabledEvents = true;
            this.calendar.ShowDateInHeader = true;
            this.calendar.ShowDisabledEvents = false;
            this.calendar.ShowEventTooltips = true;
            this.calendar.ShowTodayButton = true;
            this.calendar.Size = new System.Drawing.Size(1060, 689);
            this.calendar.TabIndex = 6;
            this.calendar.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calendar_MouseClick);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.tbNumberOFHours);
            this.Controls.Add(this.btnAddWorkingHours);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dgvWorkingHours);
            this.Name = "UserMainForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkingHours;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Button btnAddWorkingHours;
        private System.Windows.Forms.TextBox tbNumberOFHours;
        private Calendar.NET.Calendar calendar;
    }
}