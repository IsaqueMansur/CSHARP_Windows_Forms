using System.Security.Cryptography;

namespace Progress_TrackBar_ComboBox_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            progressBar.Value = trackBar.Value;
            label.Text = ("Valor atual: " + trackBar.Value).ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionado: " + comboBox1.SelectedItem.ToString(), "Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            trackBar.Value = randomNumber;
            label.Text = ("Valor atual: " + randomNumber).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains("Animal"))
                listBox1.Items.Add("Animal");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Animal"))
                listBox1.Items.Remove("Animal");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
                MessageBox.Show("O usuário selecionou " + listBox1.SelectedItem.ToString());

        }

    }
}