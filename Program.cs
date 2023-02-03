using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_programacion_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edad = new int[] { 20, 22, 33 };
            int[] salarios = new int[] { 200, 300, 150 };
            String[] musico = new String[3];
            musico[0] = "Halsey";
            musico[1] = "Aurora";
            musico[2] = "Jerson";

            for (int i = 0; i < musico.Length; i++)
            {

                Double IVA = 0;
                IVA = 1.13;

                Console.WriteLine($"{musico[i]} Edad: {edad[i]} Salario: {salarios[i]} Total de salario con IVA: {salarios[i] * IVA} ");
            }



            Console.ReadLine();
        }
    }
}
