namespace Aula_Herança_e_Polimorfismo___Exercicios_01;
class Cão:Animal
{
 public override string Fala()
    {
        return base.Fala()+"Au au";
    }
}