namespace GatesCandyStore_CarlosRoman
{
    partial class chocolateform
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
            this.selectedFlavor.Location = new System.Drawing.Point(172, 151);
            this.selectedFlavor.Name = "selectedFlavor";
            this.selectedFlavor.Size = new System.Drawing.Size(68, 13);
            this.selectedFlavor.TabIndex = 11;
            this.selectedFlavor.Text = "pick a flavor!";
            this.selectedFlavor.Click += new System.EventHandler(this.selectedFlavor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selected";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(36, 151);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 13);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "customerLabel";
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Return to Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flavorscombobox
            // 
            this.flavorscombobox.FormattingEnabled = true;
            this.flavorscombobox.Items.AddRange(new object[] {
            "DarK",
            "White",
            "Milk"});
            this.flavorscombobox.Location = new System.Drawing.Point(39, 98);
            this.flavorscombobox.Name = "flavorscombobox";
            this.flavorscombobox.Size = new System.Drawing.Size(169, 21);
            this.flavorscombobox.TabIndex = 7;
            this.flavorscombobox.SelectedIndexChanged += new System.EventHandler(this.flavorscombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pick the Chocolate flavor that you want to buy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chocolateform
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
            this.Name = "chocolateform";
            this.Text = "chocolateform";
            this.Load += new System.EventHandler(this.chocolateform_Load);
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