using System;
using System.Collections;
using System.Collections.Generic;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCÍCIO 2

            double peso, valor;
            int distancia;

            Console.WriteLine("Digite o peso(kg): ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor(R$): ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a distância(km): ");
            distancia = int.Parse(Console.ReadLine());

            Caminhao caminhao = new Caminhao(valor, peso);
            Vagao vagao = new Vagao(valor, peso);
            

            // vagao.Peso = peso;
            // vagao.Valor = valor;
            // caminhao.Peso = peso;
            // caminhao.Valor = valor;

            Console.WriteLine("Frete para Vagão: "+vagao.calculaFrete(distancia));
            Console.WriteLine("Frete para Caminhão: "+caminhao.calculaFrete(distancia));

            // EXERCÍCIO 3

            Vagao v1 = new Vagao(27500,18550);
            Vagao v2 = new Vagao(35410,8100);
            Vagao v3 = new Vagao(3650,25700);
            Vagao v4 = new Vagao(9541,5799);
            Vagao v5 = new Vagao(25740,45000);
            Vagao v6 = new Vagao(5000,90570);
            Vagao v7 = new Vagao(8900,41000);

            Caminhao c1 = new Caminhao(27500, 18550);
            Caminhao c2 = new Caminhao(35410,8100);
            Caminhao c3 = new Caminhao(3650,25700);
            Caminhao c4 = new Caminhao(9541,5799);
            Caminhao c5 = new Caminhao(25740,45000);
            Caminhao c6 = new Caminhao(5000,90570);
            Caminhao c7 = new Caminhao(8900,41000);

            List<Vagao> vagoes = new List<Vagao>();
            vagoes.Add(v1);
            vagoes.Add(v2);
            vagoes.Add(v3);
            vagoes.Add(v4);
            vagoes.Add(v5);
            vagoes.Add(v6);
            vagoes.Add(v7);

            List<Caminhao> caminhoes = new List<Caminhao>();
            caminhoes.Add(c1);
            caminhoes.Add(c2);
            caminhoes.Add(c3);
            caminhoes.Add(c4);
            caminhoes.Add(c5);
            caminhoes.Add(c6);
            caminhoes.Add(c7);

            List<int> distancias = new List<int>();
            distancias.Add(200);
            distancias.Add(554);
            distancias.Add(112);
            distancias.Add(1580);
            distancias.Add(321);
            distancias.Add(627);
            distancias.Add(876);

            SimulacaoCustoFrete simulacao = new SimulacaoCustoFrete(vagoes, caminhoes, distancias);

            simulacao.EscolherTransporte();



        }
    }
}
