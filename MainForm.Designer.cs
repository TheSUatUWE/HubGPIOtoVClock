namespace HubGPIOtoVClock
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.addressCheckGrp = new System.Windows.Forms.GroupBox();
            this.addressCheck2 = new System.Windows.Forms.CheckBox();
            this.addressCheck1 = new System.Windows.Forms.CheckBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.pollTimer = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.inputCheck5 = new System.Windows.Forms.CheckBox();
            this.inputCheck4 = new System.Windows.Forms.CheckBox();
            this.inputCheck3 = new System.Windows.Forms.CheckBox();
            this.inputCheck2 = new System.Windows.Forms.CheckBox();
            this.inputCheck1 = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.outputCheck8 = new System.Windows.Forms.CheckBox();
            this.outputCheck7 = new System.Windows.Forms.CheckBox();
            this.outputCheck6 = new System.Windows.Forms.CheckBox();
            this.outputCheck5 = new System.Windows.Forms.CheckBox();
            this.outputCheck4 = new System.Windows.Forms.CheckBox();
            this.outputCheck3 = new System.Windows.Forms.CheckBox();
            this.outputCheck2 = new System.Windows.Forms.CheckBox();
            this.outputCheck1 = new System.Windows.Forms.CheckBox();
            this.addressCheckGrp.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressCheckGrp
            // 
            this.addressCheckGrp.Controls.Add(this.addressCheck2);
            this.addressCheckGrp.Controls.Add(this.addressCheck1);
            this.addressCheckGrp.Location = new System.Drawing.Point(12, 12);
            this.addressCheckGrp.Name = "addressCheckGrp";
            this.addressCheckGrp.Size = new System.Drawing.Size(108, 44);
            this.addressCheckGrp.TabIndex = 41;
            this.addressCheckGrp.TabStop = false;
            this.addressCheckGrp.Text = "Card Address";
            // 
            // addressCheck2
            // 
            this.addressCheck2.Checked = true;
            this.addressCheck2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressCheck2.Location = new System.Drawing.Point(56, 20);
            this.addressCheck2.Name = "addressCheck2";
            this.addressCheck2.Size = new System.Drawing.Size(48, 16);
            this.addressCheck2.TabIndex = 1;
            this.addressCheck2.Text = "SK6";
            // 
            // addressCheck1
            // 
            this.addressCheck1.Checked = true;
            this.addressCheck1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressCheck1.Cursor = System.Windows.Forms.Cursors.Default;
            this.addressCheck1.Location = new System.Drawing.Point(8, 20);
            this.addressCheck1.Name = "addressCheck1";
            this.addressCheck1.Size = new System.Drawing.Size(48, 16);
            this.addressCheck1.TabIndex = 0;
            this.addressCheck1.Text = "SK5";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(13, 63);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(564, 237);
            this.logTextBox.TabIndex = 42;
            // 
            // pollTimer
            // 
            this.pollTimer.Interval = 50;
            this.pollTimer.Tick += new System.EventHandler(this.pollTimer_Tick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.inputCheck5);
            this.GroupBox1.Controls.Add(this.inputCheck4);
            this.GroupBox1.Controls.Add(this.inputCheck3);
            this.GroupBox1.Controls.Add(this.inputCheck2);
            this.GroupBox1.Controls.Add(this.inputCheck1);
            this.GroupBox1.Location = new System.Drawing.Point(126, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(178, 44);
            this.GroupBox1.TabIndex = 43;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Inputs";
            // 
            // inputCheck5
            // 
            this.inputCheck5.Location = new System.Drawing.Point(141, 21);
            this.inputCheck5.Name = "inputCheck5";
            this.inputCheck5.Size = new System.Drawing.Size(26, 15);
            this.inputCheck5.TabIndex = 4;
            this.inputCheck5.Text = "5";
            this.inputCheck5.UseVisualStyleBackColor = true;
            // 
            // inputCheck4
            // 
            this.inputCheck4.Location = new System.Drawing.Point(109, 21);
            this.inputCheck4.Name = "inputCheck4";
            this.inputCheck4.Size = new System.Drawing.Size(26, 15);
            this.inputCheck4.TabIndex = 3;
            this.inputCheck4.Text = "4";
            this.inputCheck4.UseVisualStyleBackColor = true;
            // 
            // inputCheck3
            // 
            this.inputCheck3.Location = new System.Drawing.Point(77, 21);
            this.inputCheck3.Name = "inputCheck3";
            this.inputCheck3.Size = new System.Drawing.Size(26, 15);
            this.inputCheck3.TabIndex = 2;
            this.inputCheck3.Text = "3";
            this.inputCheck3.UseVisualStyleBackColor = true;
            // 
            // inputCheck2
            // 
            this.inputCheck2.Location = new System.Drawing.Point(45, 21);
            this.inputCheck2.Name = "inputCheck2";
            this.inputCheck2.Size = new System.Drawing.Size(26, 15);
            this.inputCheck2.TabIndex = 1;
            this.inputCheck2.Text = "2";
            this.inputCheck2.UseVisualStyleBackColor = true;
            // 
            // inputCheck1
            // 
            this.inputCheck1.Location = new System.Drawing.Point(13, 21);
            this.inputCheck1.Name = "inputCheck1";
            this.inputCheck1.Size = new System.Drawing.Size(26, 15);
            this.inputCheck1.TabIndex = 0;
            this.inputCheck1.Text = "1";
            this.inputCheck1.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.outputCheck8);
            this.GroupBox2.Controls.Add(this.outputCheck7);
            this.GroupBox2.Controls.Add(this.outputCheck6);
            this.GroupBox2.Controls.Add(this.outputCheck5);
            this.GroupBox2.Controls.Add(this.outputCheck4);
            this.GroupBox2.Controls.Add(this.outputCheck3);
            this.GroupBox2.Controls.Add(this.outputCheck2);
            this.GroupBox2.Controls.Add(this.outputCheck1);
            this.GroupBox2.Location = new System.Drawing.Point(310, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(267, 45);
            this.GroupBox2.TabIndex = 44;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Outputs";
            // 
            // outputCheck8
            // 
            this.outputCheck8.Location = new System.Drawing.Point(232, 21);
            this.outputCheck8.Name = "outputCheck8";
            this.outputCheck8.Size = new System.Drawing.Size(26, 15);
            this.outputCheck8.TabIndex = 12;
            this.outputCheck8.Text = "8";
            this.outputCheck8.UseVisualStyleBackColor = true;
            // 
            // outputCheck7
            // 
            this.outputCheck7.Location = new System.Drawing.Point(200, 21);
            this.outputCheck7.Name = "outputCheck7";
            this.outputCheck7.Size = new System.Drawing.Size(26, 15);
            this.outputCheck7.TabIndex = 11;
            this.outputCheck7.Text = "7";
            this.outputCheck7.UseVisualStyleBackColor = true;
            // 
            // outputCheck6
            // 
            this.outputCheck6.Location = new System.Drawing.Point(168, 21);
            this.outputCheck6.Name = "outputCheck6";
            this.outputCheck6.Size = new System.Drawing.Size(26, 15);
            this.outputCheck6.TabIndex = 10;
            this.outputCheck6.Text = "6";
            this.outputCheck6.UseVisualStyleBackColor = true;
            // 
            // outputCheck5
            // 
            this.outputCheck5.Location = new System.Drawing.Point(136, 21);
            this.outputCheck5.Name = "outputCheck5";
            this.outputCheck5.Size = new System.Drawing.Size(26, 15);
            this.outputCheck5.TabIndex = 9;
            this.outputCheck5.Text = "5";
            this.outputCheck5.UseVisualStyleBackColor = true;
            // 
            // outputCheck4
            // 
            this.outputCheck4.Location = new System.Drawing.Point(104, 21);
            this.outputCheck4.Name = "outputCheck4";
            this.outputCheck4.Size = new System.Drawing.Size(26, 15);
            this.outputCheck4.TabIndex = 8;
            this.outputCheck4.Text = "4";
            this.outputCheck4.UseVisualStyleBackColor = true;
            // 
            // outputCheck3
            // 
            this.outputCheck3.Location = new System.Drawing.Point(72, 21);
            this.outputCheck3.Name = "outputCheck3";
            this.outputCheck3.Size = new System.Drawing.Size(26, 15);
            this.outputCheck3.TabIndex = 7;
            this.outputCheck3.Text = "3";
            this.outputCheck3.UseVisualStyleBackColor = true;
            // 
            // outputCheck2
            // 
            this.outputCheck2.Location = new System.Drawing.Point(40, 21);
            this.outputCheck2.Name = "outputCheck2";
            this.outputCheck2.Size = new System.Drawing.Size(26, 15);
            this.outputCheck2.TabIndex = 6;
            this.outputCheck2.Text = "2";
            this.outputCheck2.UseVisualStyleBackColor = true;
            // 
            // outputCheck1
            // 
            this.outputCheck1.Location = new System.Drawing.Point(8, 21);
            this.outputCheck1.Name = "outputCheck1";
            this.outputCheck1.Size = new System.Drawing.Size(26, 15);
            this.outputCheck1.TabIndex = 5;
            this.outputCheck1.Text = "1";
            this.outputCheck1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 312);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.addressCheckGrp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "GPIO to VClock Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addressCheckGrp.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox addressCheckGrp;
        internal System.Windows.Forms.CheckBox addressCheck2;
        internal System.Windows.Forms.CheckBox addressCheck1;
        private System.Windows.Forms.TextBox logTextBox;
        internal System.Windows.Forms.Timer pollTimer;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox inputCheck5;
        internal System.Windows.Forms.CheckBox inputCheck4;
        internal System.Windows.Forms.CheckBox inputCheck3;
        internal System.Windows.Forms.CheckBox inputCheck2;
        internal System.Windows.Forms.CheckBox inputCheck1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.CheckBox outputCheck8;
        internal System.Windows.Forms.CheckBox outputCheck7;
        internal System.Windows.Forms.CheckBox outputCheck6;
        internal System.Windows.Forms.CheckBox outputCheck5;
        internal System.Windows.Forms.CheckBox outputCheck4;
        internal System.Windows.Forms.CheckBox outputCheck3;
        internal System.Windows.Forms.CheckBox outputCheck2;
        internal System.Windows.Forms.CheckBox outputCheck1;
    }
}

