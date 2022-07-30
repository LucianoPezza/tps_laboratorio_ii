using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Llama a validarOperando para definir el operador, realiza la operacion con los parametros recibidos y retorna el resultado.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = 0;
            switch (ValidarOperando(operador))
            {
                case '+':
                    retorno = num1 + num2;
                    break;
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':
                    retorno = num1 / num2;
                    break;
                default:
                    retorno = num1 + num2;
                    break;
            }

            return retorno;
        }


        /// <summary>
        /// recibe por parametros un caracter y valida que este sea un operador matematico. Retorna el operando matematico.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperando(char operador)
        {
            return operador;
        }
    }
    public class Operando
    {
        private double numero;


        /// <summary>
        /// Setter del atributo numero y valida que numero sea un double.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        /// <summary>
        /// Constructor de la clase con parametro double.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }


        /// <summary>
        /// Sobrecarga del constructor de la clase con parametro String. Llama a set Numero(se reutiliza el codigo igual que si pusiera :this(Convert.ToString(strNumero))).
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }


        /// <summary>
        /// Sobrecarga del constructor que inicializa el atributo en 0.
        /// </summary>
        public Operando()
            : this(0)
        {

        }


        /// <summary>
        /// Recibe un string por parametros y lo parsea a double. Retorna el numero parseado, caso contrario retorna 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;
            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            return 0;
        }


        /// <summary>
        /// Retorna true si la cadena pasada por parametros es "0" o "1". Caso contrario retorna false.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            foreach (char num in binario)
            {
                if (num.Equals('0') || num.Equals('1'))
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Se encarga de invertir la cadena pasada por parametros. Retorna la cadena invertida.
        /// <param name="cadena"></param>
        /// <returns></returns>
        private string invertirCadenaBinaria(string cadena)
        {
            string binarioInvertido = "";
            char letraInvertida = ' ';
            for (int i = 0; i < cadena.Length; i++)
            {
                letraInvertida = Convert.ToChar(cadena.Substring(i, 1));
                binarioInvertido = letraInvertida + binarioInvertido;
            }
            return binarioInvertido;
        }


        /// <summary>
        /// Recibe una cadena con un numero binarios por parametros y retorna su version decimal
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public string BinarioDecimal(string cadena)
        {
            double numero = 0;
            double numeroAux = 0;
            if (EsBinario(cadena))
            {
                cadena = invertirCadenaBinaria(cadena);
                for (int i = 0; i < cadena.Length; i++)
                {
                    numero = Convert.ToDouble(cadena.Substring(i, 1));

                    numero = Math.Pow(2, i) * numero;
                    numeroAux += numero;
                }
            }
            else
            {
                return "Valor Invalido";
            }

            return numeroAux.ToString();
        }


        /// <summary>
        /// Recibe un double por parametros y retorna su version binaria.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            numero = Math.Truncate(numero);
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    numero = (long)(numero / 2);
                }
            }
            else if (numero == 0)
            {
                numeroBinario = "0";
            }
            else
            {
                numeroBinario = "Valor invalido";
            }
            return numeroBinario;
        }


        /// <summary>
        /// La sobrecarga del metodo DecimalBinario que recibe una cadena por parametros. Retorna un numero decimal convertido en binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            return DecimalBinario(double.Parse(numero));
        }


        /// <summary>
        /// Sobrecarga del operador + y retorna la suma entre el atributo numero de la clase.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }


        /// <summary>
        /// Sobrecarga del operador - y retorna la suma entre el atributo numero de la clase.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }


        /// <summary>
        /// Sobrecarga del operador * y retorna la suma entre el atributo numero de la clase.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }


        /// <summary>
        /// Sobrecarga del operador / y retorna la suma entre el atributo numero de la clase. Si uno de los numeros es o retorna el valor minimo de un double.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

    }
}
