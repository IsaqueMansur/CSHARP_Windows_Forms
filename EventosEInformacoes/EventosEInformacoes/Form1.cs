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
            DialogResult resultado = MessageBox.Show("Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim!", "Confirmado !");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Você escolheu Não!", "Negado !");
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}