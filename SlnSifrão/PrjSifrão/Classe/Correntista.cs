using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PrjSifrão.Classe
{
    public class Correntista
    {

        private int _id;
        public string nomeCliente { get; set; }
        public DateTime dataNascimento { get; set; }
        public double rendaMensal { get; set; }
        public int CPF { get; set; }
        

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id não pode ser menor que zero!");
                }
                else
                {
                    this._id = value;
                }
            }
        }

        public Correntista(string nomecliente, int id, DateTime datanascimento, double rendamensal, int cpf)
        {
            this.nomeCliente = nomecliente;
            this.Id = id;
            this.dataNascimento = datanascimento;
            this.rendaMensal = rendamensal;
            this.CPF = cpf;
        }

        public Correntista()
        {

        }

        public int VerificarSeCorrentistaMaior()
        {
            int idade=0;
            try
            {
                int datanascimento = (Convert.ToInt32(DateTime.Now - dataNascimento));
                if (idade > 17)
                {
                    MessageBox.Show("Maior de idade");

                }
                else
                {
                    throw new Exception("");
                }
                return idade;
                
            }
            catch 
            {

                return 0;
            }
        }

        /*public string RetonarPerfilCliente(double rendaMensal)
        {
            if (rendaMensal > 10000)
            {
                MessageBox.Show("Voce é burgues"); 
            }
            
        }*/
    }
}
