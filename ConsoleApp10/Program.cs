using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet2;
            int t, soma = 0, media;
            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
            Random rand = new Random();
            for (int i = 0; i < t; i++)
            {

                vet2[i] = rand.Next(10, 50);
                soma = soma + vet2[i];

            }


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            media = soma / t;
            Console.WriteLine("a media é igual à: {0}", media);
        }
        public static void Exercicio2()
        {
            int[] vet1;
            int t, soma1 = 0, somas = 0;
            Console.WriteLine("insira o valor");
            t = int.Parse(Console.ReadLine());

            vet1 = new int[t];
            Random rando = new Random();
            for (int i = 0; i < t; i++)
            {

                vet1[i] = rando.Next(10, 50);
                if (vet1[i] % 2 == 0)
                {
                    soma1 = soma1 + vet1[i];
                }
                else
                {
                    somas = somas + vet1[i];
                }

            }


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet1[i]);
            }
            Console.WriteLine("pares:{0}", soma1
);
            Console.WriteLine("impares:{0}", somas);
        }
        public static void Exercicio3()
        {
            //não deu tempo, mas vou tentar fazer
      
        }
        public static void Exercicio4()
        {
            //não deu tempo tambem :/
        }

        static void Main(string[] args)
        {
            int programa = 1;
            do
            {
                Console.WriteLine("qual exercício deseja executar? \ndigite 0 para finalizar todos\n");
                programa = int.Parse(Console.ReadLine());


                int op;
                Console.WriteLine("MENU LISTA 9");
                Console.WriteLine("ex 1");
                Console.WriteLine("ex 2");
                Console.WriteLine("ex 3");
                Console.WriteLine("ex 4");
                
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:

                        Exercicio1();

                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                } 
            } while (programa != 0);
        }
    }
}

    
    
