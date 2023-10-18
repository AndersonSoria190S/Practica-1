using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pregunta_3
{
    internal class CelularNuevoController
    {
        public void Mostrar(List<CelularNuevo> nuevoCel)
        {
            foreach (var item in nuevoCel)
            {

                Console.WriteLine("\n--------------------------\n" +
                "\nMarca : {0} " +
                "\nModelo : {1} " +
                "\nSistemaOperativo {2} " +
                "\nRAM : {3} " +
                "\nAlmacenamiento : {4}" +
                "\nFecha : {5}" +
                "\nPrecio : {6}", item.Marca, item.Modelo, item.SistemaOperativo, item.RAM, item.Almacenamiento, item.FechaIngreso, item.Precio);
            }
        }
        public void Promedio(List<CelularNuevo> nuevoCel)
        {
            decimal promedio = nuevoCel.Average(x => x.Precio);
            Console.WriteLine("El promedio es: " + promedio);
            
        }
        public void Celular_MarcaS(List<CelularNuevo> nuevoCel) 
        {
            var samsung = nuevoCel.Where(x => x.Marca == "Samsung");
            Console.WriteLine("\n------------ CELULARES SAMSUNG ------------\n");
            Mostrar(samsung.ToList());        
        }
        public void Cel_RSA(List<CelularNuevo> nuevoCel) {
            var rsa = from cel in nuevoCel
                      where cel.RAM == 8 && cel.SistemaOperativo == Celular.SO.Android && cel.Almacenamiento == 128
                      select cel;
            Console.WriteLine("\n------------ CELULARES RSA ------------\n");
            Mostrar(rsa.ToList());
                      
        }
        public void  Celular_Ingreso(List <CelularNuevo> nuevoCel)
        {
            
            var ingreso = from cel in nuevoCel
                          where cel.FechaIngreso.Year == 2005
                          select cel;
            Console.WriteLine("\n------------ CELULARES 2005 ------------\n");
            Mostrar(ingreso.ToList());
        }
        public void AppleLambda(List<CelularNuevo> nuevoCel) {

            var apple = nuevoCel.Where( x => x.SistemaOperativo == Celular.SO.Iphone);
            Console.WriteLine("\n------------ IPHONE LAMDA ------------\n");
            foreach (var x in apple)
            {
                Console.WriteLine("\nModelo : {0} \nPrecio : {1}",x.Modelo,x.Precio);
            }
        }

        public void AppleLinQ(List<CelularNuevo> nuevoCel) 
        {
            var apple = from c in nuevoCel
                        where c.SistemaOperativo == Celular.SO.Iphone
                        select c;
            Console.WriteLine("\n------------ IPHONE LAMDA ------------\n");
            foreach (var x in apple)
            {
                Console.WriteLine("\nModelo : {0} \nPrecio : {1}", x.Modelo, x.Precio);
            }
        }



    }
}
