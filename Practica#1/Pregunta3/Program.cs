using System;
using System.Collections.Generic;

namespace Pregunta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CelularNuevo> celularNuevo = new List<CelularNuevo>();


            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Samsung",
                Modelo = "Galaxy S21",
                SistemaOperativo = Celular.SO.Android,
                RAM = 8,
                Almacenamiento = 128,
                FechaIngreso = DateTime.Parse("01/03/2021"),
                Precio = 1200.99m
            });
            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Alcatel",
                Modelo = "K21",
                SistemaOperativo = Celular.SO.Android,
                Almacenamiento = 8,
                FechaIngreso = DateTime.Parse("08/09/2019"),
                Precio = 520m
            });
            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 13",
                SistemaOperativo = Celular.SO.Iphone,
                RAM = 6,
                Almacenamiento = 128,
                FechaIngreso = DateTime.Parse("10/09/2021"),
                Precio = 799m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Samsung",
                Modelo = "Pixel 6",
                SistemaOperativo = Celular.SO.Android,
                RAM = 8,
                Almacenamiento = 128,
                FechaIngreso = DateTime.Parse("19/10/2021"),
                Precio = 599m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "OnePlus",
                Modelo = "9 Pro",
                SistemaOperativo = Celular.SO.Android,
                RAM = 12,
                Almacenamiento = 256,
                FechaIngreso = DateTime.Parse("23/03/2021"),
                Precio = 969m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Xiaomi",
                Modelo = "Mi 11 Ultra",
                SistemaOperativo = Celular.SO.Android,
                RAM = 12,
                Almacenamiento = 256,
                FechaIngreso = DateTime.Parse("29/03/2021"),
                Precio = 1399m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Sony",
                Modelo = "Xperia 1 III",
                SistemaOperativo = Celular.SO.Android,
                RAM = 12,
                Almacenamiento = 256,
                FechaIngreso = DateTime.Parse("14/04/2021"),
                Precio = 1299m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Nokia",
                Modelo = "8.3",
                SistemaOperativo = Celular.SO.Android,
                RAM = 8,
                Almacenamiento = 128,
                FechaIngreso = DateTime.Parse("22/09/2020"),
                Precio = 699m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Samsung",
                Modelo = "Edge Plus",
                SistemaOperativo = Celular.SO.Android,
                RAM = 8,
                Almacenamiento = 128,
                FechaIngreso = DateTime.Parse("22/04/2020"),
                Precio = 999m
            });
            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 13 Pro",
                SistemaOperativo = Celular.SO.Iphone,
                RAM = 6,
                Almacenamiento = 128,
                FechaIngreso = DateTime.Parse("24/09/2021"),
                Precio = 999m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 13 Pro Max",
                SistemaOperativo = Celular.SO.Iphone,
                RAM = 6,
                Almacenamiento = 256,
                FechaIngreso = DateTime.Parse("24/09/2021"),
                Precio = 1099m
            });

            celularNuevo.Add(new CelularNuevo()
            {
                Marca = "Apple",
                Modelo = "iPhone 13 Mini",
                SistemaOperativo = Celular.SO.Iphone,
                RAM = 4,
                Almacenamiento = 64,
                FechaIngreso = DateTime.Parse("24/09/2021"),
                Precio = 699m
            });


            CelularNuevoController consultas = new CelularNuevoController();

            consultas.Mostrar(celularNuevo);
            consultas.Promedio(celularNuevo);
            consultas.Celular_MarcaS(celularNuevo);
            consultas.Cel_RSA(celularNuevo);
            consultas.Celular_Ingreso(celularNuevo);
            consultas.AppleLambda(celularNuevo);
            consultas.AppleLinQ(celularNuevo);

            Console.ReadKey();
        }
    }
}
