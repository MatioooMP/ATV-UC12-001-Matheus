namespace PrjSifrão;
using PrjSifrão.Classe;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void lblId_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {

        Correntista correntistinha = new Correntista(txtNome.Text, Convert.ToInt32(txtID.Text), Convert.ToDateTime(dtpDataNascimento.Text), Convert.ToDouble(txtRendaMensal.Text), Convert.ToInt32(txtCPF.Text));
        bool maiorDeIdade = correntistinha.VerificarSeCorrentistaMaior();
        if (maiorDeIdade == true )
        {
            MessageBox.Show("Maior de idade!");
        }
        else 
        {
            MessageBox.Show("Menor de idade!");
        }

        MessageBox.Show = correntistinha.RetonarPerfilCliente();
    }
}

