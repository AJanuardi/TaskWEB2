using System;

namespace TaskWEB2.Models
{
    public class Comment
    {
        public int id { get; set; }
        public int articleid { get; set; }
        public string username { get; set; }
        public string comment { get; set; }
        public DateTime created {get; set;} 
    }
}