namespace TelaDeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool VerifyPassword(string password)
        {
            if (password != "123") return false;
            return true;
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            if (userInput.Text == "")
                MessageBox.Show("Digite  o nome do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (userInput.Text == "Isaque")
                {
                    if (VerifyPassword(passwordInput.Text))
                        MessageBox.Show("Usuário logado com sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                    MessageBox.Show("Usuário desconhecido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}