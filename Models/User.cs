using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Console1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Toestand { get; set; }

        public override string ToString()
        {
            return $"{Name} is goan {Toestand}";
        }
    }
}
