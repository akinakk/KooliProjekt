namespace KooliProjekt.Data
{
    public class Material
    {
        public int Id { get; set; }
        public string NameOfMaterial { get; set; }
        public int HowMuchUsed { get; set; }
        public int PricePerUnit { get; set; }

        public int BillId { get; set; }
        public Bill Bill { get; set; } // Навигационное свойство

        public int TotalPriceForMaterial
        {
            get
            {
                return HowMuchUsed * PricePerUnit;
            }
        }
    }
}
