using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace driver_sign_in.Models.Entities
{
    public class ProductEntity
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [EnumDataType(typeof(UnitsEnum))]
        public UnitsEnum Units { get; set; }
    }

    public enum UnitsEnum
    {
        KG = 0,
        T,
    }
}
