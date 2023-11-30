namespace KooliProjekt.Data
{
    public class Service
    {
        public int Id { get; set; }
        public string NameOfService { get; set; }

        private decimal _totalPricePerService;

        public decimal TotalPricePerService
        {
            get { return _totalPricePerService; }
            set { _totalPricePerService = value; }
        }

        protected Service()
        {
        }

        public Service(string nameOfService, decimal price)
        {
            NameOfService = nameOfService;
            TotalPricePerService = price;
        }
    }
}
