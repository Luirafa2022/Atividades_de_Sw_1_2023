namespace Exemplo_heranca_e_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
       FuncionarioN1 n1 = new FuncionarioN1();
       FuncionarioN2 n2 = new FuncionarioN2();
       FuncionarioN3 n3 = new FuncionarioN3();

       n1.Nome = "Fulano";
       n2.Nome = "Ciclando";
       n3.Nome = "Beltando";

       Console.WriteLine("Nome: " + n1.Nome + " / Lucro: " + n1.Lucro());
       Console.WriteLine("Nome: " + n2.Nome + " / Lucro: " + n2.Lucro());
       Console.WriteLine("Nome: " + n3.Nome + " / Lucro: " + n3.Lucro());
    }
}
