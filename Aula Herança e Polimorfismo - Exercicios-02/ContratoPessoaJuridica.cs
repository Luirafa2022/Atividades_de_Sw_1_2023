namespace Aula_Herança_e_Polimorfismo___Exercicios_02;
class ContratoPessoaJuridica:Contrato
{
public string? Cnpj;
public string? IE;
public string? NomeEmpresa;

    public override string Nome()
    {
        return base.Nome() + "Luiz";
    }
    public override string Email()
    {
        return base.Email() + "exemplo@gmail.com";
    }
    public override string Telefone()
    {
        return base.Telefone() + "+ (99) 99999-9999";
    }
}