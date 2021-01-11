using System;
using System.Collections.Generic;
using System.Text;

namespace Sensor.Core.Contracts
{
    public interface ISensor
    {
        string DeviceId { get; }
        string Name { get; }
    }

    public interface ISensor<T> : ISensor
        where T : ISensorData
    {
    }
}
