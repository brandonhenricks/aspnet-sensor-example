namespace Sensor.Core.Contracts
{
    public interface ISensor
    {
        string DeviceId { get; }
        string ModelNumber { get; }
        string Name { get; }
    }

    public interface ISensor<out T> : ISensor
        where T : ISensorData
    {
        T SensorData { get; }
    }
}
