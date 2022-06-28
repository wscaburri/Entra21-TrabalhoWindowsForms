namespace Entra21_TrabalhoWindowsForms
{
    partial class RegistroGeral
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.buttonConsultaMarcarda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1795, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(1682, 85);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(138, 68);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(1506, 85);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(138, 68);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(1315, 85);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(168, 68);
            this.buttonAdicionarCliente.TabIndex = 3;
            this.buttonAdicionarCliente.Text = "Adicionar Cliente";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonConsultaMarcarda
            // 
            this.buttonConsultaMarcarda.Location = new System.Drawing.Point(1147, 83);
            this.buttonConsultaMarcarda.Name = "buttonConsultaMarcarda";
            this.buttonConsultaMarcarda.Size = new System.Drawing.Size(142, 70);
            this.buttonConsultaMarcarda.TabIndex = 4;
            this.buttonConsultaMarcarda.Text = "Consulta Marcada";
            this.buttonConsultaMarcarda.UseVisualStyleBackColor = true;
            // 
            // RegistroGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 875);
            this.Controls.Add(this.buttonConsultaMarcarda);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistroGeral";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "RegistroGeral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonAdicionarCliente;
        private Button buttonConsultaMarcarda;
    }
}