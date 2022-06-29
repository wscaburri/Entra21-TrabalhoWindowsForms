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
            this.labelNomeMedicamento = new System.Windows.Forms.Label();
            this.textBoxNomeMedicamento = new System.Windows.Forms.TextBox();
            this.labelTipoMedicamento = new System.Windows.Forms.Label();
            this.comboBoxTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
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
            this.ColumnTipo});
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.ReadOnly = true;
            this.dataGridViewMedicamentos.RowTemplate.Height = 25;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(432, 370);
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
            this.labelTipoMedicamento.Location = new System.Drawing.Point(479, 100);
            this.labelTipoMedicamento.Name = "labelTipoMedicamento";
            this.labelTipoMedicamento.Size = new System.Drawing.Size(161, 21);
            this.labelTipoMedicamento.TabIndex = 3;
            this.labelTipoMedicamento.Text = "Tipo do Medicamento";
            // 
            // comboBoxTipoMedicamento
            // 
            this.comboBoxTipoMedicamento.FormattingEnabled = true;
            this.comboBoxTipoMedicamento.Items.AddRange(new object[] {
            "Antidepressivo",
            "Antibiotico",
            "Vacina"});
            this.comboBoxTipoMedicamento.Location = new System.Drawing.Point(479, 124);
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
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(655, 165);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(736, 165);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // MedicamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewMedicamentos;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTipo;
        private Label labelNomeMedicamento;
        private TextBox textBoxNomeMedicamento;
        private Label labelTipoMedicamento;
        private ComboBox comboBoxTipoMedicamento;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}