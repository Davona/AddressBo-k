using System.ComponentModel.DataAnnotations;

namespace AddressBoоk.Models
{
    public class ContactViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string PhysicalAddress { get; set; }
    }
}
