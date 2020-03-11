using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Linq;

namespace ShoppingApp.ViewModel
{
    public class Order
    {
        public int Id { get; set; }
        public int TotalCost { get; set; }
        public string TotalCostString { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public void SetId()
        {
            int hash = DateTime.Now.GetHashCode();
            if (hash < 0) hash *= (-1);
            Id = hash;
        }
    }
}