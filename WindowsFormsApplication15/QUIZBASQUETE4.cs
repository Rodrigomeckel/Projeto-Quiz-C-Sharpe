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
    public partial class QUIZBASQUETE4 : Form
    {
        public QUIZBASQUETE4()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                VariaveisGlobais.acertos += 1;

                QUIZBASQUETE5 QBQ5 = new QUIZBASQUETE5();
                QBQ5.ShowDialog();
                this.Close();
            }

            else if (rbtn2.Checked || rbtn3.Checked || rbtn4.Checked)
            {
                VariaveisGlobais.erros += 1;

                QUIZBASQUETE5 QBQ5 = new QUIZBASQUETE5();
                QBQ5.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("ESCOLHA UMA OPÇÃO PARA CONTINUAR !!!");
            }
        }
    }
}
