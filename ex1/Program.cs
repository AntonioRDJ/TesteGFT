using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double multiplicando;
            int inicioInter, fimInter;

            Console.WriteLine("Digite um número(multiplicando):");
            multiplicando = double.Parse(Console.ReadLine());
            if(multiplicando<0 || multiplicando>3000){
                Console.WriteLine("O multiplicando não pode ser menor que 0 ou maior que 3000.");
            }else{
                Console.WriteLine("Digite o inicio do intervalo:");
                inicioInter = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o fim do intervalo:");
                fimInter = int.Parse(Console.ReadLine());

                
                if(inicioInter<0 || fimInter<0 || inicioInter>3000 || fimInter>3000){
                    Console.WriteLine("Erro, o intervalo deve ser positivo e menor que 3000.");
                }else if((fimInter-inicioInter)>9){
                    Console.WriteLine("O intervalo não pode ser maior que 10.");
                }else if(inicioInter>=fimInter){
                    Console.WriteLine("O incio do intervalo deve ser menor que seu fim.");
                }else{
                    for (;inicioInter <= fimInter; inicioInter++)
                    {
                        Console.WriteLine(multiplicando+" x "+inicioInter+" = "+inicioInter*multiplicando);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
