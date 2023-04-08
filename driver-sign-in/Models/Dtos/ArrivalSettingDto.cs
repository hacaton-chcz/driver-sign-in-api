using System.ComponentModel.DataAnnotations;

namespace driver_sign_in.Models.Dtos
{
    public class ArrivalSettingDto
    {
        [Required]
        public string InvoiceId { get; set; }
        [Required]
        public bool IsArrived { get; set; }

    }
}
