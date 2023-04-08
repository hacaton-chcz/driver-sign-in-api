using System.ComponentModel.DataAnnotations;

namespace driver_sign_in.Models.Dtos
{
    public class InvoiceCreationDto
    {
        [Required]
        public string InvoiceId { get; set; }
        [Required]
        public string CarNumber { get; set; }
        [Required]
        public string DriverFullName { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public float ProductAmount { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
    }
}
