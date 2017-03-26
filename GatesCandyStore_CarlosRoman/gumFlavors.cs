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
    public partial class gumFlavors : Form
    {
        public gumFlavors(string string_value, Form1 frm1Handle)
        {
            InitializeComponent();
            customerLabel.Text = string_value;
            HandleToForm1 = frm1Handle;

        }

        //we create a Handle here to pass the values back to the form 
       
        private Form1 HandleToForm1;

        private void button1_Click(object sender, EventArgs e)
        {
            HandleToForm1.WriteToTextbox3(flavorscombobox.SelectedItem.ToString());
            Close();
        }

        private void gumFlavors_Load(object sender, EventArgs e)
        {

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
                


            }
        }
    }
}
