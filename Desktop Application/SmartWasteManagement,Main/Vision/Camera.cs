using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectShowLib;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace SmartWasteManagement.Main.Vision
{
    public class Camera
    {
        public VideoCapture videoCapture { get; set; }

        public Camera() 
        {
            // Create a new VideoCapture object
            videoCapture = new VideoCapture();
        }

        public Mat GrabImage(int deviceIndex)
        {
            videoCapture = new VideoCapture(deviceIndex);

            // set video dimensions height and width
            // videoCapture.Set(VideoCaptureProperties.FrameWidth, 1920);
            // videoCapture.Set(VideoCaptureProperties.FrameHeight, 1080);
            
            videoCapture.Open(deviceIndex);

            Mat frame = new Mat();
            videoCapture.Read(frame); // Read a frame from the camera

            videoCapture.Release(); // close the camera

            return frame;
        }

        public List<string> GetDeviceList()
        {
            List<string> deviceList = new List<string>();   
            var videoDevices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            foreach (var device in videoDevices)
            {
                deviceList.Add(device.Name);
            }

            return deviceList;
        }
    }
}
