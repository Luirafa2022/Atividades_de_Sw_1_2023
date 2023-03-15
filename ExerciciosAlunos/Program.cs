namespace ExerciciosAlunos;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Luiz";
        aluno1.nota1 = 6.2;
        aluno1.nota2 = 8.9;

        aluno1.mensagem();
    }
}
