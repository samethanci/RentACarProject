using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public short BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
