namespace POO_aula_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno("Fellipe", 34);
            aluno1.Turma = 34;
            Console.WriteLine("O peimeiro nome é: " + aluno1.Nome);
            aluno1.Nome = "Laura";
            Console.WriteLine("O segundo nome é: " + aluno1.Nome);
            Console.WriteLine("Sua turma é: " + aluno1.Turma);
        }
    }
}
