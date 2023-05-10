namespace Aula_Herança_e_Polimorfismo___Exercicios_01;
class Program
{
    static void Main(string[] args)
    {
        Homem Luiz = new Homem();
        Gato Gaterson = new Gato();
        Cão Spike = new Cão();

        Console.WriteLine("Eu chamei o homem e ele falou:" + Luiz.Fala());
        Console.WriteLine("Eu chamei o gato e ele falou:" + Gaterson.Fala());
        Console.WriteLine("Eu chamei o cão e ele falou:" + Spike.Fala());
    }
}
