
class Banda(string nome)
{
    public string? Nome { get; } = nome;
    private readonly List<Album> albuns = [];

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void PrintBanda()
    {
        Console.WriteLine("Nome da banda: " + Nome);
        System.Console.WriteLine("Albuns:");
        System.Console.WriteLine("------------------"); 
        PrintAlbuns();
    }

    private void PrintAlbuns()
    {
        int i = 1;
        foreach (var album in albuns)
        {
            System.Console.WriteLine($"Album {i}:");
            album.PrintAlbum();
            i++;
        }
    }
}