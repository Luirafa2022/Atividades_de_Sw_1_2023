namespace Aula_Herança_e_Polimorfismo___Exercicios_03;
class Program
{
    static void Main(string[] args)
    {
        Contrato_de_Pessoa_Física PessoaF = new Contrato_de_Pessoa_Física();
        Contrato_de_Pessoa_Jurídica PessoaJ = new Contrato_de_Pessoa_Jurídica();

        PessoaF.Nome = "André";
        PessoaJ.Nome = "Luiz";

       Console.WriteLine("Nome: " + PessoaF.Nome + " / Prestação: " + PessoaF.CalcularPrestação());
       Console.WriteLine("Nome: " + PessoaJ.Nome + " / Prestação: " + PessoaJ.CalcularPrestação());

    }
}
