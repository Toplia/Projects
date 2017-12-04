using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Win_Project
{
    public partial class MainWin : Form
    {
        private string userName;
        private login login;

        public MainWin()
        {
            InitializeComponent();
        }

        public MainWin(string userName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.Text = userName;
        }

        public MainWin(string userName, login login)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.userName = userName;
            this.Text = userName;
            this.login = login;
        }

        private void FormMainWin_Load(object sender, EventArgs e)
        {
            this.login.Visible = false;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.login.Controls.Remove(this.login.loading);
            this.login.Controls.Add(this.login.loginPanel);
            this.login.Visible = true;
        }
    }
}
