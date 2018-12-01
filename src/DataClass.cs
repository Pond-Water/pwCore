using System;

namespace PWCore
{
    [GeneratedController("api/book")]
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
    }


    [GeneratedController("api/v1/album")]
    public class Album
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }
    }

}
