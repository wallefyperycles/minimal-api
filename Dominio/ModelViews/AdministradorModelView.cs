using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.MoldelViews;

public record AdministradorModelView
{
    public int Id { get; set; } = default!;

    public string Email { get; set; } = default!;
    public string Perfil {get; set;} = default!;
}