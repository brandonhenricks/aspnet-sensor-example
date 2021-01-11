namespace Sensor.Core.Contracts
{
    using System;

    using Sensor.Core.Enums;

    public interface ISensorData
    {
        SensorDataType DataType { get; }

        DateTimeOffset TimeStamp { get; }
    }

    public interface ISensorData<out T> : ISensorData
        where T : class, new()
    {
        T Data { get; }
    }
}
