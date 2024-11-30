namespace HotelManagement.View
{
    partial class AdminControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.BtnDeleteAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClearAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBoxDataAdmin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GridviewDataAdmin = new System.Windows.Forms.DataGridView();
            this.GroupBoxDataAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewDataAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxUsername.BorderRadius = 5;
            this.TextBoxUsername.BorderThickness = 2;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.DefaultText = "";
            this.TextBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.Enabled = false;
            this.TextBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUsername.Location = new System.Drawing.Point(56, 137);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.PlaceholderText = "";
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.Size = new System.Drawing.Size(395, 37);
            this.TextBoxUsername.TabIndex = 21;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.BackColor = System.Drawing.Color.White;
            this.LabelUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.Black;
            this.LabelUsername.Location = new System.Drawing.Point(52, 112);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(102, 21);
            this.LabelUsername.TabIndex = 25;
            this.LabelUsername.Text = "Username";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPassword.BorderRadius = 5;
            this.TextBoxPassword.BorderThickness = 2;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.Enabled = false;
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(56, 224);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.PlaceholderText = "";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.Size = new System.Drawing.Size(395, 37);
            this.TextBoxPassword.TabIndex = 26;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.White;
            this.LabelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.Black;
            this.LabelPassword.Location = new System.Drawing.Point(52, 199);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(98, 21);
            this.LabelPassword.TabIndex = 27;
            this.LabelPassword.Text = "Password";
            // 
            // BtnDeleteAdmin
            // 
            this.BtnDeleteAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDeleteAdmin.BorderColor = System.Drawing.Color.White;
            this.BtnDeleteAdmin.BorderRadius = 25;
            this.BtnDeleteAdmin.BorderThickness = 2;
            this.BtnDeleteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDeleteAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAdmin.Location = new System.Drawing.Point(93, 354);
            this.BtnDeleteAdmin.Name = "BtnDeleteAdmin";
            this.BtnDeleteAdmin.Size = new System.Drawing.Size(300, 60);
            this.BtnDeleteAdmin.TabIndex = 36;
            this.BtnDeleteAdmin.Text = "DELETE";
            this.BtnDeleteAdmin.Click += new System.EventHandler(this.BtnDeleteAdmin_Click);
            // 
            // BtnClearAdmin
            // 
            this.BtnClearAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClearAdmin.BorderColor = System.Drawing.Color.White;
            this.BtnClearAdmin.BorderRadius = 25;
            this.BtnClearAdmin.BorderThickness = 2;
            this.BtnClearAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClearAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClearAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClearAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClearAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClearAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnClearAdmin.Location = new System.Drawing.Point(93, 458);
            this.BtnClearAdmin.Name = "BtnClearAdmin";
            this.BtnClearAdmin.Size = new System.Drawing.Size(300, 60);
            this.BtnClearAdmin.TabIndex = 37;
            this.BtnClearAdmin.Text = "CLEAR";
            this.BtnClearAdmin.Click += new System.EventHandler(this.BtnClearAdmin_Click);
            // 
            // GroupBoxDataAdmin
            // 
            this.GroupBoxDataAdmin.BackColor = System.Drawing.Color.White;
            this.GroupBoxDataAdmin.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBoxDataAdmin.Controls.Add(this.GridviewDataAdmin);
            this.GroupBoxDataAdmin.Controls.Add(this.BtnClearAdmin);
            this.GroupBoxDataAdmin.Controls.Add(this.BtnDeleteAdmin);
            this.GroupBoxDataAdmin.Controls.Add(this.LabelPassword);
            this.GroupBoxDataAdmin.Controls.Add(this.TextBoxPassword);
            this.GroupBoxDataAdmin.Controls.Add(this.LabelUsername);
            this.GroupBoxDataAdmin.Controls.Add(this.TextBoxUsername);
            this.GroupBoxDataAdmin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxDataAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxDataAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxDataAdmin.ForeColor = System.Drawing.Color.White;
            this.GroupBoxDataAdmin.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxDataAdmin.Name = "GroupBoxDataAdmin";
            this.GroupBoxDataAdmin.Size = new System.Drawing.Size(1199, 809);
            this.GroupBoxDataAdmin.TabIndex = 1;
            this.GroupBoxDataAdmin.Text = "Data Admin";
            // 
            // GridviewDataAdmin
            // 
            this.GridviewDataAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridviewDataAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridviewDataAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridviewDataAdmin.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridviewDataAdmin.GridColor = System.Drawing.Color.Silver;
            this.GridviewDataAdmin.Location = new System.Drawing.Point(505, 70);
            this.GridviewDataAdmin.Name = "GridviewDataAdmin";
            this.GridviewDataAdmin.RowHeadersWidth = 51;
            this.GridviewDataAdmin.RowTemplate.Height = 24;
            this.GridviewDataAdmin.Size = new System.Drawing.Size(660, 453);
            this.GridviewDataAdmin.TabIndex = 39;
            this.GridviewDataAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewDataAdmin_CellClick);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.GroupBoxDataAdmin);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(1199, 809);
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.GroupBoxDataAdmin.ResumeLayout(false);
            this.GroupBoxDataAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewDataAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelUsername;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteAdmin;
        private Guna.UI2.WinForms.Guna2Button BtnClearAdmin;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxDataAdmin;
        protected System.Windows.Forms.DataGridView GridviewDataAdmin;
    }
}
