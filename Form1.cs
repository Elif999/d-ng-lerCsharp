namespace WinFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 11; i <= 20; i++)
            {
                listBox1.Items.Add(i.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
