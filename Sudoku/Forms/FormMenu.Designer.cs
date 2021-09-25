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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
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
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonExit, 0, 3);
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonOptions, 0, 2);
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonLoad, 0, 1);
            this.tableLayoutPanelPrzyciskiMainMenu.Controls.Add(this.buttonPlay, 0, 0);
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
            // buttonExit
            // 
            this.buttonExit.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonExit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Sudoku.Properties.Settings.Default, "KolorTekstuPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonExit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonExit.Location = new System.Drawing.Point(3, 99);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(246, 26);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonOptions.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Sudoku.Properties.Settings.Default, "KolorTekstuPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonOptions.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOptions.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonOptions.Location = new System.Drawing.Point(3, 67);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(246, 26);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Opcje";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonLoad.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoad.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Sudoku.Properties.Settings.Default, "KolorTekstuPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoad.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonLoad.Location = new System.Drawing.Point(3, 35);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(246, 26);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonPlay.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonPlay.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Sudoku.Properties.Settings.Default, "KolorTekstuPrzyciskow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonPlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(246, 26);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Graj!";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // labelGameTitle
            // 
            this.labelGameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameTitle.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BackColor = global::Sudoku.Properties.Settings.Default.KolorOkna;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelMainMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorOkna", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrzyciskiMainMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelGameTitle;
    }
}

