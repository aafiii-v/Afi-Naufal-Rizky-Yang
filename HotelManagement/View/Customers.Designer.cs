namespace HotelManagement.View
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxCustomers = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GridviewDataTamu = new System.Windows.Forms.DataGridView();
            this.PanelSelectTamu = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.TxtBoxKodePemesanan = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelKodePemesanan = new System.Windows.Forms.Label();
            this.TxtBoxNoKamar = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelNoKamar = new System.Windows.Forms.Label();
            this.TextBoxNoHp = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNamaTamu = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxKodeTamu = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelNoHpTamu = new System.Windows.Forms.Label();
            this.labelNamaTamu = new System.Windows.Forms.Label();
            this.labelKotaTamu = new System.Windows.Forms.Label();
            this.GroupBoxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewDataTamu)).BeginInit();
            this.PanelSelectTamu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxCustomers
            // 
            this.GroupBoxCustomers.BackColor = System.Drawing.Color.White;
            this.GroupBoxCustomers.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBoxCustomers.Controls.Add(this.GridviewDataTamu);
            this.GroupBoxCustomers.Controls.Add(this.PanelSelectTamu);
            this.GroupBoxCustomers.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxCustomers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCustomers.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCustomers.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxCustomers.Name = "GroupBoxCustomers";
            this.GroupBoxCustomers.Size = new System.Drawing.Size(1199, 809);
            this.GroupBoxCustomers.TabIndex = 2;
            this.GroupBoxCustomers.Text = "Data Guests";
            // 
            // GridviewDataTamu
            // 
            this.GridviewDataTamu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridviewDataTamu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridviewDataTamu.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridviewDataTamu.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridviewDataTamu.GridColor = System.Drawing.Color.Silver;
            this.GridviewDataTamu.Location = new System.Drawing.Point(94, 76);
            this.GridviewDataTamu.Name = "GridviewDataTamu";
            this.GridviewDataTamu.RowHeadersWidth = 51;
            this.GridviewDataTamu.RowTemplate.Height = 24;
            this.GridviewDataTamu.Size = new System.Drawing.Size(1010, 374);
            this.GridviewDataTamu.TabIndex = 49;
            this.GridviewDataTamu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewDataTamu_CellClick);
            // 
            // PanelSelectTamu
            // 
            this.PanelSelectTamu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelSelectTamu.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelSelectTamu.Controls.Add(this.BtnClear);
            this.PanelSelectTamu.Controls.Add(this.TxtBoxKodePemesanan);
            this.PanelSelectTamu.Controls.Add(this.LabelKodePemesanan);
            this.PanelSelectTamu.Controls.Add(this.TxtBoxNoKamar);
            this.PanelSelectTamu.Controls.Add(this.LabelNoKamar);
            this.PanelSelectTamu.Controls.Add(this.TextBoxNoHp);
            this.PanelSelectTamu.Controls.Add(this.TextBoxNamaTamu);
            this.PanelSelectTamu.Controls.Add(this.TextBoxKodeTamu);
            this.PanelSelectTamu.Controls.Add(this.LabelNoHpTamu);
            this.PanelSelectTamu.Controls.Add(this.labelNamaTamu);
            this.PanelSelectTamu.Controls.Add(this.labelKotaTamu);
            this.PanelSelectTamu.Location = new System.Drawing.Point(94, 476);
            this.PanelSelectTamu.Name = "PanelSelectTamu";
            this.PanelSelectTamu.Size = new System.Drawing.Size(893, 257);
            this.PanelSelectTamu.TabIndex = 48;
            // 
            // BtnClear
            // 
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClear.BorderColor = System.Drawing.Color.Transparent;
            this.BtnClear.BorderRadius = 20;
            this.BtnClear.BorderThickness = 2;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(698, 98);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(160, 50);
            this.BtnClear.TabIndex = 56;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtBoxKodePemesanan
            // 
            this.TxtBoxKodePemesanan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxKodePemesanan.BorderRadius = 5;
            this.TxtBoxKodePemesanan.BorderThickness = 2;
            this.TxtBoxKodePemesanan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxKodePemesanan.DefaultText = "";
            this.TxtBoxKodePemesanan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBoxKodePemesanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBoxKodePemesanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxKodePemesanan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxKodePemesanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxKodePemesanan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxKodePemesanan.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxKodePemesanan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxKodePemesanan.Location = new System.Drawing.Point(250, 201);
            this.TxtBoxKodePemesanan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBoxKodePemesanan.Name = "TxtBoxKodePemesanan";
            this.TxtBoxKodePemesanan.PasswordChar = '\0';
            this.TxtBoxKodePemesanan.PlaceholderText = "";
            this.TxtBoxKodePemesanan.SelectedText = "";
            this.TxtBoxKodePemesanan.Size = new System.Drawing.Size(256, 37);
            this.TxtBoxKodePemesanan.TabIndex = 54;
            // 
            // LabelKodePemesanan
            // 
            this.LabelKodePemesanan.AutoSize = true;
            this.LabelKodePemesanan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKodePemesanan.ForeColor = System.Drawing.Color.Black;
            this.LabelKodePemesanan.Location = new System.Drawing.Point(46, 212);
            this.LabelKodePemesanan.Name = "LabelKodePemesanan";
            this.LabelKodePemesanan.Size = new System.Drawing.Size(181, 23);
            this.LabelKodePemesanan.TabIndex = 53;
            this.LabelKodePemesanan.Text = "Kode Pemesanan";
            // 
            // TxtBoxNoKamar
            // 
            this.TxtBoxNoKamar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxNoKamar.BorderRadius = 5;
            this.TxtBoxNoKamar.BorderThickness = 2;
            this.TxtBoxNoKamar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxNoKamar.DefaultText = "";
            this.TxtBoxNoKamar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBoxNoKamar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBoxNoKamar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxNoKamar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxNoKamar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxNoKamar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxNoKamar.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxNoKamar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxNoKamar.Location = new System.Drawing.Point(250, 64);
            this.TxtBoxNoKamar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBoxNoKamar.Name = "TxtBoxNoKamar";
            this.TxtBoxNoKamar.PasswordChar = '\0';
            this.TxtBoxNoKamar.PlaceholderText = "";
            this.TxtBoxNoKamar.SelectedText = "";
            this.TxtBoxNoKamar.Size = new System.Drawing.Size(256, 37);
            this.TxtBoxNoKamar.TabIndex = 52;
            // 
            // LabelNoKamar
            // 
            this.LabelNoKamar.AutoSize = true;
            this.LabelNoKamar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoKamar.ForeColor = System.Drawing.Color.Black;
            this.LabelNoKamar.Location = new System.Drawing.Point(46, 75);
            this.LabelNoKamar.Name = "LabelNoKamar";
            this.LabelNoKamar.Size = new System.Drawing.Size(108, 23);
            this.LabelNoKamar.TabIndex = 51;
            this.LabelNoKamar.Text = "No Kamar";
            // 
            // TextBoxNoHp
            // 
            this.TextBoxNoHp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxNoHp.BorderRadius = 5;
            this.TextBoxNoHp.BorderThickness = 2;
            this.TextBoxNoHp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNoHp.DefaultText = "";
            this.TextBoxNoHp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNoHp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNoHp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNoHp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNoHp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNoHp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNoHp.ForeColor = System.Drawing.Color.Black;
            this.TextBoxNoHp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNoHp.Location = new System.Drawing.Point(250, 156);
            this.TextBoxNoHp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNoHp.Name = "TextBoxNoHp";
            this.TextBoxNoHp.PasswordChar = '\0';
            this.TextBoxNoHp.PlaceholderText = "";
            this.TextBoxNoHp.SelectedText = "";
            this.TextBoxNoHp.Size = new System.Drawing.Size(404, 37);
            this.TextBoxNoHp.TabIndex = 50;
            // 
            // TextBoxNamaTamu
            // 
            this.TextBoxNamaTamu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxNamaTamu.BorderRadius = 5;
            this.TextBoxNamaTamu.BorderThickness = 2;
            this.TextBoxNamaTamu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNamaTamu.DefaultText = "";
            this.TextBoxNamaTamu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNamaTamu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNamaTamu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNamaTamu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNamaTamu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNamaTamu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNamaTamu.ForeColor = System.Drawing.Color.Black;
            this.TextBoxNamaTamu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNamaTamu.Location = new System.Drawing.Point(250, 111);
            this.TextBoxNamaTamu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNamaTamu.Name = "TextBoxNamaTamu";
            this.TextBoxNamaTamu.PasswordChar = '\0';
            this.TextBoxNamaTamu.PlaceholderText = "";
            this.TextBoxNamaTamu.SelectedText = "";
            this.TextBoxNamaTamu.Size = new System.Drawing.Size(404, 37);
            this.TextBoxNamaTamu.TabIndex = 23;
            // 
            // TextBoxKodeTamu
            // 
            this.TextBoxKodeTamu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxKodeTamu.BorderRadius = 5;
            this.TextBoxKodeTamu.BorderThickness = 2;
            this.TextBoxKodeTamu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxKodeTamu.DefaultText = "";
            this.TextBoxKodeTamu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxKodeTamu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxKodeTamu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxKodeTamu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxKodeTamu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxKodeTamu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxKodeTamu.ForeColor = System.Drawing.Color.Black;
            this.TextBoxKodeTamu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxKodeTamu.Location = new System.Drawing.Point(250, 19);
            this.TextBoxKodeTamu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxKodeTamu.Name = "TextBoxKodeTamu";
            this.TextBoxKodeTamu.PasswordChar = '\0';
            this.TextBoxKodeTamu.PlaceholderText = "";
            this.TextBoxKodeTamu.SelectedText = "";
            this.TextBoxKodeTamu.Size = new System.Drawing.Size(256, 37);
            this.TextBoxKodeTamu.TabIndex = 22;
            // 
            // LabelNoHpTamu
            // 
            this.LabelNoHpTamu.AutoSize = true;
            this.LabelNoHpTamu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoHpTamu.ForeColor = System.Drawing.Color.Black;
            this.LabelNoHpTamu.Location = new System.Drawing.Point(46, 164);
            this.LabelNoHpTamu.Name = "LabelNoHpTamu";
            this.LabelNoHpTamu.Size = new System.Drawing.Size(70, 23);
            this.LabelNoHpTamu.TabIndex = 2;
            this.LabelNoHpTamu.Text = "No Hp";
            // 
            // labelNamaTamu
            // 
            this.labelNamaTamu.AutoSize = true;
            this.labelNamaTamu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaTamu.ForeColor = System.Drawing.Color.Black;
            this.labelNamaTamu.Location = new System.Drawing.Point(46, 120);
            this.labelNamaTamu.Name = "labelNamaTamu";
            this.labelNamaTamu.Size = new System.Drawing.Size(67, 23);
            this.labelNamaTamu.TabIndex = 1;
            this.labelNamaTamu.Text = "Nama";
            // 
            // labelKotaTamu
            // 
            this.labelKotaTamu.AutoSize = true;
            this.labelKotaTamu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKotaTamu.ForeColor = System.Drawing.Color.Black;
            this.labelKotaTamu.Location = new System.Drawing.Point(46, 30);
            this.labelKotaTamu.Name = "labelKotaTamu";
            this.labelKotaTamu.Size = new System.Drawing.Size(122, 23);
            this.labelKotaTamu.TabIndex = 0;
            this.labelKotaTamu.Text = "Kode Tamu";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxCustomers);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1199, 809);
            this.Load += new System.EventHandler(this.Customers_Load);
            this.GroupBoxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridviewDataTamu)).EndInit();
            this.PanelSelectTamu.ResumeLayout(false);
            this.PanelSelectTamu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxCustomers;
        protected System.Windows.Forms.DataGridView GridviewDataTamu;
        private Guna.UI2.WinForms.Guna2Panel PanelSelectTamu;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNoHp;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNamaTamu;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxKodeTamu;
        private System.Windows.Forms.Label LabelNoHpTamu;
        private System.Windows.Forms.Label labelNamaTamu;
        private System.Windows.Forms.Label labelKotaTamu;
        private Guna.UI2.WinForms.Guna2TextBox TxtBoxKodePemesanan;
        private System.Windows.Forms.Label LabelKodePemesanan;
        private Guna.UI2.WinForms.Guna2TextBox TxtBoxNoKamar;
        private System.Windows.Forms.Label LabelNoKamar;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
    }
}
