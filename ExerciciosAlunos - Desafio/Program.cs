namespace ExerciciosAlunos;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string? nomealuno = Console.ReadLine();
        Console.WriteLine("O seu nome é " + nomealuno);
        Console.Write("Digite um número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi " + numero1);
        Console.Write("Digite outro número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi " + numero2);
         string situacao="";
        if ((numero1 + numero2)/2>=6){
            situacao="aprovado";
            }else{
                situacao="reprovado";
            }
        Console.WriteLine("A média de " + nomealuno + " foi de: " + (numero1 + numero2)/2 + " e ele foi " + situacao);
        
    }
}
