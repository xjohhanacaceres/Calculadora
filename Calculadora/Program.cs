using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
                char operador;
            //Enviamos un mensaje de bienvenida Y una descripcion del programa

            Console.WriteLine("Bienvenido a Nuestro Programa");
            Console.WriteLine("Este programa Permite Opreaciones Basicas Sobre Dos Numeros");
            Console.WriteLine("-----------------------");

            Console.WriteLine("De el valor del primer Numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("De el valor del Segundo Numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique la Operacion(*,+,+/)");
            operador = char.Parse(Console.ReadLine());
            /*Identificamos el tipo de opreaciones a realizar haciendo uso del condicional IF*/

            if (operador == '*')
            {
                Console.WriteLine("la multiplicacion es de: " + (num1 * num2));
            }
            if (operador == '*')
            {
                Console.WriteLine("la divicion es de: " + (num1 * num2));

            }
            
            Console.ReadLine();

            switch (operador)
            {
                case '*':
                    Console.WriteLine("la multipliacion es de : " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("la division es de : " + (num1 / num2));
                    break;
                case '+':
                    Console.WriteLine("la suma es de : " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("la resta es de : " + (num1 - num2));
                    break;

            }







        }
    }
}
