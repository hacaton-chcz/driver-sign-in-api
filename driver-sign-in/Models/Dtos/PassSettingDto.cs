using System.ComponentModel.DataAnnotations;

namespace driver_sign_in.Models.Dtos
{
    public class PassSettingDto
    {
        [Required]
        public string InvoiceId { get; set; }
        [Required]
        public bool IsPassed { get; set; }

    }
}
