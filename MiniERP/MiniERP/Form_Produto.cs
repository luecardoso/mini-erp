using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MiniERP.DataModels;

namespace MiniERP
{
    public partial class Form_Produto : Form
    {
        public Form_Produto()
        {
            InitializeComponent();
            CarregarFornecedores();
            listar();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            textBox_Id.Text = null;
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();

                if (String.IsNullOrEmpty(textBox_Buscar.Text))
                {
                    dataGridView_Produtos.DataSource = produtos;
                }
                else
                {
                    var listaProdutos = contexto.Produtos.Where(prod =>
                    prod.Nome.Contains(textBox_Buscar.Text)).ToList();
                    dataGridView_Produtos.DataSource = listaProdutos;
                }
            }
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Id.Text))
            {
                salvar();
            }
            else
            {
                salvarAlterado();
            }
        }

        private void salvar()
        {
            if (verificarCampos())
            {
                try
                {
                    using (var contexto = new MiniErpContext())
                    {
                        Produto produto = new Produto();
                        int idFornecedor = (comboBox_Fornecedor.SelectedItem as Fornecedor).Id;
                        string nomeForncedor = comboBox_Fornecedor.Text;
                        produto.Nome = textBox_Nome.Text;
                        produto.Quantidade = int.Parse(textBox_Quantidade.Text);
                        produto.Preco = decimal.Parse(textBox_Preco.Text);
                        produto.FkFornecedor = idFornecedor;
                        produto.Descricao = textBox_Descricao.Text;
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Produtos.Add(produto);
                        contexto.Produtos.Add(produto);
                        contexto.SaveChanges();

                        MessageBox.Show("Produto adicionado com sucesso!");
                        listar();
                        limparCampos();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o produto");
                    MessageBox.Show("Erro: " + ex);

                }

            }
        }

        private void salvarAlterado()
        {
            if (verificarCampos())
            {
                using (var contexto = new MiniErpContext())
                {
                    int id = int.Parse(textBox_Id.Text);
                    Produto produtoAletrado = contexto.Produtos.Find(id);
                    produtoAletrado.Nome = textBox_Nome.Text;
                    produtoAletrado.Descricao = textBox_Descricao.Text;
                    produtoAletrado.Quantidade = int.Parse(textBox_Quantidade.Text);
                    produtoAletrado.Preco = decimal.Parse(textBox_Preco.Text);
                    produtoAletrado.FkFornecedor = int.Parse(comboBox_Fornecedor.Text);
                    contexto.Produtos.Update(produtoAletrado);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor editado com sucesso!");
                    listar();
                }

            }
        }

        private void CarregarFornecedores()
        {
            using (var contexto = new MiniErpContext())
            {
                var fornecedores = contexto.Fornecedors.ToList();
                comboBox_Fornecedor.DataSource = fornecedores;
                comboBox_Fornecedor.DisplayMember = "Nome";
                comboBox_Fornecedor.ValueMember = "Id";
            }
        }

        private bool verificarCampos()
        {
            if (String.IsNullOrEmpty(textBox_Nome.Text))
            {
                MessageBox.Show("Insira o nome do produto");
                return false;
            }
            if (String.IsNullOrEmpty(textBox_Quantidade.Text))
            {
                MessageBox.Show("Insira a quantidade do produto");
                return false;
            }
            if (String.IsNullOrEmpty(textBox_Preco.Text))
            {
                MessageBox.Show("Insira o preço do produto");
                return false;
            }
            return true;
        }

        private void editar()
        {
            if (dataGridView_Produtos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um produto para editar!");
            }
            else
            {
                textBox_Id.Text = dataGridView_Produtos.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Nome.Text = dataGridView_Produtos.SelectedRows[0].Cells[1].Value.ToString();
                textBox_Quantidade.Text = dataGridView_Produtos.SelectedRows[0].Cells[2].Value.ToString();
                textBox_Descricao.Text = dataGridView_Produtos.SelectedRows[0].Cells[3].Value == null ?
                  string.Empty : dataGridView_Produtos.SelectedRows[0].Cells[3].Value.ToString();
                textBox_Preco.Text = dataGridView_Produtos.SelectedRows[0].Cells[4].Value.ToString();

                comboBox_Fornecedor.SelectedItem = dataGridView_Produtos.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void limparCampos()
        {
            textBox_Buscar.Text = string.Empty;
            textBox_Id.Text = string.Empty;
            textBox_Nome.Text = string.Empty;
            textBox_Descricao.Text = string.Empty;
            textBox_Quantidade.Text = string.Empty;
            textBox_Preco.Text = string.Empty;
            comboBox_Fornecedor.SelectedItem = 0;
            dataGridView_Produtos.ClearSelection();
            textBox_Nome.Focus();

        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Form_Principal principal = new Form_Principal();
            principal.Show();
            this.Hide();
        }
    }
}
