using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
     abstract class Celular
    {
        public string  Marca { get; set; }
        public string Modelo { get; set; }

        public enum SO  { Android , Iphone }
        public SO SistemaOperativo { get; set; }
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }

        public virtual void MostrarCelular()
        {
            Console.WriteLine("Marca : {0} \n Modelo : {1} \n SistemaOperativo {2} \n RAM : {3} \n Almacenamiento : {4}" , Marca , Modelo , SistemaOperativo, RAM, Almacenamiento);
        }

    }
}
