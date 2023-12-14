namespace MiniERP
{
    partial class Form_Produto
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
            panel1 = new Panel();
            button_Editar = new Button();
            textBox_Id = new TextBox();
            button_Voltar = new Button();
            comboBox_Fornecedor = new ComboBox();
            label7 = new Label();
            textBox_Descricao = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboBox_Categoria = new ComboBox();
            textBox_Preco = new TextBox();
            label4 = new Label();
            textBox_Quantidade = new TextBox();
            label3 = new Label();
            dataGridView_Produtos = new DataGridView();
            button_Buscar = new Button();
            textBox_Buscar = new TextBox();
            button_Cadastrar = new Button();
            label2 = new Label();
            textBox_Nome = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(button_Editar);
            panel1.Controls.Add(textBox_Id);
            panel1.Controls.Add(button_Voltar);
            panel1.Controls.Add(comboBox_Fornecedor);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox_Descricao);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_Categoria);
            panel1.Controls.Add(textBox_Preco);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_Quantidade);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView_Produtos);
            panel1.Controls.Add(button_Buscar);
            panel1.Controls.Add(textBox_Buscar);
            panel1.Controls.Add(button_Cadastrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Nome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 738);
            panel1.TabIndex = 0;
            // 
            // button_Editar
            // 
            button_Editar.Location = new Point(680, 703);
            button_Editar.Name = "button_Editar";
            button_Editar.Size = new Size(75, 23);
            button_Editar.TabIndex = 37;
            button_Editar.Text = "Editar";
            button_Editar.UseVisualStyleBackColor = true;
            button_Editar.Click += button_Editar_Click;
            // 
            // textBox_Id
            // 
            textBox_Id.Enabled = false;
            textBox_Id.Location = new Point(69, 74);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(49, 23);
            textBox_Id.TabIndex = 1;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(39, 703);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 36;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // comboBox_Fornecedor
            // 
            comboBox_Fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Fornecedor.FormattingEnabled = true;
            comboBox_Fornecedor.Location = new Point(460, 122);
            comboBox_Fornecedor.Name = "comboBox_Fornecedor";
            comboBox_Fornecedor.Size = new Size(310, 23);
            comboBox_Fornecedor.Sorted = true;
            comboBox_Fornecedor.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 125);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 34;
            label7.Text = "Fornecedor";
            // 
            // textBox_Descricao
            // 
            textBox_Descricao.Location = new Point(114, 166);
            textBox_Descricao.Multiline = true;
            textBox_Descricao.Name = "textBox_Descricao";
            textBox_Descricao.Size = new Size(316, 82);
            textBox_Descricao.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 166);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 32;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 179);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 31;
            label5.Text = "Categoria";
            // 
            // comboBox_Categoria
            // 
            comboBox_Categoria.FormattingEnabled = true;
            comboBox_Categoria.Location = new Point(544, 176);
            comboBox_Categoria.Name = "comboBox_Categoria";
            comboBox_Categoria.Size = new Size(226, 23);
            comboBox_Categoria.TabIndex = 30;
            // 
            // textBox_Preco
            // 
            textBox_Preco.Location = new Point(235, 122);
            textBox_Preco.Name = "textBox_Preco";
            textBox_Preco.Size = new Size(100, 23);
            textBox_Preco.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 126);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 28;
            label4.Text = "Preço";
            // 
            // textBox_Quantidade
            // 
            textBox_Quantidade.Location = new Point(114, 122);
            textBox_Quantidade.Name = "textBox_Quantidade";
            textBox_Quantidade.Size = new Size(60, 23);
            textBox_Quantidade.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 126);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 26;
            label3.Text = "Quantidade";
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.AllowUserToAddRows = false;
            dataGridView_Produtos.AllowUserToDeleteRows = false;
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Location = new Point(52, 317);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.ReadOnly = true;
            dataGridView_Produtos.RowTemplate.Height = 25;
            dataGridView_Produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Produtos.Size = new Size(703, 367);
            dataGridView_Produtos.TabIndex = 25;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(680, 265);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(75, 23);
            button_Buscar.TabIndex = 24;
            button_Buscar.Text = "Buscar";
            button_Buscar.UseVisualStyleBackColor = true;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Location = new Point(52, 266);
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(616, 23);
            textBox_Buscar.TabIndex = 23;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(680, 225);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 7;
            button_Cadastrar.Text = "Salvar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 78);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(180, 74);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(590, 23);
            textBox_Nome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 78);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 18;
            label1.Text = "ID: ";
            // 
            // Form_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 738);
            Controls.Add(panel1);
            Name = "Form_Produto";
            Text = "Produto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_Quantidade;
        private Label label3;
        private DataGridView dataGridView_Produtos;
        private Button button_Buscar;
        private TextBox textBox_Buscar;
        private Button button_Cadastrar;
        private Label label2;
        private TextBox textBox_Nome;
        private Label label1;
        private TextBox textBox_Descricao;
        private Label label6;
        private Label label5;
        private ComboBox comboBox_Categoria;
        private TextBox textBox_Preco;
        private Label label4;
        private ComboBox comboBox_Fornecedor;
        private Label label7;
        private Button button_Voltar;
        private TextBox textBox_Id;
        private Button button_Editar;
    }
}