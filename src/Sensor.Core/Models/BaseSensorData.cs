namespace Sensor.Core.Models
{
    using System;

    using Sensor.Core.Contracts;
    using Sensor.Core.Enums;

    public abstract class BaseSensorData : ISensorData
    {
        public SensorDataType DataType { get; protected set; } = SensorDataType.Other;

        public DateTimeOffset TimeStamp { get; } = DateTimeOffset.UtcNow;
    }
}
