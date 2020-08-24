using System;

namespace Sutro.Core.Models.Profiles
{
    public interface IMachineProfile : IProfile
    {
        string ManufacturerName { get; set; }
        string ModelIdentifier { get; set; }

        double BedSizeXMM { get; set; }
        double BedSizeYMM { get; set; }

        [Obsolete("Use MaxHeightMM instead")]
        double BedSizeZMM { get; set; } 

        double MaxHeightMM { get => BedSizeZMM; set => BedSizeZMM = value; }

        MachineBedOriginLocationX OriginX { get; set; }
        MachineBedOriginLocationY OriginY { get; set; }
    }
}