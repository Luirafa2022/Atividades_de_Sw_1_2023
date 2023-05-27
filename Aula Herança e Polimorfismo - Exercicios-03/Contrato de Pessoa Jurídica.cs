namespace Aula_Herança_e_Polimorfismo___Exercicios_03;
class Contrato_de_Pessoa_Jurídica:Contratos
{
    public override double Prazo()
    {
        return base.Prazo() + 12;
    }
    public override double ValorContrato()
    {
        return base.ValorContrato() + 15000;
    }
    public override double CalcularPrestação(){
        return base.CalcularPrestação() + 3;
    }
    
}
