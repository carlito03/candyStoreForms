namespace GatesCandyStore_CarlosRoman
{
    partial class gumFlavors
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
            this.selectedFlavor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flavorscombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectedFlavor
            // 
            this.selectedFlavor.AutoSize = true;
            this.selectedFlavor.Location = new System.Drawing.Point(166, 151);
            this.selectedFlavor.Name = "selectedFlavor";
            this.selectedFlavor.Size = new System.Drawing.Size(68, 13);
            this.selectedFlavor.TabIndex = 17;
            this.selectedFlavor.Text = "pick a flavor!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selected";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(30, 151);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 13);
            this.customerLabel.TabIndex = 15;
            this.customerLabel.Text = "customerLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Return to Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flavorscombobox
            // 
            this.flavorscombobox.FormattingEnabled = true;
            this.flavorscombobox.Items.AddRange(new object[] {
            "Mint",
            "Fruit",
            "Cinnamon"});
            this.flavorscombobox.Location = new System.Drawing.Point(33, 98);
            this.flavorscombobox.Name = "flavorscombobox";
            this.flavorscombobox.Size = new System.Drawing.Size(169, 21);
            this.flavorscombobox.TabIndex = 13;
            this.flavorscombobox.SelectedIndexChanged += new System.EventHandler(this.flavorscombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pick the GUM flavor that you want to buy";
            // 
            // gumFlavors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.selectedFlavor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flavorscombobox);
            this.Controls.Add(this.label1);
            this.Name = "gumFlavors";
            this.Text = "gumFlavors";
            this.Load += new System.EventHandler(this.gumFlavors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedFlavor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox flavorscombobox;
        private System.Windows.Forms.Label label1;
    }
}