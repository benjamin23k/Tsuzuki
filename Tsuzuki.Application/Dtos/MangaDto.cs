using System;
using System.Collections.Generic;
using System.Text;

namespace Tsuzuki.Application.Dtos
{
    public class MangaDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? CoverImageUrl { get; set; }
    }
}
