namespace MiniERP
{
    partial class Form_Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView_Clientes = new DataGridView();
            dataGridView_Pedidos = new DataGridView();
            dataGridView_Produtos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_Voltar = new Button();
            button_EscolherCliente = new Button();
            button_SelecionarCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(33, 79);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.RowHeadersVisible = false;
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Clientes.Size = new Size(531, 257);
            dataGridView_Clientes.TabIndex = 0;
            // 
            // dataGridView_Pedidos
            // 
            dataGridView_Pedidos.AllowUserToAddRows = false;
            dataGridView_Pedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_Pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Pedidos.Location = new Point(647, 79);
            dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            dataGridView_Pedidos.ReadOnly = true;
            dataGridView_Pedidos.RowHeadersVisible = false;
            dataGridView_Pedidos.RowTemplate.Height = 25;
            dataGridView_Pedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Pedidos.Size = new Size(514, 257);
            dataGridView_Pedidos.TabIndex = 1;
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.AllowUserToAddRows = false;
            dataGridView_Produtos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Location = new Point(33, 413);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.ReadOnly = true;
            dataGridView_Produtos.RowHeadersVisible = false;
            dataGridView_Produtos.RowTemplate.Height = 25;
            dataGridView_Produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Produtos.Size = new Size(1128, 338);
            dataGridView_Produtos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(647, 51);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 4;
            label2.Text = "Compras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 383);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 5;
            label3.Text = "Produtos";
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(33, 789);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 6;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // button_EscolherCliente
            // 
            button_EscolherCliente.Location = new Point(451, 50);
            button_EscolherCliente.Name = "button_EscolherCliente";
            button_EscolherCliente.Size = new Size(113, 23);
            button_EscolherCliente.TabIndex = 7;
            button_EscolherCliente.Text = "Escolher Cliente";
            button_EscolherCliente.UseVisualStyleBackColor = true;
            button_EscolherCliente.Click += button_EscolherCliente_Click;
            // 
            // button_SelecionarCompra
            // 
            button_SelecionarCompra.Location = new Point(1033, 49);
            button_SelecionarCompra.Name = "button_SelecionarCompra";
            button_SelecionarCompra.Size = new Size(128, 23);
            button_SelecionarCompra.TabIndex = 8;
            button_SelecionarCompra.Text = "Selecionar Compra";
            button_SelecionarCompra.UseVisualStyleBackColor = true;
            button_SelecionarCompra.Click += button_SelecionarCompra_Click;
            // 
            // Form_Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 824);
            Controls.Add(button_SelecionarCompra);
            Controls.Add(button_EscolherCliente);
            Controls.Add(button_Voltar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_Produtos);
            Controls.Add(dataGridView_Pedidos);
            Controls.Add(dataGridView_Clientes);
            Name = "Form_Compras";
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Clientes;
        private DataGridView dataGridView_Pedidos;
        private DataGridView dataGridView_Produtos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_Voltar;
        private Button button_EscolherCliente;
        private Button button_SelecionarCompra;
    }
}