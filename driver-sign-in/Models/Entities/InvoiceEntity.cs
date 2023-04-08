using driver_sign_in.Models.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace driver_sign_in.Models.Entities
{
    public class InvoiceEntity
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string CarNumber { get; set; }
        public string DriverFullName { get; set; }
        [ForeignKey("ProductId")]
        public long productId { get; set; }
        
        public float ProductAmount { get; set; }

        [EnumDataType(typeof(StatusesEnum))]
        public StatusesEnum Status { get; set; }
        public DateTime StatusUpdatedUtc { get; set; }
        [AllowNull]
        public DateTime? MustBeOnCheckUtc { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }

    public enum StatusesEnum
    {
        CREATED = 0,
        ARRIVED = 1,
        INVITED = 2,
        PASSED_INSPECTION = 3,
        ON_INTERNAL_PARKING = 4,
        ON_LOAD = 5,
        LOAD_END = 10
    }
}
