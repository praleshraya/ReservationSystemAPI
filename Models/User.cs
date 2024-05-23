using System.ComponentModel.DataAnnotations;

namespace ReservationSystemAPI.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        [StringLength(50)]
        public String first_name { get; set; }
        [StringLength(50)]
        public String middle_name { get; set; }
        [Required]
        [StringLength(50)]
        public String last_name { get; set; }
        [Required]
        [StringLength(50)]
        public String email { get; set; }
        [Required]
        [StringLength(50)]
        public String password { get; set; }
        [Required]
        [StringLength(3)]
        public String country_code { get; set; }
        [Required]
        [StringLength(10)]
        public String phone_number { get; set; }
        public bool gender { get; set; }
    }
}
