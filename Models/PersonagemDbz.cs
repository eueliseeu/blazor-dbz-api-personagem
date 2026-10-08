using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Models;

public class PersonagemDbz
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("name")]
  public string Name { get; set; } = string.Empty;

  [JsonPropertyName("image")]
  public string Image { get; set; } = string.Empty;

  [JsonPropertyName("originPlanet")]
  public OriginPlanet? OriginPlanet { get; set; }

  [JsonPropertyName("transformations")]
  public List<Transformacao> Transformations { get; set; } = new();
}

public class OriginPlanet
{
  [JsonPropertyName("name")]
  public string Name { get; set; } = string.Empty;
}

public class Transformacao
{
  [JsonPropertyName("name")]
  public string Name { get; set; } = string.Empty;
}
