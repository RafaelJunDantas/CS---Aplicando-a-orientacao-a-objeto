class Album(Banda artista, string nome)
{
    public string Nome { get; } = nome;
    public Banda Artista { get; } = artista;
    private readonly List<Musica> musicas = [];
    private int Duracao => musicas.Sum(musica => musica.Duracao);

    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void PrintAlbum()
    {
        Console.WriteLine("Nome do album: " + Nome);
        Console.WriteLine("Artista: " + Artista.Nome);
        Console.WriteLine("Duração: " + Duracao);
        System.Console.WriteLine("Musicas:");
        System.Console.WriteLine("------------------"); 
        PrintMusicas();
    }

    public void PrintMusicas()
    {
        int i = 1;
        foreach (var musica in musicas)
        {
            System.Console.WriteLine($"Musica {i}:");
            musica.PrintMusica();
            i++;
        }
    }
}