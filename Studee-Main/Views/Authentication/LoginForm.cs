﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studee_Main.Views.Authentication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignUpText_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}
