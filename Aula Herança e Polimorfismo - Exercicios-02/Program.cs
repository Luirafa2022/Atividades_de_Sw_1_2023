namespace Aula_Herança_e_Polimorfismo___Exercicios_02;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica PessoaFisica = new ContratoPessoaFisica();
        ContratoPessoaJuridica PessoaJuridica = new ContratoPessoaJuridica();

        PessoaFisica.Cpf = "000.000.000-00";
        PessoaFisica.Idade = 25;
        PessoaJuridica.NomeEmpresa = "Honda";
        PessoaJuridica.IE = "Sefaz";
        PessoaJuridica.Cnpj = "00.123.123/0123-45 Matriz";

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Contrato da pessoa fisica:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Nome: " + PessoaFisica.Nome());
        Console.WriteLine("Idade: " + PessoaFisica.Idade);
        Console.WriteLine("Cpf: " + PessoaFisica.Cpf);
        Console.WriteLine("Email: " + PessoaFisica.Email());
        Console.WriteLine("Telefone: " + PessoaFisica.Telefone());
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Contrato da pessoa juridica:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Nome: " + PessoaJuridica.Nome());
        Console.WriteLine("IE: " + PessoaJuridica.IE);
        Console.WriteLine("Cnpj: " + PessoaJuridica.Cnpj);
        Console.WriteLine("Nome da empresa: " + PessoaJuridica.NomeEmpresa);
        Console.WriteLine("Email: " + PessoaJuridica.Email());
        Console.WriteLine("Telefone: " + PessoaJuridica.Telefone());
        Console.WriteLine("----------------------------------------");

    }
}
