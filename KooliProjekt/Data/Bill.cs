using System.ComponentModel.DataAnnotations.Schema;

namespace KooliProjekt.Data
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal FinalBillForMaterials { get; set; }
        public decimal FinalBillForService { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public Customer User { get; set; }

        public IList<Service> Services { get; set; } // Коллекция для услуг
        public IList<Material> Materials { get; set; } // Коллекция для материалов

        public decimal TotalBill
        {
            get
            {
                return FinalBillForMaterials + FinalBillForService;
            }
        }

        // Метод для добавления услуги и обновления FinalBillForService
        public void AddService(Service service)
        {
                FinalBillForService += service.TotalPricePerService;
            Services.Add(service);
        }

        // Метод для добавления материала и обновления FinalBillForMaterials
        public void AddMaterial(Material material)
        {
                FinalBillForMaterials += material.TotalPriceForMaterial;

        }
    }
}
