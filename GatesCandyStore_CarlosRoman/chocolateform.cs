using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatesCandyStore_CarlosRoman
{
    public partial class chocolateform : Form
    {
        public chocolateform(string string_value, Form1 frm1Handle)
        {
            InitializeComponent();
            customerLabel.Text = string_value;
            HandleToForm1 = frm1Handle;

        }

        private Form1 HandleToForm1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customerLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flavorscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flavorscombobox.SelectedIndex == -1)
            {
                selectedFlavor.Text = string.Empty;
            }
            else
            {
                selectedFlavor.Text = flavorscombobox.SelectedItem.ToString();
                HandleToForm1.WriteToTextbox2(flavorscombobox.SelectedItem.ToString());

            }
        }

        private void selectedFlavor_Click(object sender, EventArgs e)
        {

        }

        private void chocolateform_Load(object sender, EventArgs e)
        {

        }
    }
}
