using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lesson7;

namespace Lesson7
{
    public partial class fMain : Form
    {
        Udvoitel udvoitel;

        public fMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(10, 100);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            lblFinish.Text = udvoitel.Finish.ToString();
            tbCurrent.Text = udvoitel.Current.ToString();
            lblTurns.Text = udvoitel.Turns.ToString();
            lblMinTurns.Text = udvoitel.MinTurns.ToString();
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            udvoitel.Plus();
            UpdateInfo();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            udvoitel.Multi();
            UpdateInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            udvoitel.Reset();
            UpdateInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            if (udvoitel.Turns != 0) {
                udvoitel.Back();
                UpdateInfo();

            }

        }
    }
}
