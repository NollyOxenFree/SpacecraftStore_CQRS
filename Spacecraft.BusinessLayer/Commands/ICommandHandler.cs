using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacecraft.BusinessLayer.Commands
{
    internal interface ICommandHandler<T>
        where T : class, ICommand
    {
        void Handle(T command);
    }
}
