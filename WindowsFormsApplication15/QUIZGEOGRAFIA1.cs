using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class QUIZGEOGRAFIA1 : Form
    {
        public QUIZGEOGRAFIA1()
        {
            InitializeComponent();
        }

        private void iNICIARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void iNICIARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QUIZGEOGRAFIA2 QGF2 = new QUIZGEOGRAFIA2();
            QGF2.ShowDialog();
            this.Close();
        }

        private void iNICIARQUIZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
