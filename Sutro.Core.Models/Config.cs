using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Sutro.Core.Models
{
    public static class Config
    {
        public static bool DebuggerAttached { get; set; }        
        public static bool Debug { get; set; }
        public static bool Parallel { get; set; }
    }
}
