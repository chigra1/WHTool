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
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkingHours
            // 
            this.dgvWorkingHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkingHours.Location = new System.Drawing.Point(291, 12);
            this.dgvWorkingHours.Name = "dgvWorkingHours";
            this.dgvWorkingHours.Size = new System.Drawing.Size(786, 363);
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
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 611);
            this.Controls.Add(this.tbNumberOFHours);
            this.Controls.Add(this.btnAddWorkingHours);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dgvWorkingHours);
            this.Name = "UserMainForm";
            this.Text = "AdminMainForm";
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
    }
}