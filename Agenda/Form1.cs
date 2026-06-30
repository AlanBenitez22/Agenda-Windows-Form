using System.Data;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBAgenda.CriarDataBase();
            DBAgenda.CriarTabela();
            ConfigurarDataGridView(); // Resolução 1: configurar o grid
            ExibirDados();
        }

        //  Resolução 1: Configuração do DataGridView
        private void ConfigurarDataGridView()
        {
            // Não permite edição direta dos dados
            dGDados.ReadOnly = true;

            // Seleciona a linha inteira ao clicar em qualquer célula
            dGDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Resolução 6
            dGDados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 87, 141);
            dGDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dGDados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dGDados.EnableHeadersVisualStyles = false; 
            dGDados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 242, 252);
            dGDados.BorderStyle = BorderStyle.FixedSingle;
            dGDados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGDados.GridColor = Color.LightSteelBlue;
        }

        //  Resolução 2: Carregar dados da linha selecionada nos campos 
        private void dGDados_SelectionChanged(object sender, EventArgs e)
        {
            if (dGDados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dGDados.SelectedRows[0];
                txtId.Text       = row.Cells["Id"].Value?.ToString() ?? "";
                txtNome.Text     = row.Cells["Nome"].Value?.ToString() ?? "";

                // O MaskedTextBox //
                string tel = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtTelefone.Text = tel;
            }
        }

        // Resolução 3: Validação de campos 
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show(
                    "O campo Nome não pode estar vazio.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            // MaskedTextBox: verifica se o texto sem máscara tem ao menos 10 dígitos
            string telefoneDigitos = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
            if (string.IsNullOrWhiteSpace(telefoneDigitos))
            {
                MessageBox.Show(
                    "O campo Telefone não pode estar vazio.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return false;
            }

            if (telefoneDigitos.Length < 10)
            {
                MessageBox.Show(
                    "O Telefone deve conter pelo menos 10 dígitos (DDD + número).",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return false;
            }

            return true;
        }
        private void ExibirDados()
        {
            try
            {
                DataTable table = DBAgenda.GetContatos();
                dGDados.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Text = "";
        }

        // Botão Inserir 
        private void btInserir_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return; // Resolução 3

            try
            {
                Contato contato = new Contato
                {
                    Id       = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                    Nome     = txtNome.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim()
                };

                DBAgenda.InserirContato(contato);
                ExibirDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Botão Alterar 
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return; // Resolução 3

            try
            {
                Contato contato = new Contato
                {
                    Id       = Convert.ToInt32(txtId.Text),
                    Nome     = txtNome.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim()
                };

                DBAgenda.AlterarContato(contato);
                ExibirDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Botão Localizar 
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                DataTable table = DBAgenda.GetContatoById(id);
                dGDados.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Resolução 5: telinha de confirmação antes de excluir 
        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(txtId.Text);
                DBAgenda.ExcluirContato(id);
                ExibirDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Botão Próxima 
        private void btNext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
