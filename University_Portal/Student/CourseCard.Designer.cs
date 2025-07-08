namespace University_Portal.Student
{
    partial class CourseCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel8 = new System.Windows.Forms.Panel();
            this.flpGrades = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSectionStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            this.flpGrades.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.flpGrades);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1258, 319);
            this.panel8.TabIndex = 5;
            // 
            // flpGrades
            // 
            this.flpGrades.AutoScroll = true;
            this.flpGrades.Controls.Add(this.panel10);
            this.flpGrades.Controls.Add(this.panel11);
            this.flpGrades.Controls.Add(this.panel12);
            this.flpGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGrades.Location = new System.Drawing.Point(0, 0);
            this.flpGrades.Name = "flpGrades";
            this.flpGrades.Size = new System.Drawing.Size(1258, 319);
            this.flpGrades.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Controls.Add(this.lblResult);
            this.panel10.Controls.Add(this.lblStatus);
            this.panel10.Controls.Add(this.lblSectionStatus);
            this.panel10.Controls.Add(this.lblTitle);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(279, 162);
            this.panel10.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(125, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label9";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(44, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label8";
            // 
            // lblSectionStatus
            // 
            this.lblSectionStatus.AutoSize = true;
            this.lblSectionStatus.Location = new System.Drawing.Point(44, 54);
            this.lblSectionStatus.Name = "lblSectionStatus";
            this.lblSectionStatus.Size = new System.Drawing.Size(35, 13);
            this.lblSectionStatus.TabIndex = 1;
            this.lblSectionStatus.Text = "label7";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(44, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label6";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Location = new System.Drawing.Point(288, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(279, 162);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(573, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(279, 162);
            this.panel12.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(285, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(279, 162);
            this.panel13.TabIndex = 1;
            // 
            // CourseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Name = "CourseCard";
            this.Size = new System.Drawing.Size(1258, 319);
            this.panel8.ResumeLayout(false);
            this.flpGrades.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flpGrades;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSectionStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}
