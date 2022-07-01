namespace Entra21_TrabalhoWindowsForms
{
    partial class VeterinarioForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNomeVeterinario = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelDataAdmissao = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewVeterinarios = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(57, 101);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(195, 28);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do Veterinário";
            // 
            // textBoxNomeVeterinario
            // 
            this.textBoxNomeVeterinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomeVeterinario.Location = new System.Drawing.Point(57, 132);
            this.textBoxNomeVeterinario.Name = "textBoxNomeVeterinario";
            this.textBoxNomeVeterinario.Size = new System.Drawing.Size(329, 34);
            this.textBoxNomeVeterinario.TabIndex = 1;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCpf.Location = new System.Drawing.Point(57, 212);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(45, 28);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF";
            // 
            // labelDataAdmissao
            // 
            this.labelDataAdmissao.AutoSize = true;
            this.labelDataAdmissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataAdmissao.Location = new System.Drawing.Point(57, 334);
            this.labelDataAdmissao.Name = "labelDataAdmissao";
            this.labelDataAdmissao.Size = new System.Drawing.Size(170, 28);
            this.labelDataAdmissao.TabIndex = 3;
            this.labelDataAdmissao.Text = "Data de Admissão";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(57, 243);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(229, 34);
            this.maskedTextBoxCpf.TabIndex = 4;
            // 
            // dateTimePickerDataAdmissao
            // 
            this.dateTimePickerDataAdmissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataAdmissao.Location = new System.Drawing.Point(57, 365);
            this.dateTimePickerDataAdmissao.Name = "dateTimePickerDataAdmissao";
            this.dateTimePickerDataAdmissao.Size = new System.Drawing.Size(170, 34);
            this.dateTimePickerDataAdmissao.TabIndex = 5;
            // 
            // dataGridViewVeterinarios
            // 
            this.dataGridViewVeterinarios.AllowUserToAddRows = false;
            this.dataGridViewVeterinarios.AllowUserToDeleteRows = false;
            this.dataGridViewVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeterinarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNomeVeterinario,
            this.ColumnCpf,
            this.ColumnDataAdmissao});
            this.dataGridViewVeterinarios.Location = new System.Drawing.Point(479, 44);
            this.dataGridViewVeterinarios.Name = "dataGridViewVeterinarios";
            this.dataGridViewVeterinarios.ReadOnly = true;
            this.dataGridViewVeterinarios.RowHeadersWidth = 51;
            this.dataGridViewVeterinarios.RowTemplate.Height = 29;
            this.dataGridViewVeterinarios.Size = new System.Drawing.Size(534, 489);
            this.dataGridViewVeterinarios.TabIndex = 6;
            this.dataGridViewVeterinarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVeterinarios_CellContentClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNomeVeterinario
            // 
            this.ColumnNomeVeterinario.HeaderText = "Nome do Veterinário";
            this.ColumnNomeVeterinario.MinimumWidth = 6;
            this.ColumnNomeVeterinario.Name = "ColumnNomeVeterinario";
            this.ColumnNomeVeterinario.ReadOnly = true;
            this.ColumnNomeVeterinario.Width = 125;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.MinimumWidth = 6;
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            this.ColumnCpf.Width = 125;
            // 
            // ColumnDataAdmissao
            // 
            this.ColumnDataAdmissao.HeaderText = "Data de Admissão";
            this.ColumnDataAdmissao.MinimumWidth = 6;
            this.ColumnDataAdmissao.Name = "ColumnDataAdmissao";
            this.ColumnDataAdmissao.ReadOnly = true;
            this.ColumnDataAdmissao.Width = 125;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(479, 551);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(579, 551);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(192, 504);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(292, 504);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // VeterinarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 614);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewVeterinarios);
            this.Controls.Add(this.dateTimePickerDataAdmissao);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.labelDataAdmissao);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.textBoxNomeVeterinario);
            this.Controls.Add(this.labelNome);
            this.Name = "VeterinarioForm";
            this.Text = "VeterinarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeterinarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNomeVeterinario;
        private Label labelCpf;
        private Label labelDataAdmissao;
        private MaskedTextBox maskedTextBoxCpf;
        private DateTimePicker dateTimePickerDataAdmissao;
        private DataGridView dataGridViewVeterinarios;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNomeVeterinario;
        private DataGridViewTextBoxColumn ColumnCpf;
        private DataGridViewTextBoxColumn ColumnDataAdmissao;
    }
}