using static NNN.Logic;

namespace NNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool j = false;
        string ch;
        private void button1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (j) { textBox1.Text = "0"; }
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            x = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button D = (Button)sender;
            ch = D.Text;
            j = true;
            if (D.Text == "=")
            {
                textBox1.Text = CH(ch, textBox1.Text);
            }
            Set(textBox1.Text);
        }
    }
}
