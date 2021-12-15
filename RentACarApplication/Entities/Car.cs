using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACarApplication.Entities
{
    public class Car
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100,MinimumLength =2)]
        public string Made { get; set; }
        
        [Required]
        [StringLength(100,MinimumLength =2)]
        public string Model { get; set; }

        [StringLength(250,MinimumLength =25)]
        public string Description { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
        public DateTime CreatedDate { get; set; }

        [Required]
        public double Price { get; set; }

        public string CarImagePath { get; set; }

        [ForeignKey("UserId")]
        public virtual UserCar UserCar { get; set; }
    }
}
