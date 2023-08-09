using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;

            Console.WriteLine("Digite o modelo do veículo: ");
               string modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo: ");
               string marca = Console.ReadLine();

            Console.WriteLine("Digite a cor do veículo: ");
              string cor= Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo: ");
                string ano = Console.ReadLine();

            Console.WriteLine("Digite a quilometragem do veículo: ");
              string quilo = Console.ReadLine();

            Console.WriteLine("\n O modelo do veículo: {0}, \n A marca do veículo: {1}, \n A cor do veículo: {2}, \n O ano do veículo: {3}, \n A quilometragem: {4}", modelo, marca, cor, ano, quilo);     


            Console.ReadKey();

        }
    }
}
