using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLojaDeInformatica
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

       DateTime time;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ficheirpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasMencaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProdutos produtos = new NovoProdutos();
            produtos.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            toolStripStatusLabel1.Text = time.ToLocalTime().ToString();


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonFicheiro_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonVendas_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registroDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReparacoes reparacoes = new FormReparacoes();
            reparacoes.Show();
        }

        private void toolStripButtonReparacoes_Click(object sender, EventArgs e)
        {
            FormReparacoes reparacoes = new FormReparacoes();
            reparacoes.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProdutos produtos = new NovoProdutos();
            produtos.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProdutos produtos = new NovoProdutos();
            produtos.Show();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProdutos produtos = new NovoProdutos();
            produtos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProdutos produtos = new NovoProdutos();
            produtos.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vendasMenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta funcionalidade estará disponível na próxima atualização.";

            MessageBox.Show(mensagem, "Próxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
