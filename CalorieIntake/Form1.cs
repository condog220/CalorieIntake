namespace CalorieIntake
{
    public partial class Form1 : Form
    {

        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int calories = int.Parse(textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();

            Product product = new Product(name, calories);

            string output = product.ConvString();
            Console.WriteLine(output);

            int amount = int.Parse(label1.Text);
            int total = amount - calories;
            label1.Text = total.ToString();

            List<string> list = new List<string>();
            list.Add(output);

            foreach (string cal in list)
            {
                label3.Text += cal + Environment.NewLine;
            }

        }

        public void WriteToFile()
        {
            StreamWriter file = new StreamWriter("data.txt");

            file.WriteLine(DateTime.Now);
            file.WriteLine(label3.Text);
            file.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("data.txt");
            file.WriteLine(string.Empty);
            file.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBox3.Text);
            label1.Text = amount.ToString();
            EnableScreen();

        }

        private void EnableScreen()
        {
            Name.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label2.Visible = true;
            label1.Visible = true;

            label5.Visible = false;
            textBox3.Visible = false;
            button4.Visible = false;
        }
    }
}