using System.ComponentModel.DataAnnotations.Schema;
namespace KooliProjekt.Data
{
    public class House
    {
        public int Id { get; set; }
        public string HouseAddress { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public int HouseNumber {get; set; }

        public string HouseConstructionStatus { get; set; } 
        [ForeignKey("UserId")] // Указываем, что UserId - внешний ключ
        public int UserId { get; set; } // Внешний ключ к таблице User
    }
}
