using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public byte ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
