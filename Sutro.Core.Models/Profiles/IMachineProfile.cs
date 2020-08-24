namespace Sutro.Core.Models.Profiles
{
    public interface IMachineProfile : IProfile
    {
        string ManufacturerName { get; set; }
        string ModelIdentifier { get; set; }

        double MachineBedSizeXMM { get; set; }
        double MachineBedSizeYMM { get; set; }
        double MachineBedSizeZMM { get; set; }

        MachineBedOriginLocationX OriginX { get; set; }
        MachineBedOriginLocationY OriginY { get; set; }
    }
}