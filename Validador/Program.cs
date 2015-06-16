using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador
{
    class Program
    {
        public static String texto { get; set; }
        static Char aberto = '(';
        static Char fechado = ')';
        public static Int32 balanceado;

        static void Main(string[] args)
        {
            Console.Write("Informe o texto: \n");
            texto = Console.ReadLine();

            Validador(texto);

            if (balanceado > 0 || balanceado < 0) {
                Console.WriteLine(false);
                Console.WriteLine("Texto informado não está balanceado!");
            }
            else{
                Console.WriteLine(true);
                Console.WriteLine("Texto informado está balanceado!");
            }

            Console.ReadLine();
        }

        static void Validador(String valor)
        {
            if (valor[0] == aberto) {
                balanceado += 1;
            }
            else
            if (valor[0] == fechado){
                balanceado -= 1;
            }

            if (valor.Length > 1) {
                Validador(valor.Substring(1));
            }
        }

    }
}
