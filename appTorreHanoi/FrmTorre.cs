using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appTorreHanoi
{
    public partial class FrmTorre : Form
    {
        public FrmTorre()
        {
            InitializeComponent();
        }

        public bool cliqueiDisc()
        {
            if (disc1.BorderStyle == BorderStyle.Fixed3D || disc2.BorderStyle == BorderStyle.Fixed3D || disc1.BorderStyle == BorderStyle.Fixed3D)
            return true;
            else
            return false;
        }

        private void disc1_MouseClick(object sender, MouseEventArgs e)
        {
            disc1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (cliqueiDisc() == true)
            {
                disc1.Location = p3.Location;
                disc1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

    }
}
