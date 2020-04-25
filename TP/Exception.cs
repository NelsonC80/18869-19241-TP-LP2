using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP

    {
        class Exceptions
        {
            public static DateTime InserirData(string data)
            {
                try
                {
                    return DateTime.Parse(data);
                }

                catch (FormatException e)
                {
                    throw new Exception("Formato Invalido" + e.Message);
                }

                catch (Exception e)
                {
                    throw new Exception("ERRO" + e.Message);
                }
            }

        }
}

