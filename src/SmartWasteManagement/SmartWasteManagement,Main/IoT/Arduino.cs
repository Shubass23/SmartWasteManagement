using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SmartWasteManagement.Main.IoT
{
    public static class Arduino
    {
        public static SerialPort serialPort { get; set; }

        public static bool getConnection(string PortName, int BaudRate)
        {
            serialPort = new SerialPort(PortName, BaudRate);

            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Arduino failed to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        public static int[] GetAllSensorsReadings()
        {
            string[] readings = serialPort.ReadLine().Split(','); // Read data from serial port and seperate using delimiter
            int[] readings_int = new int[readings.Length];

            for(int i=0; i<readings.Length; i++)
            {
                readings_int[i] = int.Parse(readings[i]);
            }

            return readings_int;
        }

        public static string GetReadingLine()
        {
            return serialPort.ReadLine();
        }
    }
}
