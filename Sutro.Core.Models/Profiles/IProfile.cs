namespace Sutro.Core.Models.Profiles
{
    public interface IProfile<TSettings>
    {
        int SchemaVersion { get; }

        string Name { get; }

        IProfile<TSettings> Clone();

        void ApplyToSettings(TSettings settings);

        void LoadFromSettings(TSettings settings);
    }
}
