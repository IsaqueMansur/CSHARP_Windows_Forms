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
            DialogResult result = MessageBox.Show("Deseja continuar?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Voc� escolheu Sim!", "Confirmado !");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Voc� escolheu N�o!", "Negado !");
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