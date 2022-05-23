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
    public partial class QUIZFUTEBOL1 : Form
    {
        public QUIZFUTEBOL1()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iNICIARToolStripMenuItem_Click(object sender, EventArgs e)
        {


            QUIZFUTEBOL QFT = new QUIZFUTEBOL();
            QFT.ShowDialog();
            this.Close();
            
        }

        private void qUIZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }   
    }
}
