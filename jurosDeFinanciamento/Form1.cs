namespace jurosDeFinanciamento
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
        private void btnCalcularButton_Click(object sender, EventArgs e)
        {
            //((Convert.ToDouble(taxaDeJurosAnual.Text) / 12) / 100);
            double valorDaParcela = Convert.ToDouble(principal.Text) *
                ((Convert.ToDouble(taxaDeJurosAnual.Text) / 12 / 100) / (1 - Math.Pow(1 + (Convert.ToDouble(taxaDeJurosAnual.Text) / 12 / 100), -Convert.ToDouble(numeroDeParcelas.Text))));
            valorPago.Text = "Valor da Parcela: " + valorDaParcela.ToString("N2");
            double resultadoFinanciamento = valorDaParcela * Convert.ToDouble(numeroDeParcelas.Text);
            totalJuros.Text = "Total de Juros: " + (resultadoFinanciamento - Convert.ToDouble(principal.Text)).ToString("N2");
            resultadoFinal.Text = "Total Final: " + resultadoFinanciamento.ToString("N2");
        }


    }
}