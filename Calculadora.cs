using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerClasses
{
    public class Calculadora
    {
        //propriedades 
        public decimal n1 { get; set; }

        public decimal n2 { get; set; }

        public decimal n3 { get; set; }

        public decimal n4 { get; set; }

        public string Nome1 { get; set; }

        public string Nome2 { get; set; }

        public double M1 { get; set; }

        public double M2 { get; set; }

        //metodo

        public string Resultado(decimal numero1, decimal numero2, decimal numero3)
        {

            string resultado;


            if (numero1 < numero2 && numero2 < numero3)
            {
                resultado = numero1.ToString() + "," + numero2.ToString() + "," + numero3.ToString();
                return resultado;
            }

            else if (numero3 < numero2 && numero2 < numero1)
            {
                resultado = numero3.ToString() + "," + numero2.ToString() + "," + numero1.ToString();
                return resultado;
            }

            else if (numero2 < numero1 && numero1 < numero3)
            {
                resultado = numero2.ToString() + "," + numero1.ToString() + "," + numero3.ToString();
                return resultado;
            }

            else if (numero2 < numero3 && numero3 < numero1)
            {
                resultado = numero2.ToString() + "," + numero3.ToString() + "," + numero1.ToString();
                return resultado;
            }

            else if (numero1 < numero3 && numero3 < numero2)
            {
                resultado = numero1.ToString() + "," + numero3.ToString() + "," + numero2.ToString();
                return resultado;
            }

            else
            {
                resultado = numero3.ToString() + "," + numero1.ToString() + "," + numero2.ToString();
                return resultado;
            }

        }


        public string Triangulo(decimal Numero1, decimal Numero2, decimal Numero3)
        {



            if (Numero1 + Numero2 > Numero3 && Numero2 + Numero3 > Numero1 && Numero1 + Numero3 > Numero2)
            {

                Console.WriteLine("É um triângulo");

            }


            else
            {

                Console.WriteLine("Não é um triângulo");

            }

            return ":)";
        }



        public string Fut(decimal Numero1, decimal Numero2, string Nome1, string Nome2)
        {
            String vencerdor;

            if (Numero1 > Numero2)
            {
                vencerdor = Nome1;
                return vencerdor + " Venceu";
            }


            else if (Numero2 > Numero1)
            {
                vencerdor = Nome2;
                return vencerdor + " Venceu";
            }


            else
            {
                vencerdor = "Deu empate";
                return vencerdor;
            }



        }


        public string lerV(decimal Numero1, decimal Numero2)
        {

            if (Numero1 > Numero2)
            {
                Console.WriteLine("O primeiro número é o maior");

            }

            else if (Numero2 > Numero1)
            {
                Console.WriteLine("O segundo número é maior");
            }

            else
            {
                Console.WriteLine("Os números são iguais");

            }


            return ":)";
        }


        public string Soma(decimal IdadeM1, decimal IdadeM2, decimal IdadeF1, decimal IdadeF2)
        {
            decimal IdadeHM1;
            decimal IdadeHM2;
           



            if (IdadeM1 > IdadeM2 && IdadeF1 > IdadeF2)
            {
                IdadeHM1 = IdadeM1 + IdadeF2;
                IdadeHM2 = IdadeM2 + IdadeF1;

                Console.WriteLine("resposta 1: " + IdadeHM1 + "; Resposta 2: " + IdadeHM2);
                return ":)";

            }
           
            else 
            {
            
             IdadeHM1 = IdadeM1 + IdadeF1;
             IdadeHM2 = IdadeM2 + IdadeF2;

             Console.WriteLine("resposta 1: " + IdadeHM1 + "; Resposta 2: " + IdadeHM2);
                return ":)";
            }


           
        }


        public string Frutas(double Morango, double Maca)
        {
            double result;
            double desconto;
            
            if (Morango <= 5 && Maca <= 5)
            {

                if(Morango + Maca > 8)
                {
                    desconto = ((Morango * 2.50) + (Maca * 1.80)) * 0.1;
                    result = ((Morango * 2.20) + (Maca * 1.50)) - desconto;
                    return "o cliente ira pagar " + result.ToString();

                }
                else 
                {
                    result = (Morango * 2.50) + (Maca * 1.80);

                    return "o cliente ira pagar " + result.ToString();
                }
                
            }

            else 
            {
                desconto = ((Morango * 2.20) + (Maca * 1.50)) * 0.1 ;
                result = ((Morango * 2.20) + (Maca * 1.50)) - desconto;
                return "o cliente ira pagar " + result.ToString();

            }

            

            


          
        }


        public string Usuario(string User)
        {
            string senha;

            if (User == "1234")
            {

                Console.WriteLine("Qual a sua senha?");
                senha = Console.ReadLine();

               if(senha == "9999")
               {
                    return "Seja bem vindo";

               }


                else
                {

                    return "Senha incorreta";
                }

            }

            else
            {

                return "Usuário inválido!";
            }


            
        }

    }
}
