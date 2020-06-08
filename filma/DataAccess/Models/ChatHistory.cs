using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class ChatHistory
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
