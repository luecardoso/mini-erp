using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.DataModels;

namespace MiniERP
{
    public partial class Form_Fornecedor : Form
    {
        public Form_Fornecedor()
        {
            InitializeComponent();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void salvar()
        {
            if (String.IsNullOrEmpty(textBox_Nome.Text))
            {
                MessageBox.Show("Digite um nome!");
            }
            else
            {
                using (var contexto = new MiniErpContext())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Nome = textBox_Nome.Text;
                    contexto.Fornecedors.Add(fornecedor);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor salvo com sucesso!");
                    listar();
                    limparCampos();
                }

            }
        }

        private void listar()
        {
            using (var contexto = new MiniErpContext())
            {
                var fornecedores = contexto.Fornecedors.ToList();

                if (String.IsNullOrEmpty(textBox_Buscar.Text))
                {
                    dataGridView_Fornecedores.DataSource = fornecedores;
                }
                else
                {
                    var listaFornecedor = contexto.Fornecedors.Where(fornecedor =>
                    fornecedor.Nome.Contains(textBox_Buscar.Text)).ToList();
                    dataGridView_Fornecedores.DataSource = listaFornecedor;
                }
            }
        }

        private void salvarAlterado()
        {
            if (String.IsNullOrEmpty(textBox_Nome.Text))
            {
                MessageBox.Show("Digite um nome!");
            }
            else
            {
                using (var contexto = new MiniErpContext())
                {
                    int id = int.Parse(textBox_Id.Text);
                    Fornecedor fornecedorAletrado = contexto.Fornecedors.Find(id);
                    fornecedorAletrado.Nome = textBox_Nome.Text;
                    contexto.Fornecedors.Update(fornecedorAletrado);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor editado com sucesso!");
                    listar();
                    limparCampos();
                }
            }
        }

        private void editar()
        {
            if (dataGridView_Fornecedores.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um fornecedor para editar!");
            }
            else
            {
                textBox_Id.Text = dataGridView_Fornecedores.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Nome.Text = dataGridView_Fornecedores.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void excluir()
        {
            if (dataGridView_Fornecedores.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um fornecedor para excluir!");
            }
            else
            {
                try
                {
                    using (var contexto = new MiniErpContext())
                    {
                        int id = int.Parse(dataGridView_Fornecedores.SelectedRows[0].Cells[0].Value.ToString());
                        Fornecedor excluirFornecedor = contexto.Fornecedors.Find(id);
                        foreach (var produto in excluirFornecedor.Produtos.Where(f => f.FkFornecedor == excluirFornecedor.Id))
                        {
                            contexto.Produtos.Remove(produto);
                        }
                        contexto.Fornecedors.Remove(excluirFornecedor);
                        contexto.SaveChanges();
                        MessageBox.Show("Fornecedor removido com sucesso!");
                        listar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir devido a: " + ex);
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

        private void limparCampos()
        {
            textBox_Nome.Text = string.Empty;
            textBox_Buscar.Text = string.Empty;
            textBox_Id.Text = string.Empty;
            textBox_Nome.Focus();
            dataGridView_Fornecedores.ClearSelection();
        }

        private void button_Editar_Click_1(object sender, EventArgs e)
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
