class Program
{
    static void Main(string[] args)
    {
        // Banda banda = new("Ado");

        // Musica musica = new(banda, "Show")
        // {
        //     Duracao = -200,
        // };

        // Album album = new(banda, "Album");

        // album.AddMusica(musica);
        
        // banda.AddAlbum(album);
        // //banda.PrintBanda();
        // musica.PrintMusica();

        Episodio episodio1 = new("Episodio1", 200, 1);
        Episodio episodio2 = new("Episodio2", 300, 2);
        episodio1.AdicionarConvidado("Convidado1");
        episodio2.AdicionarConvidado("Convidado2");

        Podcast podcast = new("Host", "Podcast");
        podcast.AdicionarEpisodio(episodio2);
        podcast.AdicionarEpisodio(episodio1);

        podcast.PrintPodcast();
    }
}