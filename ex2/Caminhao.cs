namespace ex2
{
    public class Caminhao : Transporte
    {
        public Caminhao(double valor, double peso){
            this.Valor = valor;
            this.Peso = peso;
        }
        
        public override double calculaFrete(int distancia)
        {
            if(Valor>40000){
                return ((0.02*Peso)+(0.03*Valor)+(2*distancia))*0.75;
            }
            return ((0.02*Peso)+(0.03*Valor)+(2*distancia));
        }
    }
}