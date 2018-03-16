namespace Sudoku
{
    partial class FormOpcje
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
            this.labelTloOkna = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPersonalizacja = new System.Windows.Forms.GroupBox();
            this.buttonTloOkna = new System.Windows.Forms.Button();
            this.buttonTekstPrzyciskow = new System.Windows.Forms.Button();
            this.buttonTloPrzyciskow = new System.Windows.Forms.Button();
            this.groupBoxTrudnoscPlanszy = new System.Windows.Forms.GroupBox();
            this.radioButtonLatwa = new System.Windows.Forms.RadioButton();
            this.radioButtonSrednia = new System.Windows.Forms.RadioButton();
            this.radioButtonTrudna = new System.Windows.Forms.RadioButton();
            this.groupBoxPersonalizacja.SuspendLayout();
            this.groupBoxTrudnoscPlanszy.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTloOkna
            // 
            this.labelTloOkna.AutoSize = true;
            this.labelTloOkna.Location = new System.Drawing.Point(87, 29);
            this.labelTloOkna.Name = "labelTloOkna";
            this.labelTloOkna.Size = new System.Drawing.Size(51, 13);
            this.labelTloOkna.TabIndex = 0;
            this.labelTloOkna.Text = "Tło okna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tło przycisków";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tekst przyciskow";
            // 
            // groupBoxPersonalizacja
            // 
            this.groupBoxPersonalizacja.Controls.Add(this.buttonTloOkna);
            this.groupBoxPersonalizacja.Controls.Add(this.label2);
            this.groupBoxPersonalizacja.Controls.Add(this.labelTloOkna);
            this.groupBoxPersonalizacja.Controls.Add(this.buttonTekstPrzyciskow);
            this.groupBoxPersonalizacja.Controls.Add(this.label1);
            this.groupBoxPersonalizacja.Controls.Add(this.buttonTloPrzyciskow);
            this.groupBoxPersonalizacja.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonalizacja.Name = "groupBoxPersonalizacja";
            this.groupBoxPersonalizacja.Size = new System.Drawing.Size(200, 111);
            this.groupBoxPersonalizacja.TabIndex = 6;
            this.groupBoxPersonalizacja.TabStop = false;
            this.groupBoxPersonalizacja.Text = "Personalizacja";
            // 
            // buttonTloOkna
            // 
            this.buttonTloOkna.BackColor = global::Sudoku.Properties.Settings.Default.KolorOkna;
            this.buttonTloOkna.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorOkna", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTloOkna.Location = new System.Drawing.Point(6, 19);
            this.buttonTloOkna.Name = "buttonTloOkna";
            this.buttonTloOkna.Size = new System.Drawing.Size(75, 23);
            this.buttonTloOkna.TabIndex = 1;
            this.buttonTloOkna.UseVisualStyleBackColor = false;
            this.buttonTloOkna.Click += new System.EventHandler(this.buttonTloOkna_Click);
            // 
            // buttonTekstPrzyciskow
            // 
            this.buttonTekstPrzyciskow.BackColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonTekstPrzyciskow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorTekstuPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTekstPrzyciskow.Location = new System.Drawing.Point(6, 79);
            this.buttonTekstPrzyciskow.Name = "buttonTekstPrzyciskow";
            this.buttonTekstPrzyciskow.Size = new System.Drawing.Size(75, 23);
            this.buttonTekstPrzyciskow.TabIndex = 4;
            this.buttonTekstPrzyciskow.UseVisualStyleBackColor = false;
            this.buttonTekstPrzyciskow.Click += new System.EventHandler(this.buttonTekstPrzyciskow_Click);
            // 
            // buttonTloPrzyciskow
            // 
            this.buttonTloPrzyciskow.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonTloPrzyciskow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTloPrzyciskow.Location = new System.Drawing.Point(6, 50);
            this.buttonTloPrzyciskow.Name = "buttonTloPrzyciskow";
            this.buttonTloPrzyciskow.Size = new System.Drawing.Size(75, 23);
            this.buttonTloPrzyciskow.TabIndex = 3;
            this.buttonTloPrzyciskow.UseVisualStyleBackColor = false;
            this.buttonTloPrzyciskow.Click += new System.EventHandler(this.buttonTloPrzyciskow_Click);
            // 
            // groupBoxTrudnoscPlanszy
            // 
            this.groupBoxTrudnoscPlanszy.Controls.Add(this.radioButtonTrudna);
            this.groupBoxTrudnoscPlanszy.Controls.Add(this.radioButtonSrednia);
            this.groupBoxTrudnoscPlanszy.Controls.Add(this.radioButtonLatwa);
            this.groupBoxTrudnoscPlanszy.Location = new System.Drawing.Point(12, 130);
            this.groupBoxTrudnoscPlanszy.Name = "groupBoxTrudnoscPlanszy";
            this.groupBoxTrudnoscPlanszy.Size = new System.Drawing.Size(200, 117);
            this.groupBoxTrudnoscPlanszy.TabIndex = 7;
            this.groupBoxTrudnoscPlanszy.TabStop = false;
            this.groupBoxTrudnoscPlanszy.Text = "Trudność planszy";
            // 
            // radioButtonLatwa
            // 
            this.radioButtonLatwa.AutoSize = true;
            this.radioButtonLatwa.Location = new System.Drawing.Point(6, 20);
            this.radioButtonLatwa.Name = "radioButtonLatwa";
            this.radioButtonLatwa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonLatwa.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLatwa.TabIndex = 0;
            this.radioButtonLatwa.TabStop = true;
            this.radioButtonLatwa.Text = "Łatwa";
            this.radioButtonLatwa.UseVisualStyleBackColor = true;
            this.radioButtonLatwa.CheckedChanged += new System.EventHandler(this.radioButtonLatwa_CheckedChanged);
            // 
            // radioButtonSrednia
            // 
            this.radioButtonSrednia.AutoSize = true;
            this.radioButtonSrednia.Location = new System.Drawing.Point(6, 43);
            this.radioButtonSrednia.Name = "radioButtonSrednia";
            this.radioButtonSrednia.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSrednia.TabIndex = 1;
            this.radioButtonSrednia.TabStop = true;
            this.radioButtonSrednia.Text = "Średnia";
            this.radioButtonSrednia.UseVisualStyleBackColor = true;
            this.radioButtonSrednia.CheckedChanged += new System.EventHandler(this.radioButtonSrednia_CheckedChanged);
            // 
            // radioButtonTrudna
            // 
            this.radioButtonTrudna.AutoSize = true;
            this.radioButtonTrudna.Location = new System.Drawing.Point(6, 66);
            this.radioButtonTrudna.Name = "radioButtonTrudna";
            this.radioButtonTrudna.Size = new System.Drawing.Size(59, 17);
            this.radioButtonTrudna.TabIndex = 2;
            this.radioButtonTrudna.TabStop = true;
            this.radioButtonTrudna.Text = "Trudna";
            this.radioButtonTrudna.UseVisualStyleBackColor = true;
            this.radioButtonTrudna.CheckedChanged += new System.EventHandler(this.radioButtonTrudna_CheckedChanged);
            // 
            // FormOpcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Sudoku.Properties.Settings.Default.KolorOkna;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBoxTrudnoscPlanszy);
            this.Controls.Add(this.groupBoxPersonalizacja);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorOkna", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximizeBox = false;
            this.Name = "FormOpcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku - opcje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOpcje_FormClosed);
            this.Load += new System.EventHandler(this.FormOpcje_Load);
            this.groupBoxPersonalizacja.ResumeLayout(false);
            this.groupBoxPersonalizacja.PerformLayout();
            this.groupBoxTrudnoscPlanszy.ResumeLayout(false);
            this.groupBoxTrudnoscPlanszy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTloOkna;
        private System.Windows.Forms.Button buttonTloOkna;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTloPrzyciskow;
        private System.Windows.Forms.Button buttonTekstPrzyciskow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPersonalizacja;
        private System.Windows.Forms.GroupBox groupBoxTrudnoscPlanszy;
        private System.Windows.Forms.RadioButton radioButtonTrudna;
        private System.Windows.Forms.RadioButton radioButtonSrednia;
        private System.Windows.Forms.RadioButton radioButtonLatwa;
    }
}