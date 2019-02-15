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
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.btnAddWorkingHours = new System.Windows.Forms.Button();
            this.tbNumberOFHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calendar = new Calendar.NET.Calendar();
            this.SuspendLayout();
            // 
            // cmbProjects
            // 
            this.cmbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.ItemHeight = 24;
            this.cmbProjects.Location = new System.Drawing.Point(45, 94);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(227, 32);
            this.cmbProjects.TabIndex = 2;
            // 
            // btnAddWorkingHours
            // 
            this.btnAddWorkingHours.Location = new System.Drawing.Point(45, 161);
            this.btnAddWorkingHours.Name = "btnAddWorkingHours";
            this.btnAddWorkingHours.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorkingHours.TabIndex = 4;
            this.btnAddWorkingHours.Text = "Add Hours";
            this.btnAddWorkingHours.UseVisualStyleBackColor = true;
            this.btnAddWorkingHours.Click += new System.EventHandler(this.btnAddWorkingHours_Click);
            // 
            // tbNumberOFHours
            // 
            this.tbNumberOFHours.Location = new System.Drawing.Point(136, 132);
            this.tbNumberOFHours.Name = "tbNumberOFHours";
            this.tbNumberOFHours.Size = new System.Drawing.Size(100, 20);
            this.tbNumberOFHours.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Project:";
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
            this.calendar.Size = new System.Drawing.Size(1060, 673);
            this.calendar.TabIndex = 6;
            this.calendar.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.tbNumberOFHours);
            this.Controls.Add(this.btnAddWorkingHours);
            this.Controls.Add(this.cmbProjects);
            this.Name = "UserMainForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Button btnAddWorkingHours;
        private System.Windows.Forms.TextBox tbNumberOFHours;
        private Calendar.NET.Calendar calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}