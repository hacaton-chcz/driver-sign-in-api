
namespace driver_sign_in.Models.Dtos
{
    public class InvoiceCreationDto
    {
        public long Id { get; set; }
        public string CarNumber { get; set; }
        public string DriverFullName { get; set; }
        public string Sender { get; set; }
        public int Checkpoint { get; set; }
        public int Product { get; set; }
        public int ProductId { get; set; }
        public DateTime At { get; set; }
        public DateTime From { get; set; }

    }
}
