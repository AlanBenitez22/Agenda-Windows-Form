namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            btInserir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btExcluir = new Button();
            dGDados = new DataGridView();
            btNext = new Button();
            ((System.ComponentModel.ISupportInitialize)dGDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(83, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(207, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 41);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(83, 67);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(207, 23);
            txtTelefone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 70);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // btInserir
            // 
            btInserir.Location = new Point(26, 109);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(75, 23);
            btInserir.TabIndex = 6;
            btInserir.Text = "Inserir";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(107, 109);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 23);
            btAlterar.TabIndex = 7;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(188, 109);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(75, 23);
            btLocalizar.TabIndex = 8;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(269, 109);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // dGDados
            // 
            dGDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGDados.Location = new Point(28, 173);
            dGDados.Name = "dGDados";
            dGDados.Size = new Size(325, 150);
            dGDados.TabIndex = 10;
            // 
            // btNext
            // 
            btNext.Location = new Point(350, 109);
            btNext.Name = "btNext";
            btNext.Size = new Size(75, 23);
            btNext.TabIndex = 11;
            btNext.Text = "Próxima";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btNext);
            Controls.Add(dGDados);
            Controls.Add(btExcluir);
            Controls.Add(btLocalizar);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agenda";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dGDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private Button btInserir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btExcluir;
        private DataGridView dGDados;
        private Button btNext;
    }
}
