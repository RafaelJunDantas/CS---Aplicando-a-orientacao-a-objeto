class Musica(Banda artista, string nome)
{
    private string Nome { get; } = nome;
    private Banda Artista { get; } = artista;
    private int duracao;
    public int Duracao {
        get => duracao;
        set {
            if(value < 0)
            {
                duracao = 0;
            } else
            {
                duracao = value;
            }
        }
    }
    public bool Disponivel { get; } = false;
    public string Descricao => $"A musica {Nome} é do artista {Artista} e tem duração de {Duracao} segundos.";

    public void PrintMusica()
    {
        Console.WriteLine("Nome da musica: " + Nome);
        Console.WriteLine("Artista: " + Artista.Nome);
        Console.WriteLine("Duração: " + Duracao);
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano para ouvir esta música");
        }
    }
}