﻿using System.Threading.Tasks;

namespace Modbus.Core
{
    public interface IModbusSession
    {
        Response<T> SendRequest<T>(int slaveAddress, int functionCode, object data) where T : struct;

        Task<Response<T>> SendRequestAsync<T>(int slaveAddress, int functionCode, object data) where T : struct;
    }
}