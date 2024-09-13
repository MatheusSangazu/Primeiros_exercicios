using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerClasses
{
    class Calc2
    {
       public String Tipo;
       public double litro;





        public string Valor(double Litr, string tipoo)
        {
            tipoo = Tipo;
            double desconto;
            double resultado;
            double resultadoFINAL;

            if (tipoo == "G" && Litr <= 20)
            {
                
                resultado = Litr * 3.30;
                desconto = resultado * 0.04;
                resultadoFINAL = resultado - desconto;
                return resultadoFINAL.ToString();
            }

            else if (tipoo == "G" && Litr > 20)
            {
                resultado = Litr * 3.30;
                desconto = resultado * 0.06;
                resultadoFINAL = resultado - desconto;
                return resultadoFINAL.ToString();

            }
            else if (tipoo == "A" && Litr <= 20)
            {
                resultado = Litr * 2.90;
                desconto = resultado * 0.03;
                resultadoFINAL = resultado - desconto;
                return resultadoFINAL.ToString();


            }

            else if (tipoo == "A" && Litr > 20)
            {

                resultado = Litr * 2.90;
                desconto = resultado * 0.05;
                resultadoFINAL = resultado - desconto;
                return resultadoFINAL.ToString();

            }



                return ":)";

        }




    }





}
