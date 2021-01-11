namespace Sensor.Core.Models
{
    using Sensor.Core.Contracts;
    using Sensor.Core.Enums;

    public class SensorData<T> : BaseSensorData, ISensorData<T>
        where T : class, new()
    {
        public SensorData(SensorDataType dataType, T data)
        {
            DataType = dataType;
            Data = data;
        }

        public T Data { get; }
    }
}
