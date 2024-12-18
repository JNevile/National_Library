﻿using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            // Call to method is OK, just not definition
            InitializeComponent();
            btnLogout.Click += btnLogout_Click;
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            //When user clicks the Logout button, first shows them a message asking for confirmation:
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                "Logout Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //If the user says yes to the confirmation message, this hides the current form
                this.Hide();

                //And brings the user back to the homepage login screen
                Form Login = new Login();
                Login.Show();

                //Lastly, closes the user dashboard upon logout
                this.Close();
            }
        }
    }
}