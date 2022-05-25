using FastRecord.API.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastRecord.API.Model
{
    public class ServiceModel : BaseEntity
    {
        public ServiceModel(string serviceName, ServiceType typeService, double price)
        {
            ServiceName = serviceName;
            CreatedAt = DateTime.Now;
            TypeService = typeService;
            Price = price;
        }

        public string ServiceName { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public ServiceType TypeService{ get; private set; }
        public double Price { get; private set; }

    }
}
