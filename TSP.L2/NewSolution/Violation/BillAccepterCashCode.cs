using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public class BillAccepterCashCode : DeviceType
    {
       override public SerialPort createPort()
        {
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
            return port;
        }
    }
}