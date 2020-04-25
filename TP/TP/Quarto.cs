using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{

    public enum TipoQuarto
    {
        SINGLE,
        CASAL,
        Dormitorio
    }
    public class Quarto
    {
        int quartoId;
        TipoQuarto tipo;
     
        bool ocupado;
        decimal rate; //rate - tarifa do quarto

        public Quarto(int num, bool o, decimal rate, TipoQuarto tipo) 
        {
            ocupado = o;
           
            this.tipo = tipo;
            this.rate = rate;
            //this.quartoId = Quarto.Totalquartos + 1;
        }

        public int QuartoId
        {
            get => quartoId;
            set => quartoId = value;
        }

        //public int Capacidade
        //{
        //    get => capacity;
        //    set => capacity = value;
        //}

        public TipoQuarto Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public decimal Rate
        {
            get => rate;
            set => rate = value;
        }
        public string print ()
        {
            if (ocupado == true)
                return "quarto esta ocupado";
            else
                return "o quarto nao esta ocupado";

        }

    }
}
