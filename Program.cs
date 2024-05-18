Banda banda = new Banda("banda X");

//Using initializers
Musica musica = new Musica(banda, "faixa1"){
    Duracao = 180,
    Disponivel = true
};

Album album =new Album("new");


musica.ExibirFihaTecnica();

Podcast podcast = new Podcast("ENGTI", "Joaozinho");
Episodio ep1 = new Episodio(1, "teste dados", 30);
ep1.AdicionarConvidado("julio");
ep1.AdicionarConvidado("andre");

Episodio ep2 = new Episodio(2, "teste sif", 30);
ep2.AdicionarConvidado("Ana");
ep2.AdicionarConvidado("Jose");
Episodio ep3 = new Episodio(3, "teste b", 30);
ep3.AdicionarConvidado("Vitor");
ep3.AdicionarConvidado("Carlos");
Episodio ep4 = new Episodio(4, "teste d", 30);
ep4.AdicionarConvidado("Amanda");
ep4.AdicionarConvidado("julia");
Episodio ep5 = new Episodio(5, "teste a", 60);
ep5.AdicionarConvidado("Carlos");
ep5.AdicionarConvidado("Amanda");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep4);
podcast.AdicionarEpisodio(ep5);




podcast.ExibirDetalhes();