﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CS_Win_Project
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        private string _name;
        private string _password;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _name = name.Text;
            _password = password.Text;
            if (_name == null || _name.Trim().Equals(""))
            {
                Dialog dialog = new Dialog("请输入用户名");
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (_password == null || _password.Trim().Equals(""))
            {
                Dialog dialog = new Dialog("请输入用户名");
                dialog.ShowDialog();
                return;
            }

            panel.BringToFront();
            panel.Visible = true;

            Thread _progress = new Thread(new ThreadStart(process));
            _progress.Start();
        }
        private void process()
        {
            for (int i = 1; i < 101; i++)
            {
                progressBar.Value = i;
                if (i == progressBar.Maximum)
                {
                    this.Dispose();
                    new MainWin(_name).Show();
                    
                }
                Thread.Sleep(100);
            }
        } 

        private void cancel_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            panel.SendToBack();
        }

    }
}
