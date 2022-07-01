namespace Entra21_TrabalhoWindowsForms
{
    partial class MenuForm
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
            this.buttonCadastroResponsavel = new System.Windows.Forms.Button();
            this.buttonCadastroPet = new System.Windows.Forms.Button();
            this.buttonVeterinario = new System.Windows.Forms.Button();
            this.buttonCadastroMedicamentos = new System.Windows.Forms.Button();
            this.buttonAgendamentoConsulta = new System.Windows.Forms.Button();
            this.buttonConsultarHorarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastroResponsavel
            // 
            this.buttonCadastroResponsavel.Location = new System.Drawing.Point(42, 139);
            this.buttonCadastroResponsavel.Name = "buttonCadastroResponsavel";
            this.buttonCadastroResponsavel.Size = new System.Drawing.Size(177, 162);
            this.buttonCadastroResponsavel.TabIndex = 0;
            this.buttonCadastroResponsavel.Text = "CADASTRO RESPONSAVEL";
            this.buttonCadastroResponsavel.UseVisualStyleBackColor = true;
            this.buttonCadastroResponsavel.Click += new System.EventHandler(this.buttonCadastroResponsavel_Click);
            // 
            // buttonCadastroPet
            // 
            this.buttonCadastroPet.Location = new System.Drawing.Point(258, 139);
            this.buttonCadastroPet.Name = "buttonCadastroPet";
            this.buttonCadastroPet.Size = new System.Drawing.Size(177, 162);
            this.buttonCadastroPet.TabIndex = 1;
            this.buttonCadastroPet.Text = "CADASTRO PET";
            this.buttonCadastroPet.UseVisualStyleBackColor = true;
            this.buttonCadastroPet.Click += new System.EventHandler(this.buttonCadastroPet_Click);
            // 
            // buttonVeterinario
            // 
            this.buttonVeterinario.Location = new System.Drawing.Point(42, 404);
            this.buttonVeterinario.Name = "buttonVeterinario";
            this.buttonVeterinario.Size = new System.Drawing.Size(177, 162);
            this.buttonVeterinario.TabIndex = 2;
            this.buttonVeterinario.Text = "CADASTRO VETERINÁRIO";
            this.buttonVeterinario.UseVisualStyleBackColor = true;
            this.buttonVeterinario.Click += new System.EventHandler(this.buttonVeterinario_Click);
            // 
            // buttonCadastroMedicamentos
            // 
            this.buttonCadastroMedicamentos.Location = new System.Drawing.Point(487, 139);
            this.buttonCadastroMedicamentos.Name = "buttonCadastroMedicamentos";
            this.buttonCadastroMedicamentos.Size = new System.Drawing.Size(177, 162);
            this.buttonCadastroMedicamentos.TabIndex = 3;
            this.buttonCadastroMedicamentos.Text = "CADASTRO MEDICAMENTOS";
            this.buttonCadastroMedicamentos.UseVisualStyleBackColor = true;
            this.buttonCadastroMedicamentos.Click += new System.EventHandler(this.buttonCadastroMedicamentos_Click);
            // 
            // buttonAgendamentoConsulta
            // 
            this.buttonAgendamentoConsulta.Location = new System.Drawing.Point(258, 404);
            this.buttonAgendamentoConsulta.Name = "buttonAgendamentoConsulta";
            this.buttonAgendamentoConsulta.Size = new System.Drawing.Size(177, 162);
            this.buttonAgendamentoConsulta.TabIndex = 4;
            this.buttonAgendamentoConsulta.Text = "AGENDAMENTO CONSULTA";
            this.buttonAgendamentoConsulta.UseVisualStyleBackColor = true;
            this.buttonAgendamentoConsulta.Click += new System.EventHandler(this.buttonAgendamentoConsulta_Click);
            // 
            // buttonConsultarHorarios
            // 
            this.buttonConsultarHorarios.Location = new System.Drawing.Point(487, 404);
            this.buttonConsultarHorarios.Name = "buttonConsultarHorarios";
            this.buttonConsultarHorarios.Size = new System.Drawing.Size(177, 162);
            this.buttonConsultarHorarios.TabIndex = 5;
            this.buttonConsultarHorarios.Text = "CONSULTAR HORARIOS";
            this.buttonConsultarHorarios.UseVisualStyleBackColor = true;
            this.buttonConsultarHorarios.Click += new System.EventHandler(this.buttonConsultarHorarios_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 626);
            this.Controls.Add(this.buttonConsultarHorarios);
            this.Controls.Add(this.buttonAgendamentoConsulta);
            this.Controls.Add(this.buttonCadastroMedicamentos);
            this.Controls.Add(this.buttonVeterinario);
            this.Controls.Add(this.buttonCadastroPet);
            this.Controls.Add(this.buttonCadastroResponsavel);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastroResponsavel;
        private Button buttonCadastroPet;
        private Button buttonVeterinario;
        private Button buttonCadastroMedicamentos;
        private Button buttonAgendamentoConsulta;
        private Button buttonConsultarHorarios;
    }
}