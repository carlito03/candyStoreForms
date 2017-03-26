namespace GatesCandyStore_CarlosRoman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.candyList = new System.Windows.Forms.ComboBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.candyBox = new System.Windows.Forms.TextBox();
            this.chocolateselection = new System.Windows.Forms.TextBox();
            this.gumselection = new System.Windows.Forms.TextBox();
            this.lollipopselection = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalcandies = new System.Windows.Forms.Label();
            this.totalLollipops = new System.Windows.Forms.Label();
            this.totalChocolates = new System.Windows.Forms.Label();
            this.gumtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Candy type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected Candy type is:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Process Candy selection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your Selections";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chocolate selection:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gum selection:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lollipop selection:";
            // 
            // candyList
            // 
            this.candyList.FormattingEnabled = true;
            this.candyList.Items.AddRange(new object[] {
            "Lollipops",
            "Gum",
            "Chocolate",
            "Everlastinggumstopper"});
            this.candyList.Location = new System.Drawing.Point(202, 53);
            this.candyList.Name = "candyList";
            this.candyList.Size = new System.Drawing.Size(176, 21);
            this.candyList.TabIndex = 8;
            this.candyList.SelectedIndexChanged += new System.EventHandler(this.candyList_SelectedIndexChanged);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(202, 21);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(176, 20);
            this.customerName.TabIndex = 9;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // candyBox
            // 
            this.candyBox.Location = new System.Drawing.Point(202, 97);
            this.candyBox.Name = "candyBox";
            this.candyBox.ReadOnly = true;
            this.candyBox.Size = new System.Drawing.Size(100, 20);
            this.candyBox.TabIndex = 11;
            this.candyBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chocolateselection
            // 
            this.chocolateselection.Location = new System.Drawing.Point(223, 247);
            this.chocolateselection.Name = "chocolateselection";
            this.chocolateselection.ReadOnly = true;
            this.chocolateselection.Size = new System.Drawing.Size(100, 20);
            this.chocolateselection.TabIndex = 12;
            // 
            // gumselection
            // 
            this.gumselection.Location = new System.Drawing.Point(223, 281);
            this.gumselection.Name = "gumselection";
            this.gumselection.ReadOnly = true;
            this.gumselection.Size = new System.Drawing.Size(100, 20);
            this.gumselection.TabIndex = 13;
            // 
            // lollipopselection
            // 
            this.lollipopselection.Location = new System.Drawing.Point(223, 317);
            this.lollipopselection.Multiline = true;
            this.lollipopselection.Name = "lollipopselection";
            this.lollipopselection.ReadOnly = true;
            this.lollipopselection.Size = new System.Drawing.Size(100, 20);
            this.lollipopselection.TabIndex = 14;
            this.lollipopselection.TextChanged += new System.EventHandler(this.lollipopselection_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "TOTAL";
            // 
            // totalcandies
            // 
            this.totalcandies.AutoSize = true;
            this.totalcandies.Location = new System.Drawing.Point(397, 363);
            this.totalcandies.Name = "totalcandies";
            this.totalcandies.Size = new System.Drawing.Size(13, 13);
            this.totalcandies.TabIndex = 19;
            this.totalcandies.Text = "0";
            // 
            // totalLollipops
            // 
            this.totalLollipops.AutoSize = true;
            this.totalLollipops.Location = new System.Drawing.Point(397, 324);
            this.totalLollipops.Name = "totalLollipops";
            this.totalLollipops.Size = new System.Drawing.Size(13, 13);
            this.totalLollipops.TabIndex = 20;
            this.totalLollipops.Text = "0";
            // 
            // totalChocolates
            // 
            this.totalChocolates.AutoSize = true;
            this.totalChocolates.Location = new System.Drawing.Point(397, 254);
            this.totalChocolates.Name = "totalChocolates";
            this.totalChocolates.Size = new System.Drawing.Size(13, 13);
            this.totalChocolates.TabIndex = 21;
            this.totalChocolates.Text = "0";
            // 
            // gumtotal
            // 
            this.gumtotal.AutoSize = true;
            this.gumtotal.Location = new System.Drawing.Point(397, 288);
            this.gumtotal.Name = "gumtotal";
            this.gumtotal.Size = new System.Drawing.Size(13, 13);
            this.gumtotal.TabIndex = 22;
            this.gumtotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 385);
            this.Controls.Add(this.gumtotal);
            this.Controls.Add(this.totalChocolates);
            this.Controls.Add(this.totalLollipops);
            this.Controls.Add(this.totalcandies);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lollipopselection);
            this.Controls.Add(this.gumselection);
            this.Controls.Add(this.chocolateselection);
            this.Controls.Add(this.candyBox);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.candyList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Welcome to Gate\'s Candy Store!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox candyList;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox chocolateselection;
        private System.Windows.Forms.TextBox gumselection;
        public System.Windows.Forms.TextBox candyBox;
        protected System.Windows.Forms.TextBox lollipopselection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalcandies;
        private System.Windows.Forms.Label totalLollipops;
        private System.Windows.Forms.Label totalChocolates;
        private System.Windows.Forms.Label gumtotal;
    }
}

