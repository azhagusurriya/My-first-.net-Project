﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Week2Class1.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        [Required]
        [Microsoft.AspNetCore.Mvc.Remote("CheckNames", "Remote", AdditionalFields = "FirstName, LastName")]

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Total { get; set; }

        public Country CountryCodeNavigation { get; set; }
        public Province ProvinceCodeNavigation { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
