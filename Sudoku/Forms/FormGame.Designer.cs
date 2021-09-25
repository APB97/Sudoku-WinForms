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
            this.buttonSaveState = new System.Windows.Forms.Button();
            this.saveSudokuDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelSudoku = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelRemainingSupports = new System.Windows.Forms.Label();
            this.labelDostepne = new System.Windows.Forms.Label();
            this.buttonSupportMe = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.buttonLoadState = new System.Windows.Forms.Button();
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
            // buttonSaveState
            // 
            this.buttonSaveState.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonSaveState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveState.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonSaveState.Location = new System.Drawing.Point(12, 435);
            this.buttonSaveState.Name = "buttonSaveState";
            this.buttonSaveState.Size = new System.Drawing.Size(70, 23);
            this.buttonSaveState.TabIndex = 1;
            this.buttonSaveState.Text = "Zapisz";
            this.toolTip1.SetToolTip(this.buttonSaveState, "Zapis stanu gry.");
            this.buttonSaveState.UseVisualStyleBackColor = false;
            this.buttonSaveState.Click += new System.EventHandler(this.ButtonSaveState_Click);
            // 
            // saveSudokuDialog
            // 
            this.saveSudokuDialog.CreatePrompt = true;
            this.saveSudokuDialog.Filter = "Pliki tekstowe|*.txt";
            this.saveSudokuDialog.Title = "Zapisz Sudoku";
            // 
            // panelSudoku
            // 
            this.panelSudoku.Controls.Add(this.buttonPrint);
            this.panelSudoku.Controls.Add(this.labelRemainingSupports);
            this.panelSudoku.Controls.Add(this.labelDostepne);
            this.panelSudoku.Controls.Add(this.buttonSupportMe);
            this.panelSudoku.Controls.Add(this.buttonSolve);
            this.panelSudoku.Controls.Add(this.buttonBackToMenu);
            this.panelSudoku.Controls.Add(this.buttonLoadState);
            this.panelSudoku.Controls.Add(this.tableLayoutPanelPlansza);
            this.panelSudoku.Controls.Add(this.buttonSaveState);
            this.panelSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSudoku.Location = new System.Drawing.Point(0, 0);
            this.panelSudoku.Name = "panelSudoku";
            this.panelSudoku.Size = new System.Drawing.Size(484, 461);
            this.panelSudoku.TabIndex = 2;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonPrint.Location = new System.Drawing.Point(433, 55);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(48, 37);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Drukuj";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // labelRemainingSupports
            // 
            this.labelRemainingSupports.AutoSize = true;
            this.labelRemainingSupports.Location = new System.Drawing.Point(417, 440);
            this.labelRemainingSupports.Name = "labelRemainingSupports";
            this.labelRemainingSupports.Size = new System.Drawing.Size(13, 13);
            this.labelRemainingSupports.TabIndex = 6;
            this.labelRemainingSupports.Text = "3";
            // 
            // labelDostepne
            // 
            this.labelDostepne.Location = new System.Drawing.Point(365, 440);
            this.labelDostepne.Name = "labelDostepne";
            this.labelDostepne.Size = new System.Drawing.Size(56, 13);
            this.labelDostepne.TabIndex = 7;
            this.labelDostepne.Text = "Dostępne:";
            // 
            // buttonSupportMe
            // 
            this.buttonSupportMe.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonSupportMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupportMe.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonSupportMe.Location = new System.Drawing.Point(294, 435);
            this.buttonSupportMe.Name = "buttonSupportMe";
            this.buttonSupportMe.Size = new System.Drawing.Size(65, 23);
            this.buttonSupportMe.TabIndex = 5;
            this.buttonSupportMe.Text = "Pomóż mi!";
            this.toolTip1.SetToolTip(this.buttonSupportMe, "Uzupełnia jedno pole w Sudoku.");
            this.buttonSupportMe.UseVisualStyleBackColor = false;
            this.buttonSupportMe.Click += new System.EventHandler(this.ButtonSupportMe_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonSolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSolve.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonSolve.Location = new System.Drawing.Point(164, 435);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(124, 23);
            this.buttonSolve.TabIndex = 4;
            this.buttonSolve.Text = "Rozwiąz za mnie!";
            this.toolTip1.SetToolTip(this.buttonSolve, "Pokazuje rozwiązane Sudoku.");
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.ButtonSolve_Click);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMenu.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonBackToMenu.Location = new System.Drawing.Point(433, 12);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(48, 37);
            this.buttonBackToMenu.TabIndex = 3;
            this.buttonBackToMenu.Text = "Do menu";
            this.toolTip1.SetToolTip(this.buttonBackToMenu, "Powrót do menu.");
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.ButtonBackToMenu_Click);
            // 
            // buttonLoadState
            // 
            this.buttonLoadState.BackColor = global::Sudoku.Properties.Settings.Default.KolorPrzyciskow;
            this.buttonLoadState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoadState.ForeColor = global::Sudoku.Properties.Settings.Default.KolorTekstuPrzyciskow;
            this.buttonLoadState.Location = new System.Drawing.Point(88, 435);
            this.buttonLoadState.Name = "buttonLoadState";
            this.buttonLoadState.Size = new System.Drawing.Size(70, 23);
            this.buttonLoadState.TabIndex = 2;
            this.buttonLoadState.Text = "Wczytaj";
            this.toolTip1.SetToolTip(this.buttonLoadState, "Wczytanie stanu gry.");
            this.buttonLoadState.UseVisualStyleBackColor = false;
            this.buttonLoadState.Click += new System.EventHandler(this.ButtonLoadState_Click);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.panelSudoku.ResumeLayout(false);
            this.panelSudoku.PerformLayout();
            this.tableLayoutPanelPlansza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveState;
        private System.Windows.Forms.SaveFileDialog saveSudokuDialog;
        private System.Windows.Forms.Panel panelSudoku;
        private System.Windows.Forms.Button buttonLoadState;
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
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonSupportMe;
        private System.Windows.Forms.Label labelRemainingSupports;
        private System.Windows.Forms.Label labelDostepne;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}