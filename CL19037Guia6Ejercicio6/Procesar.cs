using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia6Ejercicio6
{
    class Procesar
    {
        //atributos
        int numero;

        //propiedades
        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        //metodos 
        //para poder evaluar si es multiplo de 3
        public int Divi3()
        {
            int residuo;
            residuo = numero % 3;
            return residuo;
        }
        //para saber el resultado de la operacion  numero/3
        public int resultado3()
        {
            int resultado;
            resultado = numero / 3;
            return resultado;
        }
        //para poder evaluar si es multiplo de 5
        public int Divi5()
        {
            int otroResiduo;
            otroResiduo = numero % 5;
            return otroResiduo;
        }
        //para saber el resultado de la operacion numero/5
        public int resultado5()
        {
            int otroResultado;
            otroResultado = numero / 5;
            return otroResultado;
        }

    }
}
