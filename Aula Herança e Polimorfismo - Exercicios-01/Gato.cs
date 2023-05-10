namespace Aula_Herança_e_Polimorfismo___Exercicios_01;
class Gato:Animal
{
 public override string Fala()
    {
        return base.Fala()+"Miau";
    }
}