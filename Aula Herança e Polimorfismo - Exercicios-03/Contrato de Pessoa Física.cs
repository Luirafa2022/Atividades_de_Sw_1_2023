namespace Aula_Herança_e_Polimorfismo___Exercicios_03;
class Contrato_de_Pessoa_Física:Contratos
{
    public int Idade(){
        return 51;
    }
    public override double Prazo()
    {
        return base.Prazo() + 12;
    }
    public override double ValorContrato()
    {
        return base.ValorContrato() + 10000;
    }
    public virtual double CalcularPrestação(){
        return ValorContrato()/Prazo() + CalculaAdicional();
    }
     public double CalculaAdicional() {
        double adicional = 0.0;

        if (Idade() <= 30) {
            adicional = 1.0;
        } else if (Idade() <= 40) {
            adicional = 2.0;
        } else if (Idade() <= 50) {
            adicional = 3.0;
        } else {
            adicional = 4.0;
        }

        return adicional;
    }

}