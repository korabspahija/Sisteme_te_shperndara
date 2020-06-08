using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Time
    {
        public int Id { get; set; }
        public int? Clock { get; set; }
        public string Day { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}
