using System;
using System.ComponentModel.DataAnnotations;

namespace JustInMindServer.Entities
{
    public class History
    {
        public DateTime Date { get; set; }
        [Key]
        public string UserName { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }
}