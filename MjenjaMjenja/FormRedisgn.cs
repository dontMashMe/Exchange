using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Repository;
namespace MjenjaMjenja
{
    public partial class FormRedisgn : Form
    {

        public FormRedisgn()
        {
            InitializeComponent();
        }

        private void FormRedisgn_Load(object sender, EventArgs e)
        {

            FirstControl.Visible = true;
            exchangeControl1.Visible = false;
            graphControl1.Visible = false;
            tableControl1.Visible = false;
            cruDcontrol1.Visible = false;


        }

        private void picIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnTwit_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.twitter.com";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.instagram.com/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.facebook.com/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FirstControl.Visible = true;
            graphControl1.Visible = false;
            exchangeControl1.Visible = false;
            tableControl1.Visible = false;
            cruDcontrol1.Visible = false;
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {

            FirstControl.Visible = false;
            graphControl1.Visible = false;
            exchangeControl1.Visible = true;
            tableControl1.Visible = false;
            cruDcontrol1.Visible = false;


        }

        private void btnGraph_Click(object sender, EventArgs e)
        {

            FirstControl.Visible = false;
            exchangeControl1.Visible = false;
            graphControl1.Visible = true;
            tableControl1.Visible = false;
            cruDcontrol1.Visible = false;


        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            FirstControl.Visible = false;
            exchangeControl1.Visible = false;
            graphControl1.Visible = false;
            tableControl1.Visible = true;
            cruDcontrol1.Visible = false;

        }
    

        private void btnCrude_Click(object sender, EventArgs e)
        {

            FirstControl.Visible = false;
            exchangeControl1.Visible = false;
            graphControl1.Visible = false;
            tableControl1.Visible = false;
            cruDcontrol1.Visible = true;
        }


    }
}
