namespace Sudoku
{
    partial class FormOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPickImageDestination = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImageDestination = new System.Windows.Forms.TextBox();
            this.numericLineSize = new System.Windows.Forms.NumericUpDown();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericCellSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericBlanks = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericHelpAvailable = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCellSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHelpAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPickImageDestination);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxImageDestination);
            this.groupBox1.Controls.Add(this.numericLineSize);
            this.groupBox1.Controls.Add(this.numericFontSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericCellSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 101);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing";
            // 
            // buttonPickImageDestination
            // 
            this.buttonPickImageDestination.Location = new System.Drawing.Point(426, 17);
            this.buttonPickImageDestination.Name = "buttonPickImageDestination";
            this.buttonPickImageDestination.Size = new System.Drawing.Size(27, 23);
            this.buttonPickImageDestination.TabIndex = 17;
            this.buttonPickImageDestination.Text = "...";
            this.buttonPickImageDestination.UseVisualStyleBackColor = true;
            this.buttonPickImageDestination.Click += new System.EventHandler(this.ButtonPickImageDestination_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Image destination";
            // 
            // textBoxImageDestination
            // 
            this.textBoxImageDestination.Location = new System.Drawing.Point(255, 18);
            this.textBoxImageDestination.Name = "textBoxImageDestination";
            this.textBoxImageDestination.ReadOnly = true;
            this.textBoxImageDestination.Size = new System.Drawing.Size(165, 20);
            this.textBoxImageDestination.TabIndex = 15;
            // 
            // numericLineSize
            // 
            this.numericLineSize.Location = new System.Drawing.Point(92, 71);
            this.numericLineSize.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericLineSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericLineSize.Name = "numericLineSize";
            this.numericLineSize.Size = new System.Drawing.Size(61, 20);
            this.numericLineSize.TabIndex = 14;
            this.numericLineSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericLineSize.ValueChanged += new System.EventHandler(this.NumericLineSize_ValueChanged);
            // 
            // numericFontSize
            // 
            this.numericFontSize.Location = new System.Drawing.Point(92, 45);
            this.numericFontSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericFontSize.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(61, 20);
            this.numericFontSize.TabIndex = 13;
            this.numericFontSize.Value = new decimal(new int[] {
            46,
            0,
            0,
            0});
            this.numericFontSize.ValueChanged += new System.EventHandler(this.NumericFontSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Printed line size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Printed font size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Printed cell size";
            // 
            // numericCellSize
            // 
            this.numericCellSize.Location = new System.Drawing.Point(92, 19);
            this.numericCellSize.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericCellSize.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericCellSize.Name = "numericCellSize";
            this.numericCellSize.Size = new System.Drawing.Size(61, 20);
            this.numericCellSize.TabIndex = 9;
            this.numericCellSize.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericCellSize.ValueChanged += new System.EventHandler(this.NumericCellSize_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericHelpAvailable);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericBlanks);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 72);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desired blanks";
            // 
            // numericBlanks
            // 
            this.numericBlanks.Location = new System.Drawing.Point(92, 19);
            this.numericBlanks.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericBlanks.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericBlanks.Name = "numericBlanks";
            this.numericBlanks.Size = new System.Drawing.Size(61, 20);
            this.numericBlanks.TabIndex = 11;
            this.numericBlanks.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericBlanks.ValueChanged += new System.EventHandler(this.NumericBlanks_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Help available";
            // 
            // numericHelpAvailable
            // 
            this.numericHelpAvailable.Location = new System.Drawing.Point(92, 45);
            this.numericHelpAvailable.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericHelpAvailable.Name = "numericHelpAvailable";
            this.numericHelpAvailable.Size = new System.Drawing.Size(61, 20);
            this.numericHelpAvailable.TabIndex = 13;
            this.numericHelpAvailable.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericHelpAvailable.ValueChanged += new System.EventHandler(this.NumericHelpAvailable_ValueChanged);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku - options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOptions_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCellSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHelpAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericCellSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericLineSize;
        private System.Windows.Forms.NumericUpDown numericFontSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericBlanks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImageDestination;
        private System.Windows.Forms.Button buttonPickImageDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericHelpAvailable;
    }
}