using TesteTargetSistemas.Atividades;
static class Program
{
    private static void Main(string[] args)
    {
        #region Atividade 1 Soma Loop
        //Podemos instanciar ou não a classe - nesse exemplo não instanciei pois o metódo não depende de mais variáveis de instancia        
        Console.WriteLine("Atividade 1 Soma Loop:");          
        Console.WriteLine(SomaLoop.CalcularSoma(13));
        #endregion

        #region Atividade 2
        //Nesse exemplo irei instanciar a classe
        Console.WriteLine("Atividade 2 Fibonacci:");
        Fibonacci fibonacci = new Fibonacci();
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(fibonacci.PertenceASequencia(numero));

        #endregion
    }
}