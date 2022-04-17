using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacecraft.BusinessLayer.Queries
{
    public class SpacecraftInventory : IQuery
    {
        public SpacecraftInventory(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int CurrentStock { get; set; }
    }
}
