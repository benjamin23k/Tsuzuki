using System;
using System.Collections.Generic;
using System.Text;

namespace Tsuzuki.Domain.Entities
{
    public  class Anime
    {
        public int Id { get; private set; }

        public string? Title { get; private set; }
         
        public string? season { get; private set; }

        public string? episode { get; private set; }

        public string? description { get; private set; }

        public string? coverImageUrl { get; private set; }

        public string? Status { get; private set; }


    }
}
