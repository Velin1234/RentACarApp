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
        [Display(Name ="Марка")]
        public string Make { get; set; }
        [Required]
        [Display(Name = "Модел")]
        public string Model { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Дата на производство")]
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
        [Display(Name ="Описание")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Цена на Ден")]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [RegularExpression("^0([0-9]{9})")]
        [Display(Name = "Тел. номер")]
        public int PhoneNumber { get; set; }
    }
}
