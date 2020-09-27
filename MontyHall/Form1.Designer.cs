namespace MontyHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioSwitch = new System.Windows.Forms.RadioButton();
            this.RadioKeep = new System.Windows.Forms.RadioButton();
            this.NumberOfDoors = new System.Windows.Forms.NumericUpDown();
            this.NumberOfAttempts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDoors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfAttempts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioKeep);
            this.panel1.Controls.Add(this.RadioSwitch);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 49);
            this.panel1.TabIndex = 0;
            // 
            // RadioSwitch
            // 
            this.RadioSwitch.AutoSize = true;
            this.RadioSwitch.Checked = true;
            this.RadioSwitch.Location = new System.Drawing.Point(4, 4);
            this.RadioSwitch.Name = "RadioSwitch";
            this.RadioSwitch.Size = new System.Drawing.Size(83, 17);
            this.RadioSwitch.TabIndex = 0;
            this.RadioSwitch.TabStop = true;
            this.RadioSwitch.Text = "Switch Door";
            this.RadioSwitch.UseVisualStyleBackColor = true;
            // 
            // RadioKeep
            // 
            this.RadioKeep.AutoSize = true;
            this.RadioKeep.Location = new System.Drawing.Point(4, 27);
            this.RadioKeep.Name = "RadioKeep";
            this.RadioKeep.Size = new System.Drawing.Size(76, 17);
            this.RadioKeep.TabIndex = 1;
            this.RadioKeep.Text = "Keep Door";
            this.RadioKeep.UseVisualStyleBackColor = true;
            // 
            // NumberOfDoors
            // 
            this.NumberOfDoors.Location = new System.Drawing.Point(12, 25);
            this.NumberOfDoors.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumberOfDoors.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfDoors.Name = "NumberOfDoors";
            this.NumberOfDoors.Size = new System.Drawing.Size(98, 20);
            this.NumberOfDoors.TabIndex = 1;
            this.NumberOfDoors.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumberOfAttempts
            // 
            this.NumberOfAttempts.Location = new System.Drawing.Point(116, 25);
            this.NumberOfAttempts.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumberOfAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfAttempts.Name = "NumberOfAttempts";
            this.NumberOfAttempts.Size = new System.Drawing.Size(120, 20);
            this.NumberOfAttempts.TabIndex = 2;
            this.NumberOfAttempts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of doors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of attempts";
            // 
            // ResTextBox
            // 
            this.ResTextBox.Location = new System.Drawing.Point(117, 52);
            this.ResTextBox.Multiline = true;
            this.ResTextBox.Name = "ResTextBox";
            this.ResTextBox.ReadOnly = true;
            this.ResTextBox.Size = new System.Drawing.Size(155, 93);
            this.ResTextBox.TabIndex = 5;
            this.ResTextBox.Text = "Results displayed here";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(12, 162);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(93, 162);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ResTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfAttempts);
            this.Controls.Add(this.NumberOfDoors);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monty Hall";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDoors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfAttempts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioKeep;
        private System.Windows.Forms.RadioButton RadioSwitch;
        private System.Windows.Forms.NumericUpDown NumberOfDoors;
        private System.Windows.Forms.NumericUpDown NumberOfAttempts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button button1;
    }
}

