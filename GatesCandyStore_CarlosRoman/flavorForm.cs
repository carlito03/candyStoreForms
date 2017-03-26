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
    public partial class flavorForm : Form
    {
        public flavorForm(string string_value, Form1 frm1Handle)
        {
            InitializeComponent();
            customerLabel.Text = string_value;
            HandleToForm1 = frm1Handle;
            


        }
        private Form1 HandleToForm1;
        public string sendText
        {

            get
            {

                return selectedFlavor.Text;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleToForm1.WriteToTextbox(flavorscombobox.SelectedItem.ToString());
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void flavorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
