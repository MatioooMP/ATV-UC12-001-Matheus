namespace PrjSifrão;
using PrjSifrão.Classe;
using System.Linq.Expressions;

public partial class Form1 : Form
{
    Correntista correntistinha;
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
        try
        {
            Correntista correntistinha = new Correntista(txtNome.Text, Convert.ToInt32(txtID.Text), Convert.ToDateTime(dtpDataNascimento.Text), Convert.ToDouble(txtRendaMensal.Text), txtCPF.Text);
            bool maiorDeIdade = correntistinha.VerificarSeCorrentistaMaior();

            if (maiorDeIdade == false)
            {
                MessageBox.Show("O correntista deve possuir ao menos 18 anos de idade para\r\nregistro no banco.");
            }

            else
            {
                /*Correntista correntistinha1 = new Correntista(txtNome.Text, Convert.ToInt32(txtID.Text), Convert.ToDateTime(dtpDataNascimento.Text), Convert.ToDouble(txtRendaMensal.Text), Convert.ToInt32(txtCPF.Text));
                string perfilcliente = correntistinha.RetonarPerfilCliente();
                MessageBox.Show(perfilcliente);*/
                Correntista correntistinha2 = new Correntista(txtNome.Text, Convert.ToInt32(txtID.Text), Convert.ToDateTime(dtpDataNascimento.Text), Convert.ToDouble(txtRendaMensal.Text), txtCPF.Text);
                MessageBox.Show(correntistinha2.MontarMensagensBoasVindas());

            }
        }
        catch (Exception)
        {

            throw;
        }
        

    }

    private void txtNome_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(txtNome.Text, out int res))
        {
            txtNome.Clear();
        }
        
    }
}

