using System;
using System.Collections.Generic;
using System.Text;

namespace Sutro.Core.Models.Profiles
{
    public interface IProfile
    {
        string Name { get; set; }

        IProfile Clone();
    }
}
