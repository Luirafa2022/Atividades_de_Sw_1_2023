namespace Aula_Herança_e_Polimorfismo___Exercicios_02;
class ContratoPessoaFisica:Contrato
{
public string? Cpf;
public int Idade;
public override string Nome()
    {
        return base.Nome() + "João";
    }
    public override string Email()
    {
        return base.Email() + "exemplo2@gmail.com";
    }
    public override string Telefone()
    {
        return base.Telefone() + "+55 (55) 55555-5555";
    }

}
