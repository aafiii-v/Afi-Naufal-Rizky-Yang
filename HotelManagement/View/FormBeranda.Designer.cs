﻿namespace HotelManagement.View
{
    partial class FormBeranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeranda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelCloseApplication = new System.Windows.Forms.Label();
            this.PanelNavigasi = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnLogoutBeranda = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdminControl = new Guna.UI2.WinForms.Guna2Button();
            this.CirclePictureBoxHotel = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LabelHotelName = new System.Windows.Forms.Label();
            this.PanelNavigasion = new System.Windows.Forms.Panel();
            this.AdminRooms = new HotelManagement.AdminRooms();
            this.Dashboard = new HotelManagement.View.Dashboard();
            this.AdminControl = new HotelManagement.View.AdminControl();
            this.panel3.SuspendLayout();
            this.PanelNavigasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 860);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1784, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 860);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.LabelCloseApplication);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1754, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 860);
            this.panel3.TabIndex = 2;
            // 
            // LabelCloseApplication
            // 
            this.LabelCloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCloseApplication.AutoSize = true;
            this.LabelCloseApplication.BackColor = System.Drawing.Color.Silver;
            this.LabelCloseApplication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCloseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelCloseApplication.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCloseApplication.ForeColor = System.Drawing.Color.Red;
            this.LabelCloseApplication.Location = new System.Drawing.Point(-1, 0);
            this.LabelCloseApplication.Name = "LabelCloseApplication";
            this.LabelCloseApplication.Size = new System.Drawing.Size(32, 35);
            this.LabelCloseApplication.TabIndex = 30;
            this.LabelCloseApplication.Text = "X";
            this.LabelCloseApplication.Click += new System.EventHandler(this.LabelCloseApplication_Click);
            // 
            // PanelNavigasi
            // 
            this.PanelNavigasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelNavigasi.BorderRadius = 1;
            this.PanelNavigasi.Controls.Add(this.BtnLogoutBeranda);
            this.PanelNavigasi.Controls.Add(this.BtnDashboard);
            this.PanelNavigasi.Controls.Add(this.guna2Button1);
            this.PanelNavigasi.Controls.Add(this.BtnRooms);
            this.PanelNavigasi.Controls.Add(this.BtnAdminControl);
            this.PanelNavigasi.Controls.Add(this.CirclePictureBoxHotel);
            this.PanelNavigasi.Controls.Add(this.LabelHotelName);
            this.PanelNavigasi.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelNavigasi.Location = new System.Drawing.Point(30, 30);
            this.PanelNavigasi.Name = "PanelNavigasi";
            this.PanelNavigasi.Size = new System.Drawing.Size(450, 830);
            this.PanelNavigasi.TabIndex = 31;
            // 
            // BtnLogoutBeranda
            // 
            this.BtnLogoutBeranda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLogoutBeranda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogoutBeranda.BorderColor = System.Drawing.Color.White;
            this.BtnLogoutBeranda.BorderRadius = 2;
            this.BtnLogoutBeranda.BorderThickness = 2;
            this.BtnLogoutBeranda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogoutBeranda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogoutBeranda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogoutBeranda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogoutBeranda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogoutBeranda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLogoutBeranda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogoutBeranda.ForeColor = System.Drawing.Color.White;
            this.BtnLogoutBeranda.Location = new System.Drawing.Point(22, 767);
            this.BtnLogoutBeranda.Name = "BtnLogoutBeranda";
            this.BtnLogoutBeranda.Size = new System.Drawing.Size(408, 47);
            this.BtnLogoutBeranda.TabIndex = 37;
            this.BtnLogoutBeranda.Text = "LogOut";
            this.BtnLogoutBeranda.Click += new System.EventHandler(this.BtnLogoutBeranda_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDashboard.BorderColor = System.Drawing.Color.White;
            this.BtnDashboard.BorderRadius = 2;
            this.BtnDashboard.BorderThickness = 2;
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Location = new System.Drawing.Point(78, 277);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(300, 80);
            this.BtnDashboard.TabIndex = 36;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(78, 656);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(300, 80);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "CUSTOMERS";
            // 
            // BtnRooms
            // 
            this.BtnRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRooms.BorderColor = System.Drawing.Color.White;
            this.BtnRooms.BorderRadius = 2;
            this.BtnRooms.BorderThickness = 2;
            this.BtnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRooms.ForeColor = System.Drawing.Color.White;
            this.BtnRooms.Location = new System.Drawing.Point(78, 531);
            this.BtnRooms.Name = "BtnRooms";
            this.BtnRooms.Size = new System.Drawing.Size(300, 80);
            this.BtnRooms.TabIndex = 34;
            this.BtnRooms.Text = "ROOMS";
            this.BtnRooms.Click += new System.EventHandler(this.BtnRooms_Click);
            // 
            // BtnAdminControl
            // 
            this.BtnAdminControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdminControl.BorderColor = System.Drawing.Color.White;
            this.BtnAdminControl.BorderRadius = 2;
            this.BtnAdminControl.BorderThickness = 2;
            this.BtnAdminControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdminControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdminControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdminControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdminControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdminControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdminControl.ForeColor = System.Drawing.Color.White;
            this.BtnAdminControl.Location = new System.Drawing.Point(78, 404);
            this.BtnAdminControl.Name = "BtnAdminControl";
            this.BtnAdminControl.Size = new System.Drawing.Size(300, 80);
            this.BtnAdminControl.TabIndex = 33;
            this.BtnAdminControl.Text = "ADMIN";
            this.BtnAdminControl.Click += new System.EventHandler(this.BtnAdminControl_Click);
            // 
            // CirclePictureBoxHotel
            // 
            this.CirclePictureBoxHotel.BackColor = System.Drawing.Color.Transparent;
            this.CirclePictureBoxHotel.FillColor = System.Drawing.Color.Transparent;
            this.CirclePictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("CirclePictureBoxHotel.Image")));
            this.CirclePictureBoxHotel.ImageRotate = 0F;
            this.CirclePictureBoxHotel.Location = new System.Drawing.Point(140, 10);
            this.CirclePictureBoxHotel.Name = "CirclePictureBoxHotel";
            this.CirclePictureBoxHotel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CirclePictureBoxHotel.Size = new System.Drawing.Size(170, 170);
            this.CirclePictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CirclePictureBoxHotel.TabIndex = 32;
            this.CirclePictureBoxHotel.TabStop = false;
            this.CirclePictureBoxHotel.UseTransparentBackground = true;
            // 
            // LabelHotelName
            // 
            this.LabelHotelName.AutoSize = true;
            this.LabelHotelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelHotelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHotelName.ForeColor = System.Drawing.Color.White;
            this.LabelHotelName.Location = new System.Drawing.Point(19, 193);
            this.LabelHotelName.Name = "LabelHotelName";
            this.LabelHotelName.Size = new System.Drawing.Size(407, 34);
            this.LabelHotelName.TabIndex = 31;
            this.LabelHotelName.Text = "Management Hotel System";
            // 
            // PanelNavigasion
            // 
            this.PanelNavigasion.BackColor = System.Drawing.Color.Black;
            this.PanelNavigasion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavigasion.Location = new System.Drawing.Point(30, 0);
            this.PanelNavigasion.Name = "PanelNavigasion";
            this.PanelNavigasion.Size = new System.Drawing.Size(1724, 30);
            this.PanelNavigasion.TabIndex = 2;
            // 
            // AdminRooms
            // 
            this.AdminRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminRooms.Location = new System.Drawing.Point(479, 30);
            this.AdminRooms.Name = "AdminRooms";
            this.AdminRooms.Size = new System.Drawing.Size(1275, 830);
            this.AdminRooms.TabIndex = 34;
            // 
            // Dashboard
            // 
            this.Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dashboard.Location = new System.Drawing.Point(479, 30);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(1275, 830);
            this.Dashboard.TabIndex = 33;
            // 
            // AdminControl
            // 
            this.AdminControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminControl.BackColor = System.Drawing.Color.Gray;
            this.AdminControl.Location = new System.Drawing.Point(480, 30);
            this.AdminControl.Name = "AdminControl";
            this.AdminControl.Size = new System.Drawing.Size(1274, 830);
            this.AdminControl.TabIndex = 32;
            // 
            // FormBeranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1784, 890);
            this.Controls.Add(this.AdminRooms);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.AdminControl);
            this.Controls.Add(this.PanelNavigasi);
            this.Controls.Add(this.PanelNavigasion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "FormBeranda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBeranda_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelNavigasi.ResumeLayout(false);
            this.PanelNavigasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBoxHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Panel PanelNavigasi;
        private System.Windows.Forms.Label LabelHotelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBoxHotel;
        private System.Windows.Forms.Label LabelCloseApplication;
        private System.Windows.Forms.Panel PanelNavigasion;
        private Guna.UI2.WinForms.Guna2Button BtnAdminControl;
        private Guna.UI2.WinForms.Guna2Button BtnLogoutBeranda;
        private Guna.UI2.WinForms.Guna2Button BtnDashboard;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BtnRooms;
        private AdminControl AdminControl;
        private Dashboard Dashboard;
        private AdminRooms AdminRooms;
    }
}