using System.Collections.Generic;

namespace AspNetCoreDemo.Models
{
    public class BeerResponseDto
    {
        public string Name { get; set; }
        public double Abv { get; set; }
        public string Style { get; set; }
        public string User { get; set; }
        public double AverageRating { get; set; }
        public List<string> Comments { get; set; }
    }
}
