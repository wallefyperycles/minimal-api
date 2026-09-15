using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.MoldelViews;

public record AdmistradorLogado
{

    public string Email { get; set; } = default!;
    public string Perfil {get; set;} = default!;
    public string Token { get; set; } = default!;
}