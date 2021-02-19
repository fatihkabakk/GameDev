using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Discount : IEntity
    {
        public string Name { get; set; }
        public double DiscountRate { get; set; }
    }
}
