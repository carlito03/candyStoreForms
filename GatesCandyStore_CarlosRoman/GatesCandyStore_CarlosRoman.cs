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
    public partial class Form1 : Form
    {
        //variables to keep track of how many candy, also total 
        private static int howManyLollipops;
        private static int howManyChocolates;
        private static int howMuchGum;
        private static int totalCandy;


        public Form1()
        {
            InitializeComponent();
        }

        public void WriteToTextbox(string inputText)
        {
            this.lollipopselection.Text = this.lollipopselection.Text + inputText + ",";
            howManyLollipops = howManyLollipops +1;
            totalCandy = totalCandy+ 1;
            totalLollipops.Text = howManyLollipops.ToString();
            totalcandies.Text = totalCandy.ToString();
        }

        public void WriteToTextbox2(string inputText)
        {
            this.chocolateselection.Text = this.chocolateselection.Text + inputText + ",";
            howManyChocolates = howManyChocolates + 1;
            totalCandy = totalCandy + 1;
            totalChocolates.Text = howManyChocolates.ToString();
            totalcandies.Text = totalCandy.ToString();
        }

        public void WriteToTextbox3(string inputText)
        {
            this.gumselection.Text = this.gumselection.Text + inputText + ",";
            howMuchGum = howMuchGum + 1;
            totalCandy = totalCandy + 1;
            gumtotal.Text = howMuchGum.ToString();
            totalcandies.Text = totalCandy.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void candyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (candyList.SelectedIndex == -1)
            {
                candyBox.Text = string.Empty;
            }
            else
            {
                candyBox.Text = candyList.SelectedItem.ToString();
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (candyBox.Text.ToLower() == "lollipops")
            {

                flavorForm FlavorForm = new flavorForm(customerName.Text, this);
                FlavorForm.ShowDialog();
            }

           if (candyBox.Text.ToLower() == "chocolate")
           {

                chocolateform ChocolateForm = new chocolateform(customerName.Text, this);
                ChocolateForm.ShowDialog();
            }

            if (candyBox.Text.ToLower() == "gum")
            {

                gumFlavors GumForm = new gumFlavors(customerName.Text, this);
                GumForm.ShowDialog();
            }

            //  


            //   
        }

        private void lollipopselection_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
