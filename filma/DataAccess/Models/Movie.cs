using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }
        public virtual ICollection<ChatHistory> ChatHistories { get; set; }

    }
}
