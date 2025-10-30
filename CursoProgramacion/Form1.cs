namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 123;
            double numeroConComas = 5000.28;
            string prueba = "Prueba de variable: "+ numeroConComas;
            label1.Text = prueba;
        }
    }
}
