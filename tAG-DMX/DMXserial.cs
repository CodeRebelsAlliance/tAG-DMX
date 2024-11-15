using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace tAG_DMX
{
    public class DMXSerial
    {
        private SerialPort _serialPort;
        private const byte StartCode = 0x7E;
        private const byte EndCode = 0xE7;
        private const byte LabelDmxData = 6;
        private const int DmxPacketSize = 513; // 1 start code + 512 channels
        private byte[] _dmxData = new byte[DmxPacketSize];

        public DMXSerial(string portName)
        {
            _serialPort = new SerialPort(portName, 57600, Parity.None, 8, StopBits.Two);
            _dmxData[0] = 0; // DMX start code
        }

        public void Connect()
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }
        }

        public bool IsConnected()
        {
            return _serialPort.IsOpen;
        }

        public void SetChannel(int channel, byte value)
        {
            if (channel < 1 || channel > 512)
            {
                throw new ArgumentOutOfRangeException(nameof(channel), "Channel must be between 1 and 512.");
            }

            _dmxData[channel] = value;
            SendDmxData();
        }

        public void SetUniverse(byte value)
        {
            for (int i = 1; i < DmxPacketSize; i++)
            {
                _dmxData[i] = value;
            }

            SendDmxData();
        }

        public void Blackout()
        {
            SetUniverse(0);
        }

        public void Disconnect()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void SendDmxData()
        {
            if (!_serialPort.IsOpen)
            {
                throw new InvalidOperationException("Serial port is not open.");
            }

            int dataLength = _dmxData.Length;
            byte[] packet = new byte[dataLength + 5];
            packet[0] = StartCode;
            packet[1] = LabelDmxData;
            packet[2] = (byte)(dataLength & 0xFF);
            packet[3] = (byte)((dataLength >> 8) & 0xFF);
            Array.Copy(_dmxData, 0, packet, 4, dataLength);
            packet[packet.Length - 1] = EndCode;

            _serialPort.Write(packet, 0, packet.Length);
        }
    }

}
