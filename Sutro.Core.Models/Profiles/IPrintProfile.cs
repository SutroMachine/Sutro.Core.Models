using System;
using System.Collections.Generic;
using System.Text;

namespace Sutro.Core.Models.Profiles
{
    public interface IPrintProfile
    {
        public IMachineProfile Machine { get; }

        public IMaterialProfile Material { get; }

        public IPartProfile Part { get; }
    }
}
