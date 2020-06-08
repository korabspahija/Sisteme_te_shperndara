using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Seat { get; set; }
        public bool IsReserved { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
