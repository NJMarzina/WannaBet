﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WannaBetClassLibrary;

namespace WannaBet
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                //Create better validation later, just know this is where it goes.
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    lblMessage.Text = "All fields are required.";
                    return;
                }

                // Create a new User object with the input values
                User newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = int.Parse(txtPhoneNumber.Text.Trim()),
                    Balance = 0, //initial values start at 0 (duh)
                    NumBets = 0,
                    NumWins = 0,
                    NumLoses = 0
                };

                // Here you would typically:
                // 1. Check if username already exists
                // 2. Hash the password
                // 3. Save the user to database
                // For this example, we're just show a success message

                lblMessage.Text = "Registration Successful!";

                // Clear the form
                ClearForm();

                Response.Redirect("Dashboard.aspx");
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Registration failed: " + ex.Message;
            }
        }

        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }
    }
}