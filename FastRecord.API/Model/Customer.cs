using FastRecord.API.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastRecord.API.Model
{
    public class Customer : BaseEntity
    {
        public Customer(string customerName, ServiceModel service, string email, string phoneNumber)
        {
            CustomerName = customerName;
            Service = service;
            Email = email;
            PhoneNumber = phoneNumber;
            Status = ServiceStatus.Created;
        }

        public string CustomerName { get; private set; }
        public ServiceModel Service { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public ServiceStatus Status { get; private set; }

    }
}
