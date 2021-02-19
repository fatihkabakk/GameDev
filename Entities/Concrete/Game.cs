using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string ReleaseDate { get; set; }
        public double UnitPrice { get; set; }
    }
}
