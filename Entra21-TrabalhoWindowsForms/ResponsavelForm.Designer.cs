namespace Entra21_TrabalhoWindowsForms
{
    partial class ResponsavelForm
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelLocalTrabalho = new System.Windows.Forms.Label();
            this.textBoxLocalDeTrabalho = new System.Windows.Forms.TextBox();
            this.textBoxObservacaoLocalDeTrabalho = new System.Windows.Forms.TextBox();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.labelDataDeCadastro = new System.Windows.Forms.Label();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelNomePet = new System.Windows.Forms.Label();
            this.comboBoxNomePet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(257, 571);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(117, 58);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(380, 571);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(116, 58);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(128, 571);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(123, 58);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(11, 571);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(111, 58);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(12, 65);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(30, 15);
            this.labelTipo.TabIndex = 4;
            this.labelTipo.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.comboBoxTipo.Location = new System.Drawing.Point(12, 83);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(145, 29);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(191, 65);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(96, 15);
            this.labelNomeCompleto.TabIndex = 6;
            this.labelNomeCompleto.Text = "Nome Completo";
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(191, 83);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(465, 29);
            this.textBoxNomeCompleto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(400, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastro Responsável";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(674, 83);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(304, 29);
            this.maskedTextBoxCpf.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(12, 152);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerDataNascimento.TabIndex = 14;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 134);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(98, 15);
            this.labelDataNascimento.TabIndex = 15;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(237, 134);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 16;
            this.labelCep.Text = "CEP";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCep.Location = new System.Drawing.Point(237, 152);
            this.maskedTextBoxCep.Mask = "99.999.999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(167, 29);
            this.maskedTextBoxCep.TabIndex = 17;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "Cachorro",
            "Gato"});
            this.comboBoxCidade.Location = new System.Drawing.Point(419, 152);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(237, 29);
            this.comboBoxCidade.TabIndex = 18;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(419, 134);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 15);
            this.labelCidade.TabIndex = 19;
            this.labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(674, 137);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(38, 15);
            this.labelBairro.TabIndex = 20;
            this.labelBairro.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBairro.Location = new System.Drawing.Point(674, 155);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(304, 29);
            this.textBoxBairro.TabIndex = 21;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(12, 193);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.TabIndex = 22;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEndereco.Location = new System.Drawing.Point(12, 211);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(410, 29);
            this.textBoxEndereco.TabIndex = 23;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumero.Location = new System.Drawing.Point(439, 211);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(128, 29);
            this.textBoxNumero.TabIndex = 24;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(451, 193);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(51, 15);
            this.labelNumero.TabIndex = 25;
            this.labelNumero.Text = "Numero";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(605, 193);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(84, 15);
            this.labelComplemento.TabIndex = 26;
            this.labelComplemento.Text = "Complemento";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComplemento.Location = new System.Drawing.Point(602, 211);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(376, 29);
            this.textBoxComplemento.TabIndex = 27;
            // 
            // labelLocalTrabalho
            // 
            this.labelLocalTrabalho.AutoSize = true;
            this.labelLocalTrabalho.Location = new System.Drawing.Point(11, 255);
            this.labelLocalTrabalho.Name = "labelLocalTrabalho";
            this.labelLocalTrabalho.Size = new System.Drawing.Size(99, 15);
            this.labelLocalTrabalho.TabIndex = 28;
            this.labelLocalTrabalho.Text = "Local de Trabalho";
            // 
            // textBoxLocalDeTrabalho
            // 
            this.textBoxLocalDeTrabalho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocalDeTrabalho.Location = new System.Drawing.Point(12, 273);
            this.textBoxLocalDeTrabalho.Name = "textBoxLocalDeTrabalho";
            this.textBoxLocalDeTrabalho.Size = new System.Drawing.Size(410, 29);
            this.textBoxLocalDeTrabalho.TabIndex = 29;
            // 
            // textBoxObservacaoLocalDeTrabalho
            // 
            this.textBoxObservacaoLocalDeTrabalho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxObservacaoLocalDeTrabalho.Location = new System.Drawing.Point(439, 273);
            this.textBoxObservacaoLocalDeTrabalho.Name = "textBoxObservacaoLocalDeTrabalho";
            this.textBoxObservacaoLocalDeTrabalho.Size = new System.Drawing.Size(236, 29);
            this.textBoxObservacaoLocalDeTrabalho.TabIndex = 30;
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(439, 255);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(69, 15);
            this.labelObservacao.TabIndex = 31;
            this.labelObservacao.Text = "Observação";
            // 
            // labelDataDeCadastro
            // 
            this.labelDataDeCadastro.AutoSize = true;
            this.labelDataDeCadastro.Location = new System.Drawing.Point(705, 255);
            this.labelDataDeCadastro.Name = "labelDataDeCadastro";
            this.labelDataDeCadastro.Size = new System.Drawing.Size(97, 15);
            this.labelDataDeCadastro.TabIndex = 32;
            this.labelDataDeCadastro.Text = "Data de Cadastro";
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(705, 273);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(239, 29);
            this.dateTimePickerDataCadastro.TabIndex = 33;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(11, 367);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 34;
            this.labelTelefone.Text = "Telefone";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(12, 385);
            this.maskedTextBoxTelefone.Mask = "(99)9 9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(183, 29);
            this.maskedTextBoxTelefone.TabIndex = 35;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(221, 385);
            this.maskedTextBoxCelular.Mask = "(99)9 9999-9999";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(183, 29);
            this.maskedTextBoxCelular.TabIndex = 36;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(218, 367);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(44, 15);
            this.labelCelular.TabIndex = 37;
            this.labelCelular.Text = "Celular";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 441);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 38;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(12, 459);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(410, 29);
            this.textBoxEmail.TabIndex = 39;
            // 
            // labelNomePet
            // 
            this.labelNomePet.AutoSize = true;
            this.labelNomePet.Location = new System.Drawing.Point(11, 311);
            this.labelNomePet.Name = "labelNomePet";
            this.labelNomePet.Size = new System.Drawing.Size(60, 15);
            this.labelNomePet.TabIndex = 40;
            this.labelNomePet.Text = "Nome Pet";
            // 
            // comboBoxNomePet
            // 
            this.comboBoxNomePet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNomePet.FormattingEnabled = true;
            this.comboBoxNomePet.Location = new System.Drawing.Point(12, 329);
            this.comboBoxNomePet.Name = "comboBoxNomePet";
            this.comboBoxNomePet.Size = new System.Drawing.Size(410, 29);
            this.comboBoxNomePet.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(436, 291);
            this.dataGridView1.TabIndex = 42;
            // 
            // ResponsavelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxNomePet);
            this.Controls.Add(this.labelNomePet);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.maskedTextBoxCelular);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.dateTimePickerDataCadastro);
            this.Controls.Add(this.labelDataDeCadastro);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.textBoxObservacaoLocalDeTrabalho);
            this.Controls.Add(this.textBoxLocalDeTrabalho);
            this.Controls.Add(this.labelLocalTrabalho);
            this.Controls.Add(this.textBoxComplemento);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.labelNomeCompleto);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Name = "ResponsavelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditar;
        private Button buttonCancelar;
        private Button buttonApagar;
        private Button buttonSalvar;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
        private Label labelNomeCompleto;
        private TextBox textBoxNomeCompleto;
        private Label label2;
        private MaskedTextBox maskedTextBoxCpf;
        private Label label3;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelDataNascimento;
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private ComboBox comboBoxCidade;
        private Label labelCidade;
        private Label labelBairro;
        private TextBox textBoxBairro;
        private Label labelEndereco;
        private TextBox textBoxEndereco;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private Label labelComplemento;
        private TextBox textBoxComplemento;
        private Label labelLocalTrabalho;
        private TextBox textBoxLocalDeTrabalho;
        private TextBox textBoxObservacaoLocalDeTrabalho;
        private Label labelObservacao;
        private Label labelDataDeCadastro;
        private DateTimePicker dateTimePickerDataCadastro;
        private Label labelTelefone;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCelular;
        private Label labelCelular;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelNomePet;
        private ComboBox comboBoxNomePet;
        private DataGridView dataGridView1;
    }
}