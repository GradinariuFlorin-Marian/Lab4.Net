using System.IO.Ports;

namespace SOLID.OCP.NewSolution.Violation
{
    public class BillDispenserEcdm : DeviceType
    {
        override public SerialPort createPort()
        {
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
            return port;
        }
    }
}