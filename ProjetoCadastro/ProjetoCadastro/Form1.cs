using CadasterLib;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class Form1 : Form
    {
        BaseDeDados dataBase;
        public Form1()
        {
            InitializeComponent();
            dataBase = new BaseDeDados("dataBase.xml");
        }

        private void BTN_CADASTER_USER_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadasterPeople = new CadastroPessoa
                (
                INPUT_NAME_USER.Text,
                INPUT_DOC_USER.Text,
                Convert.ToDateTime(INPUT_BIRTHDAY_USER.Text),
                INPUT_STREET_USER.Text,
                Convert.ToUInt32(INPUT_NUMBERHOUSE_USER.Text)
                );
            dataBase.AdicionarPessoa(cadasterPeople);
            MessageBox.Show("Usuário cadastrado com sucesso", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTN_FIND_USER_DOC_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listPeoples = dataBase.PesquisaPessoaPorDoc(INPUT_FIND_USER_DOC.Text);
            if (listPeoples != null && listPeoples.Count > 0)
            {
                LABEL_NAME_USER_MOV.Text = listPeoples[0].Nome;
                LABEL_BIRTHDAY_USER_MOV.Text = listPeoples[0].DataDeNascimento.ToString();
                LABEL_STREET_USER_MOV.Text = listPeoples[0].NomeDaRua;
                LABEL_NUMBERHOUSE_USER_MOV.Text = listPeoples[0].NumeroDaCasa.ToString();
            }
            else
                MessageBox.Show("Usuário não localizado", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BTN_DELETE_USER_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listPeoples = dataBase.RemoverPessoaPorDoc(INPUT_FIND_USER_DOC.Text);
            if (listPeoples != null && listPeoples.Count > 0)
            {
                MessageBox.Show("Usuário deletado com sucesso", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Usuário não localizado", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}