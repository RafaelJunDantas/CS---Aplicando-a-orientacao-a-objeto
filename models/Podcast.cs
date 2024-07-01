
class Podcast(string host, string nome)
{   
    public string Host { get; } = host;
    public string Nome { get; } = nome;
    private List<Episodio> episodios = [];

    public void PrintPodcast()
    {
        Console.WriteLine("Nome do podcast: " + Nome);
        Console.WriteLine("Host: " + Host);
        System.Console.WriteLine("Episódios em ordem:");
        System.Console.WriteLine("------------------"); 
        PrintEpisodios();
    }

    private void PrintEpisodios()
    {
        int i = 1;
        foreach (var episodio in episodios)
        {
            System.Console.WriteLine($"Episódio {i}:");
            episodio.PrintEpisodio();
            i++;
        }
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        episodios = [.. episodios.OrderBy(episodio => episodio.Ordem)];
    }
}