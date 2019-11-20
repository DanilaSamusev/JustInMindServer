using System;
using System.ComponentModel.DataAnnotations;

namespace JustInMindServer.Entities
{
    public class Comment
    {
        [Key]
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
    }
}