namespace SociedadeTecnologia.Entities;

public class Author(string? name = "", string? about = "", string? description = "", string? avatarPath = "", string? imagePath = "")
{
    public string? Name { get; set; } = name;
    public string? About { get; set; } = about;
    public string? Description { get; set; } = description;
    public string? AvatarPath { get; set; } = avatarPath;
    public string? ImagePath { get; set; } = imagePath;

}
