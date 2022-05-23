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
    public partial class escreva_seu_nome : Form
    {
        public escreva_seu_nome()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void escreva_seu_nome_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            VariaveisGlobais.jogador = textBox1.Text += ","; 
            Form1 ff1 = new Form1();
            ff1.ShowDialog();

        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
