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
    public partial class QUIZFINAL : Form
    {
        public QUIZFINAL()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void QUIZFUTEBOLFINAL_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.acertos.ToString();
            lblErros.Text = VariaveisGlobais.erros.ToString();
            label5.Text = VariaveisGlobais.jogador.ToString();
            label8.Text = VariaveisGlobais.acertos.ToString();

            
            
            
        }

        private void lblAcertos_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}
