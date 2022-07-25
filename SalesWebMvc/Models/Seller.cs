using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        List<SalesRecord> sales = new List<SalesRecord>();

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            this.BirthDate = birthDate;
            BaseSalary = baseSalary;
        }

        public void AddSales(SalesRecord sale)
        {
            sales.Add(sale);
        }
        public void RemoveSales(SalesRecord sale)
        {
            sales.Remove(sale);
        }

    }
}
