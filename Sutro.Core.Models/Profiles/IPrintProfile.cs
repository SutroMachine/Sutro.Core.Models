using System;
using System.Collections.Generic;
using System.Text;

namespace Sutro.Core.Models.Profiles
{
    public interface IPrintProfile
    {
        public IMachineProfile MachineProfile { get; }

        public IMaterialProfile MaterialProfile { get; }

        public IPartProfile PartProfile { get; }
    }
}
