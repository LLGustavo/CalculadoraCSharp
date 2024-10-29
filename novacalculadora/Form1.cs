using System.Linq.Expressions;

namespace novacalculadora
{

    public partial class Form1 : Form
    {
    public decimal Resultado {  get; set; }

    public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada {  get; set; }

       private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttZero_Click(object sender, EventArgs e)
        {
            //posso fazer dessas duas formas
            //txtResultado.Text += "0";
            txtResultado.Text = txtResultado.Text + "0"; 
        }

        private void butum_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1"; 
        }

        private void butDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2"; 
        }

        private void butTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3"; 
        }

        private void butQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void butCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void butSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void butSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void butOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void butNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void butApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            txtResultado.Text = "/";
        }

        private void butMultpl_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            txtResultado.Text = "*";
        }

        private void butSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            txtResultado.Text = "+";
        }

        private void butSubtr_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            txtResultado.Text = "-";
        }
        private void butVirgu_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void butResult_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal (txtResultado.Text);

                break;
                
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;


            }
            txtResultado.Text =Convert.ToString (Resultado);
        }

    }
}
