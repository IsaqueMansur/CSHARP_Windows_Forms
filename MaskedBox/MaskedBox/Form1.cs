namespace MaskedBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Números em MASK = ('0' obrigatório | '#' opcional)
            masked4Numbers.Mask = "\\1000";

            //Letras em MASK = ('L' obrigatório | '?' opcional)
            masked4Letters.Mask = "LLLL";

            //Data em MASK
            maskDate.Mask = "00/00/0000";

            //Placas de carro em MASK
            maskPlacesOfCars.Mask = "LLL-0000";

            //Senhas em MASK
            maskPassword.PasswordChar = '*';

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (masked4Numbers.MaskCompleted)
            {
                MessageBox.Show("O usuário digitou tudo");
            } else
            {
                MessageBox.Show("O usuário não digitou tudo");
            }
        }
    }
}