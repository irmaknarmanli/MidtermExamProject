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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text Files | *.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                txtText.Text = System.IO.File.ReadAllText(file);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, txtText.Text);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Paste();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }
    }
}
