using Sudoku.Properties;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormOptions : Form
    {
        private readonly Form mainForm;

        public FormOptions(Form mainForm) : this()
        {
            this.mainForm = mainForm ?? throw new System.ArgumentNullException(nameof(mainForm));
        }

        public FormOptions()
        {
            InitializeComponent();
            numericCellSize.Value = Settings.Default.PrintedCellSize;
            numericFontSize.Value = (decimal)Settings.Default.PrintedFontSize;
            numericLineSize.Value = Settings.Default.PrintedLineWidth;
            numericBlanks.Value = Settings.Default.DesiredBlanks;
            numericHelpAvailable.Value = Settings.Default.SupportsAvailable;
            textBoxImageDestination.Text = Settings.Default.ImageDestination;
        }

        private void FormOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
            if (e.CloseReason == CloseReason.UserClosing)
                mainForm.Show();
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
                Application.Exit();
        }

        private void NumericCellSize_ValueChanged(object sender, System.EventArgs e)
        {
            Settings.Default.PrintedCellSize = (int)numericCellSize.Value;
        }

        private void NumericFontSize_ValueChanged(object sender, System.EventArgs e)
        {
            Settings.Default.PrintedFontSize = (float)numericFontSize.Value;
        }

        private void NumericLineSize_ValueChanged(object sender, System.EventArgs e)
        {
            Settings.Default.PrintedLineWidth = (int)numericLineSize.Value;
        }

        private void NumericBlanks_ValueChanged(object sender, System.EventArgs e)
        {
            Settings.Default.DesiredBlanks = (int)numericBlanks.Value;
        }

        private void NumericHelpAvailable_ValueChanged(object sender, System.EventArgs e)
        {
            Settings.Default.SupportsAvailable = (int)numericHelpAvailable.Value;
        }

        private void ButtonPickImageDestination_Click(object sender, System.EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog() { Filter = "PNG files|*.png" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxImageDestination.Text = Settings.Default.ImageDestination = dialog.FileName;
                }
            }
        }
    }
}
