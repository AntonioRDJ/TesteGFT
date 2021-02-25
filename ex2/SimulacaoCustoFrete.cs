using System;
using System.Collections;
using System.Collections.Generic;

namespace ex2
{
    public class SimulacaoCustoFrete
    {
        private List<Vagao> vagoes;
        private List<Caminhao> caminhoes;
        private List<int> distancias;

        public SimulacaoCustoFrete(){}
        public SimulacaoCustoFrete(List<Vagao> vagoes, List<Caminhao> caminhoes, List<int> distancias){
            Vagoes = vagoes;
            Caminhoes = caminhoes;
            Distancias = distancias;
        }

        public List<Vagao> Vagoes{
            get{ return vagoes;}
            set{ vagoes = value;}
        }
        public List<Caminhao> Caminhoes{
            get{ return caminhoes;}
            set{ caminhoes = value;}
        }
        public List<int> Distancias{
            get{ return distancias;}
            set{ distancias = value;}
        }

        public void EscolherTransporte(){
            int totalVagoes=0;
            int totalCaminhoes=0;
            double custoTotal=0;

            for (int i = 0; i < 7; i++)
            {
                if(vagoes[i].calculaFrete(distancias[i]) >= caminhoes[i].calculaFrete(distancias[i])){
                    totalCaminhoes++;
                    custoTotal+=caminhoes[i].calculaFrete(distancias[i]);
                }else {
                    totalVagoes++;
                    custoTotal+= vagoes[i].calculaFrete(distancias[i]);
                }
            }
            Console.WriteLine("Total de Caminhões: "+totalCaminhoes);
            Console.WriteLine("Total de Vagões: "+totalVagoes);
            Console.WriteLine("Custo Total: "+custoTotal);
        }


    }
}