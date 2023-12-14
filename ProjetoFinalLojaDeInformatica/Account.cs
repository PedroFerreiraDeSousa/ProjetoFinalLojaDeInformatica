using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalLojaDeInformatica
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked == true)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Pedro" & textUsername.Text == "Loja do Pedro" & textPassword.Text == "Bestloj@123")
            {
                MessageBox.Show("Login efetuado!");
                this.Close();
                NovoProdutos produtos = new NovoProdutos();
                produtos.Show();
            }
            else
            {
                MessageBox.Show("O Username ou a Password não existe ou está errada, tente novamente!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
