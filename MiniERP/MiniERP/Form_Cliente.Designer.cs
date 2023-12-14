namespace MiniERP
{
    partial class Form_Cliente
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
            panel1 = new Panel();
            button_editar = new Button();
            button_Voltar = new Button();
            dataGridView_Clientes = new DataGridView();
            button_Buscar = new Button();
            textBox_Buscar = new TextBox();
            button_Cadastrar = new Button();
            comboBox_Sexo = new ComboBox();
            label5 = new Label();
            maskedTextBox_Telefone = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            maskedTextBox_DataNascimento = new MaskedTextBox();
            label2 = new Label();
            textBox_Nome = new TextBox();
            textBox_Id = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(button_editar);
            panel1.Controls.Add(button_Voltar);
            panel1.Controls.Add(dataGridView_Clientes);
            panel1.Controls.Add(button_Buscar);
            panel1.Controls.Add(textBox_Buscar);
            panel1.Controls.Add(button_Cadastrar);
            panel1.Controls.Add(comboBox_Sexo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(maskedTextBox_Telefone);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedTextBox_DataNascimento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Nome);
            panel1.Controls.Add(textBox_Id);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 726);
            panel1.TabIndex = 0;
            // 
            // button_editar
            // 
            button_editar.Location = new Point(683, 691);
            button_editar.Name = "button_editar";
            button_editar.Size = new Size(75, 21);
            button_editar.TabIndex = 15;
            button_editar.Text = "Editar";
            button_editar.UseVisualStyleBackColor = true;
            button_editar.Click += button_editar_Click;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(37, 691);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 14;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
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
            dataGridView_Clientes.Location = new Point(59, 301);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.RowHeadersVisible = false;
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Clientes.Size = new Size(703, 367);
            dataGridView_Clientes.TabIndex = 13;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(687, 244);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(75, 23);
            button_Buscar.TabIndex = 12;
            button_Buscar.Text = "Buscar";
            button_Buscar.UseVisualStyleBackColor = true;
            button_Buscar.Click += button_Buscar_Click;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Location = new Point(59, 244);
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(616, 23);
            textBox_Buscar.TabIndex = 11;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(687, 182);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 10;
            button_Cadastrar.Text = "Salvar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // comboBox_Sexo
            // 
            comboBox_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Sexo.FormattingEnabled = true;
            comboBox_Sexo.Items.AddRange(new object[] { "Feminino", "Masculino", "Não Informar", "Outros" });
            comboBox_Sexo.Location = new Point(568, 132);
            comboBox_Sexo.Name = "comboBox_Sexo";
            comboBox_Sexo.Size = new Size(121, 23);
            comboBox_Sexo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(483, 135);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Sexo";
            // 
            // maskedTextBox_Telefone
            // 
            maskedTextBox_Telefone.Location = new Point(362, 132);
            maskedTextBox_Telefone.Mask = "(##)#####-####";
            maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            maskedTextBox_Telefone.Size = new Size(100, 23);
            maskedTextBox_Telefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 130);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 5;
            label3.Text = "Data de Nascimento: ";
            // 
            // maskedTextBox_DataNascimento
            // 
            maskedTextBox_DataNascimento.Location = new Point(159, 127);
            maskedTextBox_DataNascimento.Mask = "##/##/####";
            maskedTextBox_DataNascimento.Name = "maskedTextBox_DataNascimento";
            maskedTextBox_DataNascimento.Size = new Size(100, 23);
            maskedTextBox_DataNascimento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 79);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.ForeColor = SystemColors.WindowText;
            textBox_Nome.Location = new Point(172, 75);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(590, 23);
            textBox_Nome.TabIndex = 2;
            // 
            // textBox_Id
            // 
            textBox_Id.Enabled = false;
            textBox_Id.Location = new Point(61, 75);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(49, 23);
            textBox_Id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 79);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "ID: ";
            // 
            // Form_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 726);
            Controls.Add(panel1);
            Name = "Form_Cliente";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBox_Nome;
        private TextBox textBox_Id;
        private Label label1;
        private Button button_Cadastrar;
        private ComboBox comboBox_Sexo;
        private Label label5;
        private MaskedTextBox maskedTextBox_Telefone;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBox_DataNascimento;
        private Button button_Buscar;
        private TextBox textBox_Buscar;
        private DataGridView dataGridView_Clientes;
        private Button button_Voltar;
        private Button button_editar;
    }
}