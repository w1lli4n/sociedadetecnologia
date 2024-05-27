namespace SociedadeTecnologia.Entities;

public class Author(string? name, string? about, string? avatarPath)
{
    public string? Name { get; set; } = name;
    public string? About { get; set; } = about;
    public string? AvatarPath { get; set; } = avatarPath;
}
