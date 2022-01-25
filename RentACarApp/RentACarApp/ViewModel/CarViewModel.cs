using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentACarApp.ViewModel
{
    public class CarViewModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IFormFile Image { get; set; }
        [RegularExpression("(0)([0-9]{9})")]
        public int PhoneNumber { get; set; }
    }
}
