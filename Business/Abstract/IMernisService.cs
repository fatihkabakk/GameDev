using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMernisService
    {
        bool Validate(Gamer gamer);
    }
}
