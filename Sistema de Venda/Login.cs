using Sistema_de_Caixa;
using Sistema_de_Venda.Controller;

namespace Sistema_de_Venda
{
    public partial class Login : Form
    {
        LoginController loginController = new();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty)
            {
                MessageBox.Show("Preencha o nome do usuario para fazer o login");
                return;
            }

            string nome = txtLogin.Text;
            string senha = txtSenha.Text;
            bool LoginValido = loginController.VerificaLogin(nome, senha);
            if (LoginValido)
            {
                Caixa caixa = new();
                Hide();
                caixa.ShowDialog();
                Close();

            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            bool temUsuarios = loginController.VerificaCadastros();
            if (!temUsuarios)
            {
                MessageBox.Show("Cadastre seu primeiro usuario");
                Usuarios usuarios = new(true);
                usuarios.ShowDialog();
            }
        }
    }
}