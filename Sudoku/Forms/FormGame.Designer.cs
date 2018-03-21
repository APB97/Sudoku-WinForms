namespace Sudoku
{
    partial class FormGame
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
            this.buttonZapiszStan = new System.Windows.Forms.Button();
            this.saveSudokuDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelSudoku = new System.Windows.Forms.Panel();
            this.buttonDrukuj = new System.Windows.Forms.Button();
            this.labelPozostaloPomocy = new System.Windows.Forms.Label();
            this.labelDostepne = new System.Windows.Forms.Label();
            this.buttonPomoz = new System.Windows.Forms.Button();
            this.buttonRozwiaz = new System.Windows.Forms.Button();
            this.button_DoMenu = new System.Windows.Forms.Button();
            this.buttonWczytajStan = new System.Windows.Forms.Button();
            this.tableLayoutPanelPlansza = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.openSudokuDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSudoku.SuspendLayout();
            this.tableLayoutPanelPlansza.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonZapiszStan
            // 
            this.buttonZapiszStan.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonZapiszStan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZapiszStan.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonZapiszStan.Location = new System.Drawing.Point(12, 435);
            this.buttonZapiszStan.Name = "buttonZapiszStan";
            this.buttonZapiszStan.Size = new System.Drawing.Size(70, 23);
            this.buttonZapiszStan.TabIndex = 1;
            this.buttonZapiszStan.Text = "Zapisz";
            this.toolTip1.SetToolTip(this.buttonZapiszStan, "Zapis stanu gry.");
            this.buttonZapiszStan.UseVisualStyleBackColor = false;
            this.buttonZapiszStan.Click += new System.EventHandler(this.buttonZapiszStan_Click);
            // 
            // saveSudokuDialog
            // 
            this.saveSudokuDialog.CreatePrompt = true;
            this.saveSudokuDialog.Filter = "Pliki tekstowe|*.txt";
            this.saveSudokuDialog.Title = "Zapisz Sudoku";
            // 
            // panelSudoku
            // 
            this.panelSudoku.Controls.Add(this.buttonDrukuj);
            this.panelSudoku.Controls.Add(this.labelPozostaloPomocy);
            this.panelSudoku.Controls.Add(this.labelDostepne);
            this.panelSudoku.Controls.Add(this.buttonPomoz);
            this.panelSudoku.Controls.Add(this.buttonRozwiaz);
            this.panelSudoku.Controls.Add(this.button_DoMenu);
            this.panelSudoku.Controls.Add(this.buttonWczytajStan);
            this.panelSudoku.Controls.Add(this.tableLayoutPanelPlansza);
            this.panelSudoku.Controls.Add(this.buttonZapiszStan);
            this.panelSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSudoku.Location = new System.Drawing.Point(0, 0);
            this.panelSudoku.Name = "panelSudoku";
            this.panelSudoku.Size = new System.Drawing.Size(484, 461);
            this.panelSudoku.TabIndex = 2;
            // 
            // buttonDrukuj
            // 
            this.buttonDrukuj.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonDrukuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDrukuj.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonDrukuj.Location = new System.Drawing.Point(433, 55);
            this.buttonDrukuj.Name = "buttonDrukuj";
            this.buttonDrukuj.Size = new System.Drawing.Size(48, 37);
            this.buttonDrukuj.TabIndex = 8;
            this.buttonDrukuj.Text = "Drukuj";
            this.buttonDrukuj.UseVisualStyleBackColor = false;
            this.buttonDrukuj.Click += new System.EventHandler(this.buttonDrukuj_Click);
            // 
            // labelPozostaloPomocy
            // 
            this.labelPozostaloPomocy.AutoSize = true;
            this.labelPozostaloPomocy.Location = new System.Drawing.Point(417, 440);
            this.labelPozostaloPomocy.Name = "labelPozostaloPomocy";
            this.labelPozostaloPomocy.Size = new System.Drawing.Size(13, 13);
            this.labelPozostaloPomocy.TabIndex = 6;
            this.labelPozostaloPomocy.Text = "3";
            // 
            // labelDostepne
            // 
            this.labelDostepne.Location = new System.Drawing.Point(365, 440);
            this.labelDostepne.Name = "labelDostepne";
            this.labelDostepne.Size = new System.Drawing.Size(56, 13);
            this.labelDostepne.TabIndex = 7;
            this.labelDostepne.Text = "Dostępne:";
            // 
            // buttonPomoz
            // 
            this.buttonPomoz.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonPomoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPomoz.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonPomoz.Location = new System.Drawing.Point(294, 435);
            this.buttonPomoz.Name = "buttonPomoz";
            this.buttonPomoz.Size = new System.Drawing.Size(65, 23);
            this.buttonPomoz.TabIndex = 5;
            this.buttonPomoz.Text = "Pomóż mi!";
            this.toolTip1.SetToolTip(this.buttonPomoz, "Uzupełnia jedno pole w Sudoku.");
            this.buttonPomoz.UseVisualStyleBackColor = false;
            this.buttonPomoz.Click += new System.EventHandler(this.buttonPomoz_Click);
            // 
            // buttonRozwiaz
            // 
            this.buttonRozwiaz.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonRozwiaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRozwiaz.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonRozwiaz.Location = new System.Drawing.Point(164, 435);
            this.buttonRozwiaz.Name = "buttonRozwiaz";
            this.buttonRozwiaz.Size = new System.Drawing.Size(124, 23);
            this.buttonRozwiaz.TabIndex = 4;
            this.buttonRozwiaz.Text = "Rozwiąz za mnie!";
            this.toolTip1.SetToolTip(this.buttonRozwiaz, "Pokazuje rozwiązane Sudoku.");
            this.buttonRozwiaz.UseVisualStyleBackColor = false;
            this.buttonRozwiaz.Click += new System.EventHandler(this.buttonRozwiaz_Click);
            // 
            // button_DoMenu
            // 
            this.button_DoMenu.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.button_DoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DoMenu.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.button_DoMenu.Location = new System.Drawing.Point(433, 12);
            this.button_DoMenu.Name = "button_DoMenu";
            this.button_DoMenu.Size = new System.Drawing.Size(48, 37);
            this.button_DoMenu.TabIndex = 3;
            this.button_DoMenu.Text = "Do menu";
            this.toolTip1.SetToolTip(this.button_DoMenu, "Powrót do menu.");
            this.button_DoMenu.UseVisualStyleBackColor = false;
            this.button_DoMenu.Click += new System.EventHandler(this.button_DoMenu_Click);
            // 
            // buttonWczytajStan
            // 
            this.buttonWczytajStan.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonWczytajStan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWczytajStan.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonWczytajStan.Location = new System.Drawing.Point(88, 435);
            this.buttonWczytajStan.Name = "buttonWczytajStan";
            this.buttonWczytajStan.Size = new System.Drawing.Size(70, 23);
            this.buttonWczytajStan.TabIndex = 2;
            this.buttonWczytajStan.Text = "Wczytaj";
            this.toolTip1.SetToolTip(this.buttonWczytajStan, "Wczytanie stanu gry.");
            this.buttonWczytajStan.UseVisualStyleBackColor = false;
            this.buttonWczytajStan.Click += new System.EventHandler(this.buttonWczytajStan_Click);
            // 
            // tableLayoutPanelPlansza
            // 
            this.tableLayoutPanelPlansza.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanelPlansza.ColumnCount = 3;
            this.tableLayoutPanelPlansza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlansza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlansza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel7, 1, 2);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel8, 2, 2);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel0, 0, 0);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanelPlansza.Controls.Add(this.tableLayoutPanel5, 2, 1);
            this.tableLayoutPanelPlansza.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelPlansza.Name = "tableLayoutPanelPlansza";
            this.tableLayoutPanelPlansza.RowCount = 3;
            this.tableLayoutPanelPlansza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlansza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlansza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPlansza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPlansza.Size = new System.Drawing.Size(418, 420);
            this.tableLayoutPanelPlansza.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(141, 282);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(135, 134);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 282);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(133, 134);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(280, 282);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(134, 134);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(141, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 134);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel0
            // 
            this.tableLayoutPanel0.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel0.ColumnCount = 3;
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel0.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel0.Margin = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.tableLayoutPanel0.Name = "tableLayoutPanel0";
            this.tableLayoutPanel0.RowCount = 3;
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel0.Size = new System.Drawing.Size(133, 134);
            this.tableLayoutPanel0.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(280, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 4, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 134);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 142);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 136);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(141, 142);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(135, 136);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(280, 142);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(134, 136);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // openSudokuDialog
            // 
            this.openSudokuDialog.Filter = "Pliki tekstowe|*.txt";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Sudoku.Properties.Settings.Default.KolorOkna;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelSudoku);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Sudoku.Properties.Settings.Default, "KolorOkna", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku - gra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panelSudoku.ResumeLayout(false);
            this.panelSudoku.PerformLayout();
            this.tableLayoutPanelPlansza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonZapiszStan;
        private System.Windows.Forms.SaveFileDialog saveSudokuDialog;
        private System.Windows.Forms.Panel panelSudoku;
        private System.Windows.Forms.Button buttonWczytajStan;
        private System.Windows.Forms.OpenFileDialog openSudokuDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlansza;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_DoMenu;
        private System.Windows.Forms.Button buttonRozwiaz;
        private System.Windows.Forms.Button buttonPomoz;
        private System.Windows.Forms.Label labelPozostaloPomocy;
        private System.Windows.Forms.Label labelDostepne;
        private System.Windows.Forms.Button buttonDrukuj;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}