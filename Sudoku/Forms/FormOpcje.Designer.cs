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
            this.buttonTekstPrzyciskow = new System.Windows.Forms.Button();
            this.buttonTloPrzyciskow = new System.Windows.Forms.Button();
            this.buttonTloOkna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTloOkna
            // 
            this.labelTloOkna.AutoSize = true;
            this.labelTloOkna.Location = new System.Drawing.Point(93, 22);
            this.labelTloOkna.Name = "labelTloOkna";
            this.labelTloOkna.Size = new System.Drawing.Size(51, 13);
            this.labelTloOkna.TabIndex = 0;
            this.labelTloOkna.Text = "Tło okna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tło przycisków";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tekst przyciskow";
            // 
            // buttonTekstPrzyciskow
            // 
            this.buttonTekstPrzyciskow.BackColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskosw;
            this.buttonTekstPrzyciskow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorTekstuPrzyciskosw", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTekstPrzyciskow.Location = new System.Drawing.Point(12, 72);
            this.buttonTekstPrzyciskow.Name = "buttonTekstPrzyciskow";
            this.buttonTekstPrzyciskow.Size = new System.Drawing.Size(75, 23);
            this.buttonTekstPrzyciskow.TabIndex = 4;
            this.buttonTekstPrzyciskow.UseVisualStyleBackColor = false;
            this.buttonTekstPrzyciskow.Click += new System.EventHandler(this.buttonTekstPrzyciskow_Click);
            // 
            // buttonTloPrzyciskow
            // 
            this.buttonTloPrzyciskow.BackColor = global::Sudoku.Properties.Settings.Default.KolorPzyciskow;
            this.buttonTloPrzyciskow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorPzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTloPrzyciskow.Location = new System.Drawing.Point(12, 43);
            this.buttonTloPrzyciskow.Name = "buttonTloPrzyciskow";
            this.buttonTloPrzyciskow.Size = new System.Drawing.Size(75, 23);
            this.buttonTloPrzyciskow.TabIndex = 3;
            this.buttonTloPrzyciskow.UseVisualStyleBackColor = false;
            this.buttonTloPrzyciskow.Click += new System.EventHandler(this.buttonTloPrzyciskow_Click);
            // 
            // buttonTloOkna
            // 
            this.buttonTloOkna.BackColor = global::Sudoku.Properties.Settings.Default.KolorOkna;
            this.buttonTloOkna.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorOkna", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTloOkna.Location = new System.Drawing.Point(12, 12);
            this.buttonTloOkna.Name = "buttonTloOkna";
            this.buttonTloOkna.Size = new System.Drawing.Size(75, 23);
            this.buttonTloOkna.TabIndex = 1;
            this.buttonTloOkna.UseVisualStyleBackColor = false;
            this.buttonTloOkna.Click += new System.EventHandler(this.buttonTloOkna_Click);
            // 
            // FormOpcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTekstPrzyciskow);
            this.Controls.Add(this.buttonTloPrzyciskow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTloOkna);
            this.Controls.Add(this.labelTloOkna);
            this.Name = "FormOpcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOpcje_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTloOkna;
        private System.Windows.Forms.Button buttonTloOkna;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTloPrzyciskow;
        private System.Windows.Forms.Button buttonTekstPrzyciskow;
        private System.Windows.Forms.Label label2;
    }
}