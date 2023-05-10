namespace Aula_Herança_e_Polimorfismo___Exercicios_01;
class Homem:Animal
{
    public override string Fala()
    {
        return base.Fala()+"Oi";
    }
}