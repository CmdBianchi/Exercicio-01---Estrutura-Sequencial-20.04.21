using System;

namespace Exercícios___Estrutura_Sequencial_20._04._21
{
    class Program
    {
        //-----> INICIO
        ///////////////////////////////////////////////////////////////////////////////////////////////////     
        static void Main(string[] args)
        {
            MsgBoasVindas();
            Calculo();


        }
        /////////////////////////////////////////////////////////////////////////////////////////////////// 
        static void MsgBoasVindas()
        {
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("Codigo simples para soma de DOIS numeros");
            Console.WriteLine(" ");
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////// 
        static void Calculo()
        {
            int a, b, soma;

            Console.Write("Ecreva valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ecreva valor de B: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.Write("Soma: "+soma);

        }











    }
}
