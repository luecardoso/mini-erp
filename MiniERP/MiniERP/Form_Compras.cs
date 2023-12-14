using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Form_Compras : Form
    {
        public Form_Compras()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            using (var contexto = new MiniErpContext())
            {
                var clientes = contexto.Clientes.ToList();
                dataGridView_Clientes.DataSource = clientes;
            }
        }

        private void CarregarPedidos()
        {
            if (dataGridView_Clientes.SelectedRows.Count > 0)
            {
                using (var contexto = new MiniErpContext())
                {
                    int idCliente = int.Parse(dataGridView_Clientes.SelectedRows[0].Cells[0].Value.ToString());
                    var pedidos = contexto.Pedidos.Where(cli => cli.FkCliente == idCliente);
                    dataGridView_Pedidos.DataSource = pedidos.ToList();
                }
            }
        }

        private void CarregarProdutos()
        {
            if (dataGridView_Pedidos.SelectedRows.Count > 0)
            {
                using (var contexto = new MiniErpContext())
                {
                    int idPedido = int.Parse(dataGridView_Pedidos.SelectedRows[0].Cells[0].Value.ToString());
                    var itens = contexto.Itempedidos.Where(p => p.FkPedido == idPedido);
                    dataGridView_Produtos.DataSource = itens.ToList();
                }
            }
        }
        private void button_EscolherCliente_Click(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void button_SelecionarCompra_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Form_Principal principal = new Form_Principal();
            principal.Show();
            this.Hide();
        }
    }
}
