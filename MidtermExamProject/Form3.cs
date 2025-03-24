using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExamProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int red = 0, green = 0, blue = 0;

        private void vScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            green = vScrollBarGreen.Value;
            BackColor = Color.FromArgb(red, green, blue);
            lblColorInfo.Text = "Current Color: RGB(" + red + "," + green + "," + blue + ")";
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            blue = hScrollBarBlue.Value;
            BackColor = Color.FromArgb(red, green, blue);
            lblColorInfo.Text = "Current Color: RGB(" + red + "," + green + "," + blue + ")";
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            red = trackBarRed.Value;
            BackColor = Color.FromArgb(red, green, blue);
            lblColorInfo.Text = "Current Color: RGB(" + red + "," + green + "," + blue + ")";
        }
    }
}
