

namespace MinimalApi.DTOs;
public class LoginDTO
{
    public string Email { get; set; } = default!;
    public int Senha {get; set;} = default!;
}