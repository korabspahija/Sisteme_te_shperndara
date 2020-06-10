using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool IsReserved { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
