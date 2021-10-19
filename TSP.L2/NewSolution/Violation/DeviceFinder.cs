using System;
using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public class DeviceFinder
    {
        public string FindDevice(DeviceType model)
        {
            SerialPort port = model.createPort();
            return Find(port);
        }

        public string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }

            return null;
        }
    }
}