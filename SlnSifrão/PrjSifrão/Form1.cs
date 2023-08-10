namespace PrjSifrão;
using PrjSifrão.Classe;

    public partial class Form1 : Form
{
    Correntista conta1;
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

            conta1.VerificarSeCorrentistaMaior();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);

        }
        /*conta1.RetonarPerfilCliente();*/
    }
}
