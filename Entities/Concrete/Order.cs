using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order
    {
        public int BuyerId { get; set; }
        public Double Price { get; set; }
    }
}
