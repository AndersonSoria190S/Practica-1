using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] decenas = { "", "diez", "veinti", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] centena = { "", "ciento", "docientos", "trecientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochecientos", "novecientos" };
            string[] milesima = { "", "mil", "dos mil", "tres mil", "cuatro mil", "cinco mil", "seis mil", "siete mil", "ocho mil", "nueve mil" };
           
            int numero = int.Parse(Console.ReadLine());
            string resultado = "";
            int cont = 1;
            if (numero < 20)
            {
                resultado = unidades[numero] + resultado;
            }
            else
            {
                while (numero != 0)
                {

                    if (cont == 1)
                    {
                        int modulo = numero % 10;
                        resultado = unidades[modulo] + resultado;
                    }
                    if (cont == 2)
                    {  

                        int modulo = numero % 10;
                        if (modulo == 2 || modulo == 0 || modulo == 1)
                        {
                            resultado = decenas[modulo] + resultado;
                        }
                        else
                        {                           
                            resultado = decenas[modulo] + " y " + resultado;                                                    
                        }
                       
                    }
                    if (cont == 3)
                    {
                        int modulo = numero % 10;
                       resultado = centena[modulo] + " " + resultado;
                        
                        
                    }
                    if (cont == 4)
                    {
                        int modulo = numero % 10;
                        resultado = milesima[modulo] + " " + resultado;
                    }
                    
                    cont++;
                    numero = numero / 10;


                }
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}