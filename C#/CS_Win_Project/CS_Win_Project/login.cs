using System;
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

        private string _name;
        private string _password;
        private Thread _progress;
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
            //progressBar.MarqueeAnimationSpeed = 50 * 10;
            progressBar.Step = 1;

            _progress = new Thread(new ThreadStart(process));
            _progress.IsBackground = true;
            _progress.Start();
        }
        delegate void processCallback(int i);
        private void progressIng(int i)
        {
            
            if (progressBar.InvokeRequired)
            {
                processCallback pd = new processCallback(progressIng);
                this.Invoke(pd, new Object[] { i });
            }
            else
            {
                if (i == progressBar.Maximum)
                {
                    this.Dispose();
                    new MainWin(_name).Show();
                }
                else
                {
                    
                    progressBar.Value = i;
                    if (i < 10)
                    {
                        this.loading.Text = "正在连接...";
                        Thread.Sleep(100);
                    }
                    else if (i < 90)
                    {
                        this.loading.Text = "验证登录...";
                        Thread.Sleep(10);
                    }
                    else
                    {
                        this.loading.Text = "验证权限...";
                        Thread.Sleep(100);
                    }
                }
               
            }
            
        }
        private void process()
        {
            for (int i = 1; i < 101; i++)
            {
                progressIng(i);
            }
        } 

        private void cancel_Click(object sender, EventArgs e)
        {
            _progress.Suspend();
            panel.Visible = false;
            panel.SendToBack();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel.Visible = false;
            progressBar.Value = 1;
            panel.SendToBack();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
