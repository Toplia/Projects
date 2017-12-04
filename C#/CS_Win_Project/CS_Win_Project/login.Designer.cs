namespace CS_Win_Project
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param userName="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginMenu = new System.Windows.Forms.MenuStrip();
            this.optionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.autoLogin = new System.Windows.Forms.CheckBox();
            this.savePassword = new System.Windows.Forms.CheckBox();
            this.loading = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginMenu.SuspendLayout();
            this.loading.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMenu
            // 
            this.loginMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionMenu,
            this.helpMenu});
            this.loginMenu.Location = new System.Drawing.Point(0, 0);
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.Size = new System.Drawing.Size(407, 25);
            this.loginMenu.TabIndex = 0;
            this.loginMenu.Text = "menuBar";
            this.loginMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBar_Clicked);
            // 
            // optionMenu
            // 
            this.optionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.exitMenuItem});
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(44, 21);
            this.optionMenu.Text = "设置";
            this.optionMenu.Click += new System.EventHandler(this.optionMenu_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openMenuItem.Text = "打开";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 21);
            this.helpMenu.Text = "帮助";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.helpMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(103, 22);
            this.helpMenuItem.Text = "Help";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserName.Location = new System.Drawing.Point(98, 55);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(44, 17);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "用户名";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassword.Location = new System.Drawing.Point(98, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(44, 17);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "密   码";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(167, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(152, 51);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(156, 21);
            this.userName.TabIndex = 4;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(152, 88);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(156, 21);
            this.password.TabIndex = 5;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // autoLogin
            // 
            this.autoLogin.AutoSize = true;
            this.autoLogin.Enabled = false;
            this.autoLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoLogin.Location = new System.Drawing.Point(233, 115);
            this.autoLogin.Name = "autoLogin";
            this.autoLogin.Size = new System.Drawing.Size(75, 21);
            this.autoLogin.TabIndex = 6;
            this.autoLogin.Text = "自动登录";
            this.autoLogin.UseVisualStyleBackColor = true;
            // 
            // savePassword
            // 
            this.savePassword.AutoSize = true;
            this.savePassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savePassword.Location = new System.Drawing.Point(152, 115);
            this.savePassword.Name = "savePassword";
            this.savePassword.Size = new System.Drawing.Size(75, 21);
            this.savePassword.TabIndex = 7;
            this.savePassword.Text = "保存密码";
            this.savePassword.UseVisualStyleBackColor = true;
            this.savePassword.CheckedChanged += new System.EventHandler(this.savePassword_CheckedChanged);
            // 
            // loading
            // 
            this.loading.Controls.Add(this.progressBar1);
            this.loading.Controls.Add(this.cancelBtn);
            this.loading.Location = new System.Drawing.Point(0, 28);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(407, 247);
            this.loading.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(102, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 16);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(161, 112);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(61, 24);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancel_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.password);
            this.loginPanel.Controls.Add(this.autoLogin);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.labelUserName);
            this.loginPanel.Controls.Add(this.labelPassword);
            this.loginPanel.Controls.Add(this.userName);
            this.loginPanel.Controls.Add(this.savePassword);
            this.loginPanel.Location = new System.Drawing.Point(0, 28);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(407, 247);
            this.loginPanel.TabIndex = 10;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 275);
            this.Controls.Add(this.loginMenu);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.loginPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.loginMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FormLogin_load);
            this.loginMenu.ResumeLayout(false);
            this.loginMenu.PerformLayout();
            this.loading.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip loginMenu;
        private System.Windows.Forms.ToolStripMenuItem optionMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox autoLogin;
        private System.Windows.Forms.CheckBox savePassword;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Panel loading;
        public System.Windows.Forms.Panel loginPanel;

    }
}

