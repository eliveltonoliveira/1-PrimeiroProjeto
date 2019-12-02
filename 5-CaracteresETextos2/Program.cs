using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5 Caracteres E Textos 2");

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            /* valor = valor + 1;
             Console.WriteLine(valor);      Não compila, necessário fazer um casting para compilar*/

            valor = (char)(valor + 1);    //Repare que envolvemos a soma com parênteses. Dessa forma, dizemos para o C# que queremos transformar o resultado dessa soma em char.
            Console.WriteLine(valor);

            string palavra = "Alura cursos online de tecnologia ";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            Console.ReadLine();
        }
    }
}
