using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gp20AppCode.HashAlgorithms;

namespace HashProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            txtHash.Text = Hash.ComputeSHA1Hash(txtOrg.Text);
        }

        private void BtnLength_Click(object sender, EventArgs e)
        {
            lblHashLength.Text = Hash.ComputeHashTextLength(txtHash.Text);
        }

        private void BtnCampare_Click(object sender, EventArgs e)
        {
            lblResultCampare.Text = Hash.CampareHashText(txtCampare.Text, txtHash.Text);
        }
    }
}
