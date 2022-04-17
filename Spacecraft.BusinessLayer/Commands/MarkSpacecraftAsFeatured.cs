using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacecraft.BusinessLayer.Commands
{
    internal class MarkSpacecraftAsFeatured : ICommand
    {
        public MarkSpacecraftAsFeatured(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
