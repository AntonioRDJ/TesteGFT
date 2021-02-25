namespace ex2
{
    public class Vagao : Transporte
    {
        public Vagao(double valor, double peso){
                this.Valor = valor;
                this.Peso = peso;
        }
            
        public override double calculaFrete(int distancia)
        {
            if(Peso<15000){
                return ((0.07*Peso)+(0.01*Valor)+(0.5*distancia))+5000;
            }else{
                return ((0.07*Peso)+(0.01*Valor)+(0.5*distancia));
            }
        }
    }
}