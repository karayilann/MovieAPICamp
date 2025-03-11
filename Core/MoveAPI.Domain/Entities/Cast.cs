using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAPI.Domain.Entities
{
    public class Cast
    {
        public int CastId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageURL { get; set; }
        public string? Overview { get; set; } 
        public string? Biography { get; set; }
    }
}
