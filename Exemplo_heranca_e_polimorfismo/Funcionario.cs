namespace Exemplo_heranca_e_polimorfismo;
class Funcionario
{
    public string? Nome {get;set;}
    
    public virtual double Lucro(){
        return 20000;
    }
}
