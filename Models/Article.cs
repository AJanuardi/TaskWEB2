using System;

namespace TaskWEB2.Models
{
    public class Article
    {
        public int id { get; set; }
        public string judul { get; set; }
        public string highlight { get; set; }
        public string body { get; set; }
        public string publisher { get; set; }
        public string category {get; set;}
        public string picture {get; set;}
        public DateTime created {get; set;}
    }
}