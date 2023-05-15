namespace TextBox_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textBox = TXT_INPUT.Text;
            string richTextBox = RTXT_Inverted.Text;

            RTXT_Inverted.Text = textBox;
            TXT_INPUT.Text = richTextBox;
        }
    }
}