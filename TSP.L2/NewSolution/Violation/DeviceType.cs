using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public abstract class DeviceType
    {
        public SerialPort port = new SerialPort();
        public abstract SerialPort createPort();
    }
}