using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastRecord.API.Model
{
    public class Income : BaseEntity
    {                
        public List<Customer> Customers{ get; set; }

        public double TotalIncome()
        {
            return Customers.Sum(ti => ti.Service.Price);
        }
    }
}
