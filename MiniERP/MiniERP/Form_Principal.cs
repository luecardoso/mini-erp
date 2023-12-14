using System.Collections;
using System.Data;
using MiniERP.DataModels;

namespace MiniERP
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();
            label_Nome.Visible = false;
            label_ID.Text = string.Empty;
            textBox_DataHora.Text = DateTime.Now.ToString();
        }

        private void CarregarClientes()
        {
            using (var contexto = new MiniErpContext())
            {
                var clientes = contexto.Clientes.ToList();
                dataGridView_Clientes.DataSource = clientes;
                dataGridView_Clientes.Columns.Remove(dataGridView_Clientes.Columns["Telefone"]);
                dataGridView_Clientes.Columns.Remove(dataGridView_Clientes.Columns["Pedidos"]);
            }
        }

        private void CarregarProdutos()
        {
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();
                dataGridView_Produtos.DataSource = produtos;
            }
        }

        List<Itempedido> ListaItem = new List<Itempedido>();
        decimal valorTotal = 0;
        private void AdicionarListaPedido()
        {
            if (String.IsNullOrEmpty(textBox_Quantidade.Text))
            {
                MessageBox.Show("Digite a quantidade para comprar!");
            }
            else
            {
                using (var contextoLista = new MiniErpContext())
                {
                    List<Itempedido> item = contextoLista.Itempedidos.ToList();
                    Itempedido itempedido = new Itempedido();
                    itempedido.QuantidadeComprada = int.Parse(textBox_Quantidade.Text);
                    itempedido.FkProduto = int.Parse(dataGridView_Produtos.SelectedRows[0].Cells[0].Value.ToString());
                    itempedido.ValorUnitario = decimal.Parse(dataGridView_Produtos.SelectedRows[0].Cells[4].Value.ToString());
                    itempedido.ValorTotal = itempedido.ValorUnitario * itempedido.QuantidadeComprada;
                    valorTotal += (decimal)itempedido.ValorTotal;
                    label_ValorTotal.Text = "Total: " + valorTotal;
                    item.Add(itempedido);
                    ListaItem.Add(itempedido);
                    dataGridView_ItemPedido.DataSource = ListaItem.ToList(); ;
                    textBox_Quantidade.Text = string.Empty;
                }
            }
        }

        private bool verificarCampos()
        {
            if (String.IsNullOrEmpty(label_ID.Text))
            {
                MessageBox.Show("Selecione um cliente para realizar a compra");
                return false;
            }
            if (ListaItem.Count < 1)
            {
                MessageBox.Show("Adicione produtos a lista!");
                return false;
            }
            return true;
        }
        private void button_BuscarCliente_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniErpContext())
            {
                var clientes = contexto.Clientes.ToList();
                if (String.IsNullOrEmpty(textBox_BuscarCliente.Text))
                {
                    dataGridView_Clientes.DataSource = clientes;
                }
                else
                {
                    var listaClientes = contexto.Clientes.Where(cli =>
                    cli.Nome.Contains(textBox_BuscarCliente.Text)).ToList();
                    dataGridView_Clientes.DataSource = listaClientes;
                }
            }
        }

        private void button_SelecionarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView_Clientes.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um cliente para realizar a compra!");
            }
            else
            {
                label_Nome.Visible = true;
                label_Nome.Text = dataGridView_Clientes.SelectedRows[0].Cells[1].Value.ToString();
                label_ID.Text = dataGridView_Clientes.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void button_AdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarListaPedido();
        }

        private void removerItens()
        {
            using (var contexto = new MiniErpContext())
            {
                var itens = contexto.Itempedidos.ToList();
                //dataGridView_ItemPedido.DataSource = itens;
            }
        }

        private void button_RemoverItens_Click(object sender, EventArgs e)
        {
            removerItens();
        }
        private void realizarVenda()
        {
            if (verificarCampos())
            {
                using (var contexto = new MiniErpContext())
                {
                    Pedido pedido = new Pedido();
                    Cliente cliente = new Cliente();
                    pedido.DataCompra = DateTime.Parse(textBox_DataHora.Text);
                    pedido.Total = valorTotal;
                    pedido.FkCliente = int.Parse(label_ID.Text);
                    pedido.Itempedidos = ListaItem;
                    contexto.Pedidos.Add(pedido);
                    cliente.Pedidos.Add(pedido);
                    contexto.SaveChanges();

                    MessageBox.Show("Venda realizada com sucesso!");
                    limparCampos();
                }
            }

        }

        private void limparCampos()
        {
            label_Nome.Text = string.Empty;
            label_Nome.Visible = false;
            textBox_Quantidade.Text = string.Empty;
            dataGridView_ItemPedido.DataSource = new List<Itempedido>();
            ListaItem.Clear();
            valorTotal = 0;
            textBox_BuscarCliente.Text = string.Empty;
            textBox_BuscarProduto.Text = string.Empty;
            dataGridView_Clientes.ClearSelection();
            dataGridView_Produtos.ClearSelection();
        }

        private void button_RealizarVenda_Click(object sender, EventArgs e)
        {
            realizarVenda();
        }

        private void clientesToolStripMenuItem_Cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente cliente = new Form_Cliente();
            cliente.Show();
            this.Hide();
        }

        private void fornecedoresToolStripMenuItem_Fornecedor_Click(object sender, EventArgs e)
        {
            Form_Fornecedor fornecedor = new Form_Fornecedor();
            fornecedor.Show();
            this.Hide();
        }

        private void produtosToolStripMenuItem_Produto_Click(object sender, EventArgs e)
        {
            Form_Produto produtos = new Form_Produto();
            produtos.Show();
            this.Hide();
        }

        private void button_BuscarProduto_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();

                if (String.IsNullOrEmpty(textBox_BuscarProduto.Text))
                {
                    dataGridView_Produtos.DataSource = produtos;
                }
                else
                {
                    var listaProdutos = contexto.Produtos.Where(prod =>
                    prod.Nome.Contains(textBox_BuscarProduto.Text)).ToList();
                    dataGridView_Produtos.DataSource = listaProdutos;
                }
            }
        }

        private void visualizarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compras compras = new Form_Compras();
            compras.Show();
            this.Hide();
        }

        private void informacoesToolStripMenuItem_Informacoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desafio III - Academia .NET - Lucas Cardoso");
        }
    }
}
