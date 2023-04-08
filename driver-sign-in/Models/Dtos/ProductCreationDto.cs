using System.ComponentModel.DataAnnotations;

namespace driver_sign_in.Models.Dtos
{
    public class ProductCreationDto
    {
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
