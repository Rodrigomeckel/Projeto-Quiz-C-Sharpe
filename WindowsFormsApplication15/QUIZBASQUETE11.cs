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
    public partial class QUIZBASQUETE11 : Form
    {
        public QUIZBASQUETE11()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                VariaveisGlobais.acertos += 1;

                QUIZFINAL2 QF2 = new QUIZFINAL2();
                QF2.ShowDialog();
                this.Close();
            }

            else if (rbtn2.Checked || rbtn3.Checked || rbtn4.Checked)
            {
                VariaveisGlobais.erros += 1;

                QUIZFINAL2 QFF2 = new QUIZFINAL2();
                QFF2.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("ESCOLHA UMA OPÇÃO PARA CONTINUAR !!!");
            }
        }
    }
}
