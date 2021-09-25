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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericCellSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.numericLineSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericLineSize);
            this.groupBox1.Controls.Add(this.numericFontSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericCellSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 101);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Printed cell size";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Printed line size";
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
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku - options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOptions_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericCellSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericLineSize;
        private System.Windows.Forms.NumericUpDown numericFontSize;
    }
}