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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            switch (selectedIndex)
            {
                case 0: MessageBox.Show("You selected Grade: A");
                    break;
                case 1:
                    MessageBox.Show("You selected Grade: B");
                    break;
                case 2:
                    MessageBox.Show("You selected Grade: C");
                    break;
                case 3:
                    MessageBox.Show("You selected Grade: D");
                    break;
                case 4:
                    MessageBox.Show("You selected Grade: E");
                    break;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtText.Text))
            {
                MessageBox.Show("Enter a Task to Add");
            }
            else
            {
                lstText.Items.Add(txtText.Text);
                txtText.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstText.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstText.SelectedIndex > -1)
            {
                int selectedIndex = lstText.SelectedIndex;
                lstText.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("You must select a task to remove");
            }
        }
    }
}
