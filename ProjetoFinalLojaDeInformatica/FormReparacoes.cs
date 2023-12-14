using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLojaDeInformatica
{
    public partial class FormReparacoes : Form
    {
        public FormReparacoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
