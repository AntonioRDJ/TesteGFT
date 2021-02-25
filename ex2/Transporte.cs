namespace ex2
{
    public abstract class Transporte : Carga
    {
        public Transporte(){}
        public Transporte(double valor, double peso){
            this.Valor = valor;
            this.Peso = peso;
        }

        public abstract double calculaFrete(int distancia);


    }
}