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
    public partial class NovoProdutos : Form
    {
        private List<Artigo> listArtigos = new List<Artigo>();
        private Artigo artigoSelecionado; // Para armazenar o artigo selecionado para atualização ou exclusão
        public NovoProdutos()
        {
            InitializeComponent();
            comboBoxCategorias.Items.AddRange(new string[] { "Processadores", "Placas de Vídeo", "Memória RAM", "Armazenamento" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um novo artigo
            Artigo novoArtigo = new Artigo();
            artigoSelecionado = null; // Limpa o artigo selecionado

            // Atualiza a interface gráfica para um novo artigo
            AtualizarInterfaceParaArtigo(novoArtigo);
        }

        private void AtualizarInterfaceParaArtigo(Artigo artigo)
        {
            // Atualiza os campos com os dados do artigo
            textBoxCodigo.Text = artigo.Codigo;
            textBoxDesignacao.Text = artigo.Designacao;
            textBoxPreco.Text = artigo.Preco.ToString();
            comboBoxCategorias.SelectedItem = artigo.Categoria;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se a lista de artigos não está vazia
            if (listArtigos.Count == 0)
            {
                MessageBox.Show("A lista de artigos está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se um item foi selecionado na ListBox
            if (listBoxArtigos.SelectedIndex != -1 && listBoxArtigos.SelectedIndex < listArtigos.Count)
            {
                // Obtém o artigo selecionado da lista
                artigoSelecionado = listArtigos[listBoxArtigos.SelectedIndex];

                // Verifica se o artigoSelecionado não é nulo
                if (artigoSelecionado != null)
                {
                    // Preenche os campos com os dados do artigo selecionado
                    AtualizarInterfaceParaArtigo(artigoSelecionado);

                    // Exibe uma mensagem informativa
                    MessageBox.Show("Está atualizar o artigo selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine("Debug: artigoSelecionado é nulo.");
                }
            }
            else
            {
                Console.WriteLine("Debug: Nenhum item selecionado na ListBox");
                MessageBox.Show("Selecione um artigo para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Limpa os campos e cancela a operação
            LimparCampos();
            artigoSelecionado = null;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado na ListBox
            if (listBoxArtigos.SelectedIndex != -1 && listBoxArtigos.SelectedIndex < listArtigos.Count)
            {
                // Remove o artigo selecionado da lista
                listArtigos.RemoveAt(listBoxArtigos.SelectedIndex);

                // Atualiza a lista de artigos no ListBox
                AtualizarListaArtigos();
                LimparCampos();
                artigoSelecionado = null; // Limpa o artigo selecionado

                // Desseleciona o item na ListBox após a eliminação
                listBoxArtigos.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Selecione um artigo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NovoProdutos_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            textBoxCodigo.Clear();
            textBoxDesignacao.Clear();
            textBoxPreco.Clear();
            comboBoxCategorias.SelectedIndex = -1;
        }

        private void AtualizarListaArtigos()
        {
            // Limpar a lista atual
            listBoxArtigos.Items.Clear();

            // Adicionar os artigos à lista
            foreach (Artigo artigo in listArtigos)
            {
                listBoxArtigos.Items.Add($"{artigo.Codigo} - {artigo.Designacao} - {artigo.Preco:C} - {artigo.Categoria}");
            }
        }

        private class Artigo
        {
            public string Codigo { get; set; }
            public string Designacao { get; set; }
            public double Preco { get; set; }
            public string Categoria { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardarSair_Click(object sender, EventArgs e)
        {

            // Exemplo: Aqui, vou verificar se todos os campos estão preenchidos e se o preço é um número válido
            if (string.IsNullOrEmpty(textBoxCodigo.Text) || string.IsNullOrEmpty(textBoxDesignacao.Text) || string.IsNullOrEmpty(textBoxPreco.Text) || comboBoxCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar o artigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o campo de preço contém apenas números
            if (!double.TryParse(textBoxPreco.Text, out double preco))
            {
                MessageBox.Show("Digite um valor numérico válido para o preço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar um novo artigo com os dados inseridos
            Artigo novoArtigo = new Artigo
            {
                Codigo = textBoxCodigo.Text,
                Designacao = textBoxDesignacao.Text,
                Preco = preco,
                Categoria = comboBoxCategorias.SelectedItem.ToString()
            };

            // Adicionar o artigo à lista
            listArtigos.Add(novoArtigo);

            // Limpar os campos após adicionar o artigo
            LimparCampos();

            // Atualizar a lista de artigos no ListBox
            AtualizarListaArtigos();

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardarAtualização_Click(object sender, EventArgs e)
        {
            // Verifica se o artigoSelecionado não é nulo
    if (artigoSelecionado != null)
    {
        // Atualiza o artigo selecionado com os dados inseridos
        artigoSelecionado.Codigo = textBoxCodigo.Text;
        artigoSelecionado.Designacao = textBoxDesignacao.Text;
        
        // Verifica se o campo de preço contém apenas números
        if (double.TryParse(textBoxPreco.Text, out double preco))
        {
            artigoSelecionado.Preco = preco;
        }
        else
        {
            Console.WriteLine("Debug: Valor inválido no campo de preço: " + textBoxPreco.Text);
            MessageBox.Show("Digite um valor numérico válido para o preço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        artigoSelecionado.Categoria = comboBoxCategorias.SelectedItem.ToString();

        // Atualiza a lista de artigos no ListBox
        AtualizarListaArtigos();
        LimparCampos();
        artigoSelecionado = null; // Limpa o artigo selecionado

        // Desseleciona o item na ListBox após a atualização
        listBoxArtigos.SelectedIndex = -1;

        MessageBox.Show("Alterações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
        Console.WriteLine("Debug: artigoSelecionado é nulo.");
        MessageBox.Show("Selecione um artigo para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
        }
    }
}
