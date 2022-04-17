using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacecraft.BusinessLayer.Commands
{
    public class SpacecraftCommandHandler : ICommandHandler<BuySpacecraft>, ICommandHandler<NewSpacecraft>, ICommandHandler<MarkSpacecraftAsFeatured>
    {
        void ICommandHandler<BuySpacecraft>.Handle(BuySpacecraft command)
        {
            // Submit Payment (synchronous -- fail call if payment fails)
            // Update Inventory (async)
            // Track purchase (async)
            // Manage shipping detail (async)
            // Submit Thank you email (async)
        }

        void ICommandHandler<NewSpacecraft>.Handle(NewSpacecraft command)
        {
            // Add Spacecraft to Spacecraft data (synchronous -- fail call if insert fails)
            // Add to "New" list (async)
            // Update Inventory (async)
        }

        public void Handle(MarkSpacecraftAsFeatured command)
        {
            // Update table and set featured flag to true
        }
    }
}
