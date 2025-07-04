namespace University_Portal
{
    partial class StudentDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.defPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbMessages = new System.Windows.Forms.ComboBox();
            this.cmbOthers = new System.Windows.Forms.ComboBox();
            this.cmbLibrary = new System.Windows.Forms.ComboBox();
            this.cmbGradeReports = new System.Windows.Forms.ComboBox();
            this.cmbAcademics = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CandRlbl = new System.Windows.Forms.Label();
            this.Reglbl = new System.Windows.Forms.Label();
            this.GradeRlbl = new System.Windows.Forms.Label();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.btnNotification = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UandPpnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.defPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.UandPpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.defPnl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 661);
            this.panel1.TabIndex = 0;
            // 
            // defPnl
            // 
            this.defPnl.Controls.Add(this.panel3);
            this.defPnl.Location = new System.Drawing.Point(275, 116);
            this.defPnl.Name = "defPnl";
            this.defPnl.Size = new System.Drawing.Size(1297, 545);
            this.defPnl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmbMessages);
            this.panel2.Controls.Add(this.cmbOthers);
            this.panel2.Controls.Add(this.cmbLibrary);
            this.panel2.Controls.Add(this.cmbGradeReports);
            this.panel2.Controls.Add(this.cmbAcademics);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 236);
            this.panel2.TabIndex = 0;
            // 
            // cmbMessages
            // 
            this.cmbMessages.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbMessages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMessages.ForeColor = System.Drawing.Color.White;
            this.cmbMessages.FormattingEnabled = true;
            this.cmbMessages.Location = new System.Drawing.Point(0, 205);
            this.cmbMessages.Name = "cmbMessages";
            this.cmbMessages.Size = new System.Drawing.Size(244, 28);
            this.cmbMessages.TabIndex = 5;
            this.cmbMessages.Text = "Messages";
            // 
            // cmbOthers
            // 
            this.cmbOthers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbOthers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOthers.ForeColor = System.Drawing.Color.White;
            this.cmbOthers.FormattingEnabled = true;
            this.cmbOthers.Location = new System.Drawing.Point(0, 159);
            this.cmbOthers.Name = "cmbOthers";
            this.cmbOthers.Size = new System.Drawing.Size(244, 28);
            this.cmbOthers.TabIndex = 4;
            this.cmbOthers.Text = "Others";
            // 
            // cmbLibrary
            // 
            this.cmbLibrary.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibrary.ForeColor = System.Drawing.Color.White;
            this.cmbLibrary.FormattingEnabled = true;
            this.cmbLibrary.Location = new System.Drawing.Point(0, 113);
            this.cmbLibrary.Name = "cmbLibrary";
            this.cmbLibrary.Size = new System.Drawing.Size(244, 28);
            this.cmbLibrary.TabIndex = 3;
            this.cmbLibrary.Text = "Library";
            // 
            // cmbGradeReports
            // 
            this.cmbGradeReports.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbGradeReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGradeReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeReports.ForeColor = System.Drawing.Color.White;
            this.cmbGradeReports.FormattingEnabled = true;
            this.cmbGradeReports.Location = new System.Drawing.Point(0, 69);
            this.cmbGradeReports.Name = "cmbGradeReports";
            this.cmbGradeReports.Size = new System.Drawing.Size(244, 28);
            this.cmbGradeReports.TabIndex = 2;
            this.cmbGradeReports.Text = "Grade Reports";
            // 
            // cmbAcademics
            // 
            this.cmbAcademics.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbAcademics.AllowDrop = true;
            this.cmbAcademics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbAcademics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAcademics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademics.ForeColor = System.Drawing.Color.White;
            this.cmbAcademics.FormattingEnabled = true;
            this.cmbAcademics.Items.AddRange(new object[] {
            "Course & Results",
            "Registration",
            "Drop Application",
            "Offered Courses",
            "My Curriculum",
            "Financials"});
            this.cmbAcademics.Location = new System.Drawing.Point(0, 24);
            this.cmbAcademics.Name = "cmbAcademics";
            this.cmbAcademics.Size = new System.Drawing.Size(244, 28);
            this.cmbAcademics.TabIndex = 1;
            this.cmbAcademics.Text = "Academics";
            this.cmbAcademics.SelectedIndexChanged += new System.EventHandler(this.cmbAcademics_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnNotification);
            this.metroPanel1.Controls.Add(this.btnSetting);
            this.metroPanel1.Controls.Add(this.btnLogOut);
            this.metroPanel1.Controls.Add(this.welcomelbl);
            this.metroPanel1.Controls.Add(this.GradeRlbl);
            this.metroPanel1.Controls.Add(this.Reglbl);
            this.metroPanel1.Controls.Add(this.CandRlbl);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 23);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1560, 87);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CandRlbl
            // 
            this.CandRlbl.AutoSize = true;
            this.CandRlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandRlbl.Location = new System.Drawing.Point(259, 35);
            this.CandRlbl.Name = "CandRlbl";
            this.CandRlbl.Size = new System.Drawing.Size(178, 23);
            this.CandRlbl.TabIndex = 3;
            this.CandRlbl.Text = "Courses and Results";
            this.CandRlbl.Click += new System.EventHandler(this.CandRlbl_Click);
            // 
            // Reglbl
            // 
            this.Reglbl.AutoSize = true;
            this.Reglbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reglbl.Location = new System.Drawing.Point(521, 35);
            this.Reglbl.Name = "Reglbl";
            this.Reglbl.Size = new System.Drawing.Size(111, 23);
            this.Reglbl.TabIndex = 4;
            this.Reglbl.Text = "Registration";
            this.Reglbl.Click += new System.EventHandler(this.Reglbl_Click);
            // 
            // GradeRlbl
            // 
            this.GradeRlbl.AutoSize = true;
            this.GradeRlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeRlbl.Location = new System.Drawing.Point(719, 35);
            this.GradeRlbl.Name = "GradeRlbl";
            this.GradeRlbl.Size = new System.Drawing.Size(122, 23);
            this.GradeRlbl.TabIndex = 5;
            this.GradeRlbl.Text = "Grade Report";
            this.GradeRlbl.Click += new System.EventHandler(this.GradeRlbl_Click);
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(961, 35);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(89, 23);
            this.welcomelbl.TabIndex = 6;
            this.welcomelbl.Text = "Welcome";
            // 
            // btnNotification
            // 
            this.btnNotification.Image = global::University_Portal.Properties.Resources.bell;
            this.btnNotification.Location = new System.Drawing.Point(1310, 18);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(51, 40);
            this.btnNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNotification.TabIndex = 9;
            this.btnNotification.TabStop = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::University_Portal.Properties.Resources.settings;
            this.btnSetting.Location = new System.Drawing.Point(1398, 18);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(51, 40);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting.TabIndex = 8;
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::University_Portal.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(1487, 18);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(51, 40);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.UandPpnl);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(17, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 141);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please use this below information for log in to Microsoft Teams.";
            // 
            // UandPpnl
            // 
            this.UandPpnl.Controls.Add(this.label3);
            this.UandPpnl.Controls.Add(this.label2);
            this.UandPpnl.Location = new System.Drawing.Point(16, 34);
            this.UandPpnl.Name = "UandPpnl";
            this.UandPpnl.Size = new System.Drawing.Size(385, 93);
            this.UandPpnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password   :";
            // 
            // StudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1584, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentDashBoard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.defPnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.UandPpnl.ResumeLayout(false);
            this.UandPpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel defPnl;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ComboBox cmbLibrary;
        private System.Windows.Forms.ComboBox cmbGradeReports;
        private System.Windows.Forms.ComboBox cmbMessages;
        private System.Windows.Forms.ComboBox cmbOthers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CandRlbl;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label GradeRlbl;
        private System.Windows.Forms.Label Reglbl;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.PictureBox btnSetting;
        private System.Windows.Forms.PictureBox btnNotification;
        private System.Windows.Forms.ComboBox cmbAcademics;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel UandPpnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}