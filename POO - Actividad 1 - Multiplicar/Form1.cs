namespace POO___Actividad_1___Multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Multiplicar omult = new Multiplicar(int.Parse(Valor1.Text), int.Parse(Valor2.Text));
            Resultado.Text = omult.multipica().ToString();
        }
    }
}