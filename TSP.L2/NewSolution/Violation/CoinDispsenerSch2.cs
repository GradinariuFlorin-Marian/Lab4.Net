using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public class CoinDispsenerSch2 : DeviceType
    {
       override public SerialPort createPort()
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            return port;
        }
    }
}