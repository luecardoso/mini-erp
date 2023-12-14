namespace MiniERP
{
    partial class Form_Fornecedor
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
            button_Voltar = new Button();
            dataGridView_Fornecedores = new DataGridView();
            button_Buscar = new Button();
            textBox_Buscar = new TextBox();
            button_Cadastrar = new Button();
            label2 = new Label();
            textBox_Nome = new TextBox();
            textBox_Id = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(button_Editar);
            panel1.Controls.Add(button_Voltar);
            panel1.Controls.Add(dataGridView_Fornecedores);
            panel1.Controls.Add(button_Buscar);
            panel1.Controls.Add(textBox_Buscar);
            panel1.Controls.Add(button_Cadastrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Nome);
            panel1.Controls.Add(textBox_Id);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 642);
            panel1.TabIndex = 0;
            // 
            // button_Editar
            // 
            button_Editar.Location = new Point(672, 607);
            button_Editar.Name = "button_Editar";
            button_Editar.Size = new Size(75, 23);
            button_Editar.TabIndex = 19;
            button_Editar.Text = "Editar";
            button_Editar.UseVisualStyleBackColor = true;
            button_Editar.Click += button_Editar_Click_1;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(44, 607);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 18;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // dataGridView_Fornecedores
            // 
            dataGridView_Fornecedores.AllowUserToAddRows = false;
            dataGridView_Fornecedores.AllowUserToDeleteRows = false;
            dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedores.Location = new Point(44, 215);
            dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            dataGridView_Fornecedores.ReadOnly = true;
            dataGridView_Fornecedores.RowTemplate.Height = 25;
            dataGridView_Fornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Fornecedores.Size = new Size(703, 367);
            dataGridView_Fornecedores.TabIndex = 17;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(686, 173);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(75, 23);
            button_Buscar.TabIndex = 16;
            button_Buscar.Text = "Buscar";
            button_Buscar.UseVisualStyleBackColor = true;
            button_Buscar.Click += button_Buscar_Click;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Location = new Point(50, 173);
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(616, 23);
            textBox_Buscar.TabIndex = 15;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(686, 115);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 14;
            button_Cadastrar.Text = "Salvar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 90);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(171, 86);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(590, 23);
            textBox_Nome.TabIndex = 6;
            // 
            // textBox_Id
            // 
            textBox_Id.Enabled = false;
            textBox_Id.Location = new Point(60, 86);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(49, 23);
            textBox_Id.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 90);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "ID: ";
            // 
            // Form_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 642);
            Controls.Add(panel1);
            Name = "Form_Fornecedor";
            Text = "Fornecedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBox_Nome;
        private TextBox textBox_Id;
        private Label label1;
        private DataGridView dataGridView_Fornecedores;
        private Button button_Buscar;
        private TextBox textBox_Buscar;
        private Button button_Cadastrar;
        private Button button_Voltar;
        private Button button_Editar;
    }
}