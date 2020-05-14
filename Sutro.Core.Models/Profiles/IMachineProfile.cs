namespace Sutro.Core.Models
{
    public interface IMachineProfile
    {
        string ManufacturerName { get; set; }
        string ModelIdentifier { get; set; }

        double MachineBedSizeXMM { get; set; }
        double MachineBedSizeYMM { get; set; }
        double MachineBedSizeZMM { get; set; }

        MachineBedOriginLocationX OriginX { get; set; }
        MachineBedOriginLocationY OriginY { get; set; }

        IMachineProfile Clone();
    }
}