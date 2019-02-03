namespace WorkingHours.UI
{
    partial class AddProject
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(119, 27);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Location = new System.Drawing.Point(119, 66);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(100, 20);
            this.txtProjectCode.TabIndex = 1;
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(119, 103);
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(100, 20);
            this.txtProjectDescription.TabIndex = 2;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(119, 195);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(119, 139);
            this.chkActive.Name = "chkActive";
            this.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 4;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(35, 30);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(71, 13);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Location = new System.Drawing.Point(35, 69);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(68, 13);
            this.lblProjectCode.TabIndex = 6;
            this.lblProjectCode.Text = "Project Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(35, 106);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 230);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectCode);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtProjectCode);
            this.Controls.Add(this.txtProjectName);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
    }
}