namespace Entra21_TrabalhoWindowsForms
{
    partial class CadastroAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAnimal));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.labelRaca = new System.Windows.Forms.Label();
            this.labelPelagem = new System.Windows.Forms.Label();
            this.textBoxPelagem = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelDoencas = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelDataDeNascimento = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxDoencas = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.checkBoxVacinado = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxEspecie = new System.Windows.Forms.ComboBox();
            this.comboBoxRaca = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.richTextBoxObservacoes = new System.Windows.Forms.RichTextBox();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 395);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 43);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(826, 395);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(88, 43);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(200, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(270, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCadastro.Location = new System.Drawing.Point(492, 12);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(100, 15);
            this.labelCadastro.TabIndex = 7;
            this.labelCadastro.Text = "Data de Cadastro:";
            // 
            // dateTimePickerDataDeCadastro
            // 
            this.dateTimePickerDataDeCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeCadastro.Location = new System.Drawing.Point(492, 27);
            this.dateTimePickerDataDeCadastro.Name = "dateTimePickerDataDeCadastro";
            this.dateTimePickerDataDeCadastro.Size = new System.Drawing.Size(113, 23);
            this.dateTimePickerDataDeCadastro.TabIndex = 8;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelNome.Location = new System.Drawing.Point(200, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(95, 15);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Nome / Apelido:";
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelEspecie.Location = new System.Drawing.Point(200, 67);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(49, 15);
            this.labelEspecie.TabIndex = 15;
            this.labelEspecie.Text = "Espécie:";
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelRaca.Location = new System.Drawing.Point(320, 133);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(35, 15);
            this.labelRaca.TabIndex = 16;
            this.labelRaca.Text = "Raça:";
            // 
            // labelPelagem
            // 
            this.labelPelagem.AutoSize = true;
            this.labelPelagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelPelagem.Location = new System.Drawing.Point(367, 70);
            this.labelPelagem.Name = "labelPelagem";
            this.labelPelagem.Size = new System.Drawing.Size(86, 15);
            this.labelPelagem.TabIndex = 17;
            this.labelPelagem.Text = "Cor / Pelagem:";
            // 
            // textBoxPelagem
            // 
            this.textBoxPelagem.Location = new System.Drawing.Point(338, 88);
            this.textBoxPelagem.Name = "textBoxPelagem";
            this.textBoxPelagem.Size = new System.Drawing.Size(132, 23);
            this.textBoxPelagem.TabIndex = 18;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(200, 217);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(270, 23);
            this.textBoxPeso.TabIndex = 19;
            // 
            // labelDoencas
            // 
            this.labelDoencas.AutoSize = true;
            this.labelDoencas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelDoencas.Location = new System.Drawing.Point(200, 256);
            this.labelDoencas.Name = "labelDoencas";
            this.labelDoencas.Size = new System.Drawing.Size(55, 15);
            this.labelDoencas.TabIndex = 20;
            this.labelDoencas.Text = "Doenças:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelPeso.Location = new System.Drawing.Point(320, 199);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(35, 15);
            this.labelPeso.TabIndex = 23;
            this.labelPeso.Text = "Peso:";
            // 
            // labelDataDeNascimento
            // 
            this.labelDataDeNascimento.AutoSize = true;
            this.labelDataDeNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelDataDeNascimento.Location = new System.Drawing.Point(488, 70);
            this.labelDataDeNascimento.Name = "labelDataDeNascimento";
            this.labelDataDeNascimento.Size = new System.Drawing.Size(117, 15);
            this.labelDataDeNascimento.TabIndex = 25;
            this.labelDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // dateTimePickerDataDeNascimento
            // 
            this.dateTimePickerDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeNascimento.Location = new System.Drawing.Point(492, 88);
            this.dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            this.dateTimePickerDataDeNascimento.Size = new System.Drawing.Size(113, 23);
            this.dateTimePickerDataDeNascimento.TabIndex = 27;
            // 
            // textBoxDoencas
            // 
            this.textBoxDoencas.Location = new System.Drawing.Point(200, 274);
            this.textBoxDoencas.Name = "textBoxDoencas";
            this.textBoxDoencas.Size = new System.Drawing.Size(270, 23);
            this.textBoxDoencas.TabIndex = 28;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(930, 395);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(88, 43);
            this.buttonApagar.TabIndex = 29;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButtonFemea.Location = new System.Drawing.Point(484, 160);
            this.radioButtonFemea.Name = "radioButtonFemea";
            this.radioButtonFemea.Size = new System.Drawing.Size(63, 19);
            this.radioButtonFemea.TabIndex = 30;
            this.radioButtonFemea.TabStop = true;
            this.radioButtonFemea.Text = "Fêmea.";
            this.radioButtonFemea.UseVisualStyleBackColor = false;
            // 
            // radioButtonMacho
            // 
            this.radioButtonMacho.AutoSize = true;
            this.radioButtonMacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButtonMacho.Location = new System.Drawing.Point(484, 181);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(65, 19);
            this.radioButtonMacho.TabIndex = 31;
            this.radioButtonMacho.TabStop = true;
            this.radioButtonMacho.Text = "Macho.";
            this.radioButtonMacho.UseVisualStyleBackColor = false;
            // 
            // checkBoxVacinado
            // 
            this.checkBoxVacinado.AutoSize = true;
            this.checkBoxVacinado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBoxVacinado.Location = new System.Drawing.Point(484, 274);
            this.checkBoxVacinado.Name = "checkBoxVacinado";
            this.checkBoxVacinado.Size = new System.Drawing.Size(78, 19);
            this.checkBoxVacinado.TabIndex = 32;
            this.checkBoxVacinado.Text = "Vacinado.";
            this.checkBoxVacinado.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(118, 395);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 43);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxEspecie
            // 
            this.comboBoxEspecie.FormattingEnabled = true;
            this.comboBoxEspecie.Items.AddRange(new object[] {
            "Gato",
            "Cachorro"});
            this.comboBoxEspecie.Location = new System.Drawing.Point(200, 88);
            this.comboBoxEspecie.Name = "comboBoxEspecie";
            this.comboBoxEspecie.Size = new System.Drawing.Size(132, 23);
            this.comboBoxEspecie.TabIndex = 34;
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.FormattingEnabled = true;
            this.comboBoxRaca.Items.AddRange(new object[] {
            "Persa"});
            this.comboBoxRaca.Location = new System.Drawing.Point(200, 156);
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.Size = new System.Drawing.Size(270, 23);
            this.comboBoxRaca.TabIndex = 35;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSexo.Location = new System.Drawing.Point(501, 142);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 15);
            this.labelSexo.TabIndex = 37;
            this.labelSexo.Text = "Sexo:";
            // 
            // richTextBoxObservacoes
            // 
            this.richTextBoxObservacoes.Location = new System.Drawing.Point(680, 290);
            this.richTextBoxObservacoes.Name = "richTextBoxObservacoes";
            this.richTextBoxObservacoes.Size = new System.Drawing.Size(283, 67);
            this.richTextBoxObservacoes.TabIndex = 38;
            this.richTextBoxObservacoes.Text = "";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelObservacoes.Location = new System.Drawing.Point(772, 272);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(77, 15);
            this.labelObservacoes.TabIndex = 39;
            this.labelObservacoes.Text = "Observações:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnEspecie,
            this.ColumnDataDeCadastro});
            this.dataGridView1.Location = new System.Drawing.Point(611, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(460, 228);
            this.dataGridView1.TabIndex = 40;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 150;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 150;
            // 
            // ColumnEspecie
            // 
            this.ColumnEspecie.HeaderText = "Espécie";
            this.ColumnEspecie.MinimumWidth = 150;
            this.ColumnEspecie.Name = "ColumnEspecie";
            this.ColumnEspecie.ReadOnly = true;
            this.ColumnEspecie.Width = 150;
            // 
            // ColumnDataDeCadastro
            // 
            this.ColumnDataDeCadastro.HeaderText = "Data de Cadastro";
            this.ColumnDataDeCadastro.MinimumWidth = 120;
            this.ColumnDataDeCadastro.Name = "ColumnDataDeCadastro";
            this.ColumnDataDeCadastro.ReadOnly = true;
            this.ColumnDataDeCadastro.Width = 120;
            // 
            // CadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.richTextBoxObservacoes);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.comboBoxRaca);
            this.Controls.Add(this.comboBoxEspecie);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.checkBoxVacinado);
            this.Controls.Add(this.radioButtonMacho);
            this.Controls.Add(this.radioButtonFemea);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.textBoxDoencas);
            this.Controls.Add(this.dateTimePickerDataDeNascimento);
            this.Controls.Add(this.labelDataDeNascimento);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDoencas);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxPelagem);
            this.Controls.Add(this.labelPelagem);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.labelEspecie);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dateTimePickerDataDeCadastro);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CadastroAnimal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.CadastroPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonEditar;
        private TextBox textBoxNome;
        private Label labelCadastro;
        private DateTimePicker dateTimePickerDataDeCadastro;
        private Label labelNome;
        private Label labelEspecie;
        private Label labelRaca;
        private Label labelPelagem;
        private TextBox textBoxPelagem;
        private TextBox textBoxPeso;
        private Label labelDoencas;
        private Label labelPeso;
        private Label labelDataDeNascimento;
        private DateTimePicker dateTimePickerDataDeNascimento;
        private TextBox textBoxDoencas;
        private Button buttonApagar;
        private RadioButton radioButtonFemea;
        private RadioButton radioButtonMacho;
        private CheckBox checkBoxVacinado;
        private Button buttonCancelar;
        private ComboBox comboBoxEspecie;
        private ComboBox comboBoxRaca;
        private Label labelSexo;
        private RichTextBox richTextBoxObservacoes;
        private Label labelObservacoes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnEspecie;
        private DataGridViewTextBoxColumn ColumnDataDeCadastro;
    }
}