class Episodio(string titulo, int duracao, int ordem)
{
    public string Titulo { get; } = titulo;
    public int Duracao { get; } = duracao;
    public int Ordem { get; } = ordem;
    public string Descricao => $"O episódio {Titulo} tem duração de {Duracao} segundos.";
    private readonly List<string> Convidados = [];

    public void PrintEpisodio()
    {
        Console.WriteLine("Titulo do episódio: " + Titulo);
        Console.WriteLine("Duração: " + Duracao);
        System.Console.WriteLine($"Convidados:");
        System.Console.WriteLine("------------------");
        foreach (var convidado in Convidados)
        {
            System.Console.WriteLine(convidado);
        }
    }

    public void AdicionarConvidado(string nome)
    {
        Convidados.Add(nome);
    }
}