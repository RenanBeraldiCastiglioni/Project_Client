using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectClient.Models;

namespace ProjectClient.Data
{
    public class SeedingService
    {
        private readonly ProjectClientContext _context;

        public SeedingService(ProjectClientContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Client.Any())
            {
                return; //DB has been seeded
            }
            Client c1 = new Client
            {
                Id = 1,
                CPF = "54758150893",
                Name = "Jose da Silva",
                BirthDate = new DateTime(1970, 07, 15),
                Address = "Rua Itapinima",
                Neighborhood = "Vila Mangalot",
                State = "SP",
                ZIP = 05132230
            };
            Client c2 = new Client
            {
                Id = 2,
                CPF = "03922855849",
                Name = "Thiago Andrade",
                BirthDate = new DateTime(1980, 04, 22),
                Address = "Av Anastacio",
                Neighborhood = "Pq Sao Domingos",
                State = "SP",
                ZIP = 05119900
            };
            Client c3 = new Client
            {
                Id = 3,
                CPF = "14724460890",
                Name = "Maria Rose",
                BirthDate = new DateTime(1964, 04, 18),
                Address = "Rua Catao",
                Neighborhood = "Vila Romana",
                State = "SP",
                ZIP = 05171500
            };

            _context.Client.AddRange(c1, c2, c3);
            _context.SaveChanges();
        }
    }
}
