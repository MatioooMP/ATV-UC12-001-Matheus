using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        public bool VerificarSeCorrentistaMaior()
        {
            DateTime dataatual = DateTime.Now;
            int idade = dataatual.Year - this.dataNascimento.Year;
            if (dataatual.Month < this.dataNascimento.Month || (dataatual.Month == this.dataNascimento.Month && dataatual.Day < this.dataNascimento.Day))
            {
                idade = idade - 1;
            }

            if (idade > 17)
            {

                return true;

            }
            else
            {
                return false;
            }

        }

        public string RetonarPerfilCliente()
        {
            if (this.rendaMensal < 3001)
            {
                MessageBox.Show("Voce é Cliente Silver"); 
            }
            else if (this.rendaMensal > 3000.99 && this.rendaMensal < 5001 )
            {
                MessageBox.Show("Você é cliente Gold");
            }
            
        }
    }
}
