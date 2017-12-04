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
        private Login login;

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
        private void FormMainWin_Load(object sender, EventArgs e)
        {
           
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Dialog dialog = new Dialog("是否退出到登录界面?");
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Dispose();
                new Login().Show();
                return;
            }
            this.Dispose();
            Application.Exit();
        }
    }
}
