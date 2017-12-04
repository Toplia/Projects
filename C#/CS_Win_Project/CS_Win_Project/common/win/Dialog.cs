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
    public partial class Dialog : Form
    {
        private string info_title;

        public Dialog()
        {
            InitializeComponent();
        }

        public Dialog(string info_title)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.Text = info_title;
           
        }

        public Dialog(string info_title, string info_text)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.info_title = info_title;
            this.contentText.Text = info_text;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
