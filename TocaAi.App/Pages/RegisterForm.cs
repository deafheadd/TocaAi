using FluentValidation;
using ReaLTaiizor.Forms;
using TocaAi.App.Validators;
using TocaAi.App.ViewModels;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Validators;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.App.Pages
{
    public partial class RegisterForm : LostForm
    {
        // repositórios
        private readonly IBaseRepository<UserAccount, Guid> _userAccountRepository;
        private readonly IBaseRepository<Person, Guid> _personRepository;

        // validators
        private readonly IValidator<Person> _personValidator;
        private readonly IValidator<UserAccount> _userAccountValidator;
        private readonly IValidator<RegisterUserModel> _registerUserValidator;

        public RegisterForm(
            IBaseRepository<UserAccount, Guid> userAccountRepository,
            IBaseRepository<Person, Guid> personRepository,
            IValidator<Person> personValidator,
            IValidator<UserAccount> userAccountValidator,
            IValidator<RegisterUserModel> registerUserValidator)
        {
            InitializeComponent();

            _userAccountRepository = userAccountRepository;
            _personRepository = personRepository;
            _personValidator = personValidator;
            _userAccountValidator = userAccountValidator;
            _registerUserValidator = registerUserValidator;

            // trava o tamanho da janela
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            // esconde a senha
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // instância
            _personValidator = new PersonValidator();
            _userAccountValidator = new UserAccountValidator();
            _registerUserValidator = new RegisterUserModelValidator();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!radioCustomer.Checked && !radioSeller.Checked)
            {
                MessageBox.Show(
                    "Selecione o seu tipo de conta (Cliente ou Vendedor).",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var role = radioCustomer.Checked ? UserRole.Customer : UserRole.Seller;

            // criação de endereço
            var address = new Address(
                txtStreet.Text.Trim(),
                txtNumber.Text.Trim(),
                txtNeighborhood.Text.Trim(),
                txtCity.Text.Trim(),
                comboBoxState.Text.Trim(),
                txtPostalCode.Text.Trim(),
                txtComplement.Text.Trim()
            );

            // criação de pessoa
            var person = new Person(
                Guid.NewGuid(),
                txtName.Text.Trim(),
                txtDocument.Text.Trim(),
                txtPhoneNumber.Text.Trim(),
                address,
                DateTime.Now
            );

            // confirmação de senha
            var registerModel = new RegisterUserModel(
                txtPassword.Text.Trim(),
                txtConfirmPassword.Text.Trim()
            );

            // validações iniciais
            var personResult = _personValidator.Validate(person);
            if (!personResult.IsValid)
            {
                MessageBox.Show(personResult.Errors.First().ErrorMessage, "Erro de validação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var registerResult = _registerUserValidator.Validate(registerModel);
            if (!registerResult.IsValid)
            {
                MessageBox.Show(registerResult.Errors.First().ErrorMessage, "Erro de validação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // criação e validação de usuário
            var user = new UserAccount(
                Guid.NewGuid(),
                txtUsername.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPassword.Text.Trim(),
                role,
                person
             );

            var userResult = _userAccountValidator.Validate(user);
            if (!userResult.IsValid)
            {
                MessageBox.Show(userResult.Errors.First().ErrorMessage, "Erro de validação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirmação
            DialogResult confirmationResult = MessageBox.Show(
                "Confirma que os dados inseridos estão corretos antes de finalizar o cadastro?",
                "Confirmação de Dados",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // salvar
                    _userAccountRepository.Insert(user);

                    MessageBox.Show(
                        "Usuário registrado com sucesso. Prossiga para o login.",
                        "Cadastro Finalizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pBoxEye1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                // exibe a senha
                txtPassword.UseSystemPasswordChar = false;
                pBoxEye1.Image = Properties.Resources.eye_hidden;
            }
            else
            {
                // esconde a senha
                txtPassword.UseSystemPasswordChar = true;
                pBoxEye1.Image = Properties.Resources.eye_visible;
            }
        }

        private void pBoxEye2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == true)
            {
                // exibe a senha
                txtConfirmPassword.UseSystemPasswordChar = false;
                pBoxEye2.Image = Properties.Resources.eye_hidden;
            }
            else
            {
                // esconde a senha
                txtConfirmPassword.UseSystemPasswordChar = true;
                pBoxEye2.Image = Properties.Resources.eye_visible;
            }
        }
    }
}
