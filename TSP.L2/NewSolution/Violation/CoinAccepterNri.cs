using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public class CoinAccepterNri : DeviceType
    {
        override public SerialPort createPort()
        {
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
            return port;
        }
    }
}