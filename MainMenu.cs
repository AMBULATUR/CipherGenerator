using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ColumnButton_Click(object sender, EventArgs e)
        {
            new ColumnCipher().Show();
        }

        private void VizhnerButton_Click(object sender, EventArgs e)
        {
            new VizhenerCipher().Show();
        }

        private void RotatingGrillButton_Click(object sender, EventArgs e)
        {
            new RotateCipher().Show();
        }
    }
}
