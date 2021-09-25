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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxObrazZamiastDruku = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxObrazZamiastDruku);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje wydruku";
            // 
            // checkBoxObrazZamiastDruku
            // 
            this.checkBoxObrazZamiastDruku.AutoSize = true;
            this.checkBoxObrazZamiastDruku.Checked = global::Sudoku.Properties.Settings.Default.PictureInsteadOfPrint;
            this.checkBoxObrazZamiastDruku.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Sudoku.Properties.Settings.Default, "PictureInsteadOfPrint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxObrazZamiastDruku.Location = new System.Drawing.Point(6, 19);
            this.checkBoxObrazZamiastDruku.Name = "checkBoxObrazZamiastDruku";
            this.checkBoxObrazZamiastDruku.Size = new System.Drawing.Size(122, 17);
            this.checkBoxObrazZamiastDruku.TabIndex = 8;
            this.checkBoxObrazZamiastDruku.Text = "Obraz zamiast druku";
            this.toolTip1.SetToolTip(this.checkBoxObrazZamiastDruku, "Pozwala na zapisanie obrazu w formacie PNG zamiast drukowania Sudoku bezpośrednio" +
        ".");
            this.checkBoxObrazZamiastDruku.UseVisualStyleBackColor = true;
            this.checkBoxObrazZamiastDruku.CheckedChanged += new System.EventHandler(this.checkBoxObrazZamiastDruku_CheckedChanged);
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
            this.Text = "Sudoku - opcje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOpcje_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox checkBoxObrazZamiastDruku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}