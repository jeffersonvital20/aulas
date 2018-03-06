using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraSimples 
    {
        /*
         * Metodo para adicionar 2 numeros
         */
         public int Adicionar(int num1,int num2)
        {
            return num1+num2;
        }
        /*
         * Metodo para multiplicar 2 numeros
         */
         public int Multiplicar(int num1, int num2)
        {
            //parar fins de demo (bug) => reutrn num1 * num2;
            return num1 * num2;
        }
        /*
        * Metodo para Subtrair 2 numeros
        */
        public int Dimunuir(int num1, int num2)
        {
            //parar fins de demo (bug) => reutrn num1 * num2;
            return num1 - num2;
        }
        /*
        * Metodo para Dividir 2 numeros
        */
        public int Dividir(int num1, int num2)
        {
            //parar fins de demo (bug) => reutrn num1 * num2;
            return num1 / num2;
        }
    }
}
