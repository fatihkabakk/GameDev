using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class MernisManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Name.Length > 2 & gamer.LastName.Length >= 1 & gamer.NationalityId.Length == 11 & gamer.YearOfBirth < 2006)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
