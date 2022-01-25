using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentACarApp.Models
{
    public class Car
    {
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate
        {
            get
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;
            }
            set
            {
                _releaseDate = value;
            }

        }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [RegularExpression("(0)([0-9]{9})")]
        public int PhoneNumber { get; set; }
    }
}
