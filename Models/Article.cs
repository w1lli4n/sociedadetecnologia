namespace SociedadeTecnologia.Models;

public class Article(string title, string lead, string path, string imagePath, Author author)
{
    public string Title { get; set; } = title;
    public string Lead { get; set; } = lead;
    public string Path { get; set; } = path;    
    public string ImagePath { get; set; } = imagePath;
    public string HtmlText { get; set; } = String.Empty;
    public Author Author { get; set; } = author;
}