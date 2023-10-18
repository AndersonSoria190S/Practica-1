using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    internal class CelularDefectuoso : Celular
    {
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }

        public override void MostrarCelular()
        {
            Console.WriteLine("Marca : {0} " +
                "\n Modelo : {1} " +
                "\n SistemaOperativo {2} " +
                "\n RAM : {3} " +
                "\n Almacenamiento : {4}" +
                "\n Fecha : {5}" +
                "\n Motivo : {6}", Marca, Modelo, SistemaOperativo, RAM, Almacenamiento, Fecha, Motivo);
        }
    }
}
