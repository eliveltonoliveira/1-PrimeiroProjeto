using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5-Caracteres E Textos");

            //Character, 16 Bits
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);


            string titulo = "Alura Cursos de Tecnologia " + 2019;
            string cursosProgramacao = 
 @" - .NET
 - Java
 - JavaScript
 - CSharp"; 

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            Console.ReadLine();
        }
    }
}
