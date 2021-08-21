using CSScriptLib;
using DropDownPanel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownPanel
{
    public partial class Form1 : Form
    {
        //int flag = -1;
        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button1.Image = Resources.Collapse_Arrow_20px;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button1.Image = Resources.Expand_Arrow_20px;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        #region auto hide the whole panel
        //private void button1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if(e.Y == 10)
        //    {
        //        panelDropDown.Visible = true;
        //    }
        //    else if(e.Y > 20)
        //    {
        //        panelDropDown.Visible = false;
        //    }
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    flag *= -1;
        //    if (flag == 1)
        //        panelDropDown.Hide();
        //    else
        //        panelDropDown.Show();
        //}
        #endregion auto hide the whole panel
    }
}
