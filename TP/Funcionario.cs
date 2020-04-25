using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{

    // a classe funcionario deriva da class pessoa e tem nesta fase 1 instancia salario
    class Funcionario:Pessoa
    {
        int salario; 
        public Funcionario(string nome, string morada, long telefone, string email, int salario):base(nome, morada,telefone, email)
        {
            this.salario = salario;

        }

        public override string print()
        {
            return base.print() +"\n"+"salario:" +salario+"\n" ;

        }
    }
}
