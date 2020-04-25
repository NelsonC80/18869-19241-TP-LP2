using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{

    // a classe Pessoa tem 4 instancias : nome (string), morada (string) telefone (long) e email (string)
    class Pessoa
    {

        /// <summary>
        /// Construtor com 4 parametros
        /// </summary>
        string nome;
        string morada;
        long telefone;
        string email;

        public Pessoa(string nome, string morada, long telefone, string email) //long 8 bytes e um Int64 caso contrario usar num novo construtor com telefone.ToString()
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
        // imprimir (virtual) um metodo q faz o return de todas as informacoes respeitante a Pessoa associada como um string value
        public virtual string print ()
        {
            return "nome: " + this.nome + "\n " + " o numero de telefone e: " + telefone + "\n" + "Email:_" + email + "\n";
            
        } 
    }

}
