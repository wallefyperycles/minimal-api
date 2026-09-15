

namespace MinimalApi.DTOs;
public record VeiculoDTO //record é uma instância menor que uma classe;
{

    public string Nome { get; set; } = default!;
    public string Marca { get; set; } = default!;
    public int Ano { get; set; } = default!;
}