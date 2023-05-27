namespace Aula_Herança_e_Polimorfismo___Exercicios_03;
class Contratos
{
    public string? Nome {get;set;}
    public virtual double Prazo(){
            return 0;
    }
    public virtual double ValorContrato(){
        return 0;
    }
    public virtual double CalcularPrestação(){
        return ValorContrato()/Prazo();
    }
}