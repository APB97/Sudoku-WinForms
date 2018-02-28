using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class PoleSudoku : UserControl
    {
        public string ZawartoscPola
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public PoleSudoku()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && !char.IsDigit(textBox.Text[0]))
                textBox.Text = string.Empty;
        }
    }
}
