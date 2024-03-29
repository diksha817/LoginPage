using System;
using System.ComponentModel.DataAnnotations;
namespace WEEK2.Models
{
    public class Book
    {
        [Key] 
        public required int ISBN { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required double Price { get; set; }

    }
}
