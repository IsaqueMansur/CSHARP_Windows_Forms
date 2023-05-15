namespace EventosEInformacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void confimationBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim!", "Confirmado !");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Você escolheu Não!", "Negado !");
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}