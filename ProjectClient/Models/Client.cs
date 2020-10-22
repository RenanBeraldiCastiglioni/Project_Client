using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectClient.Models
{
    public class Client
    {
        public int Id { get; set; }
        public double CPF { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public double ZIP { get; set; }
    }
}
