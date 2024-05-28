namespace SociedadeTecnologia.Models;

public class Author(string name, string about, string avatarPath, string imagePath)
{
    public string Name { get; set; } = name;
    public string About { get; set; } = about;
    public string AvatarPath { get; set; } = avatarPath;
    public string ImagePath { get; set; } = imagePath;
}
