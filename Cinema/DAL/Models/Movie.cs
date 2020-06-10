using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<ChatHistory> ChatHistories { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
