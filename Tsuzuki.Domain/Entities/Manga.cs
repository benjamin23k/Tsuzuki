namespace Tsuzuki.Domain.Entities;

public class Manga
{
    public int Id { get; private set; }

    public string? ExternalId { get; private set; }

    public string Title { get; private set; } = string.Empty;

    public string Author { get; private set; } = string.Empty;

    public string? Description { get; private set; }

    public string? CoverImageUrl { get; private set; }
    public string Genre { get; set; } = string.Empty;

    public string MangaActive { get; set; } = string.Empty;

    public MangaStatus Status { get; set; }


    public enum MangaStatus
    {
        Ongoing,
        Completed,
        Hiatus,
        Canceled,
    }

    public Manga(int id, string title, string author, string? description, string? coverImageUrl, string genre, string mangaActive)
    {
        Id = id;
        Title = title;
        Author = author;
        Description = description;
        CoverImageUrl = coverImageUrl;
        Genre = genre;
        MangaActive = mangaActive;



        if (string.IsNullOrWhiteSpace(Title))
        {
            throw new ArgumentException("Title cannot be null or empty.", nameof(title));

        }

        if (string.IsNullOrWhiteSpace(Author))
        {
            throw new ArgumentException("Author cannot be null or empty.", nameof(author));

        }
    }


}
