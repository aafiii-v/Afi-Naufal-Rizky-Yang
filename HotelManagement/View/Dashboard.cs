﻿using HotelManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Dashboard : UserControl
    {
        LoginController AdminConroller;
        public Dashboard()
        {
            AdminConroller = new LoginController();
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LabelAngkaTotalAdmin.Text = AdminConroller.HitungTotalAdmin().ToString();
                //LabelAngkaAvailebleRooms.Text = 
            }
            catch (Exception ex)
            {

            }
        }
    }
}
