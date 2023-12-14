using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.DataModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniERP
{
    public partial class Form_Cliente : Form
    {
        public Form_Cliente()
        {
            InitializeComponent();
            textBox_Id.Text = string.Empty;
            comboBox_Sexo.SelectedItem = comboBox_Sexo.SelectedIndex = 0;
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

        private bool verificarCampos()
        {
            if (String.IsNullOrEmpty(textBox_Nome.Text))
            {
                MessageBox.Show("Digite o nome completo");
                return false;
            }
            return true;
        }

        private void salvar()
        {
            if (!verificarCampos())
            {
                textBox_Nome.Focus();
            }
            else
            {
                using (var contexto = new MiniErpContext())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = textBox_Nome.Text;
                    cliente.DataNascimento = maskedTextBox_DataNascimento.Text;
                    cliente.Telefone = maskedTextBox_Telefone.Text;
                    cliente.Sexo = comboBox_Sexo.SelectedItem.ToString();
                    contexto.Clientes.Add(cliente);
                    contexto.SaveChanges();
                    MessageBox.Show("Cliente salvo com sucesso!");
                    listar();
                    limparCampos();
                }
            }

        }

        private void salvarAlterado()
        {
            if (!verificarCampos())
            {
                textBox_Nome.Focus();
            }
            else
            {
                try
                {
                    using (var contexto = new MiniErpContext())
                    {
                        int id = int.Parse(textBox_Id.Text);
                        Cliente clienteAlterado = contexto.Clientes.Find(id);
                        clienteAlterado.Nome = textBox_Nome.Text;
                        clienteAlterado.DataNascimento = maskedTextBox_DataNascimento.Text;
                        clienteAlterado.Telefone = maskedTextBox_Telefone.Text;
                        clienteAlterado.Sexo = comboBox_Sexo.SelectedItem.ToString();
                        contexto.Clientes.Update(clienteAlterado);
                        contexto.SaveChanges();
                        MessageBox.Show("Cliente editado com sucesso!");
                        listar();
                        limparCampos();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar os dados: "+ex);
                }
            }
        }

        private void listar()
        {
            using (var contexto = new MiniErpContext())
            {
                var clientes = contexto.Clientes.ToList();
                if (String.IsNullOrEmpty(textBox_Buscar.Text))
                {
                    dataGridView_Clientes.DataSource = clientes;
                }
                else
                {
                    var listaClientes = contexto.Clientes.Where(cli =>
                    cli.Nome.Contains(textBox_Buscar.Text)).ToList();
                    dataGridView_Clientes.DataSource = listaClientes;
                }
            }
        }
        private void editar()
        {
            if (dataGridView_Clientes.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um cliente para editar!");
            }
            else
            {

                textBox_Id.Text = dataGridView_Clientes.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Nome.Text = dataGridView_Clientes.SelectedRows[0].Cells[1].Value.ToString();


                maskedTextBox_DataNascimento.Text = dataGridView_Clientes.SelectedRows[0].Cells[2].Value == null ?
                    string.Empty : dataGridView_Clientes.SelectedRows[0].Cells[2].Value.ToString();

                maskedTextBox_Telefone.Text = dataGridView_Clientes.SelectedRows[0].Cells[3].Value == null ?
                    string.Empty : dataGridView_Clientes.SelectedRows[0].Cells[3].Value.ToString();

                comboBox_Sexo.SelectedItem = dataGridView_Clientes.SelectedRows[0].Cells[4].Value == null ?
                    comboBox_Sexo.SelectedIndex = 0 : dataGridView_Clientes.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void excluir()
        {
            if (dataGridView_Clientes.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
            }
            else
            {
                using (var contexto = new MiniErpContext())
                {
                    int id = int.Parse(dataGridView_Clientes.SelectedRows[0].Cells[0].Value.ToString());
                    Cliente excluirCliente = contexto.Clientes.Find(id);
                    contexto.Clientes.Remove(excluirCliente);
                    contexto.SaveChanges();
                    MessageBox.Show("Cliente removido com sucesso!");
                    listar();
                }

            }
        }

        private void limparCampos()
        {
            textBox_Id.Text = string.Empty;
            textBox_Nome.Text = string.Empty;
            maskedTextBox_DataNascimento.Text = string.Empty;
            maskedTextBox_Telefone.Text = string.Empty;
            comboBox_Sexo.SelectedIndex = 0;
            textBox_Buscar.Text = string.Empty;
            dataGridView_Clientes.ClearSelection();
            textBox_Nome.Focus();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void button_editar_Click(object sender, EventArgs e)
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
