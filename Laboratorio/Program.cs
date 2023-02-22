using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[14];
            int[] edades = new int[14];
            string[] departamentos = {"Chalatenango", "La Libertad", "San Miguel", "Ahuachapan", "Cabanas", "La Union", "Morazan", "Cuscatlan", "La paz" };
            string[][] municipios = {
                new string[] { "Nueva Concepcion", "Los Ranchos", "La Palma", "El Paraiso", "La Reina", "Citala" },
                new string[] { "Santa Tecla", "Nuevo Cuscatlan", "Antiguo Cuscatlan", "Huizucar", "Jayaque", "Jicalapa" },
                new string[] { "Sesori", "Chapeltique", "Jutiapa", "Chirilagua", "Comacaran", "El Transito" },
                new string[] { "Apaneca", "Atiquizaya", "Concepcion de ataco", "El Refugio", "Guaymango", "Jujutla" },
                new string[] { "Cinquera", "Dolores", "Guacotecti", "San Isidro", "Sensunte", "Victoria" },
                new string[] { "San Alejo", "San Jose", "El Carmen", "Intipuca", "Yayantique", "Bolivar" },
                new string[] { "Arambala", "Cacaopera", "Sensembra", "Osicala", "Perquin", "San Carlos" },
                new string[] { "Cojutepeque", "Candelaria", "El Carmen", "San Ramon", "Suchitoto", "Tenancingo" },
                new string[] { "Cuyultitan", "Chapeltique", "Jutiapa", "Olocuilta", "San Emigdio", "Jerusalen" }
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre:");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la edad:");
                edades[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione el departamento:");
                for (int j = 0; j < departamentos.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {departamentos[j]}");
                }
                int departamentoUnidos = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Seleccione el municipio:");
                for (int j = 0; j < municipios[departamentoUnidos].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {municipios[departamentoUnidos][j]}");
                }
                Console.ReadLine();

                Console.WriteLine("Dato agregado correctamente.");
                Console.ReadLine();
            }

            Console.WriteLine("Edades ingresadas:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{nombres[i]} tiene {edades[i]} años.");
            }

            Console.ReadLine();
        }

    }

    
}
