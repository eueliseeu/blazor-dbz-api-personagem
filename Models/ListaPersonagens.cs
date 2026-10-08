namespace BlazorDbzPersonagem.Models;

public class ListaPersonagensResposta
{
  public List<PersonagemResumo> Items { get; set; } = new();
}

public class PersonagemResumo
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
}
