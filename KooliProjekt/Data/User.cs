﻿namespace KooliProjekt.Data
{
    public class Customer
    {
        public int Id { get; set; }

        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string OrderStatus { get; set; }
        public House House { get; set; } // Навигационное свойство

        public decimal Bill { get; set; }
        public IList<Bill> UserBills { get; set; } // Link to bill
    }
}
