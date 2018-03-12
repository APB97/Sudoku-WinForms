using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormMenu : Form
    {
        public static FormMenu glowneOknoMenu;

        public FormMenu()
        {
            InitializeComponent();
            glowneOknoMenu = this;
        }

        private void buttonGraj_Click(object sender, EventArgs e)
        {
            FormGame gra = new FormGame();
            gra.Show();
            this.Hide();
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
