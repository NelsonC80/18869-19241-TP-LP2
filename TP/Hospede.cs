using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    // a class Hospede (guest em ingles) é derivada da classe Pessoa que contem 1 instancia metodo_pagamento (string) - dinheiro ou cartao de credito
    // o construtor inicializa todas as informacoes relacionadas (nome, morada, telefone, email e metodo de pagamento
    // return do metodo imprimir (herdado da classe Pessoa)de todas as infos dos hospedes
    class Hospede :Pessoa
    {
        string metodo_pagamento;

        public Hospede (string nome, string morada, long telefone, string email, string metodo_pagamento):base (nome,morada, telefone,email)
        {
            this.metodo_pagamento = metodo_pagamento;


        }
        public override string print()
        {
            return base.print() + "metodo de pagamento: " + metodo_pagamento + "\n";
            
        }
    }
}
