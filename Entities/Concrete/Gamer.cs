using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gamer : IEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int YearOfBirth { get; set; }
    }
}
