using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAPI.Domain.Entities
{
    class Review
    {
        public int ReviewId { get; set; }
        public string ReviewMessage { get; set; }
        public decimal ReviewRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool Status { get; set; }

    }
}
