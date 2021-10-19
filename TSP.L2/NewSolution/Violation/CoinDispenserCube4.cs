using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public class CoinDispenserCube4 : DeviceType
    {
        override public SerialPort createPort()
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
            return port;
        }
    }
}