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
    public partial class QUIZBASQUETE1 : Form
    {
        public QUIZBASQUETE1()
        {
            InitializeComponent();
        }

        private void iNICIARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void iNICIARQUIZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QUIZBASQUETE2 QBQ2 = new QUIZBASQUETE2();
            QBQ2.ShowDialog();
            this.Close();
        }

        private void QUIZBASQUETE1_Load(object sender, EventArgs e)
        {

        }
    }
}
