namespace Sudoku
{
    partial class FormMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPrzyciskiMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.buttonOpcje = new System.Windows.Forms.Button();
            this.buttonWczytaj = new System.Windows.Forms.Button();
            this.buttonGraj = new System.Windows.Forms.Button();
            this.labelGameTitle = new System.Windows.Forms.Label();
            this.panelMainMenu.SuspendLayout();
            this.tableLayoutPanelMainMenu.SuspendLayout();
            this.tableLayoutPanelPrzyciskiMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.tableLayoutPanelMainMenu);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(484, 461);
            this.panelMainMenu.TabIndex = 0;
            // 
            // tableLayoutPanelMainMenu
            // 
            this.tableLayoutPanelMainMenu.ColumnCount = 3;
            this.tableLayoutPanelMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanelMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.33533F));
            this.tableLayoutPanelMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanelMainMenu.Controls.Add(this.tableLayoutPanelPrzyciskiMainMenu, 1, 1);
            this.tableLayoutPanelMainMenu.Controls.Add(this.labelGameTitle, 1, 0);
            this.tableLayoutPanelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMainMenu.Name = "tableLayoutPanelMainMenu";
            this.tableLayoutPanelMainMenu.RowCount = 2;
            this.tableLayoutPanelMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanelMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanelMainMenu.Size = new System.Drawing.Size(484, 461);
            this.tableLayoutPanelMainMenu.TabIndex = 1;
            // 
            // tableLayoutPanelPrzyciskiMainMenu
            // 
            this.tableLayoutPanelPrzyciskiMainMenu.ColumnCount = 1;
            this.tableLayoutPanelPrzyciskiMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonWyjscie, 0, 3);
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonOpcje, 0, 2);
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonWczytaj, 0, 1);
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonGraj, 0, 0);
            this.tableLayoutPanelPrzyciskiMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrzyciskiMainMenu.Location = new System.Drawing.Point(115, 76);
            this.tableLayoutPanelPrzyciskiMainMenu.Name = "tableLayoutPanelPrzyciskiMainMenu";
            this.tableLayoutPanelPrzyciskiMainMenu.RowCount = 5;
            this.tableLayoutPanelPrzyciskiMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelPrzyciskiMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelPrzyciskiMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelPrzyciskiMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelPrzyciskiMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrzyciskiMainMenu.Size = new System.Drawing.Size(252, 382);
            this.tableLayoutPanelPrzyciskiMainMenu.TabIndex = 1;
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWyjscie.Location = new System.Drawing.Point(3, 99);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(246, 26);
            this.buttonWyjscie.TabIndex = 3;
            this.buttonWyjscie.Text = "Wyjście";
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // buttonOpcje
            // 
            this.buttonOpcje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpcje.Enabled = false;
            this.buttonOpcje.Location = new System.Drawing.Point(3, 67);
            this.buttonOpcje.Name = "buttonOpcje";
            this.buttonOpcje.Size = new System.Drawing.Size(246, 26);
            this.buttonOpcje.TabIndex = 2;
            this.buttonOpcje.Text = "Opcje";
            this.buttonOpcje.UseVisualStyleBackColor = true;
            // 
            // buttonWczytaj
            // 
            this.buttonWczytaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWczytaj.Location = new System.Drawing.Point(3, 35);
            this.buttonWczytaj.Name = "buttonWczytaj";
            this.buttonWczytaj.Size = new System.Drawing.Size(246, 26);
            this.buttonWczytaj.TabIndex = 1;
            this.buttonWczytaj.Text = "Wczytaj";
            this.buttonWczytaj.UseVisualStyleBackColor = true;
            this.buttonWczytaj.Click += new System.EventHandler(this.buttonWczytaj_Click);
            // 
            // buttonGraj
            // 
            this.buttonGraj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGraj.Location = new System.Drawing.Point(3, 3);
            this.buttonGraj.Name = "buttonGraj";
            this.buttonGraj.Size = new System.Drawing.Size(246, 26);
            this.buttonGraj.TabIndex = 0;
            this.buttonGraj.Text = "Graj!";
            this.buttonGraj.UseVisualStyleBackColor = true;
            this.buttonGraj.Click += new System.EventHandler(this.buttonGraj_Click);
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameTitle.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameTitle.Location = new System.Drawing.Point(115, 0);
            this.labelGameTitle.Name = "labelGameTitle";
            this.labelGameTitle.Size = new System.Drawing.Size(252, 73);
            this.labelGameTitle.TabIndex = 2;
            this.labelGameTitle.Text = "Sudoku";
            this.labelGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku - menu główne";
            this.panelMainMenu.ResumeLayout(false);
            this.tableLayoutPanelMainMenu.ResumeLayout(false);
            this.tableLayoutPanelPrzyciskiMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainMenu;
        private System.Windows.Forms.Button buttonGraj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrzyciskiMainMenu;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Button buttonOpcje;
        private System.Windows.Forms.Button buttonWczytaj;
        private System.Windows.Forms.Label labelGameTitle;
    }
}

