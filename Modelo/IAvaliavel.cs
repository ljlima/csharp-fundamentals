namespace ScreenMusic.Modelos;

internal interface IAvaliavel 
{
    public double Media { get; }
    void AdicionarNota(Avaliacao nota);
}