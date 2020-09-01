using System;
using System.Collections.Generic;
using System.Text;

namespace Sutro.Core.Models.Profiles
{
    public interface IProfile
    {
        int SchemaVersion { get; }

        string Name { get; }

        IProfile Clone();
    }
}
