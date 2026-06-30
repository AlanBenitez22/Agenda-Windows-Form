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
            // ── Declarações ──────────────────────────────────────────────────────
            groupBoxDados   = new GroupBox();
            groupBoxAcoes   = new GroupBox();
            groupBoxGrid    = new GroupBox();

            label1          = new Label();
            label2          = new Label();
            label3          = new Label();

            txtId           = new TextBox();
            txtNome         = new TextBox();
            txtTelefone     = new MaskedTextBox();   // Melhoria 4: MaskedTextBox

            btInserir       = new Button();
            btAlterar       = new Button();
            btLocalizar     = new Button();
            btExcluir       = new Button();
            btNext          = new Button();

            dGDados         = new DataGridView();

            // ── SuspendLayout ────────────────────────────────────────────────────
            groupBoxDados.SuspendLayout();
            groupBoxAcoes.SuspendLayout();
            groupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGDados).BeginInit();
            SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            // Melhoria 6: Fonte geral da aplicação
            // ════════════════════════════════════════════════════════════════════
            Font fontePadrao = new Font("Segoe UI", 9.5f);

            // ════════════════════════════════════════════════════════════════════
            // GroupBox: Dados do Contato  (Melhoria 6: organizar em GroupBox)
            // ════════════════════════════════════════════════════════════════════
            groupBoxDados.Text      = "Dados do Contato";
            groupBoxDados.Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            groupBoxDados.Location  = new Point(12, 12);
            groupBoxDados.Size      = new Size(560, 120);
            groupBoxDados.Name      = "groupBoxDados";
            groupBoxDados.TabIndex  = 0;

            // label1 – ID
            label1.AutoSize = true;
            label1.Font     = fontePadrao;
            label1.Location = new Point(12, 30);
            label1.Name     = "label1";
            label1.Text     = "ID:";

            // txtId
            txtId.Location  = new Point(90, 27);
            txtId.Name      = "txtId";
            txtId.Size      = new Size(80, 24);
            txtId.Font      = fontePadrao;
            txtId.TabIndex  = 1;

            // label2 – Nome
            label2.AutoSize = true;
            label2.Font     = fontePadrao;
            label2.Location = new Point(12, 64);
            label2.Name     = "label2";
            label2.Text     = "Nome:";

            // txtNome
            txtNome.Location    = new Point(90, 61);
            txtNome.Name        = "txtNome";
            txtNome.Size        = new Size(440, 24);
            txtNome.Font        = fontePadrao;
            txtNome.TabIndex    = 2;

            // label3 – Telefone
            label3.AutoSize = true;
            label3.Font     = fontePadrao;
            label3.Location = new Point(190, 30);
            label3.Name     = "label3";
            label3.Text     = "Telefone:";

            // txtTelefone – Melhoria 4: MaskedTextBox com máscara (99) 99999-9999
            ((MaskedTextBox)txtTelefone).Mask        = "(00) 00000-0000";
            txtTelefone.Location                      = new Point(270, 27);
            txtTelefone.Name                          = "txtTelefone";
            txtTelefone.Size                          = new Size(160, 24);
            txtTelefone.Font                          = fontePadrao;
            txtTelefone.TabIndex                      = 3;

            groupBoxDados.Controls.Add(label1);
            groupBoxDados.Controls.Add(txtId);
            groupBoxDados.Controls.Add(label3);
            groupBoxDados.Controls.Add(txtTelefone);
            groupBoxDados.Controls.Add(label2);
            groupBoxDados.Controls.Add(txtNome);

            // ════════════════════════════════════════════════════════════════════
            // GroupBox: Ações  (Melhoria 6: organizar em GroupBox)
            // ════════════════════════════════════════════════════════════════════
            groupBoxAcoes.Text      = "Ações";
            groupBoxAcoes.Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            groupBoxAcoes.Location  = new Point(12, 142);
            groupBoxAcoes.Size      = new Size(560, 64);
            groupBoxAcoes.Name      = "groupBoxAcoes";
            groupBoxAcoes.TabIndex  = 1;

            // Melhoria 6: Botões com cores e fonte
            // btInserir
            btInserir.Location              = new Point(12, 22);
            btInserir.Name                  = "btInserir";
            btInserir.Size                  = new Size(100, 32);
            btInserir.TabIndex              = 0;
            btInserir.Text                  = "✚  Inserir";
            btInserir.Font                  = fontePadrao;
            btInserir.BackColor             = Color.FromArgb(40, 167, 69);
            btInserir.ForeColor             = Color.White;
            btInserir.FlatStyle             = FlatStyle.Flat;
            btInserir.FlatAppearance.BorderSize = 0;
            btInserir.UseVisualStyleBackColor = false;
            btInserir.Click                 += btInserir_Click;

            // btAlterar
            btAlterar.Location              = new Point(122, 22);
            btAlterar.Name                  = "btAlterar";
            btAlterar.Size                  = new Size(100, 32);
            btAlterar.TabIndex              = 1;
            btAlterar.Text                  = "✎  Alterar";
            btAlterar.Font                  = fontePadrao;
            btAlterar.BackColor             = Color.FromArgb(0, 123, 255);
            btAlterar.ForeColor             = Color.White;
            btAlterar.FlatStyle             = FlatStyle.Flat;
            btAlterar.FlatAppearance.BorderSize = 0;
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click                 += btAlterar_Click;

            // btLocalizar
            btLocalizar.Location            = new Point(232, 22);
            btLocalizar.Name                = "btLocalizar";
            btLocalizar.Size                = new Size(110, 32);
            btLocalizar.TabIndex            = 2;
            btLocalizar.Text                = "🔍  Localizar";
            btLocalizar.Font                = fontePadrao;
            btLocalizar.BackColor           = Color.FromArgb(255, 193, 7);
            btLocalizar.ForeColor           = Color.Black;
            btLocalizar.FlatStyle           = FlatStyle.Flat;
            btLocalizar.FlatAppearance.BorderSize = 0;
            btLocalizar.UseVisualStyleBackColor = false;
            btLocalizar.Click               += btLocalizar_Click;

            // btExcluir
            btExcluir.Location              = new Point(352, 22);
            btExcluir.Name                  = "btExcluir";
            btExcluir.Size                  = new Size(100, 32);
            btExcluir.TabIndex              = 3;
            btExcluir.Text                  = "🗑  Excluir";
            btExcluir.Font                  = fontePadrao;
            btExcluir.BackColor             = Color.FromArgb(220, 53, 69);
            btExcluir.ForeColor             = Color.White;
            btExcluir.FlatStyle             = FlatStyle.Flat;
            btExcluir.FlatAppearance.BorderSize = 0;
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click                 += btExcluir_Click;

            // btNext
            btNext.Location                 = new Point(462, 22);
            btNext.Name                     = "btNext";
            btNext.Size                     = new Size(85, 32);
            btNext.TabIndex                 = 4;
            btNext.Text                     = "▶  Próxima";
            btNext.Font                     = fontePadrao;
            btNext.BackColor                = Color.FromArgb(108, 117, 125);
            btNext.ForeColor                = Color.White;
            btNext.FlatStyle                = FlatStyle.Flat;
            btNext.FlatAppearance.BorderSize = 0;
            btNext.UseVisualStyleBackColor  = false;
            btNext.Click                    += btNext_Click;

            groupBoxAcoes.Controls.Add(btInserir);
            groupBoxAcoes.Controls.Add(btAlterar);
            groupBoxAcoes.Controls.Add(btLocalizar);
            groupBoxAcoes.Controls.Add(btExcluir);
            groupBoxAcoes.Controls.Add(btNext);

            // ════════════════════════════════════════════════════════════════════
            // GroupBox: Lista de Contatos  (Melhoria 6)
            // ════════════════════════════════════════════════════════════════════
            groupBoxGrid.Text       = "Lista de Contatos";
            groupBoxGrid.Font       = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            groupBoxGrid.Location   = new Point(12, 216);
            groupBoxGrid.Size       = new Size(560, 260);
            groupBoxGrid.Name       = "groupBoxGrid";
            groupBoxGrid.TabIndex   = 2;

            // ── DataGridView ─────────────────────────────────────────────────────
            // Melhoria 1: ReadOnly + FullRowSelect configurados em ConfigurarDataGridView()
            dGDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGDados.Location    = new Point(10, 22);
            dGDados.Name        = "dGDados";
            dGDados.Size        = new Size(538, 228);
            dGDados.TabIndex    = 0;
            dGDados.Font        = fontePadrao;
            dGDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Melhoria 2: evento SelectionChanged para carregar dados nos campos
            dGDados.SelectionChanged += dGDados_SelectionChanged;

            groupBoxGrid.Controls.Add(dGDados);

            // ════════════════════════════════════════════════════════════════════
            // Form1
            // ════════════════════════════════════════════════════════════════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(586, 490);
            BackColor           = Color.FromArgb(245, 247, 250);
            Font                = new Font("Segoe UI", 9.5f); // Melhoria 6: fonte do form
            Controls.Add(groupBoxDados);
            Controls.Add(groupBoxAcoes);
            Controls.Add(groupBoxGrid);
            Name    = "Form1";
            Text    = "📋  Agenda de Contatos";
            Load    += Form1_Load;

            groupBoxDados.ResumeLayout(false);
            groupBoxDados.PerformLayout();
            groupBoxAcoes.ResumeLayout(false);
            groupBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ── Declaração dos controles ─────────────────────────────────────────────
        private GroupBox    groupBoxDados;
        private GroupBox    groupBoxAcoes;
        private GroupBox    groupBoxGrid;
        private Label       label1;
        private Label       label2;
        private Label       label3;
        private TextBox     txtId;
        private TextBox     txtNome;
        private MaskedTextBox txtTelefone;   // Melhoria 4
        private Button      btInserir;
        private Button      btAlterar;
        private Button      btLocalizar;
        private Button      btExcluir;
        private Button      btNext;
        private DataGridView dGDados;
    }
}
