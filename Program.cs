using System;

namespace ExerClasses
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region exercicio 1
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            Decimal x, y, z;
            string Resultado;
            Console.WriteLine("Insira o primeiro valor");
            x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            y = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor");
            z = decimal.Parse(Console.ReadLine());


            Calculadora NovaCalculadora = new Calculadora(); //Instaciei.

            NovaCalculadora.n1 = x;
            NovaCalculadora.n2 = y;
            NovaCalculadora.n3 = z;
            Resultado = NovaCalculadora.Resultado(NovaCalculadora.n1, NovaCalculadora.n2, NovaCalculadora.n3);

            Console.WriteLine(Resultado);
            Console.Read();
            */
            #endregion

            #region exercicio 2
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            Decimal x, y, z;
            string Resultado;
            Console.WriteLine("Insira o primeiro valor");
            x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            y = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor");
            z = decimal.Parse(Console.ReadLine());

            Calculadora NovaCalculadora = new(); 

            NovaCalculadora.n1 = x;
            NovaCalculadora.n2 = y;
            NovaCalculadora.n3 = z;
            Resultado = NovaCalculadora.Triangulo(NovaCalculadora.n1, NovaCalculadora.n2, NovaCalculadora.n3);

            Console.WriteLine(Resultado);
            Console.Read();
            */
            #endregion

            #region exercicio 3
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            Decimal x, y; string No1, No2;
            string Resultado;
            Console.WriteLine("Qual o nome do primeiro time?");
            No1= Console.ReadLine();
            Console.WriteLine("Quantos gols o " + No1 + " fez?");
            x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome do segundo time?");
            No2 = Console.ReadLine();
            Console.WriteLine("Quantos gols o " + No2 + " fez?");
            y = decimal.Parse(Console.ReadLine());

            Calculadora NovaCalculadora = new Calculadora();

            NovaCalculadora.n1 = x;
            NovaCalculadora.n2 = y;
            NovaCalculadora.Nome1 = No1;
            NovaCalculadora.Nome2 = No2;
            
            Resultado = NovaCalculadora.Fut(NovaCalculadora.n1, NovaCalculadora.n2, NovaCalculadora.Nome1,  NovaCalculadora.Nome2);

            Console.WriteLine(Resultado);
            Console.Read();

            */
            #endregion

            #region exercicio 4
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            Decimal x, y;
            string Resultado;
            Console.WriteLine("Insira o primeiro valor");
            x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            y = decimal.Parse(Console.ReadLine());
            

            Calculadora NovaCalculadora = new Calculadora();


            NovaCalculadora.n1 = x;
            NovaCalculadora.n2 = y;
            
            Resultado = NovaCalculadora.lerV(NovaCalculadora.n1, NovaCalculadora.n2);

            Console.WriteLine(Resultado);
            Console.Read();
            */
            #endregion

            #region exercicio 5
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            double L;
            string T;


            string Resultado;
            Console.WriteLine("Quantos Litros de combustível foram colocados?");
            L = double.Parse(Console.ReadLine());
            Console.WriteLine("O seu tipo de combustível foi G ou A?");
            T = Console.ReadLine();


            Calc2 NovaCalculadora = new();


            NovaCalculadora.litro = L;
            NovaCalculadora.Tipo = T;

            Resultado = NovaCalculadora.Valor(NovaCalculadora.litro, NovaCalculadora.Tipo);

            Console.WriteLine("R$" + Resultado);
            Console.Read();
            */
            #endregion

            #region exercicio 6
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal x, y, z, w;
            string Resultado;
            Console.WriteLine("Insira a idade do primeiro homem");
            x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade do segundo homem");
            y = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade da primeira mulher");
            z = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade da segunda mulher");
            w = decimal.Parse(Console.ReadLine());


            Calculadora NovaCalculadora = new Calculadora(); //Instaciei.

            NovaCalculadora.n1 = x;
            NovaCalculadora.n2 = y;
            NovaCalculadora.n3 = z;
            NovaCalculadora.n4 = w;
            Resultado = NovaCalculadora.Soma(NovaCalculadora.n1, NovaCalculadora.n2, NovaCalculadora.n3, NovaCalculadora.n4);

            Console.WriteLine(Resultado);
            Console.Read();
            */
            #endregion

            #region exercicio 7
            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            double x, y;
            string Resultado;
            Console.WriteLine("Quantos kg de morango?");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos kg de maçã?");
            y = double.Parse(Console.ReadLine());


            Calculadora NovaCalculadora = new Calculadora();


            NovaCalculadora.M1 = x;
            NovaCalculadora.M2 = y;

            Resultado = NovaCalculadora.Frutas(NovaCalculadora.M1, NovaCalculadora.M2);

            Console.WriteLine(Resultado);
            Console.Read();

            */
            #endregion


            Console.ForegroundColor = ConsoleColor.Yellow;
            string x;
            string Resultado;
            string y;
            Console.WriteLine("Informe seu User");
            x = Console.ReadLine();
           

            Calculadora NovaCalculadora = new Calculadora();


            NovaCalculadora.Nome1 = x;


            Resultado = NovaCalculadora.Nome1;

            if (Resultado == "1234")
            {
                Console.WriteLine("Informe sua senha");
                y = Console.ReadLine();

                if(y == "9999")
                {

                    Console.WriteLine("Seja bem vindo!");
                }
                else
                {
                    Console.WriteLine("Senha incorreta");

                }

            }

            else
            {

                Console.WriteLine("Usuário não encontrado");

            }

       
            Console.Read();


        }



    }
}
