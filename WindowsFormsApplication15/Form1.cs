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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.erros = 0;
            QUIZFUTEBOL1 OutroForm = new QUIZFUTEBOL1();
            OutroForm.ShowDialog();
            
        }

        private void Bntsair1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.erros = 0;
            QUIZGEOGRAFIA1 QGF1 = new QUIZGEOGRAFIA1();
            QGF1.ShowDialog();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.erros = 0;
            QUIZBASQUETE1 OutroForm = new QUIZBASQUETE1();
            OutroForm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
