namespace ExerciciosAlunos;
class Aluno
{
    public string nome = "";
    public double nota1;
    public double nota2;

    //Média -> retornar o double (por exemplo um número como 8.3)
    public double obterMedia(){
        double media = (nota1 + nota2)/2;
        return media;
    }
    //Situação -> retornar uma string (por exemplo "Aprovado" e "Reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if (media>=6){
            situacao="aprovado";
            }else{
                situacao="reprovado";
            }
            return situacao;

    }
    //Mensagem -> não retorna nada. Só mostra na tela os detalhes (nome, média, situação)
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome + " está " + resultadoSituacao + " com média: " + mediaCalculada);
    }
}
