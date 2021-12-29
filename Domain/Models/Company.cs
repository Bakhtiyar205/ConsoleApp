using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Company : BaseEntity
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }
}
