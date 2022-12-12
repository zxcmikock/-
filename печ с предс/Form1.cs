namespace печ_с_предс
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Predp = new string[] { "Вы шоколадка",  "Вы купите пирог", "Вас ожидают перемены", "Если думаешь — не пиши", "Не думай", };
            Random r = new Random();

            textBox1.Text = Predp[r.Next(Predp.Length)];
        }
    }
}