using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacecraft.BusinessLayer.Queries
{
    internal interface IQuery
    {
        public Guid Id { get; set; }
    }
}
