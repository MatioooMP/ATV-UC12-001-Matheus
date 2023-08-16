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
        private string _cpf;
        private int _id;
        private string _nomeCliente;
        public string nomeCliente
        {
            get
            {
                return this._nomeCliente;
            }
            set
            {
                if (value == String.Empty )
                {
                    throw new Exception("Digite o seu nome corretamente!");
                }
                else
                {
                     this._nomeCliente = value;
                }
            } 
        }
        public DateTime dataNascimento { get; set; }
        public double rendaMensal { get; set; }
        public string CPF
        {
            get
            {
                return this._cpf;
            }
            set
            {
                if (value.Length != 11 ||  value == String.Empty)
                {
                    throw new Exception("Digite o seu cpf corretamente!");
                }
                else
                {
                    this._cpf = value;
                }
            }
        }

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

        public Correntista(string nomecliente, int id, DateTime datanascimento, double rendamensal, string cpf)
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
                return "Silver";
            }
            else if (this.rendaMensal > 3000.99 && this.rendaMensal < 5001)
            {
                return "Gold";
            }
            else if (this.rendaMensal > 5000.99 && this.rendaMensal < 10001)
            {
                return "Diamond";
            }
            else 
            {
                return "Black";
            }
        
        }

        
        public string MontarMensagensBoasVindas()
        {
          return $"Olá, {nomeCliente}!\r\nSeja bem vindo ao Sifrão\r\nCliente {RetonarPerfilCliente()}"; 
        }
    }
}

