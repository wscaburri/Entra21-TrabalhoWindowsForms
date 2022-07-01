namespace Entra21_TrabalhoWindowsForms
{
    partial class MedicamentosForm
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
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnForma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRecomendacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNomeMedicamento = new System.Windows.Forms.Label();
            this.textBoxNomeMedicamento = new System.Windows.Forms.TextBox();
            this.labelTipoMedicamento = new System.Windows.Forms.Label();
            this.comboBoxTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.radioButtonComprimido = new System.Windows.Forms.RadioButton();
            this.radioButtonLiquida = new System.Windows.Forms.RadioButton();
            this.radioButtonVacina = new System.Windows.Forms.RadioButton();
            this.labelFormaMedicamento = new System.Windows.Forms.Label();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.checkBoxCaes = new System.Windows.Forms.CheckBox();
            this.checkBoxGatos = new System.Windows.Forms.CheckBox();
            this.labelRecomendacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedicamentos
            // 
            this.dataGridViewMedicamentos.AllowUserToAddRows = false;
            this.dataGridViewMedicamentos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnTipo,
            this.ColumnForma,
            this.ColumnRecomendacao});
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.ReadOnly = true;
            this.dataGridViewMedicamentos.RowTemplate.Height = 25;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(447, 370);
            this.dataGridViewMedicamentos.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            // 
            // ColumnForma
            // 
            this.ColumnForma.HeaderText = "Forma";
            this.ColumnForma.Name = "ColumnForma";
            this.ColumnForma.ReadOnly = true;
            // 
            // ColumnRecomendacao
            // 
            this.ColumnRecomendacao.HeaderText = "Recomendado";
            this.ColumnRecomendacao.Name = "ColumnRecomendacao";
            this.ColumnRecomendacao.ReadOnly = true;
            // 
            // labelNomeMedicamento
            // 
            this.labelNomeMedicamento.AutoSize = true;
            this.labelNomeMedicamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomeMedicamento.Location = new System.Drawing.Point(479, 30);
            this.labelNomeMedicamento.Name = "labelNomeMedicamento";
            this.labelNomeMedicamento.Size = new System.Drawing.Size(174, 21);
            this.labelNomeMedicamento.TabIndex = 1;
            this.labelNomeMedicamento.Text = "Nome do Medicamento";
            // 
            // textBoxNomeMedicamento
            // 
            this.textBoxNomeMedicamento.Location = new System.Drawing.Point(479, 54);
            this.textBoxNomeMedicamento.Name = "textBoxNomeMedicamento";
            this.textBoxNomeMedicamento.Size = new System.Drawing.Size(332, 23);
            this.textBoxNomeMedicamento.TabIndex = 2;
            // 
            // labelTipoMedicamento
            // 
            this.labelTipoMedicamento.AutoSize = true;
            this.labelTipoMedicamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipoMedicamento.Location = new System.Drawing.Point(479, 91);
            this.labelTipoMedicamento.Name = "labelTipoMedicamento";
            this.labelTipoMedicamento.Size = new System.Drawing.Size(161, 21);
            this.labelTipoMedicamento.TabIndex = 3;
            this.labelTipoMedicamento.Text = "Tipo do Medicamento";
            // 
            // comboBoxTipoMedicamento
            // 
            this.comboBoxTipoMedicamento.FormattingEnabled = true;
            this.comboBoxTipoMedicamento.Items.AddRange(new object[] {
            "Analgésico",
            "Antibacteriano",
            "Antibiótico",
            "Antidepressivo",
            "Antigripal",
            "Antiinflamatório",
            "Antiséptico",
            "Descongestionante nasal"});
            this.comboBoxTipoMedicamento.Location = new System.Drawing.Point(479, 115);
            this.comboBoxTipoMedicamento.Name = "comboBoxTipoMedicamento";
            this.comboBoxTipoMedicamento.Size = new System.Drawing.Size(332, 23);
            this.comboBoxTipoMedicamento.TabIndex = 4;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(288, 415);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(369, 415);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 6;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(655, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(736, 415);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // radioButtonComprimido
            // 
            this.radioButtonComprimido.AutoSize = true;
            this.radioButtonComprimido.Location = new System.Drawing.Point(479, 175);
            this.radioButtonComprimido.Name = "radioButtonComprimido";
            this.radioButtonComprimido.Size = new System.Drawing.Size(93, 19);
            this.radioButtonComprimido.TabIndex = 9;
            this.radioButtonComprimido.TabStop = true;
            this.radioButtonComprimido.Text = "Comprimido";
            this.radioButtonComprimido.UseVisualStyleBackColor = true;
            // 
            // radioButtonLiquida
            // 
            this.radioButtonLiquida.AutoSize = true;
            this.radioButtonLiquida.Location = new System.Drawing.Point(578, 175);
            this.radioButtonLiquida.Name = "radioButtonLiquida";
            this.radioButtonLiquida.Size = new System.Drawing.Size(64, 19);
            this.radioButtonLiquida.TabIndex = 10;
            this.radioButtonLiquida.TabStop = true;
            this.radioButtonLiquida.Text = "Líquida";
            this.radioButtonLiquida.UseVisualStyleBackColor = true;
            // 
            // radioButtonVacina
            // 
            this.radioButtonVacina.AutoSize = true;
            this.radioButtonVacina.Location = new System.Drawing.Point(648, 175);
            this.radioButtonVacina.Name = "radioButtonVacina";
            this.radioButtonVacina.Size = new System.Drawing.Size(59, 19);
            this.radioButtonVacina.TabIndex = 11;
            this.radioButtonVacina.TabStop = true;
            this.radioButtonVacina.Text = "Vacina";
            this.radioButtonVacina.UseVisualStyleBackColor = true;
            // 
            // labelFormaMedicamento
            // 
            this.labelFormaMedicamento.AutoSize = true;
            this.labelFormaMedicamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormaMedicamento.Location = new System.Drawing.Point(479, 151);
            this.labelFormaMedicamento.Name = "labelFormaMedicamento";
            this.labelFormaMedicamento.Size = new System.Drawing.Size(176, 21);
            this.labelFormaMedicamento.TabIndex = 12;
            this.labelFormaMedicamento.Text = "Forma do Medicamento";
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(479, 362);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerDataCadastro.TabIndex = 13;
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataCadastro.Location = new System.Drawing.Point(479, 338);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(129, 21);
            this.labelDataCadastro.TabIndex = 14;
            this.labelDataCadastro.Text = "Data de Cadastro";
            // 
            // checkBoxCaes
            // 
            this.checkBoxCaes.AutoSize = true;
            this.checkBoxCaes.Location = new System.Drawing.Point(479, 230);
            this.checkBoxCaes.Name = "checkBoxCaes";
            this.checkBoxCaes.Size = new System.Drawing.Size(51, 19);
            this.checkBoxCaes.TabIndex = 15;
            this.checkBoxCaes.Text = "Cães";
            this.checkBoxCaes.UseVisualStyleBackColor = true;
            // 
            // checkBoxGatos
            // 
            this.checkBoxGatos.AutoSize = true;
            this.checkBoxGatos.Location = new System.Drawing.Point(539, 230);
            this.checkBoxGatos.Name = "checkBoxGatos";
            this.checkBoxGatos.Size = new System.Drawing.Size(56, 19);
            this.checkBoxGatos.TabIndex = 16;
            this.checkBoxGatos.Text = "Gatos";
            this.checkBoxGatos.UseVisualStyleBackColor = true;
            // 
            // labelRecomendacao
            // 
            this.labelRecomendacao.AutoSize = true;
            this.labelRecomendacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecomendacao.Location = new System.Drawing.Point(479, 206);
            this.labelRecomendacao.Name = "labelRecomendacao";
            this.labelRecomendacao.Size = new System.Drawing.Size(116, 21);
            this.labelRecomendacao.TabIndex = 17;
            this.labelRecomendacao.Text = "Recomendação";
            // 
            // MedicamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.labelRecomendacao);
            this.Controls.Add(this.checkBoxGatos);
            this.Controls.Add(this.checkBoxCaes);
            this.Controls.Add(this.labelDataCadastro);
            this.Controls.Add(this.dateTimePickerDataCadastro);
            this.Controls.Add(this.labelFormaMedicamento);
            this.Controls.Add(this.radioButtonVacina);
            this.Controls.Add(this.radioButtonLiquida);
            this.Controls.Add(this.radioButtonComprimido);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.comboBoxTipoMedicamento);
            this.Controls.Add(this.labelTipoMedicamento);
            this.Controls.Add(this.textBoxNomeMedicamento);
            this.Controls.Add(this.labelNomeMedicamento);
            this.Controls.Add(this.dataGridViewMedicamentos);
            this.Name = "MedicamentosForm";
            this.Text = "CadastroMedicamentos";
            this.Load += new System.EventHandler(this.MedicamentosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewMedicamentos;
        private Label labelNomeMedicamento;
        private TextBox textBoxNomeMedicamento;
        private Label labelTipoMedicamento;
        private ComboBox comboBoxTipoMedicamento;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private RadioButton radioButtonComprimido;
        private RadioButton radioButtonLiquida;
        private RadioButton radioButtonVacina;
        private Label labelFormaMedicamento;
        private DateTimePicker dateTimePickerDataCadastro;
        private Label labelDataCadastro;
        private CheckBox checkBoxCaes;
        private CheckBox checkBoxGatos;
        private Label labelRecomendacao;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnForma;
        private DataGridViewTextBoxColumn ColumnRecomendacao;
    }
}