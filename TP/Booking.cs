using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Booking
    {

            // a classe tem um construtur com 7 argumentos: os 4 primeiros para iniciar o utilizador (user) que é objeto de Pessoa, o segundo seria para iniciar o quarto (ojecto do Quarto) e o último argumento para fazer o set da dataIN (data de entrada)
            Pessoa user;
            Quarto quarto;
            DateTime dataIn; //representa a data quando o booking começa
            DateTime dataOut; // representa a data quando o booking acaba
            string guest = "Hospede";
            string Funcio = "Funcionario";
            DateTime dia = Convert.ToDateTime(0);


            public Booking(string nome, string morada, long telefone, string email, int numero, bool o, decimal rate, TipoQuarto tipo, DateTime DataEntra, DateTime DataSai)
            {
                user = new Pessoa(nome, morada, telefone, email);
                quarto = new Quarto(numero, o, rate, tipo);
                dataIn = DataEntra;
                dataOut = DataSai;
            
            }

            //public double ContabCusto(DateTime dataOut, string Tipo)
            //{
                // aqui o user pode ser tb um funcionario e um guest hospede - se o utilizador é um hospede (guest) o pagamento seria ex: 20 para 5 dias e 10 para os dias depois dos 5 primeiros dias
                // se o utilizador é um funcionario do hotel esse pagaria 5 para os primeiros 2 dias e 3 para os dias seguintes independentemento do tipo de quarto
                // se o quarto reservado é para mais de 30 dias, o funcionario tem um disconto de 10% no pagamento processado em 10% do seu salario (i.e se o salario do funcionario é 600 eur o total de desconto seria 60eur)


            //    double pagar = 0;
            //    this.dataOut = dataOut;
            //    this.dataIn = dataIn;

            //    if (Tipo == "Hospede")
            //    {
            //       dia = (dataOut - dataIn).TotalDias;
            //        //return dia;

            //        if (dia <= 5)
            //        {
            //            pagar = 20;
            //        }

            //        if (dia > 5)
            //        {
            //            pagar = 20;
            //            double novodia = dia - 5;
            //            novodia *= 10;
            //            pagar += novodia;
            //        }
            //    }
            //    else if (Tipo == "Funcionario")
            //    {
            //        if (dia <= 5)
            //        {
            //            pagar = 5;

            //            if (dia > 5)
            //            {
            //                double novodia = dia - 5;
            //                novodia *= 3;
            //                pagar = 5;
            //                pagar += novosdia;
            //            }

            //            if (dia > 30)
            //            {
            //                //desc é desconto
            //                double desc = pagar * .1;
            //                pagar = pagar - desc;

            //            }
            //        }
            //    }

            //    else return pagar;

            //}


            private DateTime dateIn;
            private DateTime dateOut;
            private int funcionarioId;
            private int quartoId;
            private int hospedeId;
            private int bookingId;

            #region Propriedades


            public DateTime DateIn
            {
                get => dataIn;
                set => dataIn = value;
            }

            public DateTime DataOut
            {
                get => dataOut;
                set => dataOut = value;
            }

            public int QuartoId
            {
                get => quartoId;
                set => quartoId = value;
            }

            public int FuncionarioId
            {
                get => funcionarioId;
                set => funcionarioId = value;
            }

            public int HospedeId
            {
                get => hospedeId;
                set => hospedeId = value;
            }

            #endregion



            #region Construtor

            public Booking(string dataIn, string dataOut, int funcionarioId, int quartoId, int hospedeId)
            {
                this.dataIn = Exceptions.InserirData(dataIn);
                this.dataOut = Exceptions.InserirData(dataOut);
                this.funcionarioId = funcionarioId;
                this.quartoId = quartoId;
                this.hospedeId = hospedeId;
                //bookingId = Booking.NumReserva + 1;        //mais uma reserva que a anterior;
            }


            #endregion

            #region Métodos
            //metodo que retorna quantos dias de reserva são
            public int DurationBooking(Booking book)
            {
                return (book.DataOut - book.dataIn).Days;
            }

            #endregion



    }
}



