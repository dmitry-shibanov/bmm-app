namespace BMM.Core.Implementations.Device
{
    public interface IDeviceInfo
    {
        string Manufacturer { get; }

        string Model { get; }

        BmmDevicePlatform Platform { get; }

        bool IsAndroid { get; }

        bool IsIos { get; }

        string VersionString { get; }
    }
}