# Agenda-Windows-Form
Sobre os desenvolvimentos solicitados pela prof Claudia:
=
1. Melhorar a configuração do DataGridView
O DataGridView deverá ser configurado para proporcionar uma melhor experiência ao usuário.
Requisitos
• Não permitir edição direta dos dados pela grade.
• Selecionar a linha inteira ao clicar em qualquer célula

1 - Resolução:
Alteração realizada nas cores e tipo de fonte, além de aplicar o ReadOnly = true e SelectionMode = FullRowSelect dentro do ConfigurarDataGridView().

------------------------------------------------------------------------------------------------------------------
2. Carregar os dados da linha selecionada nos campos de edição
Ao selecionar um registro na grade, os dados deverão ser carregados automaticamente para os campos de texto evento dGDados_SelectionChanged preenche automaticamente txtId, txtNome e txtTelefone ao selecionar qualquer linha.

Requisitos
Ao clicar em uma linha do DataGridView:
• O campo ID deve ser preenchido.
• O campo Nome deve ser preenchido.
• O campo Telefone deve ser preenchido.

2 - Resolução:
= 
Foi aplicado a condição para Carregar dados ao clicar na linha dGDados_SelectionChanged preenche automaticamente txtId, txtNome e txtTelefone ao selecionar qualquer linha.


-------------------------------------------------------------------------------------------------------------

3. Criar validações antes de inserir ou alterar registros
O sistema não deverá permitir o cadastro de informações inválidas.
Requisitos
Validar obrigatoriamente:
• Nome não pode estar vazio.
• Telefone não pode estar vazio.
• Telefone deve possuir quantidade mínima de caracteres válida.
Caso alguma validação falhe:
• Exibir mensagem ao usuário.
• Impedir a gravação dos dados.
 
3 - Resolução
=
método ValidarCampos() chamado antes de Inserir e Alterar, verificando:

Nome não vazio (String.IsNullOrWhiteSpace).
Telefone não vazio.
Telefone com mínimo de 10 dígitos numéricos.
----------------------------------------------------------------------------------------------------------------

4. Implementar máscara para telefone
O campo telefone deverá possuir uma máscara de entrada.
Requisitos
Substituir o TextBox comum por um componente adequado.
Exemplo de formato:
(00) 00000-0000

4 - Resolução:
=
o TextBox foi substituído por um MaskedTextBox com a propriedade Mask = "(00) 00000-0000".

-----------------------------------------------------------------------------------------------------------------

5. Solicitar confirmação antes da exclusão
O sistema deverá pedir confirmação antes de excluir qualquer registro.
Requisitos
Ao clicar em Excluir:
• Exibir uma caixa de confirmação.
• Permitir continuar apenas se o usuário confirmar.

5 - Resolução:
= 
Foi aplicado o MessageBox com MessageBoxButtons.YesNo antes de deletar; o registro só é excluído se o usuário clicar em Sim.

-------------------------------------------------------------------------------------------------------------------

6. Melhorias visuais
Realizar melhorias na aparência geral da aplicação.
Requisitos mínimos
Implementar pelo menos três das melhorias abaixo:
• Alterar fonte da aplicação.
• Melhorar alinhamento dos componentes.
• Organizar os campos dentro de GroupBox.
• Inserir ícones nos botões.
• Alterar cores do cabeçalho do DataGridView.

6 - Resolução:
= 
Fonte Segoe UI 9.5pt aplicada ao Form e a todos os controles.
Campos organizados em três GroupBox ("Dados do Contato", "Ações", "Lista de Contatos").
Botões coloridos com ícones emoji no texto (✚ Inserir, ✎ Alterar, 🔍 Localizar, 🗑 Excluir).
Cabeçalho do DataGridView com fundo azul escuro e texto branco.

<img width="1898" height="977" alt="image" src="https://github.com/user-attachments/assets/03a86c7e-bdf6-4460-b3f2-7174067b831f" />

