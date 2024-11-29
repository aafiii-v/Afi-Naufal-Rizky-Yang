namespace HotelManagement
{
    partial class AdminRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxDataRooms = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GridviewDataRooms = new System.Windows.Forms.DataGridView();
            this.LabelCloseDataRooms = new System.Windows.Forms.Label();
            this.PanelSelectRoom = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClearRoom = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxTypeRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxIdRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxStatusRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelStatusRoom = new System.Windows.Forms.Label();
            this.labelTypeRoom = new System.Windows.Forms.Label();
            this.labelIdRoom = new System.Windows.Forms.Label();
            this.GroupBoxDataRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewDataRooms)).BeginInit();
            this.PanelSelectRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxDataRooms
            // 
            this.GroupBoxDataRooms.Controls.Add(this.GridviewDataRooms);
            this.GroupBoxDataRooms.Controls.Add(this.LabelCloseDataRooms);
            this.GroupBoxDataRooms.Controls.Add(this.PanelSelectRoom);
            this.GroupBoxDataRooms.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxDataRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxDataRooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxDataRooms.ForeColor = System.Drawing.Color.White;
            this.GroupBoxDataRooms.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxDataRooms.Name = "GroupBoxDataRooms";
            this.GroupBoxDataRooms.Size = new System.Drawing.Size(1199, 809);
            this.GroupBoxDataRooms.TabIndex = 2;
            this.GroupBoxDataRooms.Text = "Data Rooms";
            // 
            // GridviewDataRooms
            // 
            this.GridviewDataRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridviewDataRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridviewDataRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridviewDataRooms.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridviewDataRooms.GridColor = System.Drawing.Color.Silver;
            this.GridviewDataRooms.Location = new System.Drawing.Point(97, 63);
            this.GridviewDataRooms.Name = "GridviewDataRooms";
            this.GridviewDataRooms.RowHeadersWidth = 51;
            this.GridviewDataRooms.RowTemplate.Height = 24;
            this.GridviewDataRooms.Size = new System.Drawing.Size(1010, 374);
            this.GridviewDataRooms.TabIndex = 45;
            this.GridviewDataRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewDataRooms_CellClick);
            // 
            // LabelCloseDataRooms
            // 
            this.LabelCloseDataRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCloseDataRooms.AutoSize = true;
            this.LabelCloseDataRooms.BackColor = System.Drawing.Color.Silver;
            this.LabelCloseDataRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCloseDataRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCloseDataRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelCloseDataRooms.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCloseDataRooms.ForeColor = System.Drawing.Color.Red;
            this.LabelCloseDataRooms.Location = new System.Drawing.Point(1164, 2);
            this.LabelCloseDataRooms.Name = "LabelCloseDataRooms";
            this.LabelCloseDataRooms.Size = new System.Drawing.Size(32, 35);
            this.LabelCloseDataRooms.TabIndex = 44;
            this.LabelCloseDataRooms.Text = "X";
            this.LabelCloseDataRooms.Click += new System.EventHandler(this.LabelCloseDataRooms_Click);
            // 
            // PanelSelectRoom
            // 
            this.PanelSelectRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSelectRoom.Controls.Add(this.BtnClearRoom);
            this.PanelSelectRoom.Controls.Add(this.TextBoxTypeRoom);
            this.PanelSelectRoom.Controls.Add(this.BtnDeleteRoom);
            this.PanelSelectRoom.Controls.Add(this.BtnUpdateRoom);
            this.PanelSelectRoom.Controls.Add(this.TextBoxIdRoom);
            this.PanelSelectRoom.Controls.Add(this.BtnAddRoom);
            this.PanelSelectRoom.Controls.Add(this.ComboBoxStatusRoom);
            this.PanelSelectRoom.Controls.Add(this.labelStatusRoom);
            this.PanelSelectRoom.Controls.Add(this.labelTypeRoom);
            this.PanelSelectRoom.Controls.Add(this.labelIdRoom);
            this.PanelSelectRoom.Location = new System.Drawing.Point(97, 463);
            this.PanelSelectRoom.Name = "PanelSelectRoom";
            this.PanelSelectRoom.Size = new System.Drawing.Size(1010, 288);
            this.PanelSelectRoom.TabIndex = 39;
            // 
            // BtnClearRoom
            // 
            this.BtnClearRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClearRoom.BorderColor = System.Drawing.Color.Transparent;
            this.BtnClearRoom.BorderRadius = 25;
            this.BtnClearRoom.BorderThickness = 2;
            this.BtnClearRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClearRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClearRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClearRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClearRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClearRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearRoom.ForeColor = System.Drawing.Color.White;
            this.BtnClearRoom.Location = new System.Drawing.Point(734, 205);
            this.BtnClearRoom.Name = "BtnClearRoom";
            this.BtnClearRoom.Size = new System.Drawing.Size(182, 60);
            this.BtnClearRoom.TabIndex = 49;
            this.BtnClearRoom.Text = "CLEAR";
            this.BtnClearRoom.Click += new System.EventHandler(this.BtnClearRoom_Click);
            // 
            // TextBoxTypeRoom
            // 
            this.TextBoxTypeRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxTypeRoom.BorderRadius = 5;
            this.TextBoxTypeRoom.BorderThickness = 2;
            this.TextBoxTypeRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTypeRoom.DefaultText = "";
            this.TextBoxTypeRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTypeRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTypeRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTypeRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTypeRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTypeRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTypeRoom.ForeColor = System.Drawing.Color.Black;
            this.TextBoxTypeRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTypeRoom.Location = new System.Drawing.Point(197, 106);
            this.TextBoxTypeRoom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTypeRoom.Name = "TextBoxTypeRoom";
            this.TextBoxTypeRoom.PasswordChar = '\0';
            this.TextBoxTypeRoom.PlaceholderText = "";
            this.TextBoxTypeRoom.SelectedText = "";
            this.TextBoxTypeRoom.Size = new System.Drawing.Size(307, 37);
            this.TextBoxTypeRoom.TabIndex = 23;
            // 
            // BtnDeleteRoom
            // 
            this.BtnDeleteRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDeleteRoom.BorderColor = System.Drawing.Color.Transparent;
            this.BtnDeleteRoom.BorderRadius = 25;
            this.BtnDeleteRoom.BorderThickness = 2;
            this.BtnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDeleteRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteRoom.Location = new System.Drawing.Point(499, 205);
            this.BtnDeleteRoom.Name = "BtnDeleteRoom";
            this.BtnDeleteRoom.Size = new System.Drawing.Size(182, 60);
            this.BtnDeleteRoom.TabIndex = 46;
            this.BtnDeleteRoom.Text = "DELETE";
            this.BtnDeleteRoom.Click += new System.EventHandler(this.BtnDeleteRoom_Click);
            // 
            // BtnUpdateRoom
            // 
            this.BtnUpdateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUpdateRoom.BorderColor = System.Drawing.Color.Transparent;
            this.BtnUpdateRoom.BorderRadius = 25;
            this.BtnUpdateRoom.BorderThickness = 2;
            this.BtnUpdateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdateRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateRoom.Location = new System.Drawing.Point(259, 205);
            this.BtnUpdateRoom.Name = "BtnUpdateRoom";
            this.BtnUpdateRoom.Size = new System.Drawing.Size(182, 60);
            this.BtnUpdateRoom.TabIndex = 48;
            this.BtnUpdateRoom.Text = "UPDATE";
            // 
            // TextBoxIdRoom
            // 
            this.TextBoxIdRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxIdRoom.BorderRadius = 5;
            this.TextBoxIdRoom.BorderThickness = 2;
            this.TextBoxIdRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxIdRoom.DefaultText = "";
            this.TextBoxIdRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxIdRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxIdRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxIdRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxIdRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxIdRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxIdRoom.ForeColor = System.Drawing.Color.Black;
            this.TextBoxIdRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxIdRoom.Location = new System.Drawing.Point(197, 32);
            this.TextBoxIdRoom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxIdRoom.Name = "TextBoxIdRoom";
            this.TextBoxIdRoom.PasswordChar = '\0';
            this.TextBoxIdRoom.PlaceholderText = "";
            this.TextBoxIdRoom.SelectedText = "";
            this.TextBoxIdRoom.Size = new System.Drawing.Size(147, 37);
            this.TextBoxIdRoom.TabIndex = 22;
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddRoom.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAddRoom.BorderRadius = 25;
            this.BtnAddRoom.BorderThickness = 2;
            this.BtnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddRoom.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoom.Location = new System.Drawing.Point(31, 205);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Size = new System.Drawing.Size(182, 60);
            this.BtnAddRoom.TabIndex = 47;
            this.BtnAddRoom.Text = "ADD";
            // 
            // ComboBoxStatusRoom
            // 
            this.ComboBoxStatusRoom.BackColor = System.Drawing.Color.White;
            this.ComboBoxStatusRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBoxStatusRoom.BorderRadius = 5;
            this.ComboBoxStatusRoom.BorderThickness = 2;
            this.ComboBoxStatusRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStatusRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatusRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStatusRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStatusRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStatusRoom.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxStatusRoom.ItemHeight = 30;
            this.ComboBoxStatusRoom.Items.AddRange(new object[] {
            "tersedia",
            "dipesan",
            "rusak"});
            this.ComboBoxStatusRoom.Location = new System.Drawing.Point(734, 24);
            this.ComboBoxStatusRoom.Name = "ComboBoxStatusRoom";
            this.ComboBoxStatusRoom.Size = new System.Drawing.Size(237, 36);
            this.ComboBoxStatusRoom.TabIndex = 5;
            // 
            // labelStatusRoom
            // 
            this.labelStatusRoom.AutoSize = true;
            this.labelStatusRoom.ForeColor = System.Drawing.Color.Black;
            this.labelStatusRoom.Location = new System.Drawing.Point(557, 33);
            this.labelStatusRoom.Name = "labelStatusRoom";
            this.labelStatusRoom.Size = new System.Drawing.Size(154, 27);
            this.labelStatusRoom.TabIndex = 2;
            this.labelStatusRoom.Text = "Status Room";
            // 
            // labelTypeRoom
            // 
            this.labelTypeRoom.AutoSize = true;
            this.labelTypeRoom.ForeColor = System.Drawing.Color.Black;
            this.labelTypeRoom.Location = new System.Drawing.Point(46, 116);
            this.labelTypeRoom.Name = "labelTypeRoom";
            this.labelTypeRoom.Size = new System.Drawing.Size(137, 27);
            this.labelTypeRoom.TabIndex = 1;
            this.labelTypeRoom.Text = "Type Room";
            // 
            // labelIdRoom
            // 
            this.labelIdRoom.AutoSize = true;
            this.labelIdRoom.ForeColor = System.Drawing.Color.Black;
            this.labelIdRoom.Location = new System.Drawing.Point(46, 33);
            this.labelIdRoom.Name = "labelIdRoom";
            this.labelIdRoom.Size = new System.Drawing.Size(107, 27);
            this.labelIdRoom.TabIndex = 0;
            this.labelIdRoom.Text = "ID Room";
            // 
            // AdminRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxDataRooms);
            this.Name = "AdminRooms";
            this.Size = new System.Drawing.Size(1199, 809);
            this.Load += new System.EventHandler(this.AdminRooms_Load);
            this.GroupBoxDataRooms.ResumeLayout(false);
            this.GroupBoxDataRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewDataRooms)).EndInit();
            this.PanelSelectRoom.ResumeLayout(false);
            this.PanelSelectRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxDataRooms;
        private Guna.UI2.WinForms.Guna2Panel PanelSelectRoom;
        private System.Windows.Forms.Label labelStatusRoom;
        private System.Windows.Forms.Label labelTypeRoom;
        private System.Windows.Forms.Label labelIdRoom;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxStatusRoom;
        private System.Windows.Forms.Label LabelCloseDataRooms;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTypeRoom;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxIdRoom;
        protected System.Windows.Forms.DataGridView GridviewDataRooms;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateRoom;
        private Guna.UI2.WinForms.Guna2Button BtnAddRoom;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteRoom;
        private Guna.UI2.WinForms.Guna2Button BtnClearRoom;
    }
}
